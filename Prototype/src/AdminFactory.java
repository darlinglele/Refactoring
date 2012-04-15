/**
 * Created by IntelliJ IDEA.
 * User: dearlele
 * Date: 4/15/12
 * Time: 3:22 PM
 * To change this template use File | Settings | File Templates.
 */
public class AdminFactory  implements IRoleFactory{
     public IRole create() {
        return new Admin();
    }
}
