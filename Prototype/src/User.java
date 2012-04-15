public class User  implements IRole{
    public void doAsUser() {
        System.out.println("I am User");
    }

    @Override
    public void handle() {
        doAsUser();
    }
}
