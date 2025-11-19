
public class TV {

    public void display() {
        TV tvInstance = new TV();
        tvInstance.type(100);
    }

    public void type(int value) {
        System.out.println(value);
    }

    public static void main(String[] args) {
        TV app = new TV();
        app.display();
    }
}
