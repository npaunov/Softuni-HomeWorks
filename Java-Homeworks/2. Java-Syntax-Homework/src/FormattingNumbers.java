/**
 FormattingNumbers
 */
import java.util.Scanner;

public class FormattingNumbers {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int first = Integer.parseInt(scanner.next());
        float second = Float.parseFloat(scanner.next());
        float third = Float.parseFloat(scanner.next());

        String aToHex = Integer.toHexString(first).toUpperCase();
        int aToBinary = Integer.parseInt(Integer.toBinaryString(first));

        System.out.printf("|%1$-10s|%2$010d|%3$10.2f|%4$-10.3f|", aToHex, aToBinary, second, third);
    }
}