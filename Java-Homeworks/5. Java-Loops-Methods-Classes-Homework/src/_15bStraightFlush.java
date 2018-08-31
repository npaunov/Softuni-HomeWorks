import java.util.Arrays;
import java.util.Scanner;

public class _15bStraightFlush {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String[] input = scan.nextLine().split("\\W+");
        //String[] input = {"9D", "9F", "2S", "10D", "AD", "10H", "JD", "QD", "KD"};
        String[] setsOfCards = new String[input.length];

        setsOfCardsFiller(input, setsOfCards);
        Arrays.sort(setsOfCards);
        boolean allFlush = false;

        for (int i = 0; i < setsOfCards.length; i++) {
            String[] currentCard = setsOfCards[i].split(" ");
            if (i + 4 >= setsOfCards.length) {
                break;
            }
            String[] cardAfter = setsOfCards[i + 4].split(" ");
            if (!currentCard[0].equals(cardAfter[0])) {
                continue;
            }
            boolean checkCurrentFlush = isStraightFlush(setsOfCards, i, currentCard[1]);
            if (checkCurrentFlush) {
                printFlush(setsOfCards, i);
                allFlush = true;
            }

        }
        if (!allFlush){
            System.out.println("No Straight Flushes");
        }


        //System.out.println(Arrays.toString(setsOfCards));
    }

    private static void printFlush(String[] setsOfCards, int i) {
        String[] straightFlush = new String[5];
        int counter = 0;
        for (int j = i; j <= i + 4; j++) {
            String[] flushCard = setsOfCards[j].split(" ");
            Integer cardInput = Integer.parseInt(flushCard[1]);
            String card;
            switch (cardInput) {
                case 11:
                    card = "J";
                    break;
                case 12:
                    card = "Q";
                    break;
                case 13:
                    card = "K";
                    break;
                case 14:
                    card = "A";
                    break;
                default:
                    card = Integer.toString(cardInput);
                    break;
            }
            String suit = flushCard[0];
            straightFlush[counter] = card + suit;
            counter++;
        }
        System.out.println(Arrays.toString(straightFlush));
    }

    private static boolean isStraightFlush(String[] setsOfCards, int i, String s) {
        boolean isStraightFlush = false;
        int counter = 1;
        for (int j = i + 1; j <= i + 4; j++) {
            isStraightFlush = false;
            String[] nextCard = setsOfCards[j].split(" ");
            Integer current = Integer.parseInt(s);
            Integer next = Integer.parseInt(nextCard[1]);
            if (current + counter != next) {
                break;
            }
            counter++;
            isStraightFlush = true;
        }
        return isStraightFlush;
    }

    private static void setsOfCardsFiller(String[] input, String[] setsOfCards) {
        for (int i = 0; i < setsOfCards.length; i++) {
            String suit = input[i].substring(input[i].length() - 1);
            String inputCard = input[i].substring(0, input[i].length() - 1);
            String card;
            switch (inputCard) {
                case "J":
                    card = "11";
                    break;
                case "Q":
                    card = "12";
                    break;
                case "K":
                    card = "13";
                    break;
                case "A":
                    card = "14";
                    break;
                default:
                    card = inputCard;

            }
            if (card.length() == 1) {
                card = "0" + card;
            }
            setsOfCards[i] = suit + " " + card;

        }
    }
}
