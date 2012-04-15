/**
 * Created by IntelliJ IDEA.
 * User: dearlele
 * Date: 4/15/12
 * Time: 3:21 PM
 * To change this template use File | Settings | File Templates.
 */
public class UserFactory implements IRoleFactory{
     public IRole create() {
        return new User();
    }
}
