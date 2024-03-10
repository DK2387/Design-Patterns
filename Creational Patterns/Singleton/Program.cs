// See https://aka.ms/new-console-template for more information
var greeting1 = Greeting.Instance;
var greeting2 = Greeting.Instance;

Console.WriteLine(object.ReferenceEquals(greeting1, greeting2));
