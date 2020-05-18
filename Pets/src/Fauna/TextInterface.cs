namespace Fauna
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    class TextInterface
    {
     //   List<Object> animals;
        string methodsWild = "[MakeSound, Hunt, back, quit]";        
        string methodsTame = "[Eat, TalkToOwner, MakeSound, ComeHere, GiveName, back, quit]";
        string startline = "[list, quit]";
        string methodline = "What do you want to do?";
        string animalline = "Which animal do you want to see?";
        string headerAnimals = "List of animals:";
        string[] animals = {"Cat", "Dog", "Bird", "Bear", "Wolf", "Tiger", "Elephant"};

        public TextInterface()
        {
          // animals = new List<object>();
        }

        public void Start()
        {
            string answer, answerA, answerM;
            Object testAnimal = new Object();
           
            while(true)
            {
                // choose list or quit
                System.Console.WriteLine(methodline + startline);
                answer = System.Console.ReadLine();
                if(answer == "back") break;
                if(answer == "quit") goto Done;
                else if(answer=="list")
                {
                    System.Console.WriteLine(headerAnimals);
                    PrintAnimals();
                    while(true)
                    {   
                        // choose animal            
                        System.Console.WriteLine(animalline);
                        answerA = System.Console.ReadLine();

                        if(answerA == "back") break;
                        if(answerA == "quit") goto Done;
                       // testAnimal = this.GetAnimal(answerA);
                       

                        switch(answerA)
                        {
                            case "Cat": testAnimal= new Cat(); // as Cat();
                                        break;
                            case "Dog": testAnimal = new Dog();
                                        break;     
                            case "Bird": testAnimal = new Bird();
                                         break;
                            case "Bear": testAnimal = new Bear();
                                         break;   
                            case "Wolf": testAnimal = new Wolf();
                                         break;
                            case "Tiger": testAnimal = new Tiger(); 
                                          break;   
                            case "Elephant": testAnimal = new Elephant();
                                             break;   
                            default:
                                Console.WriteLine("Unknown animal!");
                                break;                            
                        }
                        
                        while(true)
                        {
                            // choose function
                            System.Console.Write(methodline);
                            PrintList(answerA);                            
                            answerM = System.Console.ReadLine();
                            if(answerM == "back") break;
                            if(answerM == "quit") goto Done;                       
                        
                            
                            switch(answerM)
                            {
                                case "Eat": testAnimal.Eat();
                                            break;
                                case "TalkToOwner": System.Console.WriteLine(testAnimal.TalkToOwner());
                                            break;     
                                case "MakeSound": testAnimal.MakeSound();
                                            break;
                                case "ComeHere": testAnimal.ComeHere();
                                            break;   
                                case "GiveName": testAnimal.GiveName(blaa);
                                            break;
                                case "Hunt": testAnimal.Hunt(); 
                                            break;   
                                case "Elephant": testAnimal = new Elephant();
                                                break;   
                                default:
                                    Console.WriteLine("Unknown animal!");
                                    break;                            
                            }

                        }
                    }
                } 
            }    
            Done: ;       
        }

        public void PrintAnimals()
        {   
            System.Console.WriteLine("blaa");
            for(int i = 0; i< animals.Length; i++) System.Console.WriteLine(animals[i]);
           // foreach(object animal in animals) 
            // System.Console.WriteLine(animal.GetType().ToString().Substring(6));
        }

        public void PrintList(string name)
        {            
            switch (name)
            {
                case "Cat":
                case "Dog":      
                case "Bird":
                    Console.WriteLine(methodsTame);
                    break;
                case "Bear":
                case "Wolf":
                case "Tiger":      
                case "Elephant":
                    Console.WriteLine(methodsWild);
                    break;
                default:
                    Console.WriteLine("Unknown animal!");
                    break;
            }
        }
                
        public void PrintMethod(string name)
        {            
            Console.Write("");
            switch (name)
            {
                case "Cat":
                case "Dog":      
                case "Bird":
                    Console.WriteLine(methodsTame);
                    break;
                case "Bear":
                case "Wolf":
                case "Tiger":      
                case "Elephant":
                    Console.WriteLine(methodsWild);
                    break;
                default:
                    Console.WriteLine("Unknown animal!");
                    break;
            }
        }
                
    }
}
