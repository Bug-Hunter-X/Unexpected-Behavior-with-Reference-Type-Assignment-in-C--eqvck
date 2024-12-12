# C# Reference Type Assignment Bug

This repository demonstrates an uncommon, yet important, bug in C# related to the assignment of reference types.  When you assign a reference type variable to another variable, both variables point to the same object in memory.  Modifying the object through either variable will affect both.

This can lead to unexpected behavior if you're not aware of how reference types are handled in C#.

The `bug.cs` file contains the buggy code, and `bugSolution.cs` offers a solution using cloning or creating a copy of the object.

## How to Reproduce

1. Clone this repository.
2. Open the `bug.cs` file in a C# IDE (like Visual Studio).
3. Run the code. Observe that changing the `MyProperty` of `obj2` also changes the `MyProperty` of `obj1`.

## Solution

To avoid this issue, you need to create a copy of the object instead of simply assigning the reference.  The `bugSolution.cs` shows how to do this using cloning techniques or creating a new object with the same values.