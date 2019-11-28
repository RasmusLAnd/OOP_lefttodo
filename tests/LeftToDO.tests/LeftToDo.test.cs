using System;
using Xunit;
using System.Collections.Generic;

namespace lefttodo.tests
{
    public class LefttodoTests
    {
        [Fact]
        public void CreateTest()
        {   
            //Arrange
            List<Todo> ItemList = new List<Todo>();
            Todo item = new Todo();

            //act            
            item.CreateTask("kage", "d");
            ItemList.Add(item);
            int length = ItemList.Count;

            //assert
            Assert.Equal(1,length);

        }

        [Fact]
        public void TaskDone()
        { //Arrange
        List<Todo> ItemList = new List<Todo>();
        Todo item = new Todo();
        item.CreateTask("kage", "d");
        ItemList.Add(item);

          //act 
         item.ChangeStatus(ItemList, "KAGE");
         int length = ItemList.Count;

          //assert
          Assert.Equal("d",ItemList[0].status);
        }

        [Fact]
        public void FilingDone()
        { //Arrange
            List<Todo> DoneList = new List<Todo>();
            List<Todo> ItemList = new List<Todo>();
            Todo item = new Todo();
            item.CreateTask("kage", "d");
            ItemList.Add(item);          
            item.ChangeStatus(ItemList, "KAGE");

          //act 
            item.FileAll(ItemList, DoneList);
            int length = DoneList.Count;


          //assert
            Assert.Equal(1, length);

        }


    }
}
