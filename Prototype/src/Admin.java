public class Admin implements IRole {
    public void doAsAdmin() {
        System.out.println("I am Admin");
    }

    @Override
    public void handle() {
        doAsAdmin();
    }
    
    @Override
    public IRole clone(){
       return new Admin();
    }
}
