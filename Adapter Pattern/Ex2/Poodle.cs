using System;

public class Poodle : IDog
{
    public void Bark()
    {
        Debug.Log("푸들 : 왈왈!");
    }

    public void Run()
    {
        Debug.Log("푸들 : 뛰기");
    }
}