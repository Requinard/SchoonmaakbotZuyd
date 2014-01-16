import detect
import threading
import datetime
import pathfinding

if __name__== "__main__":
    print "Welkom bij facedetect(tm)"
    if datetime.datetime.now().hour > 17:
        print "Het is tijd voor bier"

    detectionThread = threading.Thread(target=detect.runDetection)
    pathfindingThread = threading.Thread(target=pathfinding.run)

    pathfindingThread.start()
    #detectionThread.start()
