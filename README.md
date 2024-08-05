# Prototype Design Pattern in Unity

## Project Overview

This project demonstrates the implementation of the Prototype design pattern using Unity. The Prototype pattern is a creational design pattern that allows an object to create a copy of itself without knowing the exact type of object that is being created. This pattern is useful in scenarios where the cost of creating a new instance of an object is expensive or complex.

## Code Implementation

### Prototype Class

The `Prototype` class implements the `IPrototype` interface and provides the `Clone` method to create a copy of the `Prototype` object.

### Spawner Class

The `Spawner` class uses the `Prototype` class to create new instances of the `Prototype` object. It has a `cubePrototype` field that holds the prototype object and a `CubeMaker` method that creates a new instance of the prototype.

### IPrototype Interface

The `IPrototype` interface defines a generic `Clone` method that must be implemented by any class that implements this interface.

## Usage

1. **Create a Prototype**: Create a GameObject in your Unity scene and attach the `Prototype` script to it. Configure its properties as needed.

2. **Set up the Spawner**: Create another GameObject and attach the `Spawner` script to it. Assign the previously created prototype GameObject to the `cubePrototype` field of the `Spawner`.

3. **Generate Clones**: Select the GameObject with the `Spawner` script and use the context menu to invoke the `CubeMaker` method. This will create a new instance of the prototype object.

## Conclusion

By using the Prototype design pattern, you can easily create new instances of objects in Unity without directly instantiating them. This approach can help in managing complex object creation logic and improving the performance of your game.
