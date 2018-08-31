import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _07CountSubstringOccurrences {
    public static void main(String[] args) {


        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine().toLowerCase();
        String word = scan.nextLine().toLowerCase();

        String formPattern = String.format("%s", word);
        Pattern pattern = Pattern.compile(formPattern);
        Matcher match = pattern.matcher(input);

        int counter = 0;
        int start = 0;
        while (match.find(start)) {
            counter++;
            start = match.start() + 1;
        }
        System.out.println(counter);

    }
}
