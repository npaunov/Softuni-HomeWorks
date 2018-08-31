import java.util.Scanner;

public class _02Generate3LetterWords {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        char[] word = scan.nextLine().toCharArray();

       // firstSolutionFor(word);
        System.out.println("\n");

        secondSolutionRecursive(word, 3, "");


    }

    private static void secondSolutionRecursive(char[] word, int requiredLength, String start) {
        if (start.length() >= requiredLength) {
            System.out.print(start + " ");
        } else {
            for (char letter : word) {
                secondSolutionRecursive(word, requiredLength, start + letter);
            }
        }
    }


    private static void firstSolutionFor(char[] word) {
        for (int first = 0; first < word.length; first++) {
            for (int second = 0; second < word.length; second++) {
                for (int third = 0; third < word.length; third++) {
                    System.out.print("" + word[first] + word[second] + word[third] + " ");
                }

            }

        }
    }
}
