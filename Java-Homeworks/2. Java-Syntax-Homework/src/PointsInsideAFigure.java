import java.util.Scanner;

public class PointsInsideAFigure {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        double pointX = Double.parseDouble(scanner.next());
        double pointY = Double.parseDouble(scanner.next());

        boolean checkFirstFigure = (pointX >= 12.5 && pointX <= 17.5)
                && (pointY >= 8.5 && pointY <= 13.5);

        boolean checkSecondFigure = (pointX >= 20 && pointX <= 22.5)
                && (pointY >= 8.5 && pointY <= 13.5);

        boolean checkThirdFigure = (pointX >= 12.5 && pointX <= 22.5)
                && (pointY >= 6 && pointY <= 8.5);


        if (checkFirstFigure || checkSecondFigure || checkThirdFigure) {
            System.out.println("Inside");
        }
        else {
            System.out.println("Outside");
        }
    }
}