using System;
using System.Collections.Generic;

namespace lefttodo
{
    class Menu
    {
        string myItem, status, searchWord; 
        int choice;      

        List<Todo> ItemList = new List<Todo>(); //creating new instacnce of Lists
        List<Todo> DoneList = new List<Todo>();        
        
        public void StartMenu()
        {
            do
            {    
                Console.WriteLine("\n\t---------          Let To Do            -----------");

                    Console.WriteLine("\tSee all of todays tasks        -           enter 1 ");
                    Console.WriteLine("\tAdd new Task to todays list     -           enter 2 ");
                    Console.WriteLine("\tChange status on Task           -           enter 3 ");
                    Console.WriteLine("\tFile all \"done\" tasks           -           enter 4 "); 
                    Console.WriteLine("\tList all filed (\"done\") tasks   -           enter 5 ");
                    Console.WriteLine("\tEnd program                     -           enter 9 ");
                    Console.Write("\tPlease enter your choice            -                   "); 

                    int.TryParse(Console.ReadLine(), out choice); 

                    switch (choice) {

                        case 1:
                            
                            int length = ItemList.Count;
                            Console.WriteLine(length);                            


                            foreach(Todo element in ItemList)
                            {
                                if(element.status =="t")
                                {Console.WriteLine($"{element.myItem} must be done today");}
                            } 

                            foreach(Todo element in ItemList)
                            {
                                if(element.status =="d")
                                {Console.WriteLine($"{element.myItem} have been done today");}
                            }

                        break;

                        case 2:
                            Todo task2 = new Todo();
                            Console.WriteLine("Adding a new Task to my ToDo List:");
                            Console.WriteLine("What is task?");
                            myItem = Console.ReadLine().ToUpper();

                            status = "t"; // t shows "to be done"
                            
                            task2.CreateTask(myItem,status);
                            ItemList.Add(task2);
                        break;

                        case 3:
                            Console.WriteLine("Enter search word...");
                            searchWord =Console.ReadLine().ToUpper();                  

                            var todo =new Todo();
                            todo.ChangeStatus(ItemList, searchWord);                                 

                        break;
                        
                        case 4:
                        Console.WriteLine("Sending all \"Done\" tasks to \"Done-list\"");
                        Todo fileall = new Todo();
                        fileall.FileAll(ItemList, DoneList);
                        break;

                        case 5:
                        Console.WriteLine("All Tasks which have been done:\n");
                                                        
                            foreach (Todo done in DoneList){
                            Console.WriteLine(done.myItem);}   
                        break;

                        case 9:
                        Console.WriteLine("Exiting Program");                            
                        break;
                   
                        default:
                        Console.WriteLine("\n\tNot an option - try again  ");
                        break;
                 }


                       
            }while(choice != 9);

        }
          public void FileAll()
        {
            Todo donelist = new Todo();
                            
            List<Lists> newList = new List<Lists>(ItemList);        //copy of itemlist to a new list               

            foreach (Todo ltd in newList)
            {
                if(ltd.status == "d")   
                {
                donelist.CreateTask(ltd.myItem, ltd.status);                                
                DoneList.Add(donelist);
                ItemList.Remove(ltd);
                } 
            }                        
            Console.WriteLine("Todays list now contains:");
            foreach(Todo itm in ItemList)
            {
            Console.WriteLine(itm.myItem);
            }                              
            
        }
    }
}
