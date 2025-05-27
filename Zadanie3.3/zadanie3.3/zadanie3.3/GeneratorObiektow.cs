namespace zadanie3._3;

public class GeneratorObiektow<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}
