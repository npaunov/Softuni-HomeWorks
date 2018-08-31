package _1Geometry.resourses.shape.shape2d;

import java.util.List;

import _1Geometry.resourses.vertex.Vertex2D;
import _1Geometry.interfaces.AreaMeasurable;
import _1Geometry.interfaces.PerimeterMeasurable;
import _1Geometry.resourses.shape.Shape;
import _1Geometry.resourses.vertex.*;

public abstract class PlaneShape
        extends Shape
        implements AreaMeasurable, PerimeterMeasurable {
    public PlaneShape(List<Vertex2D> vertices) {
        super((List)vertices);
    }

    @Override
    public String toString() {
        String planeshape = String.format(
                " Area = %.2f, Perimeter = %.2f;\n",
                this.getArea(),
                this.getPerimeter());

        return super.toString() + planeshape;
    }
}
