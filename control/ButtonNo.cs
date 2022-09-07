using David;

class ButtonNo : System.Windows.Forms.Button{

    public ButtonNo(){
        this.Text = "No";
        this.Size = new System.Drawing.Size(100, 100);
        this.Location = new System.Drawing.Point(240, 20);
        this.Click += new System.EventHandler(click);
    }

    public void click(object? sender, EventArgs e){
        Random random = new System.Random();
        Point point = new System.Drawing.Point();
        point.X = random.Next(this.Location.X / 2, David.Program.instance.Width);
        point.Y = random.Next(this.Location.Y / 2, David.Program.instance.Height);
        this.Location = point;
    }
    

}
