import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        System.out.println("Please enter two numbers:");
        System.out.print("First: ");
        int firstNumber = scan.nextInt();
        System.out.print("Second: ");
        int secondNumber = scan.nextInt();

        System.out.printf("The sum of your numbers is: %d", firstNumber + secondNumber);
    }
}
