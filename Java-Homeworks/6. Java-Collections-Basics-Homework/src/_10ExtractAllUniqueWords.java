import java.util.Arrays;
import java.util.Scanner;
import java.util.SortedSet;
import java.util.TreeSet;

public class _10ExtractAllUniqueWords {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().toLowerCase().split("[\\W]+");
        SortedSet output = new TreeSet(Arrays.asList(input));

        System.out.println(String.join(" ", output));
    }
}
