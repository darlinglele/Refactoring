public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'A';
        handle(requestType);
        writeLog(requestType);
    }

    private static void writeLog(char requestType) {

        IRole role = Helper.getRoleFactory(requestType).create();
        role = new LoggerDecorator(role);
        ((ILog) role).writeLog();
    }

    private static void handle(char requestType) {
        IRoleFactory roleFactory = Helper.getRoleFactory(requestType);
        roleFactory.create().handle();
    }
}
