using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text;
using Recipe1;

using System.Security.Cryptography.X509Certificates;

namespace Recipe1;


internal class Recipe
{
    static void Main(string[] args)
    {
        External rec = new External();


        Console.WriteLine("Welcome to Recipe Manager!");
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1. Add a recipe");
        Console.WriteLine("2. Scale recipe");
        Console.WriteLine("3. Reset recipe quantities");
        Console.WriteLine("4. Clear all data");
        Console.WriteLine("5. Exit");

        int Menu = Convert.ToInt32(Console.ReadLine());

        if (Menu == 1)
        {
            rec.Recipeinfo();
        }
        else if (Menu == 2)
        {

        }
        else if (Menu == 3)
        {

        }
        else if (Menu == 4)
        {
            //DisplayRecipeDetails();
        }
        else if (Menu == 5)
        {

        }
        else if (Menu == 6)
        {
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("Please select valid input from 1-6");
        }
    }
}

public class External
{
    String RecipeDetails, Igredients, Mearusements, UserInput;
    int NumberofIgredients = 0;
    int Steps = 0;

    public object RecipeSteps { get; private set; }

    public string Recipeinfo(int[] Quantities)
    {
        Console.WriteLine("Enter the name of the Recipe");
        RecipeDetails = Console.ReadLine();
        Console.WriteLine("Enter Number of Ingredients" + RecipeDetails);
        NumberofIgredients = Convert.ToInt32(Console.ReadLine());

        string[] NameIngredients = new string[NumberofIgredients];
        string[] QuantitityofIngredients = new string[NumberofIgredients];
        string[] TheSteps = new string[NumberofIgredients];

        for (int i = 0; i < NumberofIgredients; i++)
        {

            int add = 1 + i;
            Console.WriteLine("Enter Ingredient number" + add);
            NameIngredients[i] = Console.ReadLine();
            Console.WriteLine("The Number Of Quantity ");
            Igredients = Console.ReadLine();
            Console.WriteLine("What is the measuring unit for" + NameIngredients[i]);
            Mearusements = Console.ReadLine();
        }
        Console.WriteLine("Enter the number of steps");
        Steps = Convert.ToInt32(Console.ReadLine());

        for (int d = 0; d < Steps; d++)
        {
            int Step = 1 + d;
            Console.WriteLine("Please Enter Step" + d);
            Steps[d] = Console.ReadLine();
            
        }
        return "";
    }
    //Method for Scaling
    public string ScaleofRecipe(int[] Quantitites, int NumberOfIngredients) {
        double Pass;
        int[] newQuantity = new int[NumberOfIngredients];
        Console.WriteLine("Which scale do you wanna use[0.5,2,3]");
        Pass = Convert.ToInt32(Console.ReadLine()) * Quantitites[0];
        int ScaleFactor = Convert.ToInt32(Pass);

        if (ScaleFactor == 0.5)
        {
            for (int i = 0; i < Quantitites.Length; i++)
            {
                newQuantity[i] = Quantitites[i] * 2;
            }
            Console.WriteLine("The recipe of " + ScaleFactor + "Has been sucessful");
        }

        //Array for Scales
        else if (ScaleFactor == 2)
        {
            for (int i = 0; i < Quantitites.Length; i++)
            {
                newQuantity[i] = Quantitites[i] * 2;

            }
            Console.WriteLine("The recipe of " + ScaleFactor + "Has been sucessful");

        }
        else if (ScaleFactor == 3)
        {
            for (int i = 0; i < Quantitites.Length; i++)
            {
                newQuantity[i] = Quantitites[i] * 3;

            }
            Console.WriteLine("The recipe of " + ScaleFactor + "Has been sucessful");

        }
        else
        {
            Console.WriteLine("Values incorrect");
        } return "";
    }

    internal void Recipeinfo()
    {
        throw new NotImplementedException();
    }
} 
           public string Reset(int[] Quantities)
    {
        for (int i = 0; i< Quantities.Length; i++){
            Quantities[i] = default(int);

        }
        Console.WriteLine("Reset was Sucessful");
    return "";
} 
        
    
    

        