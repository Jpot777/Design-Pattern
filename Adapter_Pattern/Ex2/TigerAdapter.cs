// Dog 객체가 모자라서 Tiger 객체를 대신 사용해야 하는 상황
// 인터페이스가 다르기 때문에 Tiger객체를 바로 사용할 수는 없다..
public class TigerAdapter : IDog
{
    ITiger tiger = null;

    bool isAttack = false;

    public TigerAdapter(ITiger tiger)
    {
        this.tiger = tiger;
    }

    public void Bark(bool a)
    {
        tiger.Growl();
    }

    public void Run()
    {
        tiger.Run();
    }
}