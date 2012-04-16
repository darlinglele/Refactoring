public interface IRole extends Cloneable{
    void handle();
    IRole clone();
    void writeLog();
    void print();
}
