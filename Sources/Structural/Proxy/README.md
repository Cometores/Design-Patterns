# Proxy
**Structural pattern**

**Goal:** Allows to **perform** something either **before** or **after** the request gets through to the original object.

## Diagram
![proxyDiagram.png](proxyDiagram.png)
1. **Service Interface** declares the interface of the Service. The proxy must follow this interface to be able to disguise itself as a service object.
2. **Service** is a class that provides some useful business logic.
3.  **Proxy** class has a reference field that points to a service object. After the proxy finishes its processing (e.g., lazy initialization, logging, access control, caching, etc.), it passes the request to the service object.
    - Usually, proxies manage the full lifecycle of their service objects.
4. **Client** should work with both services and proxies via the same interface. This way you can pass a proxy into any code that expects a service object.

## Pros and Cons
**Pros:**
- You can control the service object without clients knowing about it.
- You can manage the lifecycle of the service object when clients don’t care about it.
- The proxy works even if the service object isn’t ready or is not available.
- **Open/Closed Principle**. You can introduce new proxies without changing the service or clients.

**Cons:**
- The code may become more complicated since you need to introduce a lot of new classes.
- The response from the service might get delayed.

# Examples
## Virtual proxy example
Instead of creating object, you can delay the object's initialization to a time when it’s really needed.

___
[Back to home page](../../../README.md)