import java.util.Arrays;
import java.util.Collections;
import java.util.Scanner;
import java.util.stream.Stream;

public class _5LegoBlocks {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int size = (Integer.parseInt(scan.nextLine()));
        String[][] arrayTotal = new String[size * 2][];
        int counter = 0;

        while (size * 2 != counter) {
            String[] input = scan.nextLine().trim().split("\\s+");
            arrayTotal[counter] = input;
            counter++;
        }
        int firstRowLength = arrayTotal[0].length + arrayTotal[size].length;
        boolean isBlock = true;
        int totalCells = 0;
        for (int i = 0; i < arrayTotal.length - size; i++) {
            totalCells += (arrayTotal[i].length + arrayTotal[i + size].length);
            if ((arrayTotal[i].length + arrayTotal[i + size].length) != firstRowLength) {
                isBlock = false;
            }
        }
        if (isBlock) {
            for (int i = 0; i < arrayTotal.length - size; i++) {
                String[] reversed = arrayTotal[i + size].clone();
                Collections.reverse(Arrays.asList(reversed));
                String[] both = Stream.concat(Arrays.stream(arrayTotal[i]), Arrays.stream(reversed))
                        .toArray(String[]::new);
                System.out.print(Arrays.toString(both));
                System.out.println();
            }
        } else {
            System.out.printf("The total number of cells is: %d", totalCells);
        }
    }
}
