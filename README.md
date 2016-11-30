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
