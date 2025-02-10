namespace StockExchangeCity.Modules.Char
{
    public class PropertiesBuilder
    {
        public void Build(TreeView tree)
        {
            tree.Nodes.AddRange([
                CreateHeadNode(),
                CreateBodyNode(),
                CreateLeftHandNode(),
                CreateRightHandNode(),
                CreateLeftLegNode(),
                CreateRightLegNode(),
            ]);
        }

        private TreeNode CreateHeadNode()
        {
            var proc = new TreeNode("Центральный процессор");
            var leye = new TreeNode("Глаз (левый)");
            var reye = new TreeNode("Глаз (правый)");
            return new TreeNode("Голова", [proc, leye, reye]);
        }

        private TreeNode CreateBodyNode()
        {
            return new TreeNode("Туловище");
        }

        private TreeNode CreateLeftHandNode()
        {
            return new TreeNode("Рука (левая)");
        }

        private TreeNode CreateRightHandNode()
        {
            return new TreeNode("Рука (правая)");
        }

        private TreeNode CreateLeftLegNode()
        {
            return new TreeNode("Нога (левая)");
        }

        private TreeNode CreateRightLegNode()
        {
            return new TreeNode("Нога (правая)");
        }
    }
}
