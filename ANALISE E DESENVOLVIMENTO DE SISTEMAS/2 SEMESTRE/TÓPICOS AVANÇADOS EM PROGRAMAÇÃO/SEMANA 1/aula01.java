import java.util.Scanner;

public class aula01{
    public static void main(String[] args){
        Scanner sc = new Scanner(System.in);
        int a, b, soma;

        System.out.println("Digite o primeiro número: ");
        a = sc.nextInt();

        System.out.println("Digite o segundo número: ");
        b = sc.nextInt();

        soma = a + b;

        System.out.println("Soma: " + soma);
        

    }
}