namespace WinForms_C__LESSON_1._1
{
    public partial class Form1 : Form
    {

        private Point startPoint;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.MouseDown += Form1_MouseDown;

            this.MouseUp += From1_MouseUp;

            
        }


        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                startPoint = e.Location;
            }


        }

        private void From1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && startPoint != Point.Empty)
            {
               


                if (Math.Abs(startPoint.X - e.X) > 9 && Math.Abs(startPoint.Y - e.Y)>9) {
                    Label dynamicLabel;

                    dynamicLabel = new Label();
                    dynamicLabel.BorderStyle = BorderStyle.FixedSingle;

                    dynamicLabel.Click += (object sender, EventArgs e) =>
                    {
                        dynamicLabel.Text = Random.Shared.Next(1000).ToString();
                    };

                    dynamicLabel.DoubleClick += (object sender, EventArgs e) =>
                    {
                        dynamicLabel.Dispose();
                    };


                    dynamicLabel.Font = new Font("Arial", 12);




                    dynamicLabel.Location = new Point(Math.Min(startPoint.X, e.X), Math.Min(startPoint.Y, e.Y));
                    dynamicLabel.Size = new Size(Math.Abs(startPoint.X - e.X), Math.Abs(startPoint.Y - e.Y));
                    this.Controls.Add(dynamicLabel);
                }
            }

        }


       

    }
}