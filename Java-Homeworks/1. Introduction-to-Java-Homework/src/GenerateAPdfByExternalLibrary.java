
public class GenerateAPdfByExternalLibrary {

    public static void main(String[] args) {

        for (int i = 14; i > 2; i--) {
            String currentCard;
            switch (i) {
                case 14:
                    currentCard = "A";
                    break;
                case 13:
                    currentCard = "K";
                    break;
                case 12:
                    currentCard = "Q";
                    break;
                case 11:
                    currentCard = "J";
                    break;
                default:
                    currentCard = Integer.toString(i);
                    break;
            }
            for (int j = 1; j < 5; j++){
                switch (j){
                    case 1:
                        String redCard = currentCard + "\u2665" +" ";
                        System.out.print("\033[31;1redCard\033[0m");break;
                    case 2:
                        System.out.print(currentCard + "\u2666" + " ");break;
                    case 3:
                        System.out.print(currentCard + "\u2667" +" ");break;
                    case 4:
                        System.out.print(currentCard + "\u2664" +" ");break;
                }
            }
            System.out.println();

        }
    }
}
