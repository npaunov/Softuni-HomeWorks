

import java.util.ArrayList;
import java.util.Collections;
import java.util.Scanner;

public class TheSmallestOf3Numbers {
    public static void main(String[] args) {
        ArrayList<Integer> array = new ArrayList<Integer>();
        Scanner scanner = new Scanner(System.in);

        for (int i = 0; i < 3; i++) {
            array.add(scanner.nextInt());
        }

        int smallestInt = Collections.min(array);

        System.out.println("Smallest is: " + smallestInt);
    }
}