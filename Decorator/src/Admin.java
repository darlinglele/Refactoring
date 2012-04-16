
public class Admin implements IRole {
    public void doAsAdmin() {
        System.out.println("Handling");
    }

    @Override
    public void handle() {
        doAsAdmin();
    }

    @Override
    public IRole clone() {
        return new Admin();
    }
}
