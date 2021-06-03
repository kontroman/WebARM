public interface ICommand
{
    public void Apply(State _state);

    //Базовые нужные команды: +add, +cmp, mul, +mov, orr, sub
}
