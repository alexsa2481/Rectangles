# Rectangles

## Description

This project contains a command-line utility to analyze certain features of rectangles.

## Assumptions and Observations
- It is assumed that coordinates are integers.
- "Screen" coordinate system is used - 0,0 is at the top left corner.
- It is assumed that rectangles are not rotated, i.e. sides are parallel to the X,Y axes.
- It is assumed that left <= right and top <= bottom, otherwise program aborts with error message.
- When all 4 coordinates for a rectangle are equal - it is a dot and program aborts with error message.
- When coordinates define a line segment - left==right or top==bottom for a rectangle, program aborts with error message.
- There is also a distinct case of equal rectangles.
- In case of one rectangle is contained inside the other and, at the same time, adjacent to it (see test case Contain3), the program returns Contain message - "Rectangle x is inside rectangle y".
- There is Docs/Test.jpg file included - illustration on test cases, with each picture describing corresponding unit test.
 
