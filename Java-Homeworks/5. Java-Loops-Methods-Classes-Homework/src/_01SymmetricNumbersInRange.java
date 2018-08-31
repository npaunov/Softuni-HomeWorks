import java.util.Scanner;

public class _01SymmetricNumbersInRange {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        int start = scan.nextInt();
        int end = scan.nextInt();

        boolean isCorrectEntry = false;  // check entry
        while (!isCorrectEntry) {
            if (start < 0 || end > 999 || start > end) {
                System.out.println("Please enter two numbers in format" +
                        " 0 ≤ start ≤ end ≤ 999");
                start = scan.nextInt();
                end = scan.nextInt();
            } else {
                isCorrectEntry = true;
            }
        }

        StringBuilder result = new StringBuilder();

        for (int i = start; i <= end; i++) {    // append if true
            if (i >= 0 && i <= 9) {
                result.append(Integer.toString(i) + " ");

            } else if (i >= 10 && i <= 99) {
                if (i / 10 == i % 10){
                    result.append(Integer.toString(i) + " ");
                }

            }else {
                if (i / 100 == i % 10){
                    result.append(Integer.toString(i) + " ");
                }

            }
        }

        if (result.length() == 0){              // Print
            System.out.println("No symmetric numbers!");
        } else {
            System.out.println(result);
        }
    }
}
