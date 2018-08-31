package _1Geometry.resourses.shape.shape2d;

import _1Geometry.resourses.vertex.Vertex2D;

import java.util.ArrayList;
import java.util.Arrays;


public class Rectangle extends PlaneShape {
    private double width;
    private double height;

    public Rectangle(Vertex2D firstVertex, double width, double height) {
        super(new ArrayList<Vertex2D>(Arrays.asList(firstVertex)));
        this.setWidth(width);
        this.setHeight(height);
    }

    public double getWidth() {
        return width;
    }

    public void setWidth(double width) {
        if (width == 0) {
            throw new ArithmeticException("Not a rectangle!");
        }

        this.width = width;
    }

    public double getHeight() {
        return height;
    }

    public void setHeight(double height) {
        if (height == 0) {
            throw new ArithmeticException("Not a rectangle!");
        }

        this.height = height;
    }

    @Override
    public double getArea() {
        double area = this.getWidth() * this.getHeight();

        return area;
    }

    @Override
    public double getPerimeter() {
        double perimeter = this.getWidth() * 2 + this.getHeight() * 2;

        return perimeter;
    }

}
