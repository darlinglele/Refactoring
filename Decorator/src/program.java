public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'A';
        handle(requestType);
        writeLog(requestType);
        print(requestType);
    }

    private static void print(char requestType) {
        IRole role = Helper.getRoleFactory(requestType).create();
            role.print();
    }

    private static void writeLog(char requestType) {
        IRole role = Helper.getRoleFactory(requestType).create();
        role.writeLog();
    }

    private static void handle(char requestType) {
        IRoleFactory roleFactory = Helper.getRoleFactory(requestType);
        roleFactory.create().handle();
    }

}
