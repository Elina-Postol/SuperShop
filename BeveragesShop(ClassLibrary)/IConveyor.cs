namespace BeveragesShop_ClassLibrary_ {
    public interface IConveyor<T> {
        void Push(T value);
        T Pull();
        bool IsEmpty { get; }
       
    }
}
