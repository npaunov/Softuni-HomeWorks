
import java.util.Scanner;

public class CountOfBitsOne {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        int input = scanner.nextInt();

        String binary = Integer.toBinaryString(input);
        int counterPresenceOfOne = 0;

        for(int i = 0; i < binary.length(); i++){
            if (binary.charAt(i) == '1') {
                counterPresenceOfOne++;
            }
        }

        System.out.printf("Bits \"1\" in %d are %d.", input, counterPresenceOfOne);
    }
}