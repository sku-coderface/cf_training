import java.util.Scanner;
import java.lang.Integer;
class SimplyMath{
    public static void main(String[] args) {
        System.out.print("Please input the first number. ");
        Scanner scanner = new Scanner(System.in);
        int input1 = Integer.valueOf(scanner.nextLine());

        System.out.print("Please input the second number. ");
        int input2 = Integer.valueOf(scanner.nextLine());

        System.out.println(input1 + "+" + input2 + "=" + (input1 + input2) + "\n" +
                           input1 + "-" + input2 + "=" + (input1 - input2) + "\n" +
                           input1 + "*" + input2 + "=" + (input1 * input2) + "\n" +
                           input1 + "/" + input2 + "=" + ((double)input1 / input2));
    } 
}