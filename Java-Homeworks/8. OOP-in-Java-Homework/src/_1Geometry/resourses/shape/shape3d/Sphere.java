package _1Geometry.resourses.shape.shape3d;

import java.util.ArrayList;
import java.util.Arrays;
import data.vertex.Vertex3D;

public class Sphere extends SpaceShape {
	double radius;

	public Sphere(Vertex3D firstVertex, double radius) {
		super(new ArrayList<Vertex3D>(Arrays.asList(firstVertex)));
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
		double area = 4 * Math.PI * this.getRadius() * this.getRadius();
		
		return area;
	}

	@Override
	public double getVolume() {
		double volume = 4/3 * Math.PI * this.getRadius() * this.getRadius() * this.getRadius();

		return volume
				;
	}

}
