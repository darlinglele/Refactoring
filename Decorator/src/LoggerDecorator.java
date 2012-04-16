/**
 * Created by IntelliJ IDEA.
 * User: dearlele
 * Date: 4/15/12
 * Time: 7:30 PM
 * To change this template use File | Settings | File Templates.
 */
public class LoggerDecorator implements IRole, ILog {
    private IRole role=null;

    public LoggerDecorator(IRole role) {
        this.role=role;
    }

    @Override
    public void handle() {
        this.role.handle();
    }

    @Override
    public IRole clone() {
        return this.role.clone();
    }

    @Override
    public void writeLog() {
        MyLogger logger=new MyLogger();
        logger.Write("logging:"+this.role.getClass().toString());
    }
}
