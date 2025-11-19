
public class Main {

    public static void main(String[] args) {
        Person myObj = new Person();
        Animal myObjTw = new Animal();
        myObj.setName("Kenji \"Brocks\" Ibus Tabugadir");
        myObjTw.setPet("Cat");
        System.out.println(myObj.getName());
        System.out.println(myObjTw.getPet());
    }
}

public class Person {

    private String name;

    public String getName() {
        return name;
    }

    public void setName(String newName) {
        this.name = newName;
    }
}

public class Animal {

    private String pet;

    public String getPet() {
        return pet;
    }

    public void setPet(String newPet) {
        this.pet = newPet;
    }
}
