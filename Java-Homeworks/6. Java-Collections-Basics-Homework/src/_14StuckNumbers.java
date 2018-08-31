import java.util.*;

public class _14StuckNumbers {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String n = scan.nextLine();
        String[] input = scan.nextLine().split("[\\W]+");
        //Set<String> hash = new HashSet<String>(Arrays.asList(read));
        //String[] input = hash.toArray(new String[hash.size()]);
        ArrayList<String> output = new ArrayList<>();
        if (input.length < 4){
            System.out.println("No");
            return;
        }
        boolean isStuck = false;

        for (int i = 0; i < input.length; i++) {
            for (int j = 0; j < input.length; j++) {
                if (j == i) continue;
                for (int k = 0; k < input.length; k++) {
                    if (k == j || k == i) continue;
                    for (int m = 0; m < input.length; m++) {
                        if (m == k || m == j || m == i) continue;
                        String first = "" + input[i] + input[j];
                        String second = "" + input[k] + input[m];
                        if (first.equals(second)) {
                            isStuck = true;
                            output.add(
                                    input[i] + "|" + input[j] + "==" + input[k] + "|" + input[m]);
                        }
                    }
                }
            }
        }
        if (!isStuck){
            System.out.println("No");
            return;
        }
        for (String s : output) {
            System.out.println(s);
        }
    }

}
