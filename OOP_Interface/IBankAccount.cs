namespace OOP_Interface
{
    public interface IBankAccount
    {
        void PayIn(decimal amount);
        bool withdraw(decimal amount);

        decimal Balance { get; }

    }
}
