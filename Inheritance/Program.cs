﻿using Inheritance.Models;

List<Shape> shapes = new List<Shape>();

Shape shape = new Point();
shapes.Add(shape);

Shape1D shape1D = new Line(3);
shapes.Add(shape1D);


Square square = new Square(5);

shape1D = square;

shape = shape1D;

shapes.Add(shape);

shape = new Triangle(3, 6, 90);
shapes.Add(shape);


foreach (var item in shapes)
{
    Console.WriteLine(item);
}

Line line = new Line(3);
line.Color = "czerwony";


Triangle triangle = new Triangle(3, 6, 45);
triangle.Color = "niebieski";

List<IColor> colors = new List<IColor>();
colors.Add(triangle);
colors.Add(line);