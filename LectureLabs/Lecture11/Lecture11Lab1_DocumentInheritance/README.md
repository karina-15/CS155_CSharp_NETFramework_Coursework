# Lecture11Lab1_DocumentInheritance
> Use inheritance to create an e-mail from a document's text  
> Write to a document

## Screenshot
![screenshot](Lecture11Lab1_DocumentInheritance.png)

## Instructions
> Define a class named Document that contains an instance variable of type  
> string named text that stores any textual content for the document.  
> Create a method named ToString() that returns the text field and also  
> include a method to set this value.  
> 
> Next, define a class for Email that is derived from Document and includes  
> instance variables for the sender, recipient, and title of an email message.  
> Implement appropriate setter and getter methods.  The body of the email  
> message should be stored in the inherited variable text.  
> Redefine the ToString() method to concatenate all text fields.  
> 
> Similarly, define a class for File that is derived from Document and  
> includes a instance variable for the pathname. The textual contents of the  
> file should be stored in the inherited variable text. Redefine the ToString()  
> method to concatenate all text fields. (see [myFile.txt](myFile.txt))  
> 
> Finally create 2 Email and Fileobjects (4 total objects) in your Main method.  
> Test your object by pass them to the following subroutine that returns true  
> if the object contains the specified keyword in the text property.  
```cs
public static bool ContainsKeyword(Document docObject, string keyword)
{
    if (docObject.ToString().IndexOf(keyword, 0) >= 0)
    {
        return true;
    }
    return false;
}
```