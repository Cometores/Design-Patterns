# Facade
**Structural pattern**

**Goal:** Providing a simplified interface to a library, a framework, or any other complex set of classes.

## Diagram
![diagram](facadeDiagram.png)
1. **Facade** provides convenient access to a particular part of the subsystem’s functionality. It knows where to direct the client’s request and how to operate all the moving parts.
2. **Additional Facade** class can be created to prevent polluting a single facade with unrelated features that might make it yet another complex structure. Additional facades can be used by both clients and other facades.
3. **Complex Subsystem** consists of dozens of various objects. To make them all do something meaningful, you have to dive deep into the subsystem’s implementation details, such as initializing objects in the correct order and supplying them with data in the proper format.
    - Subsystem classes aren’t aware of the facade’s existence. They operate within the system and work with each other directly.
4. **Client** uses the facade instead of calling the subsystem objects directly.

## Pros and Cons
**Pros:**
- You can isolate your code from the complexity of a subsystem.

**Cons:**
- A facade can become a **god object** coupled to all classes of an app.

___
[Back to home page](../../../README.md)