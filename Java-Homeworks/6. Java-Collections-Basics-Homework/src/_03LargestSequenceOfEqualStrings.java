import java.util.ArrayList;
import java.util.Scanner;

public class _03LargestSequenceOfEqualStrings {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");

        ArrayList<String> output = new ArrayList<String>(){{add(input[0]);}};

        for (int i = 0; i < input.length - 1; i++) {
            int counter = 1;

            while (input[i].equals(input[i+1])){
                counter++;
                i++;
                if (i== input.length-1){
                    break;
                }
            }
            if (counter > output.size()){
                output.clear();
                while (counter >0){
                    output.add(input[i-1]);
                    counter--;
                }
            }
        }
        System.out.println(String.join(" ", output));
    }
}
