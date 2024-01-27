# Abstract factory
**Creational pattern**

Use this pattern, when your code needs to work with various families 
of related products and you want future extensibility.

## Diagram
![abstractFactoryDiagram.png](abstractFactoryDiagram.png)

1. **Abstract Products** declare interfaces for a set of distinct but related products which make up a product family.

2. **Concrete Products** are various implementations of abstract products, grouped by variants. Each abstract product must be implemented in all given variants.

3. The **Abstract Factory** interface declares a set of methods for creating each of the abstract products.

4. **Concrete Factories** implement creation methods of the abstract factory. Each concrete factory corresponds to a specific variant of products and creates only those product variants.

5. Although concrete factories instantiate concrete products, signatures of their creation methods must return corresponding _abstract_ products. This way the client code that uses a factory doesn’t get coupled to the specific variant of the product it gets from a factory. The **Client** can work with any concrete factory/product variant, as long as it communicates with their objects via abstract interfaces.

## Pros and Cons
**Pros**:
-  You can be sure that the products you’re getting from a factory are compatible with each other.
-  **Avoid tight coupling** between concrete products and client code.
-  **Single Responsibility Principle**: You can extract the product creation code into one place, making the code easier to support.
-  **Open/Closed Principle**: You can introduce new variants of products without breaking existing client code.

**Cons**:
- Code may become more complicated
