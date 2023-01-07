using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AlgorithmCoding
{
    public class SumOfLeftLeaves
    {
        //Given the root of a binary tree, return the sum of all left leaves.
        //A leaf is a node with no children.A left leaf is a leaf that is the left child of another node.
        public static int SumOfLeftLeavesResult(TreeNode root)
        {
            if (root == null)
            {
                return 0;
            }
            else if (root.left != null && root.left.left == null && root.left.right == null)
            {
                return root.left.val + SumOfLeftLeavesResult(root.left);
            }
            else
            {
                return SumOfLeftLeavesResult(root.left) + SumOfLeftLeavesResult(root.right);
            }
        }
    }

    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }
}
