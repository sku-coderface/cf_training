import java.util.Scanner;
class QutosPrint{
    public static void main(String args[]){
        System.out.print("What is the quote? ");
        Scanner Scanner = new Scanner(System.in);
        String quote = Scanner.nextLine();
        System.out.print("who said it? ");
        String speak = Scanner.nextLine();
        String concat = speak.concat( " says, ");
        concat = concat.concat(quote);
        System.out.println(concat);
    }
}