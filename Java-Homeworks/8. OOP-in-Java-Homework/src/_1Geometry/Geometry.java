package _1Geometry;

import java.util.*;

import _1Geometry.interfaces.VolumeMeasurable;
import _1Geometry.resourses.shape.Shape;
import _1Geometry.resourses.shape.shape2d.*;
import _1Geometry.resourses.shape.shape3d.*;
import _1Geometry.resourses.vertex.*;
import javafx.scene.shape.Circle;

public class Geometry {
    public static void main(String[] args) {

        double volumeMeasurement = 4000.00;
        List<Vertex2D> vertices2d = new ArrayList<Vertex2D>(
                Arrays.asList(
                        new Vertex2D(2, 1),
                        new Vertex2D(5, 14),
                        new Vertex2D(15, 8),
                        new Vertex2D(5, 3),
                        new Vertex2D(7, 18)));
        List<Vertex3D> vertices3d = new ArrayList<Vertex3D>(
                Arrays.asList(
                        new Vertex3D(14, 21, 4),
                        new Vertex3D(22, 5, 14),
                        new Vertex3D(11, 5, 9)));

        Shape triangle = new Triangle(
                vertices2d.get(0),
                vertices2d.get(1),
                vertices2d.get(2));
        Shape rectangle = new Rectangle(
                vertices2d.get(3),
                10,
                20);
        Shape circle = new Circle(
                vertices2d.get(4),
                10);

        Shape pyramid = new SquarePyramid(
                vertices3d.get(0),
                14,
                22);
        Shape cuboid = new Cuboid(
                vertices3d.get(1),
                32,
                43,
                7);
        Shape sphere = new Sphere(
                vertices3d.get(2),
                23);

        List<Shape> shapes = new ArrayList<Shape>(Arrays.asList(
                triangle,
                rectangle,
                circle,
                pyramid,
                cuboid,
                sphere));

        shapes.forEach(shape -> System.out.println(shape));

        System.out.printf(
                "VolumeMeasurable shapes whose volume is over %.2f:\n",
                volumeMeasurement);
        shapes.stream()
                .filter(shape -> shape instanceof VolumeMeasurable)
                .filter(shape -> ((VolumeMeasurable) shape).getVolume() > volumeMeasurement)
                .forEach(shape -> System.out.printf(
                        "%s has volume over %.2f;\n",
                        shape.getClass().getSimpleName(),
                        volumeMeasurement));

        System.out.println("\nPlane shapes and sort them by their perimeter in ascending order:");
        shapes.stream()
                .filter(shape -> shape instanceof PlaneShape)
                .sorted((s1, s2) -> Double.compare(
                        ((PlaneShape) s1).getPerimeter(),
                        ((PlaneShape) s2).getPerimeter()))
                .forEach(shape -> System.out.printf(
                        "%s - Perimeter: %.2f;\n",
                        shape.getClass().getSimpleName(),
                        ((PlaneShape) shape).getPerimeter()));
    }
}
