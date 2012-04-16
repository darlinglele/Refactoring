public class UserFactory implements IRoleFactory{
     public IRole create() {
        return new User();
    }
}
