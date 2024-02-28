# Design Patterns

Software design patterns are reusable solutions to common problems encountered in software design. They provide a template or blueprint for how to solve a problem in a particular context. Design patterns help software developers communicate more effectively, make designs more maintainable and scalable, and improve code quality.

There are three main categories of design patterns:

- Creational Patterns: These patterns deal with object creation mechanisms, trying to create objects in a manner suitable to the situation.

  - [ ] Singleton Pattern: Ensures a class has only one instance and provides a global point of access to it.
  - [ ] Factory Method Pattern: Defines an interface for creating an object, but lets subclasses decide which class to instantiate.
  - [ ] Abstract Factory Pattern: Provides an interface for creating families of related or dependent objects without specifying their concrete classes.
  - [ ] Builder Pattern: Separates the construction of a complex object from its representation, allowing the same construction process to create various representations.
  - [ ] Prototype Pattern: Allows an object to create customized clones of itself, without coupling to their specific classes.

- Structural Patterns: These patterns deal with object composition, simplifying the structure by identifying the relationships between entities.

  - [ ] Adapter Pattern: Allows objects with incompatible interfaces to collaborate.
  - [ ] Bridge Pattern: Decouples an abstraction from its implementation so that the two can vary independently.
  - [ ] Composite Pattern: Composes objects into tree structures to represent part-whole hierarchies.
  - [ ] Decorator Pattern: Dynamically adds responsibilities to objects without subclassing.
  - [ ] Facade Pattern: Provides a unified interface to a set of interfaces in a subsystem.
  - [ ] Flyweight Pattern: Shares objects to allow for a large number of fine-grained objects to be used efficiently.
  - [ ] Proxy Pattern: Provides a placeholder for another object to control access, reduce cost, or defer instantiation.
        
- Behavioral Patterns: These patterns deal with object collaboration and responsibility. They describe not just patterns of objects or classes but also the patterns of communication between them.
  - [x] [Chain of Responsibility Pattern](DesignPaterns.Console/Patterns/Behavioral/ChainOfResponsibility/ChainOfResponsibilityPattern.cs): This pattern allows an object to pass a request along a chain of handlers. Each handler decides either to process the request or to pass it along the chain.
  - [x] [Command Pattern](DesignPaterns.Console/Patterns/Behavioral/Command/CommandPattern.cs): This pattern encapsulates a request as an object, thereby allowing parameterization of clients with different requests, queuing of requests, and logging of requests.  
  - [x] [Interpreter Pattern](DesignPaterns.Console/Patterns/Behavioral/Interpreter/InterpreterPattern.cs): This pattern is used to define a grammar for interpreting a language and to provide an interpreter to parse sentences in the language. 
  - [x] [Iterator Pattern](DesignPaterns.Console/Patterns/Behavioral/Iterator/IteratorPattern.cs): This pattern provides a way to access the elements of an aggregate object sequentially without exposing its underlying representation.  
  - [ ] Mediator Pattern: This pattern defines an object that encapsulates how objects interact with each other, thus decoupling them and allowing for independent changes.  
  - [ ] Memento Pattern: This pattern provides the ability to restore an object to its previous state (undo functionality) or to store and retrieve its state.  
  - [ ] Observer Pattern: This pattern defines a one-to-many dependency between objects so that when one object changes state, all its dependents are notified and updated automatically.  
  - [ ] State Pattern: This pattern allows an object to change its behavior when its internal state changes. The object will appear to change its class.  
  - [ ] Strategy Pattern: This pattern defines a family of algorithms, encapsulates each one, and makes them interchangeable. Strategy lets the algorithm vary independently from the clients that use it.  
  - [ ] Template Method Pattern: This pattern defines the skeleton of an algorithm in the superclass but lets subclasses override specific steps of the algorithm without changing its structure.  
  - [ ] Visitor Pattern: This pattern defines a new operation to a collection of objects without changing the objects themselves. It allows adding new behaviors to existing classes without modifying those classes.

Each design pattern has its use case and context where it is most suitable. It's important to understand the problem you're trying to solve before applying a design pattern, as using them unnecessarily can lead to overly complex code.
