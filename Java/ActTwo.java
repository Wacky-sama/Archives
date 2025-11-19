
import java.util.Scanner;

public class ActTwo {

    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        System.out.println("Enter 5 students name: ");
        String[] studentsName = new String[5];
        for (int i = 0; i < 5; i++) {
            studentsName[i] = scanner.nextLine();
        }
        System.out.println("\nYou entered: \n");
        for (String students : studentsName) {
            System.out.println(students);
        }
        bubble_Sort(studentsName);
        System.out.println("\nStudents Name After Sorting Alphabetically: \n");
        for (String students : studentsName) {
            System.out.println(students);
        }
        scanner.close();
    }

    private static void bubble_Sort(String[] array) {
        int length = array.length;
        for (int passIndex = 0; passIndex < length - 1; passIndex++) {
            for (int currentIndex = 0; currentIndex < length - passIndex - 1; currentIndex++) {
                if (array[currentIndex].compareTo(array[currentIndex + 1]) > 0) {
                    String temp = array[currentIndex];
                    array[currentIndex] = array[currentIndex + 1];
                    array[currentIndex + 1] = temp;
                }
            }
        }
    }
}
