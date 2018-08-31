import java.util.*;

public class _17LogsAggregator {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        int counter = Integer.parseInt(scan.nextLine());

        Map<String, Integer> minutes = new TreeMap<>();
        Map<String, TreeSet> ip = new HashMap<>();

        while (counter > 0) {
            String[] input = scan.nextLine().split(" ");

            String name = input[1];
            int min = Integer.parseInt(input[2]);
            String ipOne = input[0];

            if (!minutes.containsKey(name)) {
                minutes.put(name, min);
                TreeSet<String> temp = new TreeSet(){{add(ipOne);}};
                ip.put(name,temp);
            }else {
                int minutesValue = minutes.get(name);
                minutes.put(name, minutesValue+min);
                TreeSet<String> temp = new TreeSet(ip.get(name));
                temp.add(ipOne);
                ip.put(name,temp);
            }
            counter--;


        }

        for (Map.Entry<String, Integer> entry : minutes.entrySet()) {
            String ips = ip.get(entry.getKey()).toString();
            System.out.printf("%s: %s %s\n",entry.getKey(),entry.getValue(),ips);
        }
    }
}
