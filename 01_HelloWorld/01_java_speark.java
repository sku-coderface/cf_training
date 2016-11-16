import java.util.Scanner;
class HelloWorld{
    public static void main(String args[]){
        /*
            입력 : 이름
            출력 : 이름       
        */
        Scanner scanner = new Scanner(System.in);
        System.out.print("이름이 뭔가요? ");
        String name = scanner.nextLine();
        System.out.print(name + "님 반갑습니다. 만나서 반가워요"); 
   }
}