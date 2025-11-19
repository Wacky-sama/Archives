//Tabugadir, Kenji Brocks I. - BSIT 2A

import java.util.Scanner;

public class Main {

    public static void main(String[] knj) {
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
        int a = array.length;
        for (int i = 0; i < a - 1; i++) {
            for (int j = 0; j < a - i - 1; j++) {
                if (array[j].compareTo(array[j + 1]) > 0) {
                    String b = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = b;
                }
            }
        }
    }
}
