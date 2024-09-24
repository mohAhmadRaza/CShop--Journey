namespace WindowsFormApp
{
    using System.Drawing;
    using System.Windows.Forms;

public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.LightYellow;

            this.MinimizeBox = false;
            this.MaximizeBox = false;

            this.StartPosition = FormStartPosition.CenterScreen;
            
            Label lblFirstName = new Label();
            lblFirstName.Text = "My Calculator Application";
            lblFirstName.Location = new Point(100, 10);
            lblFirstName.Size = new Size(500, 50);
            lblFirstName.BackColor = Color.LightYellow;
            lblFirstName.ForeColor = Color.Black;
            lblFirstName.Font = new Font("Cooper std", 24, FontStyle.Bold);
            lblFirstName.TextAlign = ContentAlignment.MiddleCenter; // Center the text


            TextBox txtFirst = new TextBox();
            txtFirst.Location = new Point(200, 100); // Correctly sets the position for txtFirst
            txtFirst.Size = new Size(100, 100);
            txtFirst.BackColor = Color.Black;
            txtFirst.ForeColor = Color.White;

            TextBox txtSecond = new TextBox();
            txtSecond.Location = new Point(400, 100); // Correctly sets the position for txtSecond
            txtSecond.Size = new Size(100, 100);
            txtSecond.BackColor = Color.Black;
            txtSecond.ForeColor = Color.White;

            

            // tbxData = new TextBox();
            // tbxData.Location = new Point(300, 100);
            // tbxData.Size = new Size(200, 200);
            // tbxData.BackColor = Color.WhiteSmoke;
            // tbxData.ForeColor = Color.Black;
            // tbxData.Font = new Font("Arial", 12);

            // Button btnClick = new Button();
            // btnClick.Text = "Submit";
            // btnClick.Location = new Point(300, 150);
            // btnClick.Size = new Size(125, 40);
            // btnClick.BackColor = Color.WhiteSmoke;
            // btnClick.ForeColor = Color.Black;
            // btnClick.Font = new Font("Arial", 12);


            this.Controls.Add(lblFirstName);
            this.Controls.Add(txtFirst);
            this.Controls.Add(txtSecond);
        }

    }
}
