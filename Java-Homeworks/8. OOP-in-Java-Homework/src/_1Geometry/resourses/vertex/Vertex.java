package _1Geometry.resourses.vertex;

import java.util.List;

public abstract class Vertex {
    private List<Double> coordinates;

    protected Vertex(List<Double> coordinates) {
        this.setCoordinates(coordinates);
    }

    public Double getCoordinates(int index) {
        return coordinates.get(index);
    }

    public void setCoordinates(List<Double> coordinates) {
        this.coordinates = coordinates;
    }

    @Override
    public String toString() {
        StringBuilder vertex = new StringBuilder();

        vertex.append("(");
        coordinates
                .forEach(coordinate -> vertex
                        .append(String.format(
                                "%.2f, ",
                                coordinate)));
        vertex.delete(vertex.length() - 2, vertex.length());
        vertex.append(")");

        return vertex.toString();
    }
}
