import java.util.Scanner;


public class aula2 {
  public static void main(String[] args) {
    Scanner sc = new Scanner(System.in);

    int num, t, i;

    //tabuada do 5

    System.out.println("Digite um número: ");
    
    num = sc.nextInt();
    
    
    sc.close();
    
    for (i = 1; i <= 10; i++) {
      t = num * i;
      System.out.println(num + " x " + i + " = " + t);
    }

    
  }
}
