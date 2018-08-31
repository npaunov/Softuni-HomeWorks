import java.util.Map;
import java.util.Scanner;
import java.util.TreeMap;
import java.util.TreeSet;

public class _17LogsAggregatorSecond {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int counter = Integer.parseInt(scan.nextLine());
        Map<String, TreeMap<String, Integer>> data = new TreeMap<>();

        while (counter > 0) {
            String[] input = scan.nextLine().split(" ");

            String name = input[1];
            int min = Integer.parseInt(input[2]);
            String ipOne = input[0];

            if (!data.containsKey(name)) {
                TreeMap<String, Integer> temp = new TreeMap() {{
                    put(ipOne, min);
                }};
                data.put(name, temp);
            } else {
                int minValue = data.get(name).getOrDefault(ipOne, -1);
                if (minValue == -1) {
                    data.get(name).put(ipOne, min);
                } else {
                    data.get(name).put(ipOne, min + minValue);
                }
            }
            counter--;
        }

        for (Map.Entry<String, TreeMap<String, Integer>> myData : data.entrySet()) {
            int minutesTotal = myData.getValue().values().stream().mapToInt(Integer::intValue).sum();
            System.out.printf("%s: %d %s\n", myData.getKey(), minutesTotal, myData.getValue().keySet());
        }
    }
}

