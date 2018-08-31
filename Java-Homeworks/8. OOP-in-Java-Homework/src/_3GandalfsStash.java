import java.util.Scanner;

public class _3GandalfsStash {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        int mood = Integer.parseInt(scan.nextLine());
        String[] input = scan.nextLine().toLowerCase().split("[\\W_]+");

        for (int i = 0; i < input.length; i++) {
            switch (input[i]) {
                case "cram":
                    mood += 2;
                    break;
                case "lembas":
                    mood += 3;
                    break;
                case "apple":
                    mood++;
                    break;
                case "melon":
                    mood++;
                    break;
                case "honeycake":
                    mood += 5;
                    break;
                case "mushrooms":
                    mood -= 10;
                    break;
                default:
                    mood--;
                    break;
            }

        }
        if (mood < -5) {
            System.out.println(mood);
            System.out.println("Angry");
        } else if (mood >= -5 && mood < 0) {
            System.out.println(mood);
            System.out.println("Sad");
        } else if (mood >= 0 && mood <= 15) {
            System.out.println(mood);
            System.out.println("Happy");
        } else if (mood > 15) {
            System.out.println(mood);
            System.out.println("Special JavaScript mood ");
        }
    }
}
