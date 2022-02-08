# C# Mastery

Repo to brush up on C# using the C# YouTube course by [Bro Code](https://www.youtube.com/watch?v=wxznTygnRfQ)

## Projects

This is a list of projects created to re-inforce learning C# concepts.

| Table of Contents                                                                                                                      |
| -------------------------------------------------------------------------------------------------------------------------------------- |
| Project 1 - [Hello Daphne](https://github.com/thisislink/csharpmastery#project-1---hello-daphne)                                       |
| Project 2 - [Greeter](https://github.com/thisislink/csharpmastery#project-2---greeter)                                                 |
| Project 3 - [Simple Birthday Countdown](https://github.com/thisislink/csharpmastery#project-3---simple-birthday-countdown)             |
| Project 4 - [Random Numbers](https://github.com/thisislink/csharpmastery#project-4---random-numbers)                                   |
| Project 5 - [Roll Dice](https://github.com/thisislink/csharpmastery#project-5---roll-dice)                                             |
| Project 6 - [List Movies](https://github.com/thisislink/csharpmastery#project-6---list-movies)                                         |
| Project 7 - [Friendly Robot Helper](https://github.com/thisislink/csharpmastery#project-7---friendly-robot-helper)                     |
| Project 8 - [List Movies Constructors](https://github.com/thisislink/csharpmastery#project-8---list-movies-constructors)               |
| Project 9 - [List Movies Inheritance](https://github.com/thisislink/csharpmastery#project-9---list-movies-inheritance)                 |
| Project 10 - [Shirt Polymorphism](https://github.com/thisislink/csharpmastery#project-10---shirt-polymorphism)                         |
| Project 11 - [Simple Streaming](https://github.com/thisislink/csharpmastery#project-11---simple-streaming)                             |
| Project 12 - [Simple Streaming Encapsulation](https://github.com/thisislink/csharpmastery#project-12---simple-streaming-encapsulation) |

## Running the Projects

1. Clone the [csharpmastery](https://github.com/thisislink/csharpmastery.git) repository
2. Open the project directory you would like to demo, then open the .sln file in Visual Studio. An example .sln file would be HelloDaphne.sln that is found in the HelloDaphne directory.
3. In Visual Studio, run the application by doing one of the following options:

   - Press the F5 key on your keyboard
   - Click the green play button on the toolbar next to the name of the project HelloDaphne

     ![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/RunningProjectsReadmeAssets/play-button.png?raw=true)

   - From the menu, click Debug > Start Debugging

     ![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/RunningProjectsReadmeAssets/start-debugging.png?raw=true)

4. The console window will launch and display output on the screen.

### Project 1 - Hello Daphne

This is a console app that displays "Hello Daphne!" to the screen.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/HelloDaphneReadmeAssets/console-window.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 2 - Greeter

This is a console app that takes user input and greets the user by saying Hello and whatever the name is they entered.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/GreeterReadmeAssets/greeter.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 3 - Simple Birthday Countdown

This is a console app that asks for a month and day and outputs a specific happy birthday message depending on the values entered. If the birthday is yet to pass, the app displays how many days until the user's birthday.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/SimpleBirthdayCountdownAssets/birthday-passed.png?raw=true)

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/SimpleBirthdayCountdownAssets/birthday-today.png?raw=true)

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/SimpleBirthdayCountdownAssets/future-birthday.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 4 - Random Numbers

This is a console app that generates a pseudo-random number between 1 and any number of the user's choosing.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/RandomNumbersAssets/random-numbers.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 5 - Roll Dice

This is a console app that asks if a user wants to roll a die. The app will randomly generate a number between 1 and 6, in order to simulate one die rolling. The app runs as long as the user wants to continue rolling the die.

From a technical side, this app makes use of the switch statement.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/RollDiceAssets/rolldice.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 6 - List Movies

This is a very simple console app that displays a list of movies on the screen.

From a technical perspective, this app makes use of arrays.

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 7 - Friendly Robot Helper

This is a console app that simulates a Robot introducing themselves and performing some helpful tasks.

From a technical perspective, this app makes use of classes, specifically a separate Robot class to introduce OOP.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/FriendlyRobotAssets/helper-robot-simple.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 8 - List Movies Constructors

In this console app, you are a movie distributor and a casting director.

So, you are tasked with coming up with a movie title, the year the movie will release and casting people to act in your movie.

<ins>Technical decisions</ins>

App makes use of a separate Movie class, a Movie constructor, and a list to store a list of cast members.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/ListMoviesConstructorsAssets/list-movies-constructors.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 9 - List Movies Inheritance

This console app is an expansion of project 8 and OOP concepts.

<ins>Technical decisions</ins>

App makes use of a separate abstract Movie class, subclasses that inherit the Movie class, a Movie constructor, and a list to store a list of cast members.

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/ListMoviesInheritanceAssets/list-movies-inheritance.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 10 - Shirt Polymorphism

This console app displays different types of shirts to the screen.

<ins>Technical decisions</ins>

App makes use of a separate Clothing class, shirt subclasses that inherit the Clothing class, a clothing color method that is overridden within the subclasses that wish to set different colors than the parent class they inherit from.

The class for the short sleeve polo did not have the color method implemented, in order to show how polymorphism is working on the other shirt subclasses.

#### Console Window Result

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/ShirtPolymorphismAssets/shirt-polymorphism-result.png?raw=true)

#### Polymorphism Implementation

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/ShirtPolymorphismAssets/shirt-polymorphism-code.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 11 - Simple Streaming

This console app displays different features of a streaming application such as play, pause, stop, rewind, fast forward, and subtitles.

<ins>Technical decisions</ins>

App introduces the concept of interfaces and combines previous OOP concepts demonstrated in previous projects.

App makes use of the following:

- Musicals class that implements the declared interfaces
- Two interface classes that declare methods to be implemented and used by the subclasses
- Different genres of musical subclasses that inherit the Musicals class and one or both of the interface classes

Only the drama musicals subclass implements the language interface methods, in order to show how usage of interfaces and OOP concepts are working together.

#### Console Window Result

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/SimpleStreamingAssets/simple-streaming-result.png?raw=true)

#### Interface Implementations

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/SimpleStreamingAssets/simple-streaming-code.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)

### Project 12 - Simple Streaming Encapsulation

This console app is an expansion of project 10 in order to include the concept of encapsulation.

<ins>Technical decisions</ins>

App introduces the concept of encapsulation through the use of getters and setters.

Only one getter and setter was implemented to introduce the idea.

The movie title was made private, as it should be not be publically accessible and should be immutable.

#### Encapsulation Implementation

![image](https://github.com/thisislink/csharpmastery/blob/main/Assets/SimpleStreamingEncapsulationAssets/simple-streaming-encapsulation-code.png?raw=true)

[Back to Top](https://github.com/thisislink/csharpmastery#projects)
