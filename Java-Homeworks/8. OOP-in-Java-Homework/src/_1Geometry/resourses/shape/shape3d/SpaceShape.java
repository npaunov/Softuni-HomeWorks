package _1Geometry.resourses.shape.shape3d;

import java.util.List;

import _1Geometry.interfaces.AreaMeasurable;
import _1Geometry.interfaces.VolumeMeasurable;
import _1Geometry.resourses.shape.Shape;
import _1Geometry.resourses.vertex.Vertex3D;

public abstract class SpaceShape
		extends Shape
		implements AreaMeasurable, VolumeMeasurable {
	public SpaceShape(List<Vertex3D> vertices) {
		super((List)vertices);
	}
	
	@Override
	public String toString() {
		String spaceShape = String.format(
				" Area = %.2f, Volume = %.2f;\n",
				this.getArea(),
				this.getVolume());
		
		return super.toString() + spaceShape;
	}
}
