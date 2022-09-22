namespace CSharp11;

public class FileScopedTypes
{
    public static string Method()
    {
        var p = new PrivateToTheFile(1, "Giovanni");
        return p.ToString();
    }

}

file record class PrivateToTheFile(int Id, string Name) : IPrivateInterface;

file interface IPrivateInterface { }

file delegate void PrivateDelegate();
