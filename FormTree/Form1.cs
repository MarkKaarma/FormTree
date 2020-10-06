using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormTree
{
    public partial class Form1 : Form
    {
        TreeView tree;
        Button btn;
        Label lbl;
        CheckBox box_lbl,box_btn;
        public Form1()
        {
            this.Height = 850;
            this.Width = 1000;
            this.Text = "Primer";
            tree = new TreeView();
            tree.Dock = DockStyle.Left;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elementid");
            tn.Nodes.Add(new TreeNode("Nupp-Button"));
            tn.Nodes.Add(new TreeNode("Silt-Label"));
            tn.Nodes.Add(new TreeNode("Märkeruut-CheckBox"));

            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Nupp-Button")
            {
                btn = new Button();
                btn.Text = "Vajuta siia";
                btn.Location = new Point(200, 300);
                btn.Height = 100;
                btn.Width = 200;
                btn.Click += Btn_Click;
                this.Controls.Add(btn);
            }
            else if (e.Node.Text == "Silt-Label")
            {
                lbl = new Label();
                lbl.Text = "Tarkvara arendajad";
                lbl.Size = new Size(150, 30);
                lbl.Location = new Point(150, 200);
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "Märkeruut-CheckBox")
            {
                box_btn = new CheckBox();
                box_btn.Text = "Näita nupp";
                box_btn.Location = new Point(200, 30);
                this.Controls.Add(box_btn);
                box_lbl = new CheckBox();
                box_lbl.Text = "Näita nuppi";
                box_lbl.Location = new Point(200, 90);
                this.Controls.Add(box_lbl);
                box_btn.CheckedChanged += Box_btn_CheckedChanged;
            }
        }

        private void Box_btn_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        public void Btn_Click(object sender, EventArgs e)
        {
            if(btn.BackColor==Color.Blue)
            {
                btn.BackColor = Color.Green;
                lbl.BackColor = Color.Red;
                lbl.ForeColor = Color.Aqua;
            } 
            else
            {
                btn.BackColor = Color.Blue;
                lbl.BackColor = Color.White;
                lbl.ForeColor = Color.Lime;
            }
        }
    }
}
