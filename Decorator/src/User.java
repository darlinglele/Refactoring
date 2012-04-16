public class User  implements IRole{
    public void doAsUser() {
        System.out.println("I am User");
    }

    @Override
    public void handle() {
        doAsUser();
    }
    @Override
    public IRole clone(){
        return new User();
    }

    @Override
    public void writeLog() {
        //I don't need to write Log
    }

    @Override
    public void print() {
        //To change body of implemented methods use File | Settings | File Templates.
    }
}


