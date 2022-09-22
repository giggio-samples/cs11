namespace CSharp11;

public class StringLiterals
{
    public static string M()
    {
        var version = DateTime.Now.Day.ToString();
        var text = $$"""
            {
              "sdk": {
                "version": "{{version}}.0.{{DateTime.Now.Second}}",
                "allowPrerelease": true
              }
            }
            """;
        return text;
    }

}
