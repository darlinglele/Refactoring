public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'U';
        handle(requestType);
    }

    private static void handle(char requestType) {
        IRoleFactory roleFactory = Helper.getRoleFactory(requestType);
        roleFactory.create().handle();
    }

}
