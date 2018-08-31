import java.util.*;
import java.util.stream.Collectors;

public class _11MostFrequentWord {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().toLowerCase().split("[\\W]+");

        Map<String, Integer> output = new TreeMap<>();

        for (int i = 0; i < input.length; i++) {
            if (!output.containsKey(input[i])) {
                output.put(input[i], 1);
            } else {
                int count = output.get(input[i]);
                output.put(input[i], count + 1);
            }
        }

        int maxValue = Collections.max(output.values());

        Map<String, Integer> filtered = output
                .entrySet()
                .stream()
                .filter(entry -> Objects.equals(entry.getValue(), maxValue))
                .collect(Collectors.toMap(
                        p -> p.getKey(),
                        p -> p.getValue(),
                        (a, b) -> a,
                        TreeMap::new));

        for (Map.Entry<String, Integer> s : filtered.entrySet()) {

            System.out.printf("%s -> %s times\n", s.getKey(), s.getValue());
        }


    }
}
