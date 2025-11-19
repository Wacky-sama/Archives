
import java.util.Arrays;
import java.util.Scanner;

public class Exercise_One {

    public static void main(String[] knj) {
        int elements, search, passIndex = 0, currentIndex = 0;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter number of elements: ");
        elements = scanner.nextInt();
        int elementsOne[] = new int[elements];
        System.out.println("Input the " + elements + " elements: ");
        for (passIndex = 0; passIndex < elements; passIndex++) {
            elementsOne[passIndex] = scanner.nextInt();
        }
        System.out.println("The elements you entered are: " + Arrays.toString(elementsOne));
        System.out.println("Enter number to search: ");
        search = scanner.nextInt();
        for (passIndex = 0; passIndex < elements; passIndex++) {
            if (elementsOne[passIndex] == search) {
                currentIndex = 1;
                break;
            } else {
                currentIndex = 0;
            }
        }
        if (currentIndex == 1) {
            System.out.println("Found " + search + " at index " + (passIndex));
        } else {
            System.out.println("Element not found.");
        }
    }
}
