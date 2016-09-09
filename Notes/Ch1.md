Problem 1.2

* Inherit class IComparable<T> to redefine the buildin Sort() method of a List<T>
* Inherit class IComparer<T> and pass this object as a parameter to the Sort() method of a List<T>


```csharp
public class Square : IComparable<Square>
{
    public int CompareTo(object obj)
    {
        Square square = obj as Square;
        if (square != null)
            return CompareTo(square);
        throw new ArgumentException("Both objects being compared must be of type Square");
    }
    //...
}
listOfSquares.Sort();   // use CompareTo method, if pass no parameters
```

```csharp
IComparer<Square> heightCompare = new CompareHeight();
listOfSquares.Sort(heightCompare);  // heightCompare inherited from IComparer class and implement compare differently
```



