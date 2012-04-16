public class AdminFactory  implements IRoleFactory{
     public IRole create() {
        return new Admin();
    }
}
