using David;

class ButtonYes : System.Windows.Forms.Button{

    public ButtonYes(){
        this.Text = "Si";
        this.Size = new Size(100, 100);
        this.Location = new Point(110, 20);
        this.Click += new System.EventHandler(click);
    }

    public void click(object? sender, EventArgs e){
        MessageBox.Show("jaja que gay", "jaja que gay", MessageBoxButtons.OK, MessageBoxIcon.Information);
        David.Program.instance.Close();
    }

}
