package _1Geometry.resourses.shape;

import java.util.ArrayList;
import java.util.List;

import _1Geometry.resourses.vertex.Vertex;
import _1Geometry.resourses.vertex.Vertex3D;


public abstract class Shape {
    private List<Vertex> vertices;

    protected Shape(List<Vertex3D> vertices) {
        this.setVertices(new ArrayList<Vertex>(vertices));
    }

    public Vertex getVertices(int index) {
        return vertices.get(index);
    }

    public void setVertices(List<Vertex> vertices) {
        this.vertices = vertices;
    }

    @Override
    public String toString() {
        StringBuilder shape = new StringBuilder();

        shape.append(this.getClass().getSimpleName() + "[");
        vertices
                .forEach(vertex -> shape
                        .append(String.format(
                                "%s, ",
                                vertex)));
        shape.delete(shape.length() - 2, shape.length());
        shape.append("]");

        return shape.toString();
    }
}