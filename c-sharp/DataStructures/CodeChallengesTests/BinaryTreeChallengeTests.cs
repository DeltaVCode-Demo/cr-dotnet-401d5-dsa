using CodeChallenges;
using DataStructures.Trees;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CodeChallengesTests
{
  public class BinaryTreeChallengeTests
  {
    [Fact]
    public void Sum_of_empty_tree_is_zero()
    {
      // Arrange
      BinaryTree<int> tree = new BinaryTree<int>();

      // Act
      int result = BinaryTreeChallenges.Sum(tree);

      // Assert
      Assert.Equal(0, result);
    }

    [Fact]
    public void Sum_returns_value_of_tree_with_single_node()
    {
      // Arrange
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int> { Value = 7 };

      // Act
      int result = BinaryTreeChallenges.Sum(tree);

      // Assert
      Assert.Equal(7, result);
    }

    [Fact]
    public void Sum_returns_value_of_tree_with_node_with_Left()
    {
      // Arrange
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int> { Value = 7 };
      tree.Root.Left = new Node<int> { Value = 3 };

      // Act
      int result = BinaryTreeChallenges.Sum(tree);

      // Assert
      Assert.Equal(10, result);
    }

    [Fact]
    public void Sum_returns_value_of_tree_with_node_with_Right()
    {
      // Arrange
      BinaryTree<int> tree = new BinaryTree<int>();
      tree.Root = new Node<int> { Value = 7 };
      tree.Root.Right = new Node<int> { Value = 4 };

      // Act
      int result = BinaryTreeChallenges.Sum(tree);

      // Assert
      Assert.Equal(11, result);
    }
  }
}
