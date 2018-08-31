import java.util.*;
import java.util.stream.Collectors;

public class _12CardsFrequencies {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split("[\\W]+");

        Map<String, Long> output = Arrays.stream(input)
                .collect(Collectors.groupingBy(x -> x, LinkedHashMap::new, Collectors.counting()));


        for (Map.Entry<String, Long> s : output.entrySet()) {
            double percentage = (double)s.getValue()/input.length*100;
            System.out.printf("%s -> %.2f%% times\n", s.getKey(), percentage);
        }
    }
}
