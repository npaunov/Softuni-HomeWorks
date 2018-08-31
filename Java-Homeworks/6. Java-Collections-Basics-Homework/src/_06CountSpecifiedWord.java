import java.util.Scanner;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class _06CountSpecifiedWord {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine().toLowerCase();
        String word = scan.nextLine().toLowerCase();

        String formPattern = String.format("([\\W]|^)%s(\\W|$)", word);
        Pattern pattern = Pattern.compile(formPattern);
        Matcher match = pattern.matcher(input);

        int counter = 0;
        while (match.find()){
            counter++;
        }
        System.out.println(counter);
    }
}
