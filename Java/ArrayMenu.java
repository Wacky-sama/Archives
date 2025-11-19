
import java.util.Arrays;
import java.util.Scanner;

class Main {

    Scanner scanner = new Scanner(System.in);
    int choose;
    int i;
    int element;

    public static void main(String[] knj) {
        Main show = new Main();
        show.selectMenu();
    }

    public void selectMenu() {
        Main select = new Main();
        System.out.println("ARRAY'S MENU\n 1 - Display Score\n 2 - Maximum Score\n 3 - Sorting Items(Lowest to Highest)\n 4 - Delete Item\n 5 - Exit");
        System.out.print("Enter Choice: ");
        choose = scanner.nextInt();
        if (choose == 1) {
            select.displayScore();
        } else if (choose == 2) {
            select.maximumScore();
        } else if (choose == 3) {
            select.sortingItems();
        } else if (choose == 4) {
            select.deleteItem();
        } else if (choose == 5) {
            select.exit();
        } else {
            System.out.println("Please try again.");
            select.selectMenu();
        }
    }

    public void displayScore() {
        Main showScore = new Main();
        System.out.println("DISPLAY SCORE");
        System.out.print("Enter number of elements: ");
        element = scanner.nextInt();
        int element_One[] = new int[element];
        System.out.print("Enter the " + element + " element/s:\n");
        for (i = 0; i < element; i++) {
            element_One[i] = scanner.nextInt();
        }
        System.out.println("The elements you entered are: " + Arrays.toString(element_One));
        do {
            System.out.print("Want to try again [Y/N]: ");
            String anotherTry = scanner.next();
            if (anotherTry.equalsIgnoreCase("Y")) {
                showScore.displayScore();
            } else if (anotherTry.equalsIgnoreCase("N")) {
                showScore.selectMenu();
            }
        } while (false);
        scanner.close();
    }

    public void maximumScore() {
        Main displayMaxScore = new Main();
        System.out.println("MAXIMUM SCORE");
        System.out.print("Enter number of elements: ");
        element = scanner.nextInt();
        int element_One[] = new int[element];
        System.out.print("Enter the " + element + " element/s:\n");
        for (i = 0; i < element; i++) {
            element_One[i] = scanner.nextInt();
        }
        int score = element_One[0];
        int index = 0;
        for (i = 1; i < element; i++) {
            if (element_One[i] > score) {
                score = element_One[i];
                index = i;
            }
        }
        System.out.println("The highest score is " + score + " and is in index " + index);
        do {
            System.out.print("Want to try again? [Y/N]: ");
            String anotherTry = scanner.next();
            if (anotherTry.equalsIgnoreCase("Y")) {
                displayMaxScore.maximumScore();
            } else if (anotherTry.equalsIgnoreCase("N")) {
                displayMaxScore.selectMenu();
            }
        } while (false);
        scanner.close();
    }

    public void sortingItems() {
        Main displaySort = new Main();
        System.out.println("SORTING ITEMS(LOWEST TO HIGHEST)");
        System.out.print("Enter number of element/s: ");
        element = scanner.nextInt();
        int element_One[] = new int[element];
        System.out.print("Enter the " + element + " element/s:\n");
        for (i = 0; i < element; i++) {
            element_One[i] = scanner.nextInt();
        }
        bubbleSort(element_One);
        System.out.println("From Lowest to Highest: " + Arrays.toString(element_One));
        do {
            System.out.print("Want to try again? [Y/N]: ");
            String anotherTry = scanner.next();
            if (anotherTry.equalsIgnoreCase("Y")) {
                displaySort.sortingItems();
            } else if (anotherTry.equalsIgnoreCase("N")) {
                displaySort.selectMenu();
            }
        } while (false);
        scanner.close();
    }

    private static void bubbleSort(int[] array) {
        int num = array.length;
        int i;
        int j;
        for (i = 0; i < num - 1; i++) {
            for (j = 0; j < num - i - 1; j++) {
                if (array[j] > array[j + 1]) {
                    int tempo = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = tempo;
                }
            }
        }
    }

    private static void selectionSort(int[] array) {
        int num = array.length;
        int i;
        int j;
        for (i = 0; i < num - 1; i++) {
            int minimumIndex = 1;
            for (j = i + 1; j < num; j++) {
                if (array[j] < array[minimumIndex]) {
                    minimumIndex = j;
                }
            }
            int tempo = array[minimumIndex];
            array[minimumIndex] = array[i];
            array[i] = tempo;
        }
    }

    public void deleteItem() {
        Main displayDelete = new Main();
        System.out.println("DELETE ITEM");
        System.out.print("Enter number of elements: ");
        element = scanner.nextInt();
        int element_One[] = new int[element];
        System.out.print("Enter the " + element + " element/s:\n");
        for (i = 0; i < element; i++) {
            element_One[i] = scanner.nextInt();
        }
        System.out.print("Enter the element to delete: ");
        int deleteElement = scanner.nextInt();
        element_One = elementDel(element_One, deleteElement);
        System.out.println("Element " + deleteElement + " has been deleted.");
        for (int newElement : element_One) {
            System.out.println("New elements in the array: " + newElement);
        }
        do {
            System.out.print("Want to try again? [Y/N]: ");
            String anotherTry = scanner.next();
            if (anotherTry.equalsIgnoreCase("Y")) {
                displayDelete.sortingItems();
            } else if (anotherTry.equalsIgnoreCase("N")) {
                displayDelete.selectMenu();
            }
        } while (false);
        scanner.close();
    }

    private static int[] elementDel(int[] array, int element) {
        int i;
        int newSize = array.length - 1;
        int newElement[] = new int[newSize];
        int newIndex = 0;
        for (i = 0; i < array.length; i++) {
            if (array[i] != element) {
                newElement[newIndex] = array[i];
                newIndex++;
            }
        }
        return newElement;
    }

    public void exit() {
        scanner.close();
    }
}
