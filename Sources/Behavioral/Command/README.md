# Command
**Behavioral pattern**

**Goal:** turns a request into a stand-alone object that contains all information about the request. This transformation
lets you pass requests as method arguments, delay or queue a request’s execution, and support undoable operations.


## Diagram
![diagram](commandDiagram.png)
1.  **Sender** class (aka invoker) is responsible for initiating requests. This class must have a field for storing a reference to a command object. The sender triggers that command instead of sending the request directly to the receiver. 
    - Sender isn’t responsible for creating the command object. Usually, it gets a pre-created command from the client via the constructor.
2. **Command** interface usually declares just a single method for executing the command.
3. **Concrete Commands** implement various kinds of requests. A concrete command isn’t supposed to perform the work on its own, but rather to pass the call to one of the business logic objects. However, for the sake of simplifying the code, these classes can be merged.
   - Parameters required to execute a method on a receiving object can be declared as fields in the concrete command. You can make command objects immutable by only allowing the initialization of these fields via the constructor.
4. **Receiver** class contains some business logic. Almost any object may act as a receiver. Most commands only handle the details of how a request is passed to the receiver, while the receiver itself does the actual work.
5. **Client** creates and configures concrete command objects. The client must pass all of the request parameters, including a receiver instance, into the command’s constructor. After that, the resulting command may be associated with one or multiple senders.


## Pros and Cons
**Pros:**
- **Single Responsibility Principle**. You can decouple classes that invoke operations from classes that perform these operations.
- **Open/Closed Principle**. You can introduce new commands into the app without breaking existing client code.
- You can implement undo/redo.
- You can implement deferred execution of operations.
- You can assemble a set of simple commands into a complex one.

**Cons:**
-  The code may become more complicated since you’re introducing a whole new layer between senders and receivers.

___
[Back to home page](../../../README.md)