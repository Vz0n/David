namespace David;

partial class David{

    private void InitializeComponent(){
        this.ClientSize = new System.Drawing.Size(800, 600);
        this.Font = new Font(FontFamily.GenericMonospace, 13);
        this.Text = "David, ¿Eres gay? ";
    }

    public void CreateComponent(){
        this.Controls.Add(new ButtonYes());
        this.Controls.Add(new ButtonNo());
    }

}
