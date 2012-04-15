import java.util.HashMap;
import java.util.Map;

public class Helper {

    private static Map<Character, IRoleFactory> factoryMap = new HashMap<Character, IRoleFactory>();
    private static Map<Character, IRole> roleMap = new HashMap<Character, IRole>();

    static IRoleFactory getRoleFactory(char requestType) {
        return factoryMap.get(requestType);
    }

    static {
        factoryMap.put('U', new UserFactory());
        factoryMap.put('A', new AdminFactory());
        roleMap.put('U', new User());
        roleMap.put('A', new Admin());
    }

    public static void registerFactory(char key, IRoleFactory factory) {
        factoryMap.put(key, factory);
    }

    public static IRole getRole(char requestType) {
        return roleMap.get(requestType);
    }
}
