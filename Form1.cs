namespace WindowsFormApp
{
    using System.Drawing;
    using System.Windows.Forms;

public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.OrangeRed;

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;

            Label lblFirstName = new Label();
            lblFirstName.Text = "Enter your Name :";
            lblFirstName.Location = new Point(40, 100);
            lblFirstName.Size = new Size(200, 40);
            lblFirstName.BackColor = Color.LightBlue;
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Font = new Font("Arial", 12);
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter;
            

            TextBox tbxData = new TextBox();
            tbxData.Location = new Point(300, 100);
            tbxData.Size = new Size(200, 100);
            tbxData.BackColor = Color.WhiteSmoke;
            tbxData.ForeColor = Color.Black;
            tbxData.Font = new Font("Arial", 12);

            Button btnClick = new Button();
            btnClick.Text = "Submit";
            btnClick.Location = new Point(300, 150);
            btnClick.Size = new Size(125, 40);
            btnClick.BackColor = Color.WhiteSmoke;
            btnClick.ForeColor = Color.Black;
            btnClick.Font = new Font("Arial", 12);

            
            this.Controls.Add(lblFirstName);
            this.Controls.Add(tbxData);
            this.Controls.Add(btnClick);
        }
    }
}
