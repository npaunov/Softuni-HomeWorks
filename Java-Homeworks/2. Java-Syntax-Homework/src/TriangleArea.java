import java.util.Scanner;

public class TriangleArea {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        System.out.println("Please enter coordinates of points:");
        int sideAx = scan.nextInt();
        int sideAy = scan.nextInt();
        int sideBx = scan.nextInt();
        int sideBy = scan.nextInt();
        int sideCx = scan.nextInt();
        int sideCy = scan.nextInt();

        int triangleArea = Math.abs((sideAx * (sideBy - sideCy) + sideBx * (sideCy - sideAy) + sideCx * (sideAy - sideBy)) / 2);

        System.out.println(triangleArea);
    }
}
