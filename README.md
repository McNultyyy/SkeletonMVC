#SkeletonMvc :skull:
A skeleton project for general MVC projects.

[Documentation](http://mcnultyyy.github.io/SkeletonMvc "SkeletonMvc Documentation")

[![Build status](https://ci.appveyor.com/api/projects/status/95cde753hdyvnkvu?svg=true)](https://ci.appveyor.com/project/william/skeletonmvc)

---

###Code First
Currently uses EF codefirst migrations.

###Dependency Injection
Uses Unity for dependency injection, should be relatively easy to change to Ninject, StructureMap etc...

###Documentation
Contains the SandCastle documentation project.

###Mapper
Contains Entity, ViewModel and AutoMapping mapping configs.

###DAL (Data Access Layer)
The DAOs, ViewModels and Repositories.

###Web
A standard MVC web project.

###Extension
A collection of extension methods used through the application.
  
  
---  
  
####QuickStart
```
Enable-Migrations -ContextProjectName DAL
```
