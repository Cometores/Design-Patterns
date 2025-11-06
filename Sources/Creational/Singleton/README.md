# Singleton
**Creational pattern**

**Goal:** Ensure, that a class only has one instance, and provide a global point of access to it.

**How it's working**:
- Constructor should be private
- Static creation method that acts as a constructor. Method calls the private constructor to create an object and saves it in a static field.
- Whenever that method is called, the same object is always returned

**Real-life example:**
- **Logger** - One instance is preferred to avoid unintended consequences.
- **Lazy instantiation** - Create and store the instance when it's requested for the first time, and return that instance on subsequent requests

## Diagram
![singletonDiagram.png](singletonDiagram.png)

**Singleton** class declares the **static method** `getInstance` that returns the 
same instance of its own class.

Singleton’s **constructor** should be hidden from the client code. Calling the
`getInstance` method should be the only way of getting the Singleton object.

## Pros and Cons
**Pros**:
- You can be sure that a class has only a single instance.
- You gain a global access point to that instance.
- The singleton object is initialized only when it’s requested for the first time.

**Cons**:
- Violates the _Single Responsibility Principle_ (solves two problems at the time)
- The pattern requires special treatment in a multithreaded environment so that multiple threads won’t create a singleton object several times.
- It may be difficult to unit test the client code of the Singleton because many test frameworks rely on inheritance when producing mock objects. Since the constructor of the singleton class is private and overriding static methods is impossible in most languages, you will need to think of a creative way to mock the singleton.

## Custom logger Example:

___
[Back to home page](../../../README.md)