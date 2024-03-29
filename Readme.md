# Monopoly

[![Alt img description](https://ci.appveyor.com/api/projects/status/github/gabi22top/monopoly?svg=true)](https://ci.appveyor.com/project/gabi22top/monopoly)
[![Codacy Badge](https://api.codacy.com/project/badge/Grade/fe424edf098b4765b6fc1cbb72dd7cb4)](https://www.codacy.com/manual/gabi22top/Monopoly?utm_source=github.com&amp;utm_medium=referral&amp;utm_content=gabi22top/Monopoly&amp;utm_campaign=Badge_Grade)

## Presentation of project 
Monopoly is a board game played by two to eight players. It is played on a board with spaces. In the original version the spaces were named after streets. These streets are actual streets in Atlantic City in New Jersey in the United States. In the British original version, they are named after streets in London. Like many board games, each person has his own game token that he moves on the board. If he/she passes the go space, he/she collects $200. There is also a pair of dice, and play money. A person wins by having the most money at the end of the game.

This is an implementation of Monopoly game using WPF and using the maximun of code good practice :
Design Pattern + Uning Testing + C# Naming Conventions + Continuous Integration

## Project overview

Menu            |  Gameplay  |  Setting
:-------------------------:|:-------------------------:|:-------------------------:|
![test](https://drive.google.com/uc?export=view&id=17VpjOB9ku9tJ6lG6Nrc-U1aG3-8VlkqU) |  ![test](https://drive.google.com/uc?export=view&id=1zKlm35FhY3Yrv3a-4kUJNUyjdj5t1oX8) | ![](https://drive.google.com/uc?export=view&id=1F284N-MQkFerQ-PhZ8XdqEw2h8IUC5hS)|

The Game Board : 
The Monopoly game board is composed of 40 squares, that could be property, railroad, tax, jail ... The player could visit them during the game. The 40 squares won't change during the game and don't change between each game. So instead of writing these datas directly in the code we decided to serialize each square in a Json file and deserialize them when we need to create the Board.

Json : 

Here is an example of our Json file.
```Json
    "board": {
    "lands": [
      {
        "$type": "Monopoly_TD7.model.Lands.StartLand, Monopoly_TD7",
        "building": 0,
        "Type": 0,
		"SealableStrategy": {
          "$type": "Monopoly_TD7.model.Lands.StategyPattern.NotPurchasableStrategy, Monopoly_TD7"
        }
      },
      {
        "$type": "Monopoly_TD7.model.Lands.PropertyLand, Monopoly_TD7",
        "building": 0,
        "Price": 60.0,
		"SealableStrategy": {
          "$type": "Monopoly_TD7.model.Lands.StategyPattern.PurchasableStrategy, Monopoly_TD7",
          "LandOwner": null,
          "Price": 60.0
        },
        "Name": "Mediterranean Avenue",|
        "Multipledrent": [
          2,
          10,
          30,
          90,
          160,
          250
        ],
        "Color": "brown",
        "Type": 1,
      },
      {
        "$type": "Monopoly_TD7.model.CommunityChestLand, Monopoly_TD7",
        "building": 0,
        "Type": 4,
		 "SealableStrategy": {
          "$type": "Monopoly_TD7.model.Lands.StategyPattern.NotPurchasableStrategy, Monopoly_TD7"
        },
      },
 ```
## Design pattern 

### MVP
We design all our project around the MVP architecture using WPF.

**Model–view–presenter**  (**MVP**) is a derivation of the  model–view–controller "Model–view–controller")  (MVC)  architectural pattern, and is used mostly for building user interfaces.

![](https://drive.google.com/uc?export=view&id=1CrGQZyx52Z3r3Ao3FB5xgkmecrHr-kG_)

The **“model”** folder contains the needed logic and data for the game. The Model represents a set of classes that describes the business logic and data. It also defines business rules for data means how the data can be changed and manipulated.

It contains all the logic of our game : 
- Board.cs :  Contains the logic for how the game board works. (Array of 40 Lands)
- GameMaster.cs. : **Singleton** GameMasters class for all the logic, the progress of our game, each turn of our game ! 
- Folder **Land** contain each type of Land we have in our board 
- Player.cs. This file contains logics and data for the player. Money of players, name of players and so on...

The **“views”** folder contains the views of the game. View is a component which is directly interacts with user like XML, Activity, fragments. It does not contain any logic implemented.

The **“presenter”**  Acts upon the model and the view. It retrieves data from the model, and displays it in the view. The Presenter receives the input from users via View, then process the user’s data with the help of Model and passing the results back to the View. Presenter communicates with view through interface. Interface is defined in presenter class, to which it pass the required data.
It correspond to our .cs files of our .xaml files.

### Singleton
A singelton is a Creational design pattern , a singleton class should have some propeties :

1) it should have only one instance :  outter classes and subclasses cannot create an instace of the class and this is possible beacause of a private class constructor. 

2) instance should be globally accessible : it is done by making the access-specifier of instance public.

![enter image description here](https://lh3.googleusercontent.com/KBuKJQQDe8zn7TLUqM73E9tJlYt36Tg1dIb1Wxbvy5mXbZwxi26igzvGyOhPojAivmzHhQiqAyx7 "UML")

In our project, players use a unique monopoly **bord** game and this board should be accessible by all of the other classes, so the use of a singleton pattern is relevant.
```C#
    public sealed class Board
    {
        private static Board instance = null;
        private static readonly object padlock = new object();
        public Land[] lands { get; set; }
    
        private Board() => (lands) = (new Land[40]);
        
        public static Board Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Board();
                }
                return instance;
            }
        }
    }
```
We can observe that our Board construcor is private and our Board Instance method will ensure that a Board doesn't exist before creating a new board.

The GameMasters class also use a singleton design pattern.

### Strategy Pattern 
A strategy pattern is a Behavioral pattern, it define a family of algorithms, encapsulate each one, and make them interchangeable. Capture the abstraction in an interface, bury implementation details in derived classes.

![enter image description here](https://www.dofactory.com/images/diagrams/net/strategy.gif)

In our project we used a strategy pattern to manage the buy button functionality (that will call the Buy method). In fact we decided to take the game a step further by making possible for players to buy the lands that could be bought all around the board. (Add on of the inital TD Subject).

To do so,  we used the strategy pattern.

Here is the UML diagram of the strategy pattern adapted with some of our project classes: 
![
](https://lh3.googleusercontent.com/Qh8CuqOsnCPMToBnxotbB8TP3moona5x8KxeIBrEHkD4F_Jq_0W6p4P79Jy3caEK6wOQPXw-2GSx "UML")

For example a PropertyLand and a RailRoadLAnd could be bought so each class implement the behavior CanPurchasableStrategy in attribute  SealableStrategy, unlike the StartLand and a ChanceLand that couldn't be bought => they implemented the behavior NotPurchasableStrategy in their attribute "SealableStrategy".

We could in fact use just an Interface to do the same think. But we wanted to have an very reusability code and not duplicate code of function purchase in our code.

Since there is no default implementation of purchase behavior we may have code duplicity. You may have to rewrite the same purchase behavior over and over in many subclasses (RailRoalLand + PropertyLand). To avoid that we use the strategy pattern.

Here an exemple directly in the code source of the implementation: 
```C#
   abstract public class Land
    {
        public SealableStrategy SealableStrategy { get; set; }

        public LandType Type { get; set; }
        public int building;

        public enum LandType
        {
            Start,
            Property,
            GoToJail,
            VisitJail,
            CommunityChest,
            FreePark,
            Tax,
            RailRoad,
            Chance,
            Company

        }

        public override string ToString()
        {
            return Type.ToString();
        }
    }
}
```

```C#
public class PurchasableStrategy : SealableStrategy
    {
        public Player LandOwner { get; set; }
        public double Price { get; set; }

        public PurchasableStrategy(double price) =>(Price) = (price);
       
        public override bool Purchase(Player player)
        {
            bool result = false;

            if (LandOwner == null)
            {
                LandOwner = player;
                player.Money -= Price;
                result = true;
            }
            return result;
        }
    }
```

```C#
class PropertyLand : Land
    {
        public double Price { get; set; }
        public String Name { get; set; }
        public int [] Multipledrent { get; set; }
        public string Color { get; set; }
        public Player LandOwner { get ; set ; }

        public PropertyLand ()=> (Type,SealableStrategy) = (LandType.Property,new PurchasableStrategy(Price));

        public PropertyLand(double price, string name,int[] multipledrent, string color)
        {
            Type = LandType.Property;
            Price = price;
            Name = name;
            Multipledrent = multipledrent;
            Color = color;
            SealableStrategy = new PurchasableStrategy(Price);
        }

        public override string ToString()
        {
            return Name;
        }
    }![
]
```
## Conclusion

It was an interesting project, we tried to write the cleanest code possible using the design patterns. We didn't code the whole game because the interest was quite limited and we went around the technical side. I hope you will appreciate the cleanliness of the code and the effort to make the code as readable and reusable as possible. And of course the pretty graphical interface (makes quickly but prettier than the console 🙂).
