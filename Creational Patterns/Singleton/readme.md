# Singleton Design Pattern

The Singleton design pattern is a creational design pattern that ensures a class has only one instances and provide a global point of access to that instance. This pattern is used when exactly one object is needed to co-ordinate actions across the system.

Below is an example of Singleton class.

```csharp
    internal sealed class Greeting
    {
        private Greeting()
        {
        }
    
        public static Greeting Instance = new Greeting();
    }
```

## Characteristics of Singleton Design Pattern

### Private Constructor

The class has a private constructor to prevent instantiation from other classes.

```csharp
private Greeting()
{
}
```

### Prevent Nested Public Child Class

The class should not have a nested public child class. If the class has a nested public child class then the private constructor of base class can be invoked through nested child class constructor. This can be prevented using the `sealed` keyword.

```csharp
internal sealed class Greeting
```

### Thread Safe - Lazy Initialization

The instance is created only when it is needed. The instance should be thread-safe and at no given point multiple instance should be created when the call is made in concurrent threads.

Below is A modern way to implement Singleton, providing lazy initialization and thread safety without using explicit synchronization (locks):

```csharp
internal sealed class Greeting
{
    private Greeting()
    {
    }

    public static Greeting Instance = new Greeting();
}
```

## Usecases

1) **Logging:** Single point of logging across the application.
2) **Configuration Management:** To maintain centralized configuration settings.

## Advantages

1) **Global Point of Access:** Provides a single, globally accessible instance.
2) **Lazy Initialization:** Efficient resource utilization by creating the instance only when it is needed.
3) **Thread Safety:** Ensures a single instance in a multi-threaded environment.

## Disadvantages

1) **Global State:** May introduce a global state that persists throughout the application.
2) **Unit testing Difficulty:** Challenging to write unit tests due to the global state.

## Conclusion

Singleton design pattern should be used judiciously, considering the specific requirements of the application and drawbacks associated with the global state.

[Back](../readme.md)
