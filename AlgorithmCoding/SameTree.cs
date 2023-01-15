namespace AlgorithmCoding
{
    public class SameTree
    {
        //Definition for a binary tree node.
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

        //Given the roots of two binary trees p and q, write a function to check if they are the same or not.
        //Two binary trees are considered the same if they are structurally identical, and the nodes have the same value.

        //Input: p = [1,2,1], q = [1,1,2]
        //Output: false

        public static bool IsSameTree(TreeNode p, TreeNode q)
        {
            if (p == null && q == null) return true;
            if (p == null || q == null) return false;
            if (p.val != q.val) return false;

            return IsSameTree(p.left, q.left) && IsSameTree(p.right, q.right);
        }
    }
}
