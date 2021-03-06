using System;
using Xunit;

using DataStructures;

namespace DataStructuresTests
{
  public class LinkedListTests
  {
    [Fact]
    public void Empty_list_has_null_Head()
    {
      // Arrange
      LinkedList list = new LinkedList();

      // Act
      Node head = list.Head;

      // Assert
      Assert.Null(head);

      Assert.Empty(list);
    }

    [Fact]
    public void Insert_into_empty_LinkedList_adds_Node_with_Value_at_Head()
    {
      // Arrange
      LinkedList list = new LinkedList();

      // Act
      list.Insert(1);

      // Assert
      Assert.Equal(new[] { 1 }, list);

      // Make sure we have a Head node
      Assert.NotNull(list.Head);

      // Make sure the Head node has the inserted Value
      Assert.Equal(1, list.Head.Value);

      // Make sure the Head node does not have a Next
      Assert.Null(list.Head.Next);
    }

    [Fact]
    public void Insert_into_list_not_empty_works()
    {
      // Arrange
      LinkedList list = new LinkedList();
      list.Insert(5);

      // Act
      list.Insert(3);

      // Assert
      Assert.Equal(new[] { 3, 5 }, list);

      Assert.NotNull(list.Head);
      Assert.Equal(3, list.Head.Value);
      Assert.NotNull(list.Head.Next);
      Assert.Equal(5, list.Head.Next.Value);
      Assert.Null(list.Head.Next.Next);
    }

    [Fact]
    public void Insert_many_into_empty_list_works()
    {
      // Arrange
      LinkedList list = new LinkedList();

      // Act
      list.Insert(1, 3, 5);

      // Assert
      Assert.Equal(new[] { 1, 3, 5 }, list);
    }

    [Fact]
    public void Insert_many_into_list_not_empty_works()
    {
      // Arrange
      LinkedList list = new LinkedList();
      list.Insert(7);

      // Act
      list.Insert(1, 3, 5);

      // Assert
      Assert.Equal(new[] { 1, 3, 5, 7 }, list);
    }

    [Theory]
    [InlineData(1, false)]
    [InlineData(2, true)]
    [InlineData(3, true)]
    public void Includes_finds_value_or_not(int valueToFind, bool expected)
    {
      // Arrange
      LinkedList list = new LinkedList();
      list.Insert(2);
      list.Insert(3);
      Assert.Equal(new[] { 3, 2 }, list); // Make sure we didn't screw up

      // Act
      bool result = list.Includes(valueToFind);

      // Assert
      Assert.Equal(expected, result);
    }

    [Fact]
    public void ToString_returns_NULL_for_empty_list()
    {
      // Arrange
      LinkedList list = new LinkedList();

      // Act
      string result = list.ToString();

      // Assert
      Assert.Equal("NULL", result);
    }

    [Fact]
    public void ToString_returns_the_list()
    {
      // Arrange
      LinkedList list = new LinkedList();
      list.Insert(3);
      list.Insert(2);
      list.Insert(1);
      Assert.Equal(new[] { 1, 2, 3 }, list); // Make sure we didn't screw up

      // Act
      string result = list.ToString();

      // Assert
      Assert.Equal("1 -> 2 -> 3 -> NULL", result);
    }
  }
}
