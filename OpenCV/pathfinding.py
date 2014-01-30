__author__ = 'David'

import random
import math

from numpy import *
from operator import itemgetter


"""
INFORMATIE

Arena is 4x4 meter
Grid is verdeeld in stukken van 10x10cm

Totaal dus 40x40 delen

Bierkrat afmetingen zijn 50x30x30

Bierflesje staand is 5x5x30

Indeling grid is als volgt:
grid[Y][X]
"""

class Node():
    """
    Houdt de data voor een node vast.
    """
    def __init__(self, x, y):
        self.x = x
        self.y = y
        self.plus = 0
        self.minus = 0

    def __int__(self):
        return self.plus

    def __str__(self):
        return str("%i, %y" % (self.x, self.y))

    def __getitem__(self, item):
        if item == "plus":
            return self.plus
        elif item == "minus":
            return self.minus

    #Sorteert op x+y
    def SortPlus(self, originX, originY):
        self.plus = math.fabs((self.x - originX) + (self.y - originY))
        return self.plus

    #Sorteren op X-Y
    def SortMinus(self, originX, originY):
        self.minus = math.fabs((self.x - originX) - (self.y - originY))
        return self.minus

    def IsNode(self, x, y):
        return x == self.x and y == self.y


def genGrid():
    """
    Genereert een grid en schrijft dit naar grid.txt.

    Verzorgt ook een automatische lijst met positieve nodes.
    """
    #GRid is gemaakt van 10 centimeter vlakken. 400x400
    grid = zeros((40,40), dtype=bool)

    #bierkrat vullen
    for y in range(0, 3):
        for x in range(0, 5):
            grid[35+x][37+y] = True

    #Robot zetten
    grid[0][0] = True

    #Lijst aanmaken voor nodes
    nodes  = list()

    #Flesjes dumpen. ZUIPEN
    for cnt in range(0, 12):
        while True:
            x = random.randint(0, 40)
            y = random.randint(0, 40)

            if not grid[y][x]:
                nodes.append(Node(x, y))
                grid[y][x] = True
                break


        f = open("grid.txt", 'w')

    for x in range(0, 40):
        for y in range(0,40):
            if grid[y][x] == True:
                f.write('1 ')
            else:
                f.write('0 ')
        f.write("\n")

    f.close()

    set_printoptions(threshold='nan')

    return (grid, nodes)


def pathFind(nodes):
    """
    Begint met een lijst nodes.

    Past vervolgens
    """
    #Startpunt
    currentLocation = Node(0,0)
    #Route
    Route = list()

    PATHMODE = 0

    if(PATHMODE == 0):
        #Punten berekenen
        while True:
            #Nodes hun SortPlus geven
            for node in nodes:
                node.SortPlus(currentLocation.x, currentLocation.y)
                print "Node nummer %i op punt %f" % (1, node.plus)

            #Nodes sorteren op hun SortPlus
            nodes.sort(key=itemgetter("plus"))

            #Lijst met eindresultaten aanmaken
            possibleNodes = list()

            for i in range(0,5):
                #Als dit de kleinste overgebleven node is
                if nodes[i].plus < nodes[i+1].plus:
                    possibleNodes.append(nodes[i])
                    break
                #Als er nog even grote nodes over zijn.
                elif nodes[i].plus == nodes[i+1].plus:
                    possibleNodes.append(nodes[i])

            #Als er meer als een node is gevonden moet er gesorteerd worden op minus
            if len(possibleNodes) != 1:
                #Minus berekenen
                for node in possibleNodes:
                    node.SortMinus(currentLocation.x, currentLocation.y)

                #Sorteren
                possibleNodes.sort(key=itemgetter("minus"))


            #locatie updaten en gebruikte node verwijderen
            currentLocation = Node(possibleNodes[0].x, possibleNodes[0].y)

            for i in range(0, len(nodes)):
                if nodes[i] == possibleNodes[0]:
                    nodes.pop(i)
                    break

            Route.append(possibleNodes[0])

            if len(Route) == 6:
                break
        return Route

    elif(PATHMODE == 1):
        openList = nodes
        closedList = list()
        cameFrom = list()



def writeRoute(Route, grid):
    """
    Schrijft de route naar een textbestand
    """

    file = open("route.txt", "w")

    nodeNumber = 1

    for x in range(0, 40):
        for y in range(0, 40):
            for node in Route:
                if node.IsNode(x, y):
                    file.write(str(nodeNumber))
                    nodeNumber += 1
                else:
                    file.write("x")

        file.write('\n')

    file.close()

def run():
    grid, nodes = genGrid()
    Route = pathFind(nodes)

    writeRoute(Route, grid)

