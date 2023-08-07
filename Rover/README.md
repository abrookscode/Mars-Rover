# Mars Rover App

This is built as a C# Console app.
 
User input is split into 3 main steps. Steps 2 and 3 loop endlessly to allow the user to continue creating rovers for the Planet. 

The application can be exited at any step by submitting "exit" as the input.

Validation is applied to the user input. Loops are used to keep a user at the current step in cases of invalid input.

1. Enter bounds of planet.
2. Enter initial Rover location.
3. Enter instructions for Rover movement.

If the Rover attempts to move beyond the Planet bounds it will remain in its current position.

The Rover reports its final location output in green text.

## Example
In this example we are creating a Planet with the bounds of `5 5`, and landing 2 rovers. The first rover lands at `1 2 N` and the second lands at `3 3 E`.

The initial planet bounds entry is applied to the planet for use with collision detection, preventing the rover from moving outside of the area.

Each left `L` turn is converted to `-90` degrees and each right turn `R`
is converted to `90` degrees.

Each movement `M` is translated to an increment/decrement of the current X Y position based on its current cardinal heading. For example, if moving while facing W it will decrement position X, if facing N it will increment Y.

```
Define the Bounds for the planet [X Y]:
5 5
Define starting position of the Rover [X Y Z]:
1 2 N
Enter instructions: [LRM]:
LMLMLMLMM

The rover is now located at:
1 3 N

Define starting position of the Rover [X Y Z]:
3 3 E
Enter instructions: [LRM]:
MMRMMRMRRM

The rover is now located at:
5 1 E
```

## Main Files
`Bootstrapper` 
> The app entry point.

`Planet` 
> Holds information about the bounds of the area. All created Rovers share the same Planet that is initially created. Implements `ICollidable`. The bounds are used to prevent the rover location from exceeding its bounds when moving.

`MarsRover` 
> Handles the main Rover capabilities, movement and reporting its current location status. This class inherits from `Vehicle.cs` for its core behavior. Loops over instructions calling the respective command (Move/Rotate).

## Supporting Files

The logic to run the Mars Rover is broken out into multiple interfaces and abstract classes to allow for ease of maintenance and unit testing.

`Vehicle` 
> This is the base class that `MarsRover` uses. It inherits from `RemoteController` and implements `IMoveable` and `IRotateable`.

`RemoteController` 
> This handles the X Y positioning of its child classes. In this case it is responsible for X Y positioning of our `MarsRover.cs`. It inherits `Rotator.cs` and implements `IMoveable.cs`.

`Rotator`
> This handles setting the cardinal direction of its child classes (N,S,E,W). To do this it inherits from `Compass` and implements ` IRotateable` .

`Compass`
> Handles performing cardinal direction calculations. Providing its method `Calculate` with an argument of degrees of rotation it sets the new cardinal direction based off of its initial value.
> It also supports rotational values beyond 360 degrees. Example: Starting at a `N` heading and rotating 900 degrees will be calculated to a final heading of `S` (180 degrees).

`Parser`
> Handles displaying informational prompts to the user, splitting user input into arguments, and validating that input.

`Reader`
> Simple wrapper for `Console.ReadLine()` in order to provide extra functionality. Could be useful for unit testing if we want to mock its behavior.

`LoopController`
> Provides a global method of gracefully exiting existing loops and the application by submitting the input "exit" into the application.

## Unit Tests
Unit tests have been written to cover the core functionality of the rover behavior. I designed the application to be modular to allow for this Unit testing to be fairly simple to implement.

These could be expanded in the future to cover more details of the application.