import java.util.Scanner;

public class RectangleArea {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        System.out.println("Side A:");
        int sideA = Integer.parseInt(scan.nextLine());
        System.out.println("Side B:");
        int sideB = Integer.parseInt(scan.nextLine());

        int rectangleArea = sideA*sideB;

        System.out.printf("The rectangle area is: %d", rectangleArea );

    }
}
