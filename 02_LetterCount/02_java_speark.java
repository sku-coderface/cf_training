import java.util.Scanner;
class LetterCount{
	public static void main(String args[]){
		System.out.print("What is the input String? ");
		Scanner scanner = new Scanner(System.in);
		String input = scanner.nextLine();
		System.out.println(input + " has " + input.length() + " characters.");
	}
}