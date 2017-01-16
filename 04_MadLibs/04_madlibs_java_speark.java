import java.util.Scanner;
class MadLibs{
    public static void main(String[] args){
        Scanner scanner = new Scanner(System.in);
        System.out.print("Enter a noun: ");
        String noun = scanner.nextLine();
        System.out.print("Enter a verb: ");
        String verb = scanner.nextLine();
        System.out.print("Enter an adjective: ");
        String adjective = scanner.nextLine();
        System.out.print("Enter an adverb: ");
        String adverb = scanner.nextLine();

    System.out.println("Do you" + verb + " your " + adjective + " " + noun + " " + adverb + "?" + "That's hilarious!");
    }
}