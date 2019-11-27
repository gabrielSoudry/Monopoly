
# Monopoly

[![Alt img description](https://ci.appveyor.com/api/projects/status/github/gabi22top/monopoly?svg=true)](https://ci.appveyor.com/project/gabi22top/monopoly)

# Presentation of project 
Monopoly is a board game played by two to eight players. It is played on a board with spaces. In the original version the spaces were named after streets. These streets are actual streets in Atlantic City in New Jersey in the United States. In the British original version, they are named after streets in London. Like many board games, each person has his own game token that he moves on the board. If he/she passes the go space, he/she collects $200. There is also a pair of dice, and play money. A person wins by having the most money at the end of the game.

This is an implementation of Monopoly game using WPF and using the maximun of code good practice :
Design Pattern + Uning Testing + C# Naming Conventions + Continuous Integration

# Project overview


Menu            |  Gameplay  |  Setting
:-------------------------:|:-------------------------:|:-------------------------:
![test](https://drive.google.com/uc?export=view&id=17VpjOB9ku9tJ6lG6Nrc-U1aG3-8VlkqU) |  ![test](https://drive.google.com/uc?export=view&id=1zKlm35FhY3Yrv3a-4kUJNUyjdj5t1oX8) | ![](https://drive.google.com/uc?export=view&id=1F284N-MQkFerQ-PhZ8XdqEw2h8IUC5hS)


# Design pattern 

We design all our project around the MVP architecture using WPF.

![](https://drive.google.com/uc?export=view&id=1CrGQZyx52Z3r3Ao3FB5xgkmecrHr-kG_)

The **“model”** folder contains the needed logic and data for the game.

It contains all the logic of our game : 
- Board.cs :  Contains the logic for how the game board works. (Array of 40 Lands)
- GameMaster.cs. : **Singleton** GameMasters class for all the logic, the progress of our game, each turn of our game ! 
- Folder **Land** contain each type of Land we have in our board 
- Player.cs. This file contains logics and data for the player. Money of players, name of players and so on...

The **“views”** folder contains the views of the game.



The **“presenter”**  Acts upon the model and the view. It retrieves data from the model, and displays it in the view.



*Singleton :* 
A singelton is a Creational design pattern , a singleton class should have some propeties :

1) it should have only one instance :  outter classes and subclasses cannot create an instace of the class and this is possible beacause of a private class constructor. 

2) instance should be globally accessible : it is done by making the access-specifier of instance public.

![enter image description here](https://upload.wikimedia.org/wikipedia/commons/thumb/f/fb/Singleton_UML_class_diagram.svg/330px-Singleton_UML_class_diagram.svg.png)

In our project, players use a unique monopoly bord game and this board should be accessible by all of the other classes, so the use of a singleton pattern is relevant.

![enter image description here](https://lh3.googleusercontent.com/c6Hy-uINUtyG0GhR-tXc_XcrVnWo7wjliUOJIOyWwGpVoSkCQExhoAnPWWCdPIlW6YVAvXc6oGe7 "Board Class")

We can observe that our Board construcor is private and our Board Instance method will ensure that a Board doesn't exist before creating a new board.

*Strategy Pattern :*
A strategy pattern is a Behavioral pattern, it define a family of algorithms, encapsulate each one, and make them interchangeable. Capture the abstraction in an interface, bury implementation details in derived classes.


![enter image description here](https://www.dofactory.com/images/diagrams/net/strategy.gif)

In our project we used a strategy pattern to manage the buy button functionality (that will call the Purchase method). In fact we decided to take the game a step further by making possible for players to buy the lands that could be bought all around the board.  

![enter image description here](https://lh3.googleusercontent.com/kFUXSzvuzS0bmOhzVvTsYzWwy-ieOm5VSeZ65CS-x3dssQW43cvKzXUwOczD1EKt2JJacPN8BGio "Buy")
To do so,  we used the 'is' operator that checks if the result of an expression is compatible with a given type and, if it can be, casts it to a variable of that type. 
In our example the 'is' operator will ensure that the land which the player is trying to buy have the ISaleable interface.  Then if it has the interface it will create a local variable 'land' and apply the ISaleable Purchase metho to it.

Our Strategy is the ISaleable interface, that has 2 methods.
![enter image description here](https://lh3.googleusercontent.com/UxWi7AzYpMbMTXcOObwTSXh6lAOaK3czF891glPIlqDwFkOIZiV9pA-OrEDyzUxUk_a1ctgnMeks "Isalable")


The lands that could be bought will use the ISaleable interface and implement its methods. Here is an example of the purchase method implemented in the PropertyLand class (Concrete Strategy). If the land has no owner it could be bought, otherwise it cannot. 

![enter image description here](https://lh3.googleusercontent.com/ft07Kb6GmKcKTq23gtf90miX9ZWLqwRc0JJ93UyVXapxfb1BgZ8EzZ1tVOPpj4dHHlCeqE28bS4Z "Purchase")


# Game Preview



![enter image description here](https://lh3.googleusercontent.com/2_-ox72FpgEtc3ZyRmwBWyPgKumu2SJF6rZcqEyogSQdti-DyY-20o1y4Uvp97YpSbh6zUcZMX3n "JSON")

    enter code heref dfsgfg
    sfsfsg
    fsgg

![enter image description here](https://lh3.googleusercontent.com/kAZ5l0P4xwjR1HaIlszJECslpPGZ2rkKuCr59ltETbZ84RyA8NMhteBtkxGYw2qyHOLCjmS84gvI "Game")
