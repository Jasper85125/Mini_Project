string GoNorth = "Y";
string GoEast = "Y";
string GoSouth = "Y";
string GoWest = "Y";
Compass compass = new Compass(north: GoNorth, east: GoEast, south: GoSouth, west: GoWest);
compass.DrawCompass();