# Monopoly

[![Alt img description](https://ci.appveyor.com/api/projects/status/github/gabi22top/monopoly?svg=true)](https://ci.appveyor.com/project/gabi22top/monopoly)

# Presentation of project 
Monopoly is a board game played by two to eight players. It is played on a board with spaces. In the original version the spaces were named after streets. These streets are actual streets in Atlantic City in New Jersey in the United States. In the British original version, they are named after streets in London. Like many board games, each person has his own game token that he moves on the board. If he/she passes the go space, he/she collects $200. There is also a pair of dice, and play money. A person wins by having the most money at the end of the game.

This is an implementation of Monopoly game using WPF and using the maximun of code good practice :
Design Pattern + Uning Testing + C# Naming Conventions + Continuous Integration

# Project overview


Menu            |  Setting
:-------------------------:|:-------------------------:
![test](https://drive.google.com/uc?export=view&id=17VpjOB9ku9tJ6lG6Nrc-U1aG3-8VlkqU) |![](https://drive.google.com/uc?export=view&id=1F284N-MQkFerQ-PhZ8XdqEw2h8IUC5hS)

# Design pattern 

We design all our project around the MVP architecture using WPF.

![](https://drive.google.com/uc?export=view&id=1CrGQZyx52Z3r3Ao3FB5xgkmecrHr-kG_)

The **“model”** folder contains the needed logic and data for the game.

It contains the the logic of our game : 
- Board.cs :  Contains the logic for how the game board works.
- GameMaster.cs. : **Singleton** GameMasters class for all the logic, the progress of our game, each turn of our game ! 
- Land.cs. Folder **Land** contain 
- Player.cs. This file contains logics and data for the player. Money of players, name of players and so on...

The **“views”** folder contains the views of the game
