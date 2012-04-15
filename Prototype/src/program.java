public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'A';
        handle(requestType);
    }

    private static void handle(char requestType) {
        IRole role = null;
        IRoleFactory roleFactory;

        switch (requestType) {
            case 'A':
                roleFactory = new AdminFactory();
                break;
            case 'U':
                roleFactory = new UserFactory();
                break;
            default:
                roleFactory = new UserFactory();
                break;
        }

        roleFactory.create().handle();
    }

}
