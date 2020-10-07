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
        CheckBox box_lbl, box_btn;
        PictureBox picture;
        TabControl tabControl;
        public Form1()
        {
            this.Height = 850;
            this.Width = 1000;
            this.Text = "Primer";
            this.BackColor = Color.FromArgb(240, 230, 140);
            tree = new TreeView();
            tree.Dock = DockStyle.Right;
            tree.AfterSelect += Tree_AfterSelect;
            TreeNode tn = new TreeNode("Elementid");
            tn.Nodes.Add(new TreeNode("Nupp-Button"));
            tn.Nodes.Add(new TreeNode("Silt-Label"));
            tn.Nodes.Add(new TreeNode("Märkeruut-CheckBox"));
            tn.Nodes.Add(new TreeNode("Pildikast-PictureBox"));
            tn.Nodes.Add(new TreeNode("Kaart-TabControl"));
            //Nupp
            btn = new Button();
            btn.Text = "Vajuta siia";
            btn.Location = new Point(200, 300);
            btn.Height = 100;
            btn.Width = 200;
            btn.Click += Btn_Click;
            //Label
            lbl = new Label();
            lbl.Text = "Tarkvara arendajad";
            lbl.Size = new Size(150, 30);
            lbl.Location = new Point(150, 200);


            tree.Nodes.Add(tn);
            this.Controls.Add(tree);
        }

        private void Tree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Text == "Nupp-Button")
            {
                this.Controls.Add(btn);
                btn.BackColor = Color.FromArgb(224, 255, 255);
            }
            else if (e.Node.Text == "Silt-Label")
            {
                
                this.Controls.Add(lbl);
            }
            else if (e.Node.Text == "Märkeruut-CheckBox")
            {
                box_btn = new CheckBox();
                box_btn.Text = "Näita nupp";
                box_btn.Location = new Point(200, 30);
                this.Controls.Add(box_btn);
                box_lbl = new CheckBox();
                box_lbl.Text = "Näita silt";
                box_lbl.Location = new Point(200, 90);
                this.Controls.Add(box_lbl);
                box_btn.CheckedChanged += Box_btn_CheckedChanged;
                box_lbl.CheckedChanged += Box_lbl_CheckedChanged;
            }
            else if(e.Node.Text == "Pildikast-PictureBox"){
                picture = new PictureBox();
                picture.Image = new Bitmap("davish.png");
                picture.Location = new Point(500,50);
                picture.Size = new Size(250, 250);
                picture.SizeMode = PictureBoxSizeMode.Normal;
                picture.BorderStyle = BorderStyle.Fixed3D;
                this.Controls.Add(picture);
            }
            else if(e.Node.Text== "Kaart-TabControl"){
                tabControl = new TabControl();
                tabControl.Location = new Point(550, 450);
                tabControl.Size = new Size(200, 100);
                TabPage page1, page2, page3;
                page1 = new TabPage("First");
                page2 = new TabPage("Second");
                page3 = new TabPage("Third");
                tabControl.Controls.Add(page1);
                tabControl.Controls.Add(page2);
                tabControl.Controls.Add(page3);
                this.Controls.Add(tabControl);
            }
        }

        private void Box_lbl_CheckedChanged(object sender, EventArgs e) // Позволяет появится Label  при "галочки". Убёрем галочку, то оно тоже продает.
        {
            if(box_lbl.Checked== true)
            {
                this.Controls.Add(lbl);
            }
            else
            {
                this.Controls.Remove(lbl);
            }
        }

        private void Box_btn_CheckedChanged(object sender, EventArgs e) // Позволяет появится Button  при "галочки". Убёрем галочку, то оно тоже продает.
        {
            if (box_btn.Checked == true)
            {
                this.Controls.Add(btn);
            }
            else
            {
                this.Controls.Remove(btn);
            }
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
