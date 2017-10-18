using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ToDoList;

namespace ToDoList.Tests
{
  [TestClass]
  public class TaskTest
  {
    [TestMethod]
    public void GetDescription_ReturnDescription_String()
    {
      // Arrange
      string description01 = "walk the dog.";
      string description02 = "wank off";
      Task newTask = new Task(description01);
      Task newTask = new Task(description02);
      List<Task> newList = new List<Task> { newTask1, newTask2 };

      // Act
      List<Task> result = newTask.GetAll();
      // Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}
