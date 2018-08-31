package _1Geometry.resourses.shape.shape3d;

import java.util.ArrayList;
import java.util.Arrays;

import data.vertex.Vertex3D;

public class SquarePyramid extends SpaceShape {
	double baseWidth;
	double height;

	public SquarePyramid(Vertex3D baseCenterVertex, double baseWidth, double height) {
		super(new ArrayList<Vertex3D>(Arrays.asList(baseCenterVertex)));
		this.setBaseWidth(baseWidth);
		this.setHeight(height);
	}

	public double getBaseWidth() {
		return this.baseWidth;
	}

	public void setBaseWidth(double baseWidth) {
		this.baseWidth = baseWidth;
	}

	public double getHeight() {
		return this.height;
	}

	public void setHeight(double height) {
		this.height = height;
	}

	@Override
	public double getArea() {
		double hypothenuseOfASideTriangle =
				Math.sqrt(
						this.getHeight() * this.getHeight() +
						(this.getBaseWidth()/2) * (this.getBaseWidth()/2));
		double baseArea = this.getBaseWidth() * this.getBaseWidth();
		double area = baseArea + 2 * this.getBaseWidth() * hypothenuseOfASideTriangle;

		return area;
	}

	@Override
	public double getVolume() {
		double volume = 1/3d * this.getBaseWidth() * this.getBaseWidth() * this.getHeight();
		
		return volume;
	}

	
}
