//Tabugadir, Kenji Brocks I. 

import java.util.Scanner;

public class Calculator {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.print("First Number: ");
        double numOne = scanner.nextDouble();

        System.out.print("Enter Operator (+, -, *, /): ");
        char opr = scanner.next().charAt(0);

        System.out.print("Second Number: ");
        double numTwo = scanner.nextDouble();

        double result = 0;

        switch (opr) {
            case '+':
                result = numOne + numTwo;
                break;

            case '-':
                result = numOne - numTwo;
                break;

            case '*':
                result = numOne * numTwo;
                break;

            case '/':
                if (numTwo != 0) {
                    result = numOne / numTwo;
                } else {
                    System.out.println("Cannot divide by zero.");
                    return;
                }
                break;
            default:
                System.out.println("Invalid operator.");
                return;
        }
        System.out.println("Result: " + result);
    }
}
