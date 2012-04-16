public class Admin implements IRole {
    public void doAsAdmin() {
        System.out.println("I am Admin");
    }

    @Override
    public void handle() {
        doAsAdmin();
    }

    @Override
    public IRole clone() {
        return new Admin();
    }

    @Override
    public void writeLog() {
        MyLogger logger = new MyLogger();
        logger.Write(this.getClass().toString());
    }

    @Override
    public void print() {
        MyPrinter printer = new MyPrinter();
        printer.print("print 0-34-3450328458445848");
    }
}
