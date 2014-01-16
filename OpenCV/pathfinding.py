__author__ = 'David'

from numpy import *
from random import random


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

def generateGrid():
    #GRid is gemaakt van 10 centimeter vlakken. 400x400
    grid = zeros((40,40), dtype=bool)

    #bierkrat vullen
    for y in range(0, 3):
        for x in range(0, 5):
            grid[35+x][y] = True

    #Robot zetten
    grid[0][39] = True

    f = open("grid.txt", 'w')

    for x in range(0, 40):
        for y in range(0,40):
            if grid[x][y] == True:
                f.write('1 ')
            else:
                f.write('0 ')
        f.write("\n")

    f.close()

    set_printoptions(threshold='nan')

    print grid

def run():
    generateGrid()

