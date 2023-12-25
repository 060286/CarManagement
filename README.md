# Car management used for learning CQRS & Mediator.

### Key Concepts of CQRS:

### CQRS, which stands for Command Query Responsibility Segregation, is a design pattern used to separate the responsibility for handling read (query) and write (command) operations in an application

1. Commands: These represent operations that change the application’s state, such as creating, updating, or deleting data. Commands are used to request changes to the data.
2. Queries: Queries are responsible for retrieving data without modifying it. They are used for reading and reporting purposes.
3. Command Handlers: These components handle incoming commands, process them, and update the application’s state accordingly.
4. Query Handlers: Query handlers retrieve data based on queries and return it to the client.

### Key Features of MediatR:

### MediatR is a library for implementing the mediator pattern in C#

1. Decoupling: MediatR helps decouple the sender of a request (command or query) from its receiver (handler), allowing for more maintainable and modular code.
2. Pipeline Behaviors: It supports the use of pipeline behaviors, enabling you to add cross-cutting concerns like validation, logging, and authentication easily.
3. Automatic Handler Discovery: MediatR can automatically discover and register handlers, reducing the need for explicit configuration.

## References

- https://shorturl.at/lNPR4
