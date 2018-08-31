import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Date;

public class CurrentDateTime {
    public static void main(String[] args) {

        DateFormat dateFormat = new SimpleDateFormat();
        Date date = new Date();
        System.out.printf("Thew current date and time are: %s",dateFormat.format(date));
    }
}

