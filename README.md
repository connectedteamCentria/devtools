# Devtools
*This is a Final Gropu-task from [ConnectedteamCentria/Devtools.](https://github.com/connectedteamCentria/devtools)*

***Devtools*** is the Final project in our course Software Development tools. The perpuse of the exercise to understand the software archiecture to real life building acrchiecture and understand the blueprint as well.  

This project was completed by 4 students how were working under [ConnectedteamCentria/Devtools](https://github.com/connectedteamCentria/devtools) as a group member. At the same time we keep tracking Trello which helped us to follow the right track. For the Kanban it is easy to understand the individual task and fix our goal.  

For more details about the program's functionality please check out our [Trello board](https://trello.com/b/GdmwY8LR/connectedteam).


# The purpose of the excercise

The purpose of the excercise is to practise agile methologies while creating and presenting a system of animals.

The animals are divided into Wild and Tame and have two activities: MakeSound and Eat.

The tame animals also TalkToOwner and ComeHere. Wild anomals Hunt.

Tame Animals: **Cat**, **Dog**, **Bird** Wild animals: **Bear**, **Wolf**, **Tiger** Exceptional Wild Animal Elefant does not Hunt.


# WILD
![Tiger](https://github.com/connectedteamCentria/devtools/blob/master/Pets/assets/tiger.png)

Wild animals are *tiger*, *wolf* and *bear*.

- Make Sound
- Hunt (if an animals hunt succeeds the animal gains 1kg of weight.)


# TAME
![Bird](https://github.com/connectedteamCentria/devtools/blob/master/Pets/assets/bird.png)

Tame animals are *bird*, *cat*, *dog* 

- Talk to owner
- Make Sound
- Come to the Owner
- Eat (an animals hians 1kg in weight when eating.)


# Class Diagram

There is a Class diagram inside the assets. The Fauna2-project has an abstract class called Animals with the methods MakeSound() and Eat() and weight property. There are two interfaces, one for the ITame and the other for IWild animals. The classes inheriting ITame are Bird, Cat, Dog. ITame contains public methods TalkToOwner():string, ComeHere():string and GiveName():string and also a name property. The interface IWild has the method Hunt():string and is inherited by Tiger, Wolf and Bear -classes. There is also a user interface UI with the method Start() that is associated with both the IWild and ITame interfaces and also the abstract Animal class.

![Class Diagram](https://github.com/connectedteamCentria/devtools/blob/master/Pets/assets/Fauna2%20(1).png)

# Sequence Diagrams
![Tame Animal Cat](https://raw.githubusercontent.com/connectedteamCentria/devtools/master/Pets/assets/Animals1_Cat.png)

![Wild Animal Bear](https://raw.githubusercontent.com/connectedteamCentria/devtools/master/Pets/assets/Animals2_Bear.jpg)


Here is **Folder Structure**

```ruby

├── README.md
├── assets
│     ├── class_diagram_with_connections.png
│     └── sequence_diagram.png
├── src
│    └── Fauna
│	        ├── Animals
│           │       ├── Animal.cs
│           │       ├── UI.cs
│           │       ├── Tame
│           │       │    ├── ITame.cs
│           │       │    ├── Cat.cs
│           │       │    ├── Bird.cs
│           │       │    ├── Dog.cs
│           │       │    
│           │       │    
│           │       │
│           │       └── Wild
│           │            ├── IWild.cs
│           │		     ├── Wolf.cs
│           │		     ├── Bear.cs
│           │		     └── Tiger.cs
│           │
│           ├── FaunaProject.csproj
│           └── Program.cs
└── test
    └── FaunaTests
          ├── FaunaTest.cs
          └── FaunaTest.csproj
```



