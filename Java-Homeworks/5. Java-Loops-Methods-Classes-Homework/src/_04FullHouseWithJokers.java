import java.util.ArrayList;


// It is the same code from the previous task it has Onle One For loop added!
// The code is so long because it is meant to be changed easily if needed!

public class _04FullHouseWithJokers {
    public static void main(String[] args) {

        ArrayList<String> threeSet = new ArrayList<String>();
        ArrayList<String> twoSet = new ArrayList<String>();
        ArrayList<String> fiveSet = new ArrayList<>();
        ArrayList<String> fiveSetReplaced = new ArrayList<>();
        // Creates a list of all UNIQUE three variations "123" "124" "134" "234"! It easily can be changed
        threeSetFiller(4, threeSet);
        // Creates a list of all UNIQUE two variations "12" "13" "14" "23" "24" "34"! It easily can be changed
        twoSetFiller(4, twoSet);
        // Combines the two previous sets
        fiveSetFiller(threeSet, twoSet, fiveSet);
        // Replaces numbers with suits "1234" => "♥♦♣♠". In that order!
        replaceSuits(fiveSet, fiveSetReplaced);

        String[] cards = {"2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A"};
        StringBuilder fullHouse = new StringBuilder();
        int counter = 0;

        // Takes the First card e.g. "2" three times + second card "3" two times
        // It moves forward to the end of the deck
        // It is the half of the fullhouses
        for (int i = 0; i < cards.length - 1; i++) {
            for (int j = i + 1; j < cards.length; j++) {
                for (int k = 0; k < fiveSetReplaced.size(); k++) {
                    char[] currentColors = fiveSetReplaced.get(k).toCharArray();
                    // This "for" Loop takes the numbers from 0 to 31 into binary representation
                    // Since they are all variables of 5 bits it is useful to find out the jokers
                    // The zeroes are jokers and ones are real cards!
                    // Examples: "00000" "00100" "00111" => "11111" = 31
                    for (int l = 0; l < 32; l++) {
                        String binaryResult = String.format("%5s", Integer.toBinaryString(l)).replace(' ', '0');
                        char[] joker = binaryResult.toCharArray();

                        String firstCard = joker[0] == '0' ? " * " : cards[i] + currentColors[0] + " ";
                        String secondCard = joker[1] == '0' ? " * " : cards[i] + currentColors[1] + " ";
                        String thirdCard = joker[2] == '0' ? " * " : cards[i] + currentColors[2] + " ";
                        String forthCard = joker[3] == '0' ? " * " : cards[j] + currentColors[3] + " ";
                        String fifthCard = joker[4] == '0' ? " * " : cards[j] + currentColors[4];
                        String allCards =  firstCard + secondCard + thirdCard + forthCard + fifthCard;
                        counter++;
                        fullHouse.append(allCards + System.getProperty("line.separator"));
                    }
                }

            }
        }
        // Takes the Last card e.g. "A" three times + previous card "K" two times
        // It moves backward to the begging of the deck
        // It is the second half of the fullhouses
        for (int i = cards.length - 1; i >= 1; i--) {
            for (int j = i - 1; j >= 0; j--) {
                for (int k = 0; k < fiveSetReplaced.size(); k++) {
                    char[] currentColors = fiveSetReplaced.get(k).toCharArray();
                    for (int l = 0; l < 32; l++) {
                        String binaryResult = String.format("%5s", Integer.toBinaryString(l)).replace(' ', '0');
                        char[] joker = binaryResult.toCharArray();

                        String firstCard = joker[0] == '0' ? " * " : cards[i] + currentColors[0] + " ";
                        String secondCard = joker[1] == '0' ? " * " : cards[i] + currentColors[1] + " ";
                        String thirdCard = joker[2] == '0' ? " * " : cards[i] + currentColors[2] + " ";
                        String forthCard = joker[3] == '0' ? " * " : cards[j] + currentColors[3] + " ";
                        String fifthCard = joker[4] == '0' ? " * " : cards[j] + currentColors[4];
                        String allCards =  firstCard + secondCard + thirdCard + forthCard + fifthCard;
                        counter++;
                        fullHouse.append(allCards + System.getProperty("line.separator"));
                    }
                }

            }
        }

        System.out.println(fullHouse);
        System.out.println(counter);
    }

    private static void replaceSuits(ArrayList<String> fiveSet, ArrayList<String> fiveSetReplaced) {
        // String[] suits = {"\u2665","\u2666","\u2663","\u2660"};
        for (int i = 0; i < fiveSet.size(); i++) {
            String old = fiveSet.get(i);
            String hearts = old.replaceAll("1", "\u2665");
            String diamonds = hearts.replaceAll("2", "\u2666");
            String clubs = diamonds.replaceAll("3", "\u2663");
            String spades = clubs.replaceAll("4", "\u2660");
            fiveSetReplaced.add(spades);
        }
    }

    private static void fiveSetFiller(ArrayList<String> threeSet, ArrayList<String> twoSet, ArrayList<String> fiveSet) {
        for (String three : threeSet) {
            for (String two : twoSet) {
                fiveSet.add(three + two);
            }
        }
    }


    private static void twoSetFiller(int variations, ArrayList<String> twoSet) {
        for (int i = 1; i <= variations; i++) {
            for (int j = i + 1; j <= variations; j++) {
                if (i == j) j++;
                if (j > variations) break;
                String all = (Integer.toString(i)) + (Integer.toString(j));
                twoSet.add(all);

            }
        }
    }

    private static void threeSetFiller(int variations, ArrayList<String> threeSet) {
        for (int i = 1; i <= variations; i++) {
            for (int j = i + 1; j <= variations; j++) {
                if (i == j) j++;
                if (j > variations) break;
                for (int k = j + 1; k <= variations; k++) {
                    while ((j == k) || (i == k)) k++;
                    if (k > variations) break;
                    String all = (Integer.toString(i)) + (Integer.toString(j)) + (Integer.toString(k));
                    threeSet.add(all);
                }

            }
        }
    }

}
