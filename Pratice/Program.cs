namespace Part1
{
    class Ingredients
    {

        public string Name { get; set; }  //this helps to set the value of the value so once the user request fro the value it gets it 

        public int Quantity { get; set; }

        public string UnitofMeasurement { get; set; }

    }
    class Steps
    {



        public string Description { get; set; }


    }
    class Receipe  //this is the parent class which the steps and the ingredients class will inherit from
    {
        private Ingredients[] ingredients;    //this can not be global cause they can only ba accessed through the constructor

        private Steps[] steps;

        public Receipe(int ListOfingredients, int numberOfsteps)
        {
            ingredients = new Ingredients[ListOfingredients];
            steps = new Steps[numberOfsteps];
            //this is constructor is done to store the values inside the array for the declared objects for the array







        }

        public Receipe()
        {
        }//this is a defult constr

        public void AddIngredients(int index, string name, int quantity, string unitofMeasure)
        {
            ingredients[index] = new Ingredients { Name = name, Quantity = quantity, UnitofMeasurement = unitofMeasure };
            
        }

        public void AddSteps(int StepIndex, string explaination)
        {

            steps[StepIndex] = new Steps { Description = explaination }; //this can be also be seen as an idetifier 

        }

        public void cleardata()
        {

            ingredients = new Ingredients[ingredients.Length];
            steps = new Steps[steps.Length]; //this step was used to clear the amount of data in the array

            Console.Clear();



        }


        public void resetdata()

        {
            foreach (var ingredient in ingredients)
            {
                ingredient.Quantity = 1;

            }


        }
        public void DisplayRecepie()
        {
            if(ingredients != null)
            foreach (var ingredient in ingredients)
            {
                Console.WriteLine($"{ingredient.Name}, {ingredient.Quantity},{ingredient.UnitofMeasurement}"); //the dollar sign ensures the system knows it is printing out a number, invoking the class to acess a method from a diffrent class
            }                     //this dollar is for the index it numbers every step

            if(steps !=null)
            for (int i = 0; i < steps.Length; i++) {
                Console.WriteLine($"{steps[i].Description}");  //i is the index and it will name index every descriprion and where at the number the user prompted  
            }

        }
    }

        




            class Manager   //main driver
            {
                
                static void Main(string[] args)

                {
            Boolean finished = false;
            Receipe food = new Receipe();

                    
                    
                    Console.WriteLine("Welcome To the Recepie Menu");




            
            while (finished==false)
                    {

                    Console.WriteLine("Choose Options:");
                    
            Console.WriteLine("1. Enter recepie details \n 2. View recepie details  \n 3. Clear Data  \n 4. Reset Data \n 5. Return to Menu");
            int select = int.Parse(Console.ReadLine());

                    

                if (select == 1)
                        {
                            Console.WriteLine("Enter Recepie name:");
                            string nameofrecepie = Console.ReadLine();
                            Console.WriteLine("Recepie for " + nameofrecepie);
                            
                         
                            Console.WriteLine("How many ingridents are in the recpie");
                            
                            int numberOfingredients = Convert.ToInt32(Console.ReadLine()); //This helps me to convert a string to an int.
                            Console.WriteLine("How many steps are needed for the " + nameofrecepie);
                            int numberofSteps = Convert.ToInt32(Console.ReadLine());

                             food = new Receipe(numberOfingredients, numberofSteps);

                            for (int i = 0; i < numberOfingredients; i++)
                            {

                                Console.WriteLine($"Ingredient:{i}");
                                Console.WriteLine("Name : ");

                                string name = Console.ReadLine();


                                Console.WriteLine("Quantity : ");

                                int quantity = Convert.ToInt32(Console.ReadLine());


                                Console.WriteLine("Unit Of Measurement : ");

                                string unitOfMeasure = Console.ReadLine();
                                
                                food.AddIngredients(i, name, quantity, unitOfMeasure);
                            }
                            for (int i = 1; i < numberofSteps; i++)
                            {
                                Console.WriteLine($"numberOfSteps:{i}");
                                Console.WriteLine("Name : ");

                                string Description = Console.ReadLine();
                                food.AddSteps(i, Description);
                                  //assgined to an array
                            }
                            food.DisplayRecepie();







                        }
                        else if (select == 2)
                        {
                          Console.WriteLine("View Recpie Menu: ");
                            food.DisplayRecepie();


                        }

                        else if(select ==3)
                        {
                    
                    Console.WriteLine("Thank You your Data has be cleared");
                            food.cleardata();
                        }
                        else if (select == 4)
                        {
                   
                        Console.WriteLine("Thank You your Data has be reset");
                            food.resetdata();

                        }
                        else if(select == 5)
                        {
                            Console.WriteLine("Thank You for using the App");
                            
                        }
                        else { }
                    }

                    

                    
                    

                }
            }



}
   




