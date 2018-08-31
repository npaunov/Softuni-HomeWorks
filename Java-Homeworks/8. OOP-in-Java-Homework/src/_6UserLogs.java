
import java.util.*;
import java.util.stream.Collectors;


public class _6UserLogs {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        Map<String, LinkedHashMap<String, Integer>> logs = new TreeMap<>();
        String input = input = scan.nextLine();

        while (!input.equals("end")) {
            String[] findIp = input.split(" message=");
            String[] closeToIp = findIp[0].split("=");
            String ip = closeToIp[1];
            String[] closeToName = findIp[1].split("user=");
            String name = closeToName[1];

            if (!logs.containsKey(name)) {
                logs.put(name, new LinkedHashMap() {{
                    put(ip, 1);
                }});
            } else {
                int value = logs.get(name).getOrDefault(ip, 0);
                logs.get(name).put(ip, value + 1);
            }

            input = scan.nextLine();
        }
        for (Map.Entry<String, LinkedHashMap<String, Integer>> entry : logs.entrySet()) {
            Map<String, Integer> tempMap = entry.getValue();

            System.out.println(entry.getKey() + ": ");
            List<String> temp = tempMap.entrySet().stream().map(ips -> String.format("%s => %s", ips.getKey(), ips.getValue())).collect(Collectors.toList());
            System.out.println(String.join(", ", temp) + ".");
        }

    }
}

