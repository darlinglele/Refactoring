public class program {
    public static void main(String[] args) {
        char requestType;
        requestType = 'A';
        switch (requestType) {
            case 'A':
                doAsAdmin();
                break;
            case 'U':
                doAsUser();
                break;
            default:
                break;
        }
    }

    private static void doAsUser() {
        System.out.println("I am User");
    }

    private static void doAsAdmin() {
        System.out.println("I am Admin");
    }

}
