public class TreeNode {
    public int Key;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int key) {
        Key = key;
        left = null;
        right = null;
    }
}
public class BST {
    public TreeNode root;

    public TreeNode Insert(TreeNode root, int key) {
        if (root == null) {
            return new TreeNode(key);
        }
        if (key < root.Key) {
            root.left = Insert(root.left, key);
        } else if (key > root.Key) {
            root.right = Insert(root.right, key);
        }
        return root;
    }

    public TreeNode Delete(TreeNode root, int key) {
        if (root == null) return null;

        if (key < root.Key) {
            root.left = Delete(root.left, key);
        } else if (key > root.Key) {
            root.right = Delete(root.right, key);
        } else {
            if (root.left == null) return root.right;
            if (root.right == null) return root.left;

            TreeNode temp = MinValueNode(root.right);
            root.Key = temp.Key;
            root.right = Delete(root.right, temp.Key);
        }
        return root;
    }

    private TreeNode MinValueNode(TreeNode root) {
        while (root.left != null) {
            root = root.left;
        }
        return root;
    }

    public bool Search(TreeNode root, int key) {
        if (root == null) return false;
        if (key == root.Key) return true;
        if (key < root.Key) return Search(root.left, key);
        return Search(root.right, key);
    }

    public void Add(int key) {
        root = Insert(root, key);
    }

    public void Remove(int key) {
        root = Delete(root, key);
    }

    public bool Contains(int key) {
        return Search(root, key);
    }
}
public class MyHashSet {
    private const int size = 10000;
    private BST[] buckets;

    public MyHashSet() {
        buckets = new BST[size];
        for (int i = 0; i < size; i++) {
            buckets[i] = new BST();
        }
    }

    private int Hash(int key) {
        return key % size;
    }

    public void Add(int key) {
        int idx = Hash(key);
        if (!buckets[idx].Contains(key)) {
            buckets[idx].Add(key);
        }
    }

    public void Remove(int key) {
        int idx = Hash(key);
        buckets[idx].Remove(key);
    }

    public bool Contains(int key) {
        int idx = Hash(key);
        return buckets[idx].Contains(key);
    }
}
