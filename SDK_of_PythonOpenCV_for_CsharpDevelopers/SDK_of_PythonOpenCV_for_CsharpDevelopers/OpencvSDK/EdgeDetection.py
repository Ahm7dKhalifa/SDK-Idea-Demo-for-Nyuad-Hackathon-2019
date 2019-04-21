#first step : recive the variables from c# 
import sys
imgPath = sys.argv[1]
#second step : excute your code
import cv2
import numpy as np
img = cv2.imread(imgPath)
# Create The Laplacian Filter
laplacian_filter = np.array([ [0,-1,0], 
                              [-1, 4,-1],
                              [0,-1,0]])
sharpened = cv2.filter2D(img, -1, laplacian_filter)
ImageWithFilter = cv2.add(img , sharpened)
cv2.imshow("Original-Image", img)
cv2.imshow("Edges", sharpened)
cv2.imshow("Sharping-Image", ImageWithFilter)
cv2.waitKey(0)
cv2.destroyAllWindows()
