using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diacriticity
{
    public partial class Variant5 : Form
    {
        public Variant5()
        {
            InitializeComponent();
            foreach (var key in Symbols.dictionary.Keys)
            {
                TreeNode treeNode = new TreeNode(key.ToString());
                TreeNode[] treeNodes = new TreeNode[Symbols.dictionary[key].Length];
                for (int i = 0; i < Symbols.dictionary[key].Length; i++)
                {
                    TreeNode node = new TreeNode(Symbols.dictionary[key][i].ToString());
                    treeNodes[i] = node;
                }
                treeNode.Nodes.AddRange(treeNodes);
                treeView1.Nodes.Add(treeNode);
            }
            foreach (var key in Symbols.dictionary.Keys)
            {
                TreeNode treeNode = new TreeNode(key.ToString().ToUpper());
                TreeNode[] treeNodes = new TreeNode[Symbols.dictionary[key].Length];
                for (int i = 0; i < Symbols.dictionary[key].Length; i++)
                {
                    TreeNode node = new TreeNode(Symbols.dictionary[key][i].ToString().ToUpper());
                    treeNodes[i] = node;
                }
                treeNode.Nodes.AddRange(treeNodes);
                treeView2.Nodes.Add(treeNode);
            }
        }

        private void treeView_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            richTextBox1.SelectedText = e.Node.Text;
        }
    }
}
