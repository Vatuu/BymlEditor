using Syroot.NintenTools.Byaml.Dynamic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;

namespace BymlEditor
{
    public partial class mainForm : Form
    {

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileNormal.ShowDialog();
        }

        private void openFileNormal_FileOk(object sender, CancelEventArgs e)
        {
            tree.Nodes.Clear();
            this.Text = "Binary YAML Editor [" + openFileNormal.SafeFileName + "]";
            generateBymlList(openFileNormal.FileName);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void boxValue_TextChanged(object sender, EventArgs e)
        {

        }


        private void aboutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Form f = new Form();
        }

        private void tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (((NodeDetails)e.Node.Tag) != null)
            {
                boxId.Text = ((NodeDetails)e.Node.Tag).id;
                boxType.Text = ((NodeDetails)e.Node.Tag).type;
                boxValue.Text = ((NodeDetails)e.Node.Tag).value;
            }
        }

        private void expandAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.ExpandAll();
        }

        private void collapseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tree.CollapseAll();
        }

        #region Links

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/Vatuu/BymlEditor");
        }

        private void bYMLFileFormatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("http://mk8.tockdom.com/wiki/BYAML_(File_Format)");
        }

        private void sMOModdingHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/Hapgfny");
        }

        private void zeldaBotWModdingHubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(" https://discord.gg/68YmVJX");
        }

        #endregion

        #region Methods

        private void generateBymlList(string file)
        {
            dynamic byml = ByamlFile.Load(file, false, Syroot.BinaryData.ByteOrder.LittleEndian);
            tree.Nodes.Add(parseDynamic(byml, "root"));
        }

        private TreeNode parseDynamic(dynamic dyn, String name)
        {
            TreeNode node;
            NodeDetails details = new NodeDetails();

            if(dyn is String)
            {
                details.id = "STRING";
                details.type = "String";
                details.value = dyn;
                node = new TreeNode(name != null ? name : "String");
            }else if(dyn is int)
            {
                details.id = "INTEGER";
                details.type = "Integer";
                details.value = dyn.ToString();
                node = new TreeNode(name != null ? name : "Integer");
            }else if(dyn is float)
            {
                details.id = "FLOAT";
                details.type = "Float";
                details.value = dyn.ToString("0.000");
                node = new TreeNode(name != null ? name : "Float");
            }else if(dyn is bool)
            {
                details.id = "BOOLEAN";
                details.type = "Boolean";
                details.value = dyn.ToString();
                node = new TreeNode(name != null ? name : "Boolean");
            }else if(dyn is IEnumerable<dynamic>)
            {
                details.id = "ARRAY_LIST";
                details.type = "Array";

                List<dynamic> list = new List<dynamic>(dyn);
                List<TreeNode> nodes = new List<TreeNode>();
                foreach(var i in list)
                {
                    nodes.Add(parseDynamic(i, null));
                }

                if(list.Count == 0)
                {
                    details.value = "Empty List";
                }
                else
                {
                    details.value = list.Count == 1 ? "Contains " + list.Count + " Entry" : "Contains " + list.Count + " Entries";
                }
                node = new TreeNode(name != null ? name : "Array", nodes.ToArray());
            }else if(dyn is IDictionary<String, dynamic>)
            {
                details.id = "DICTIONARY";
                details.type = "Dictionary";

                Dictionary<String, dynamic> dic = new Dictionary<String, dynamic>(dyn);
                List<TreeNode> nodes = new List<TreeNode>();
                foreach(var i in dic)
                {
                    nodes.Add(parseDynamic(i.Value, i.Key));
                }

                if (dic.Count == 0)
                {
                    details.value = "Empty Dictionary";
                }
                else
                {
                    details.value = dic.Count == 1 ? "Contains " + dic.Count + " Entry" : "Contains " + dic.Count + " Entries";
                }
                node = new TreeNode(name != null ? name : "Dictionary", nodes.ToArray());
            }
            else
            {
                details.id = "ERROR";
                details.type = "Error";
                details.value = "ERRORED";
                node = new TreeNode(name != null ? name : "Error!");
            }

            node.Tag = details;
            return node;
        }

        #endregion

        #region Types

        public class NodeDetails
        {
            public String id { get; internal set; }
            public String type { get; set; }
            public dynamic value { get; set; }

            public NodeDetails()
            {
            }

            public NodeDetails(String id, dynamic value)
            {
                this.id = id;
                this.value = value;
            }

        }

        #endregion
    }
}
