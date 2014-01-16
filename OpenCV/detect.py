#!/usr/bin/env python

import numpy as np
import cv2
import cv2.cv as cv
from video import create_capture
from common import clock, draw_str

help_message = '''
Gezichtsherkenning demo. Herkent gezichten en de gespecificeerde nested deel. Druk op escape om te eindigen. Niet forcen
 AUB.
'''


def detect(img, cascade):
    rects = cascade.detectMultiScale(img, scaleFactor=1.3, minNeighbors=4, minSize=(5, 5))
    if len(rects) == 0:
        return []
    rects[:, 2:] += rects[:, :2]

    print rects

    return rects


def draw_rects(img, rects, color):
    for x1, y1, x2, y2 in rects:
        print "Drawing triangle"
        cv2.rectangle(img, (x1, y1), (x2, y2), color, 2)


def runDetection():
    #Gebruikt commandline zooi
    import sys, getopt

    print help_message

    #Logging van tijd aanmaken
    timeLog = list()

    #Video en cascades laden
    args, video_src = getopt.getopt(sys.argv[1:], '', ['cascade=', 'nested-cascade='])
    try:
        video_src = video_src[0]
    except:
        video_src = 0
    args = dict(args)
    cascade_fn = "haarcascades/haarcascade_frontalface_alt.xml"
    nested_fn = "haarcascades/haarcascade_mcs_nose.xml"

    cascade = cv2.CascadeClassifier(cascade_fn)
    nested = cv2.CascadeClassifier(nested_fn)

    if cascade.empty() or nested.empty():
        raise Exception("Geen werkende cascades")

    print "Cascades geladen"

    #Camera openen
    cam = create_capture(video_src, fallback='synth:bg=../cpp/lena.jpg:noise=0.05')

    if not cam.isOpened():
        raise Exception("Camera niet geopened")
    print "Beeld aangemaakt"

    while True:
        #beeld inlezen
        ret, img = cam.read()

        if not ret:
            raise Exception("beeld is leeg")

        cv2.imshow('Beeld', img)

        #Als het beeld bestaat hiermee werken
        if ret:
            #converteren naar zwart wit
            gray = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)
            gray = cv2.equalizeHist(gray)

            #grijs beeld weergeven
            cv2.imshow('Grijs', gray)

            #klok starten
            t = clock()

            #Gezichten vinden in in rects zetten
            rects = detect(gray, cascade)
            vis = img.copy()

            #rects tekenen op plaatje
            draw_rects(vis, rects, (0, 255, 0))

            #in dit vierkantje op zoek gaan naar de gespcificeerde nestedCascade
            for x1, y1, x2, y2 in rects:
                roi = gray[y1:y2, x1:x2]
                vis_roi = vis[y1:y2, x1:x2]
                subrects = detect(roi.copy(), nested)
                draw_rects(vis_roi, subrects, (255, 20, 20))

            #Kloktijd berekenen
            dt = clock() - t

            timeLog.append(dt)

            print "Gewerkte tijd is %s ms", (dt * 1000)

            #Kloktijd tekenen op scherm
            draw_str(vis, (20, 20), 'time: %.1f ms' % (dt * 1000))
            cv2.imshow('Detect', vis)

            #Exit als er op escape wordt geduwd
            if 0xFF & cv2.waitKey(5) == 27:
                break

    #gemiddele rekentijd berekenen
    cnt = 0
    for n in timeLog:
        cnt += float(n) * 1000

    print cnt / len(timeLog)

    #Alle schermen kapot maken
    cv2.destroyAllWindows()

    #Camera vrijgeven. BELANGRIJK. Als dit niet wordt gedaan moet het systeem opnieuw op worden gestart
    cam.release()