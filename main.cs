using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Enter a color ");
    var color = Console.ReadLine();


    
    if (color == "red" || color =="pink" ||color == "yellow" || color =="orange" || color =="gold"){
      Console.WriteLine ("The color " + color + " is warm");
    }
    else if (color == "blue" || color =="purple" ||color == "magenta" || color =="green"){
      Console.WriteLine ("The color " + color + " is cool");
    }
    else if (color == "black" || color == "white" || color == "ivory" || color == "brown" || color == "beige"){
      Console.WriteLine ("The color " + color + " is neutral");
    }
    else {
      Console.WriteLine ("Unable to determine the color temperature for the color " + color);
    }

  }
}