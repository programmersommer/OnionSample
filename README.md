# OnionSample
Simplified demo of ASP.NET Core solution made with Onion architecture  
It is not completly working example of ToDo application

Infrastructure and UI are independent in Control Flow   
If you check diagram that describes Onion architecture, then there would be no reference to Infrastructure from UI   
But there is a reference from UI to Infrastructure. It is needed only to add service into DI container  

UI - acts like a primary Adapter   
   
Application - contains logic and acts like a Port for primary and secondary Adapters at the same time

Core - contains entities and enterprise-wide logic/services
   
Infrastructure - acts like a secondary Adapter
