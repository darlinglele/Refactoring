public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'A';
        handle(requestType);
    }

    private static void handle(char requestType) {
        switch (requestType) {
            case 'A':
                new Admin().doAsAdmin();
                break;
            case 'U':
                new User().doAsUser();
                break;
            default:
                break;
        }
    }

}
