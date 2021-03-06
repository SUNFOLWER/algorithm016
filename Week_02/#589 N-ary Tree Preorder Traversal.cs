﻿/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node() {}

    public Node(int _val) {
        val = _val;
    }

    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
    }
}
*/

public class Solution
{

    private readonly IList<int> _ans = new List<int>();

    public IList<int> Preorder(Node root)
    {
        Helper(root);
        return _ans;
    }

    private void Helper(Node root)
    {
        if (root == null) return;

        _ans.Add(root.val);

        if (root.children != null)
        {
            for (int i = 0; i < root.children.Count; ++i)
            {
                Helper(root.children[i]);
            }
        }
    }
}