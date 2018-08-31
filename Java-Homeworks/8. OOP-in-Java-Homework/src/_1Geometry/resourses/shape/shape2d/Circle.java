package _1Geometry.resourses.shape.shape2d;

import java.util.ArrayList;
import java.util.Arrays;

import _1Geometry.resourses.shape.shape2d.PlaneShape;
import _1Geometry.resourses.vertex.Vertex2D;


public class Circle extends PlaneShape {
    private double radius;

    public Circle(Vertex2D firstVertex, double radius) {
        super(new ArrayList<Vertex2D>(Arrays.asList(firstVertex)));
        this.setRadius(radius);
    }

    public double getRadius() {
        return radius;
    }

    public void setRadius(double radius) {
        if (radius < 0) {
            throw new ArithmeticException("Radius cannot be smaller than 0!");
        }

        this.radius = radius;
    }

    @Override
    public double getArea() {
        double area = Math.PI * (this.getRadius() * this.getRadius());

        return area;
    }

    @Override
    public double getPerimeter() {
        double perimeter = 2 * Math.PI * this.getRadius();

        return perimeter;
    }
}