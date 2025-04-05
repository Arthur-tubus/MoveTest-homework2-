namespace hw2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //file with coordinates
        private const string SaveFile = "positions.txt";

        int score = 0;//account to change the text
        string[] ask = new string[3] { "What is the capital of France??", "What year is the beginning of World War II??", "How many planets are there in the solar system??" };//question
        string[] correct = new string[3] { "Paris", "1939", "9" };//correct answers
        int score_ask = 0;//question number account
        int score_correct = 0;//number of correct answers

       

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text != "Вийти")
            {
                label3.Visible = true;
                label3.Text = 3 + "/" + score_correct;


                //the location of the question
                if (score == 0)
                {

                    label1.Location = new Point(214, 93);
                    label1.Text = ask[score_ask];
                }
                else if (score == 2)
                {
                    label1.Location = new Point(104, 93);
                    label1.Text = ask[score_ask];
                }
                else if (score == 4)
                {
                    label1.Location = new Point(134, 93);
                    label1.Text = ask[score_ask];
                }






                //checking correct answers
                bool audit = string.Equals(correct[0], textBox1.Text, StringComparison.OrdinalIgnoreCase);
                if (audit == true & score == 1)
                {
                    score_correct += 1;
                    label2.Text = correct[score_ask];
                    label2.ForeColor = Color.Green;
                }
                else if (score == 3 & textBox1.Text == correct[score_ask])
                {
                    score_correct += 1;
                    label2.ForeColor = Color.Green;
                    label2.Text = correct[score_ask];
                }
                else if (score == 5 & textBox1.Text == correct[score_ask])
                {
                    score_correct += 1;
                    label2.Text = correct[score_ask];
                    label2.ForeColor = Color.Green;
                }
                else
                {
                    label2.Text = correct[score_ask];
                    label2.ForeColor = Color.Red;
                }

                //interface changes during operation
                textBox1.Visible = true;
                button1.Text = "перевірити";
                if (score % 2 == 1)
                {
                    button1.Text = "наступне";
                    textBox1.Visible = false;
                    label2.Visible = true;

                    score_ask += 1;
                    if (score == 5)
                    {
                        score_ask = 0;
                        button1.Text = "завершити";

                    }
                }
                else
                {
                    textBox1.Visible = true;
                    label2.Visible = false;


                }



                if (score == 6)
                {
                    button2.Visible = true;
                    button1.Location = new Point(222, 251);
                    button2.Location = new Point(385, 251);
                    textBox1.Visible = false;
                    label1.Text = "Кінець тесту";
                    label1.Location = new Point(255, 112);
                    button1.Text = "Вийти";
                }

                score += 1;
                textBox1.Text = string.Empty;
            }
            else
            {

                var res = MessageBox.Show(label4.Text, "Заголовок", MessageBoxButtons.YesNo,
                MessageBoxIcon.Information);
                if (res == DialogResult.Yes)
                {
                    Application.Exit();
                }

            }
            b = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {//reboot

            score = 0;
            score_correct = 0;
            score_ask = 0;
            button1.Text = "Почати";
            label1.Text = "Tecт";
            label1.Location = new Point(318, 100);

            button1.Location = new Point(296, 251);
            button2.Visible = false;
        }

        //_________________________________________

        private bool isDragging = true;
        private Point offset;

        int a = 0;
        bool b = false;
        private Control activeControl = null;
        // functions of movement of elements
        //             елемент 1
        private void label3_Click(object sender, EventArgs e)
        {
            b = true;
        }
        private void label3_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & a % 2 == 1) // Make sure the left mouse button is pressed
            {
                activeControl = sender as Control; // Remembering the element that is moving
                isDragging = true; // Let's start dragging
                offset = e.Location; // Fix the cursor displacement relative to the element
                Cursor = Cursors.Hand;
            }
        }

        private void label3_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && activeControl != null) // Check if drag and drop is active
            {
                // Update its coordinates
                activeControl.Location = this.PointToClient(Cursor.Position - new Size(offset)); 
            }
        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & b == true)
            {
                isDragging = false;
                activeControl = null;
                a += 1;
                Cursor = Cursors.Default;
            }
        }


        //                  element 2
        private void button2_MouseClick(object sender, MouseEventArgs e)
        {

            b = true;

        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & a % 2 == 1) 
            {
                activeControl = sender as Control;
                isDragging = true; 
                offset = e.Location; 
                Cursor = Cursors.Hand;
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && activeControl != null) 
            {
                activeControl.Location = this.PointToClient(Cursor.Position - new Size(offset)); 
            }
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & b == true)
            {
                isDragging = false;
                activeControl = null;
                a += 1;
                Cursor = Cursors.Default;
            }
        }
        //                  element 3
        private void label2_Click(object sender, EventArgs e)
        {
            b = true;
        }

        private void label2_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & a % 2 == 1) 
            {
                activeControl = sender as Control; 
                isDragging = true;
                offset = e.Location; 
                Cursor = Cursors.Hand;
            }
        }

        private void label2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && activeControl != null)
            {
                activeControl.Location = this.PointToClient(Cursor.Position - new Size(offset)); 
            }

        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & b == true)
            {
                isDragging = false;
                activeControl = null;
                a += 1;
                Cursor = Cursors.Default;

            }
        }
        //                  element 4
        private void textBox1_Click(object sender, EventArgs e)
        {
            b = true;

        }

        private void textBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & a % 2 == 1) 
            {
                activeControl = sender as Control; 
                isDragging = true; 
                offset = e.Location; 
                
                Cursor = Cursors.Hand;
            }
        }

        private void textBox1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && activeControl != null) 
            {
                activeControl.Location = this.PointToClient(Cursor.Position - new Size(offset)); 
            }
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & b == true)
            {
                isDragging = false;
                activeControl = null;
                a += 1;
                Cursor = Cursors.Default;

            }
        }
        //                  element 5
        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & a % 2 == 1)
            {
                activeControl = sender as Control; 
                isDragging = true; 
                offset = e.Location; 
                Cursor = Cursors.Hand;
            }
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && activeControl != null) 
            {
                activeControl.Location = this.PointToClient(Cursor.Position - new Size(offset));
            }
        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & b == true)
            {
                isDragging = false;
                activeControl = null;
                a += 1;
                Cursor = Cursors.Default;

            }
        }
        //                  element 6
        private void label1_Click(object sender, EventArgs e)
        {
            b = true;
        }

        private void label1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & a % 2 == 1) 
            {
                activeControl = sender as Control; 
                isDragging = true; 
                offset = e.Location;
                Cursor = Cursors.Hand;
            }
        }

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging && activeControl != null) 
            {
                activeControl.Location = this.PointToClient(Cursor.Position - new Size(offset));
            }
        }

        private void label1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right & b == true)
            {
                isDragging = false;
                activeControl = null;
                a += 1;
                Cursor = Cursors.Default;

            }
        }

        //method for saving coordinates
        private void SavePositions()
        {
            using (StreamWriter writer = new StreamWriter(SaveFile))
            {
                writer.WriteLine($"{label1.Location.X},{label1.Location.Y}");
                //writer.WriteLine($"{button1.Location.X},{button1.Location.Y}");
                //writer.WriteLine($"{textBox1.Location.X},{textBox1.Location.Y}");
                //writer.WriteLine($"{label2.Location.X},{label2.Location.Y}");
                //writer.WriteLine($"{label3.Location.X},{label3.Location.Y}");
                //writer.WriteLine($"{button2.Location.X},{button2.Location.Y}");


            }
        }
        private Point ParsePoint(string line)
        {
            string[] parts = line.Split(',');
            return new Point(int.Parse(parts[0]), int.Parse(parts[1]));
        }
    }
}
