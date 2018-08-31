package _1Geometry.resourses.vertex;

import java.util.ArrayList;
import java.util.Arrays;

public class Vertex3D extends Vertex {
    public Vertex3D(double x, double y, double z) {
        super(new ArrayList<Double>(Arrays.asList( x, y, z )));
    }
}
