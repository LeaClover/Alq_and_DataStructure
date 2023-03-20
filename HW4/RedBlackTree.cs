
namespace GB.alg_and_data_str.HW4 {
    public class RedBlackTree {
        private Node root;

        public Node getRoot() {
            return this.root;
        }
        public Boolean add (int value) {
            if (root != null) {
                Boolean result = addNode(root, value);
                root = rebalance(root);
                root.color = Color.BLACK;
                return result;
            }
            else {
                root = new Node();
                root.color = Color.BLACK;
                root.value = value;
                return true;
            }
        }

        private Boolean addNode (Node node, int value) {
            if (node.value == value) {
                return false;
            } 
            else {
                if (node.value > value) {
                    if (node.leftChild != null) {
                        Boolean result = addNode(node.leftChild, value);
                        node.leftChild = rebalance(node.leftChild);
                        return result;
                    }
                    else {
                        node.leftChild = new Node();
                        node.leftChild.color = Color.RED;
                        node.leftChild.value = value;
                        return true;
                    }
                }
                else {
                    if (node.rightChild != null) {
                        Boolean result = addNode(node.rightChild, value);
                        node.rightChild = rebalance(node.rightChild);
                        return result;
                    }
                    else {
                        node.rightChild = new Node();
                        node.rightChild.color = Color.RED;
                        node.rightChild.value = value;
                        return true;
                    }
                }
            }
        }

        private Node rebalance (Node node) {
            Node result = node;
            Boolean needRebalance;
            do {
                needRebalance = false;
                if (result.rightChild != null && result.rightChild.color == Color.RED &&
                    (result.leftChild == null || result.leftChild.color == Color.BLACK)) {
                        needRebalance = true;
                        result = rightSwap(result);
                }
                if (result.leftChild != null && result.leftChild.color == Color.RED &&
                    result.leftChild.leftChild != null && result.leftChild.leftChild.color == Color.RED) {
                        needRebalance = true;
                        result = leftSwap(result);
                }
                if (result.leftChild != null && result.leftChild.color == Color.RED && 
                    result.rightChild != null && result.rightChild.color == Color.RED) {
                        needRebalance = true;
                        colorSwap(result);
                }
            } 
            while (needRebalance);
            return result;
        }

        private Node rightSwap (Node node) {
            Node rightChild = node.rightChild;
            Node betweenChild = rightChild.leftChild;
            rightChild.leftChild = node;
            node.rightChild = betweenChild;
            rightChild.color = node.color;
            node.color = Color.RED;
            return rightChild;
        }

        private Node leftSwap (Node node) {
            Node leftChild = node.leftChild;
            Node betweenChild = leftChild.rightChild;
            leftChild.rightChild = node;
            node.leftChild = betweenChild;
            leftChild.color = node.color;
            node.color = Color.RED;
            return leftChild;
        }

        private void colorSwap (Node node) {
            node.rightChild.color = Color.BLACK;
            node.leftChild.color = Color.BLACK;
            node.color = Color.RED;
        }

        private void InOrderDisplay(Node root, int level) {
            if (root != null) {
                String ss = string.Concat(Enumerable.Repeat("  " , level)); 
                Console.Write(ss + level + " - " + root.value + " " + root.color + "\n");
                InOrderDisplay(root.leftChild, level + 1);
                InOrderDisplay(root.rightChild, level + 1);
            }
        }

        public void DisplayTree(int level) {
            if (root == null) {
                Console.WriteLine("Nothing in the tree!");
                return;
            }
            if (root != null) {
                InOrderDisplay(root, level);
            }
        }

        // public override string ToString() {
        //     return "Node: " +  + " " + color;
        // }
    }

    public class Node {
        public int value;
        public Color color;
        public Node leftChild;
        public Node rightChild;
    }

    public enum Color {
        RED,
        BLACK
    }
}