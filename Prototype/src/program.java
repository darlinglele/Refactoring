public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'A';
        handle(requestType);
    }

    private static void handle(char requestType) {
        IRole role = null;
        switch (requestType) {
            case 'A':
                role = new Admin();
                break;
            case 'U':
                role = new User();
                break;
            default:
                role = new User();
                break;
        }
        role.handle();

    }

}
