import java.util.Scanner;

public class _4LettersChangeNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split("[\\s]+");
        double totalNumber = 0;

        for (int i = 0; i < input.length; i++) {
            char firstLetter = Character.valueOf(input[i].charAt(0));
            char lastLetter = Character.valueOf(input[i].charAt(input[i].length() - 1));
            double number = Integer.parseInt(input[i].substring(1, input[i].length() - 1));
            if (firstLetter <= 91) {
                number /= (firstLetter - 64);
            } else {
                number *= (firstLetter - 96);
            }
            if (lastLetter <= 91) {
                number -= (lastLetter - 64);
            } else {
                number += (lastLetter - 96);
            }
            totalNumber += number;
        }
        double result = Math.round(totalNumber * 100.0) / 100.0;
        System.out.printf("%.2f",result);
    }
}
