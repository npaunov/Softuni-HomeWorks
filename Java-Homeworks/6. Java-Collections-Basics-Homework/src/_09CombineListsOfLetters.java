import java.util.ArrayList;
import java.util.Scanner;

public class _09CombineListsOfLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String first = scan.nextLine().replace(" ", "");
        String second = scan.nextLine().replace(" ", "");

        ArrayList<Character> firstList = fillList(first);
        ArrayList<Character> secondList = fillList(second);

        secondList.removeAll(firstList);
        firstList.addAll(secondList);

        for (Character character : firstList) {
            System.out.print(character + " ");
        }

    }

    private static  ArrayList<Character> fillList(String first) {
        ArrayList<Character> tempList = new ArrayList<>();
        for (int i = 0; i < first.length(); i++) {
            tempList.add(first.charAt(i));
        }
        return tempList;
    }
}
