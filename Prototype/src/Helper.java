import java.util.HashMap;
import java.util.Map;
public  class Helper {

    private static Map<Character, IRoleFactory> factoryMap = new HashMap<Character, IRoleFactory>();

    static IRoleFactory getRoleFactory(char requestType) {
        return factoryMap.get(requestType);
    }

    static {
        factoryMap.put('U', new UserFactory());
        factoryMap.put('A', new AdminFactory());
    }

    public  static void registerFactory(char key, IRoleFactory factory) {
        factoryMap.put(key, factory);
    }
}
