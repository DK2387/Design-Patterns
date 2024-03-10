// See https://aka.ms/new-console-template for more information
internal sealed class Greeting
{
    private Greeting()
    {
    }

    public static Greeting Instance = new Greeting();
}