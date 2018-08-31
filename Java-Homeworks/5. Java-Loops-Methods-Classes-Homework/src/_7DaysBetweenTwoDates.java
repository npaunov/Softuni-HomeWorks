import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Date;
import java.util.Scanner;
import java.util.concurrent.TimeUnit;

public class _7DaysBetweenTwoDates {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        SimpleDateFormat myFormat = new SimpleDateFormat("dd-MM-yyyy");

        try {
            Date firstDate = myFormat.parse(scan.nextLine());
            Date secondDate = myFormat.parse(scan.nextLine());

            long difference = secondDate.getTime() - firstDate.getTime();
            System.out.println ("Days: " + TimeUnit.DAYS.convert(difference, TimeUnit.MILLISECONDS));

        } catch (ParseException e) {
            e.printStackTrace();
        }
    }
}
