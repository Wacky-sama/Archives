/* Leader: Tabugadir, Kenji "Brocks" I.
    Member: Balgos, Wendel B.
            Palarca, Kim Leo II C.
            Pirus, Den Mark
            Aguinaldo, Janice T.
 */
import java.util.Scanner;

public class Main {

    Scanner scanner = new Scanner(System.in);

    public static void main(String[] args) {
        Main app = new Main();
        app.askUser();
    }

    public void askUser() {
        Main menu = new Main();
        System.out.println("\t\tWELCOME TO STUDENT INFORMATION SYSTEM!\t\t");
        System.out.print("Type '1' to continue, type '0' to exit: ");

        int choice = scanner.nextInt();
        scanner.nextLine();

        if (choice == 1) {
            menu.student();
        } else {
            scanner.close();
        }
    }

    public void student() {
        System.out.println("\t\tPLEASE ANSWER ALL THE INFORMATION NEEDED!\t\t");
        try {
            System.out.print("Name: ");
            String name = scanner.nextLine();

            System.out.print("Age: ");
            int age = scanner.nextInt();
            scanner.nextLine();

            System.out.print("Sex: ");
            String sex = scanner.nextLine();

            System.out.print("Course: ");
            String course = scanner.nextLine();

            System.out.print("Year: ");
            int year = scanner.nextInt();
            scanner.nextLine();

            System.out.print("Section: ");
            char section = scanner.nextLine().charAt(0);

            System.out.print("Address: ");
            String address = scanner.nextLine();

            if (sex.equalsIgnoreCase("M")) {
                System.out.println("\n" + name + " is a Student of CSU Gonzaga University and these are his info:");
            } else if (sex.equalsIgnoreCase("F")) {
                System.out.println("\n" + name + " is a Student of CSU Gonzaga University and these are her info:");
            }

            System.out.println("Name: " + name);
            System.out.println("Age: " + age);
            System.out.println("Sex: " + sex);
            System.out.println("Course: " + course);
            System.out.println("Year: " + year);
            System.out.println("Section: " + section);
            System.out.println("Address: " + address);

        } catch (Exception error) {
            System.out.println("\t\t[MAKE SURE YOU ENTERED THE INFORMATION NEEDED]\t\t");
            scanner.nextLine();
            clearConsole();
        }
    }

    private static void clearConsole() {
        System.out.print("\033[H\033[2J");
        System.out.flush();
    }
}
