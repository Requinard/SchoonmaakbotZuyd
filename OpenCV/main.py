import detect
import threading
import datetime
import pathfinding

MODE = 0

if __name__== "__main__":
    print "Welkom bij facedetect(tm)"
    if datetime.datetime.now().hour > 17:
        print "Het is tijd voor bier"

    if(MODE == 0):
        pathfinding.run()
    elif(MODE == 1):
        detect.runDetection()
    elif(MODE == 3):
        pathfinding.run()
        detect.runDetection()

