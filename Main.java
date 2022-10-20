import java.util.Scanner;

public class Main {
    public static void main(String[] args) {
        boolean loop = true;
        Scanner input = new Scanner(System.in);
        System.out.println("Enter a number");
        double calc = input.nextDouble();
        while (loop) {
            System.out.println("Enter operator");
            String operator = input.next();
            switch (operator) {
                case "*" -> {
                    System.out.println("Enter a number");
                    double number = input.nextDouble();
                    calc *= number;
                }
                case "+" -> {
                    System.out.println("Enter a number");
                    double number = input.nextDouble();
                    calc += number;
                }
                case "-" -> {
                    System.out.println("Enter a number");
                    double number = input.nextDouble();
                    calc -= number;
                }
                case "/" -> {
                    System.out.println("Enter a number");
                    double number = input.nextDouble();
                    calc /= number;
                }
                case "=" -> {
                    System.out.println(calc);
                }
                case "c" -> {
                    calc = 0;
                    System.out.println("Enter a number");
                    calc = input.nextDouble();
                }
                case "exit" -> {
                    loop = false;
                }
                default -> {
                    System.out.println("Error");
                    System.out.println("Enter a number");
                    calc = input.nextDouble();
                }
            }
        }




    }
}