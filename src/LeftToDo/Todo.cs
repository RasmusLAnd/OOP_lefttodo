using System;
using System.Collections.Generic;

namespace lefttodo
{
    public abstract class Lists
    {      
        public abstract void CreateTask(string myItem, string status);          
    }

    public class Todo: Lists
    {

        public override void CreateTask(string myItem, string status)
        {this.myItem =myItem;
        this.status = status; }        

        public string myItem{get;set;}
        public string status{get;set;}

        public void ChangeStatus(List<Todo> ItemList, string searchWord)
        {
            foreach(Todo task in ItemList)
                                {   
                                    if (task.myItem == searchWord)
                                        {
                                        task.status="d";
                                        Console.WriteLine($"The status of {task.myItem} has been set to \"Done\"");
                                        }                                                                       
                                }

        }

            public void FileAll(List<Todo> ItemList, List<Todo> DoneList)
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