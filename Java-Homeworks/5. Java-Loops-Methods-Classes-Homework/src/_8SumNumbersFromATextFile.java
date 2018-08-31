import java.io.BufferedReader;
        import java.io.FileNotFoundException;
        import java.io.FileReader;
        import java.util.Scanner;

public class _8SumNumbersFromATextFile {
    public static void main(String[] args) {
        try {
            FileReader fileInput = new FileReader("Input.txt");
            Scanner scan = new Scanner(fileInput);

            int totalSum = 0;
            while (scan.hasNextLine()) {
                totalSum += Integer.parseInt(scan.nextLine());
            }
            System.out.println(totalSum);

        } catch (FileNotFoundException e) {
            System.out.println("Error");
        }
    }
}
