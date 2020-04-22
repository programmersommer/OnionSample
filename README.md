# OnionSample
Simplified demo of ASP.NET Core solution made with Onion architecture
It is not completly working example of ToDo application

Infrastructure and UI are independent in Control Flow 
If you check diagram that describes Onion architecture, then there would be no reference to Infrastructure from UI
But there is a reference from UI to Infrastructure. It is needed only to add service into DI container

UI - acts like a primary Port

Application - acts like a primary and secondary Adapter at the same time

Infrastructure - acts like a secondary Port
