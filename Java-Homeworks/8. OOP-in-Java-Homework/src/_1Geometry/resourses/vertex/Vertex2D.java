package _1Geometry.resourses.vertex;

import java.util.ArrayList;
import java.util.Arrays;

public class Vertex2D extends Vertex {
    public Vertex2D(double x, double y) {
        super(new ArrayList<Double>(Arrays.asList( x, y )));
    }

    public static double getDistance(Vertex2D firstVertex, Vertex2D secondVertex) {
        double deltaX = firstVertex.getCoordinates(0) - secondVertex.getCoordinates(0);
        double deltaY = firstVertex.getCoordinates(1) - secondVertex.getCoordinates(1);
        double distance = Math
                .sqrt(deltaX * deltaX + deltaY * deltaY);

        return distance;
    }
}
