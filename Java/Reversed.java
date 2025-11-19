// Tabugadir, Kenji "Brocks" I. - BSIT 2A - IT211

import java.util.*;

public class Main {

    public static void main(String[] knj) {
        Scanner scanner = new Scanner(System.in);
        char choice;

        do {
            System.out.print("Enter a word. I will reverse it: ");
            String input = scanner.next();
            String reverseWord = reversedWord(input);
            System.out.println("Reverse word:  " + reverseWord);
            System.out.print("Again? (y/n): ");
            choice = scanner.next().charAt(0);
        } while (choice == 'y' || choice == 'N');
        System.out.println("That's it, forwards and backwards!");
    }

    static String reversedWord(String word) {
        Stack<Character> stack = new Stack<>();
        for (char ch : word.toCharArray()) {
            stack.push(ch);
        }
        StringBuilder reversedWord = new StringBuilder();
        while (!stack.isEmpty()) {
            reversedWord.append(stack.pop());
        }
        return reversedWord.toString();
    }
}
