import java.util.Arrays;
import java.util.Scanner;

public class SortArrayOfStrings {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        System.out.print("Number of strings: ");
        int numberOfStrings = scan.nextInt();
        scan.nextLine();

        String[] stringsArr = new String[numberOfStrings];

        for (int i = 0; i < stringsArr.length; i++) {

            stringsArr[i] = scan.nextLine();
        }

        // This is Selection Sort it moves to the left every string that is "lower" to the current
        // It also compares the newly moved one
        for (int i = 0; i < stringsArr.length; i++) {
            String lowestElement;
            for (int j = i; j < stringsArr.length; j++) {
                if (stringsArr[j].compareTo(stringsArr[i]) < 0) {
                    lowestElement = stringsArr[j];
                    stringsArr[j] = stringsArr[i];
                    stringsArr[i] = lowestElement;
                }
            }
        }

        // This uses JDK 1.8
        Arrays.asList(stringsArr).stream().forEach(s -> System.out.println(s));
        System.out.println();

//        //Prior to JDK 1.8;
//        for (String arr : stringsArr) {
//            System.out.println(arr);
//        }

    }
}
