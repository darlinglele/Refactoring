public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'U';
        handle(requestType);
    }

    private static void handle(char requestType) {
        Helper.getRoleFactory(requestType).create().handle();
    }

}
