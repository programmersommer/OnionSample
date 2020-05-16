# OnionSample
Simplified demo of ASP.NET Core solution made with Onion architecture (draft of ToDo application).

Infrastructure and UI are independent in Control Flow   
If you check diagram that describes Onion architecture, then there would be no reference to Infrastructure from UI, but there is a reference from UI to Infrastructure in this solution. It is needed only to add Infrastructure services into DI container. Projects are still independent in flow.  

UI - acts like a primary Adapter   
   
Application - contains logic and acts like a Port for primary and secondary Adapters at the same time

Core - contains entities and enterprise-wide logic/services
   
Infrastructure - acts like a secondary Adapter

Disadvantage of this approach - in theory you should use Infrastructure services only from Application. But there is no way to make a restriction because we have all services in same DI container.  
In branch called "UsingMediatR" you can find option to bind Infrastructure with Application using MediatR library. 
