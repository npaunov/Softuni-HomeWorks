import java.util.Scanner;

public class DecimalToHexadecimal {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int inputNumber = scanner.nextInt();

        String convertedNumberToHex = Integer.toHexString(inputNumber);

        System.out.printf("The hexadecimal of %d is %s.", inputNumber, convertedNumberToHex.toUpperCase());
    }
}