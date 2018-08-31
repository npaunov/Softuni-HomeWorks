package _1Geometry.resourses.shape.shape3d;

import java.util.ArrayList;
import java.util.Arrays;
import data.vertex.Vertex3D;

public class Cuboid extends SpaceShape {
	double width;
	double height;
	double depth;
	
	public Cuboid(Vertex3D firstVertex, double width, double height, double depth) {
		super(new ArrayList<Vertex3D>(Arrays.asList(firstVertex)));
		this.setWidth(width);
		this.setHeight(height);
		this.setDepth(depth);
	}

	public double getWidth() {
		return width;
	}

	public void setWidth(double width) {
		this.width = width;
	}

	public double getHeight() {
		return height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	public double getDepth() {
		return depth;
	}

	public void setDepth(double depth) {
		this.depth = depth;
	}

	@Override
	public double getArea() {
		double area =
				(2 * this.getWidth() * this.getHeight()) +
				(2 * this.getDepth() * this.getHeight() +
				(2 * this.getWidth() * this.getDepth()));
		
		return area;
	}

	@Override
	public double getVolume() {
		double volume = this.getWidth() * this.getHeight() * this.getDepth();
		
		return volume;
	}

}
