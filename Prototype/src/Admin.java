/**
 * Created by IntelliJ IDEA.
 * User: dearlele
 * Date: 4/15/12
 * Time: 2:38 PM
 * To change this template use File | Settings | File Templates.
 */
public class Admin implements IRole {
    public void doAsAdmin() {
        System.out.println("I am Admin");
    }

    @Override
    public void handle() {
        doAsAdmin();
    }
}
