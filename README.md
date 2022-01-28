![Build & Test workflow](https://github.com/Jacques-Philippe/learning-di-calculator/actions/workflows/unit-tests.yml/badge.svg)

# Purpose

The ideology behind dependency injection is pretty interesting. What it boils down to is that classes, or code components, should be responsible for only themselves. In addition, in order to promote code maintainability in a more long-term way, dependency injection allows us to use more loosely-coupled code.  
In other words, if you have a service consumer and a service provider. Without dependency injection, we may need to make changes to the service consumer given changes to the service provider. Dependency injection allows us to avoid this.
For more information, [read this article](https://docs.microsoft.com/en-us/dotnet/core/extensions/dependency-injection).

This repository will be my first time trying dependency injection.

# Planning

I'm going to have a main class `Calculator`, which will have an `Adder` and a `Multiplier`, where the `Adder` is a consumer of some addition-centric service, and `Multiplier` is a consumer of some multiplication-centric service.  
I will create two service providers for both `Adder` and `Multiplier`, and switching out providers should have no effect on the code within the `Calculator` class, and should have no effect on its behaviour.

## Responsibilities

- `Adder`; responsible for implementing the calculator's addition operation
- `Multiplier`; responsible for implementing the calculator's multiplication operation

### Interfaces

- IAdder
  - Add(float, float): float
- IMultiplier
  - Multiply(float, float): float

### Classes

- CalculatorPositiveAdder : IAdder
  - return the sum of two numbers by adding them
  ```
     1 + 1 = 2
  ```
- CalculatorNegativeAdder : IAdder
  - return the sum of two numbers by subtracting the negative of the second number from the first number
  ```
     1 - -1 = 2
  ```
- CalculatorMultiplyByTimesing : IMultiply
  - return the product of two numbers by multiplying them
    ```
       2 * 3 = 6
    ```
- CalculatorMultiplyByDividing : IMultiply
  - return the product of two numbers by dividing by one over the second number
    ```
       2 / (1 / 3) = 6
    ```

# Get started (dev)

1. Install csharpier
   ```
   dotnet tool install csharpier -g
   ```
1. Install yarn
1. Clone the repo
1. Delete the .git directory
1. Initialize a new git repo
1. run `yarn prepare`
1.
