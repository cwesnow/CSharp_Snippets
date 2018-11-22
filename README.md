# CSharp_Snippets

## Main Program

  Holds the basic Menu System that allows you to run a selected code sample.  None of this code is designed as an end product, but rather serves as a small pool of samples for referencing.  The menu is based on older Console and Command Line Menues, but there isn't any ASCII ART or fancy color schemes here.  Just a simple display of a list, and a number input to choose which program to run.
  
  Note: Transitioned from monolithical Main into dividing each example into their own class for ease of maintainance.  Everything is static, but will likely switch to an instance approach or a repository style pattern as examples grow.

## Sample 1 - Spaceship

  Simple Console.WriteLine practice that allowed for exploration into ways we can display text in various alternative ways.  This practice can lead to understanding how different methods can impact our ability to work with the code, and the ease with changing it later.
  
## Sample 2 - Calculator

  Basic calculator example that simply accepts a number, the operation to do, and then another number.  Then it displays what the user input along with it's answer.

## Sample 3 - Guess Your Number

  This program tries to guess your number by using a random number generator and asking if they guessed too high, too low, or if it's right.  This program began fairly simply, but recently tried a more broken out design to simplify/limit code changes inside of it.  It could be reworked at least 5 different ways as it stands, but should be a reasonable example of basic logic processes and interesting to play a few times.

## Sample 4 - Registration Date

  User entry example that required a date format.  The user is asked for their name and a date, and then displays their information.  This example is based on accepting DateTime formats from users, or possibly from another Control element.  It validates for proper format, and then assuming that format stays.  We can use substring to pull out the information we want or create methods for easier code reading.

## Sample 5 - OOP

  Very basic concepts of inheritance, and interfaces.  We have a mini-demo that runs some code that creates 2 people, and a cat and dog object.  They all have a name, eat something, and can say something.  The demo simply creates these objects and calls the same code speak() method.  Yet, each object implements this method differently.  This example could be improved, but is simple enough to follow and experiment on.

## Sample 6 - Auction Posts

  Lists are similar to Arrays, but offer many advantages, this example helps showcase a basic menu driven post site that uses Lists to filter and find content.

## Sample 7 - Exception Handling

  Generally we like to pretend like every program will never encounter an error or experience bad user input that can corrupt the system.  However, in the case where we can't prevent everything there is a way to catch these exceptions.  Our method or system can be designed to throw these Exceptions that can be caught and later handled appropriately.  We can even design our own Exceptions with custom Handling Methods in our code... but this example just shows throwing an error and catching it for now.

## Sample 8 - Temperature Conversion

  Basic Farenheit to Celsius calculator with a Number Validator and displays Degree Symbols correctly. Uses two different methods of showing custom degree symbol, and Temperature's are truncated for users to avoid long insignificant decimal numbers.
  
## Sample 9 - (RLE) Encoder

  Demonstrates basic compression using the Run Length Encoder (RLE) Method. Combines redundant characters and counts them to quickly compres long redenduant numbers into something simple like , 3333333333 would simply be the number 3 10 times. It also allows for comparing between uncompressed and compressed versions to see how much it has reduced the size of the string or file.
  
## Sample 10 - Prime Numbers

  Displays Prime Numbers starting with 2 up to the Size of your Console - 8. Users are allowed to enter any number between 2 and their systems limitation. Provides a simple Invalidation process and retries for the user input. The system then runs through every number up to their input and validates primes with a string of X to represent it passed the test for each number leading up to it. A column to the left simplifies the Prime Numbers found. The X representations provides a visual representations of how the Primes are spaces away from each other, or how many numbers are between them.
  
## Sample 11 - Unique Numbers

Provides unique random numbers, until the "magic number" is hit. This program mimics a password/pin that needs to be figured out and instead of brute forcing sequentially is using a random generator to avoid starting at "0" and waiting until "9999" to find it. Uses a Hash to avoid using the same numbers multiple times, and pauses every 10 combinations for User interaction/testing.

## Sample 12 - Dictionary with Enums

Provides a Dictionary of Stats for a basic game system. This allows for an easy character generator that uses ENUMS for the Stats Name, and AbstractClass to setup it's Name, Min, Max, and Current status for the character.

## Sample 13 - Equestion Solver

A more advanced calculated that attempts to parse equations for the user. Allowing the user to type in 1 + 2, instead of the basic calculator needing the user to specify each number and math symbol individually.
