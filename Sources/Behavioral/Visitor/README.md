# Visitor
**Behavioral pattern**

**Goal:** Lets you separate algorithms from the objects on which they operate.

## Diagram
![diagram](visitorDiagram.png)
1. **Visitor** interface declares a set of visiting methods that can take concrete elements of an object structure as arguments. These methods may have the same names if the program is written in a language that supports overloading, but the type of their parameters must be different.
2. **Concrete Visitor** implements several versions of the same behaviors, tailored for different concrete element classes.
3. **Element** interface declares a method for “accepting” visitors. This method should have one parameter declared with the type of the visitor interface.
4. Each **Concrete Element** must implement the acceptance method. The purpose of this method is to redirect the call to the proper visitor’s method corresponding to the current element class. Be aware that even if a base element class implements this method, all subclasses must still override this method in their own classes and call the appropriate method on the visitor object.
5. **Client** usually represents a collection or some other complex object (for example, a Composite tree). Usually, clients aren’t aware of all the concrete element classes because they work with objects from that collection via some abstract interface.

## Pros and Cons
**Pros:**
- **Open/Closed Principle**. You can introduce a new behavior that can work with objects of different classes without changing these classes.
- **Single Responsibility Principle**. You can move multiple versions of the same behavior into the same class.
- A visitor object can accumulate some useful information while working with various objects. This might be handy when you want to traverse some complex object structure, such as an object tree, and apply the visitor to each object of this structure.

**Cons:**
- You need to update all visitors each time a class gets added to or removed from the element hierarchy.
- Visitors might lack the necessary access to the private fields and methods of the elements that they’re supposed to work with.

___
[Back to home page](../../../README.md)