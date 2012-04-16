public class User  implements IRole{
    public void doAsUser() {
        System.out.println("I am User");
    }

    @Override
    public void handle() {
        new MyLogger().Write("messages");
        doAsUser();
    }

    @Override
    public IRole clone(){
        return new User();
    }
}


