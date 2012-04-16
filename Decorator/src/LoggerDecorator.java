public class LoggerDecorator implements ILog,IRole {
    private IRole role = null;
    private MyLogger logger = new MyLogger();

    public LoggerDecorator(IRole role) {
        this.role = role;
    }

    @Override
    public void write(String message) {

    }

    @Override
    public void handle() {
        logger.Write(this.role.toString());
        this.role.handle();
    }

    @Override
    public IRole clone() {
        return this.role.clone();
    }

    @Override
    public void writeLog() {

    }

    @Override
    public void print() {
        //To change body of implemented methods use File | Settings | File Templates.
    }
}
