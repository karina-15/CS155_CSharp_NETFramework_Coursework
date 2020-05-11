# Homework10
> Rewrite video game code as object-oriented programming (OOP)
> with classes, inheritance, virtual, and private fields

## Screenshot
![screenshot](Homework10.png)

## Instructions
> In the attached file [`Program.cs`](Program.cs) you will find some video game code by J. Hacker.  
> There is an Alien class to represent a monster and an AlienPack class  
> that represents a band of aliens and how much damage they can inflict.  
> 
> The code is not very object oriented and does not support information  
> hiding in the Alien class.  Split the code into multiple files.  
> Rewrite the code so that inheritance is used to represent the different  
> types of aliens instead of the “type” parameter.  This should result in  
> deletion of the “type” parameter.  Also rewrite the Alien class to hide  
> the instance variables and create a GetDamage method for each derived  
> class that returns the amount of damage the alien inflicts.  Finally,  
> rewrite the CalculateDamage method to use GetDamage and write a Main  
> method that tests the code.