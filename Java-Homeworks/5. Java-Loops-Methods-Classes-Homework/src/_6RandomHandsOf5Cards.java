import java.util.ArrayList;
import java.util.Random;
import java.util.Scanner;

public class _6RandomHandsOf5Cards {
    public static void main(String[] args) {
        Random random = new Random();
        Scanner scan = new Scanner(System.in);

        String[] suits = {"\u2660", "\u2665", "\u2666", "\u2663"};
        String[] faces = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};

        ArrayList<String> allCards = new ArrayList<>();

        for (int i = 0; i < faces.length; i++) {
            for (int j = 0; j < suits.length; j++) {
                String card = faces[i]+ suits[j];
                allCards.add(card);
            }
        }

        System.out.println("Enter a number of hands:");
        int hands = Integer.parseInt(scan.nextLine());

        int counter = 52;
        for (int i = 0; i < hands; i++) {
            for (int j = 0; j < 5; j++) {
                int randomNumber = random.nextInt(counter);
                String showCard = allCards.get(randomNumber);
                allCards.remove(randomNumber);
                counter--;
                System.out.print(showCard + " ");
            }
            System.out.println();
        }



    }
}
