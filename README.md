# SERVICE ORIENTED ONION ARCHITECTURE SOLUTION

##Introduction
Main goal for this repository is to make a template as starting point for other projects that are intended to be developed with similar or identical architecture.

Projects between are loosely coupled, therefore the fine dependency graph.
![](https://github.com/sumarsky/ServiceOrientedOnionArchitectureSolution/blob/master/Dependencies.png)

Most independent project is the **[Entities]** project, the place where all entities take place. Whether data entities or DTO objects all should be stored here.

The **[Entities]** are used everywhere in the solution. **[Data]** and **[BL.Interfaces]** projects are only dependent on **[Entities]**, therefore they are at second level in the dependency graph.

**[Data]** project contains Entity Framework code first model. Repository pattern is implemented for database communication.

**[BL.Interfaces]** is the project where the interfaces for the business logic are stored.

Next level in the graph is reserved for **[BL]** project, which depends on **[Entities]**, **[Data]** and **[BL.Interfaces]** projects. In this project is the main business logic stored.

After the **[BL]** project is defined, the very next level in the dependency diagram is kept for **[DependencyResolution]**. In this project all the dependencies are resolved using the Ninject DI framework.

When all dependencies are resolver, next step is to create the end user project (in this solution it is console application). And last but not least, are defined the unit tests.

##Dependencies
- EntityFramework (database access)
- Ninject (dependency resolution)
- Moq (mock framework for testing in isolation)

##License
The MIT License (MIT)

Copyright (c) 2015 Igor Dimcevski
