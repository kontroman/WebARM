public interface ICommand
{
    public void Apply(State _state);

    //������� ������ �������: +add, +cmp, mul, +mov, orr, sub
}
