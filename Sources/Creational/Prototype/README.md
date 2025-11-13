# Prototype
**Creational pattern**

Use this pattern when you want to create a copy of an existing object without making your code dependent on its class.

**How it's working:** Cloning process is delegated to the actual objects that are being cloned.
- An object that supports cloning is called a *prototype*.
- Interface with `clone` method.
  - Implementation of the `clone` method is very similar in all classes
- When you need an object like the one you’ve configured, you clone a prototype instead of constructing a new object from scratch.

## Diagram
![diagram](diagram.png)
- **Prototype** interface declares the cloning methods. In most cases, it's a single `clone` method.
- **Concrete Prototype** implements the cloning method. 
  - In addition to copying the original object's data to the clone, this method may also handle some edge cases of the cloning process related to cloning linked objects, untangling recursive dependencies, etc.
- **Client** can produce a copy of any object that follows the prototype interface.

## Pros and Cons
**Pros:**
- You can clone objects without coupling to their concrete classes.
- You can get rid of repeated initialization code in favor of cloning pre-built prototypes.
- You can produce complex objects more conveniently.
- You get an alternative to inheritance when dealing with configuration presets for complex objects.

**Cons:**
- Cloning complex objects that have circular references might be very tricky.

---

## C# cloning specifics
### Different types of Copies
**Shallow copy**:
- Copy primitive type values
- Complex type values will be shared across clones
- Can be achieved via `MemberwiseClone` method

**Deep copy**:
- Copy of primitive type values and complex type values
- Can be achieved via `BinaryFormatter` **OBSOLETE**:
```csharp
class ClassToClone
{
    public override ClassToClone Clone()
    {  
        var formatter = new BinaryFormatter();
        using (var stream = new MemoryStream())
        {            
            formatter.Serialize(stream, this);
            stream.Seek(0, SeekOrigin.Begin);
            return (ClassToClone)formatter.Deserialize(stream);
        }
    }
}
```
- Or can be achieved via `JsonSerializer` **RECOMMENDED**
```csharp
class ClassToClone
{
    public override ClassToClone Clone()  
    {
        var objectAsJson = JsonSerializer.Serialize(this);
        return JsonSerializer.Deserialize<ClassToClone>(objectAsJson);
    }
}
```

### ICloneable
- it enables us to provide a customized implementation that creates a copy of an existing object

**Disadvantages**:
- Does not specify whether the cloning operation performs a deep copy, a shallow copy, or something in between.
- It doesn't require all property values of the original instance to be copied to the new instance
- Returns an `object`, which means the client could need an additional cast

___
[Back to home page](../../../README.md)