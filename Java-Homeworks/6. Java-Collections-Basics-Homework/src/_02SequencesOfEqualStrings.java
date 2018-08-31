import java.util.Scanner;

public class _02SequencesOfEqualStrings {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        String[] input = scan.nextLine().split(" ");

        for (int i = 0; i < input.length; i++) {

            System.out.print(input[i] + " ");
            if (checkOutOfRange(input, i)) break;

            while ((input[i].equals(input[i+1]) )){
                System.out.print(input[i+1] + " ");
                i++;
                if (checkOutOfRange(input, i)) break;
            }
            System.out.println();
        }
    }

    private static boolean checkOutOfRange(String[] input, int i) {
        if(i == input.length-1){
            return true;
        }
        return false;
    }
}
