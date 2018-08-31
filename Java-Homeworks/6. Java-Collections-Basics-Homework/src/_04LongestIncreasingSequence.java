import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class _04LongestIncreasingSequence {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");
        int[] numbers = new int[input.length];

        for (int i = 0; i < numbers.length; i++) {
            numbers[i] = Integer.parseInt(input[i]);
        }

        ArrayList<ArrayList<String>> output = new ArrayList<>();
        ArrayList<String> longestSequence = new ArrayList<>();

        for (int i = 0; i < numbers.length; i++) {
            ArrayList<String> temp = new ArrayList<>();

            temp.add(Integer.toString(numbers[i]));

            while ((i + 1 != numbers.length) && (numbers[i] < numbers[i + 1])) {
                temp.add(Integer.toString(numbers[i + 1]));
                i++;
                if (i == numbers.length - 1) {
                    break;
                }
            }

            if (temp.size() > longestSequence.size()) {
                longestSequence.clear();
                longestSequence.addAll(temp);
            }
            output.add(temp);
        }

        for (ArrayList<String> integers : output) {
            System.out.println(String.join(" ", integers));
        }
        System.out.printf("Longest: %s", String.join(" ", longestSequence));
    }
}

