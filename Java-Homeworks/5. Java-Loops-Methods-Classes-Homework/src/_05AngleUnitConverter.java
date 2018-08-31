import java.util.Locale;
import java.util.Scanner;

public class _05AngleUnitConverter {
    public static void main(String[] args) {
        Locale.setDefault(Locale.US);
        Scanner scan = new Scanner(System.in);

        Integer numbersOfCalculations = Integer.parseInt(scan.nextLine());
        String[] input = new String[numbersOfCalculations];
        int counter = 0;

        while (counter < numbersOfCalculations) {
            input[counter] = scan.nextLine();
            counter++;
        }
        for (int i = 0; i < input.length; i++) {
            String[] split = input[i].split(" ");
            double number = Double.parseDouble(split[0]);
            String operand = split[1];
            double output;

            if (operand.equals("deg")){
                output = Math.toRadians(number);
            }else {
                output = Math.toDegrees(number);
            }

            String finalText = operand.equals("deg")? "rad": "deg";
            System.out.printf("%.6f %s\n", output, finalText);


        }

    }
}
