using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static WindowsFormsApp1.DFS;


namespace WindowsFormsApp1
{
    public partial class game : Form
    {
        public game()
        {
            InitializeComponent();
        }

        private void wolf_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            //if wolf,goat on the Boat 
            if (wolf.Location == new Point(807, 417)&& cabbage.Location == new Point(939, 429)) { wolf.Location = new Point(1074, 417); }
            if (goat.Location == new Point(805, 417) && cabbage.Location == new Point(939, 429)) { goat.Location = new Point(994, 417); }
            if (goat.Location == new Point(276, 417) && cabbage.Location == new Point(37, 429)) { goat.Location = new Point(92, 417); }
            if (wolf.Location == new Point(276, 417) && cabbage.Location == new Point(37, 429)) { wolf.Location = new Point(172, 417); }
            // move cabbage into aBoat from side
            if (cabbage.Location == new Point(939, 429) && ship.Location == new Point(733, 467) && farmer.Location == new Point(733, 351)) { cabbage.Location = new Point(832, 429); }
            //// move cabbage from aBoat into  side
            else if (cabbage.Location == new Point(832, 429) && ship.Location == new Point(733, 467) && farmer.Location == new Point(733, 351)) { cabbage.Location = new Point(939, 429); }
            // move cabbage into side from aBoat
            else if (farmer.Location == new Point(376, 351) && ship.Location == new Point(276, 467) && cabbage.Location == new Point(276, 429)) { cabbage.Location = new Point(37, 429); }
            //// move cabbage side aBoat into  aBoat
            else if (farmer.Location == new Point(376, 351) && ship.Location == new Point(276, 467) && cabbage.Location == new Point(37, 429)) { cabbage.Location = new Point(276, 429); }
            goal();
            
        }  
        
        public void goal()
        {
            if(goat.Location == new Point(92, 417) && cabbage.Location == new Point(37, 429)&& wolf.Location == new Point(172, 417))
            {
                
                label1.Text = "Well done ";
                if(label1.Location ==new Point(838, 23)) { label1.Location = new Point(529, 213); }
                if (label3.Location == new Point(208, 138)) { label3.Location = new Point(566, 263); }
                label1.Visible = true;
                label3.Text = "Replay ";
                label3.Visible = true;
                goat.Hide();
                wolf.Hide();
                cabbage.Hide();
                farmer.Hide();
                ship.Hide();

            }
            if(goat.Location==new Point(994, 417)&&cabbage.Location==new Point(939, 429)&& wolf.Location != new Point(1074, 417)&& ship.Location != new Point(733, 467))
            {
               
                label2.Text = "Game over ";
                if (label2.Location == new Point(160, 25)) { label2.Location = new Point(529, 213); }
                if (label3.Location == new Point(208, 138)) { label3.Location = new Point(566, 263); }
                label2.Visible = true;
                label3.Text = "Replay ";
                label3.Visible = true;
                goat.Hide();
                wolf.Hide();
                cabbage.Hide();
                farmer.Hide();
                ship.Hide();

            }
            if (goat.Location == new Point(994, 417) && wolf.Location == new Point(1074, 417) && cabbage.Location != new Point(939, 429) && ship.Location != new Point(733, 467))
            {

                label2.Text = "Game over ";
                if (label2.Location == new Point(160, 25)) { label2.Location = new Point(529, 213); }
                if (label3.Location == new Point(208, 138)) { label3.Location = new Point(566, 263); }
                label2.Visible = true;
                label3.Text = "Replay ";
                label3.Visible = true;
                goat.Hide();
                wolf.Hide();
                cabbage.Hide();
                farmer.Hide();
                ship.Hide();

            }
            if (goat.Location == new Point(92, 417) && cabbage.Location == new Point(37, 429) && wolf.Location != new Point(172, 417) && ship.Location != new Point(276, 467))
            {

                label2.Text = "Game over ";
                if (label2.Location == new Point(160, 25)) { label2.Location = new Point(529, 213); }
                if (label3.Location == new Point(208, 138)) { label3.Location = new Point(566, 263); }
                label2.Visible = true;
                label3.Text = "Replay ";
                label3.Visible = true;
                goat.Hide();
                wolf.Hide();
                cabbage.Hide();
                farmer.Hide();
                ship.Hide();

            }
            if (goat.Location == new Point(92, 417) && wolf.Location == new Point(172, 417) && cabbage.Location != new Point(37, 429) && ship.Location != new Point(276, 467))
            {

                label2.Text = "Game over ";
                if (label2.Location == new Point(160, 25)) { label2.Location = new Point(529, 213); }
                if (label3.Location == new Point(208, 138)) { label3.Location = new Point(566, 263); }
                label2.Visible = true;
                label3.Text = "Replay ";
                label3.Visible = true;
                goat.Hide();
                wolf.Hide();
                cabbage.Hide();
                farmer.Hide();
                ship.Hide();


            }



        } 
        private void pictureBox7_Click(object sender, EventArgs e)
        {
            //if cabbage,goat on the Boat
            if (goat.Location == new Point(805, 417)&&wolf.Location==new Point(1074, 417)) { goat.Location = new Point(994, 417); }
            if (cabbage.Location == new Point(832, 429) && wolf.Location == new Point(1074, 417)) { cabbage.Location = new Point(939, 429); }
            if (goat.Location == new Point(276, 417) && wolf.Location == new Point(172, 417)) { goat.Location = new Point(92, 417); }
            if (cabbage.Location == new Point(276, 429) && wolf.Location == new Point(172, 417)) { cabbage.Location = new Point(37, 429); }
            // move wolf into aBoat from side
            if (wolf.Location == new Point(1074, 417) && ship.Location == new Point(733, 467) && farmer.Location == new Point(733, 351)) { wolf.Location = new Point(807, 417); }
            //// move wolf from aBoat into  side
            else if (wolf.Location == new Point(807, 417) && ship.Location == new Point(733, 467) && farmer.Location == new Point(733, 351)) { wolf.Location = new Point(1074, 417); }
            // move wolf into side from aBoat
            else if (farmer.Location == new Point(376, 351)&& ship.Location == new Point(276, 467)&& wolf.Location == new Point(276, 417)) { wolf.Location = new Point(172, 417); }
            //// move wolf side aBoat into  aBoat
            else if (farmer.Location==new Point(376, 351)&& ship.Location==new Point(276, 467)&&wolf.Location==new Point(172, 417)) { wolf.Location = new Point(276, 417); }
            goal();
            
        }


        private void ship_move_Click(object sender, EventArgs e)
        {
            //go to another side
            //ship is empty
            if (farmer.Location == new Point(733, 351) && ship.Location == new Point(733, 467) && cabbage.Location != new Point(832, 429) && wolf.Location != new Point(807, 417) && goat.Location != new Point(805, 417)) { farmer.Location = new Point(376, 351);  ship.Location = new Point(276, 467); }
            //cabbage in ship 
            else if (farmer.Location == new Point(733, 351) && ship.Location == new Point(733, 467) && cabbage.Location == new Point(832, 429)) { farmer.Location = new Point(376, 351);  ship.Location = new Point(276, 467);  cabbage.Location = new Point(276, 429); }
            //wolf in ship
            else if (farmer.Location == new Point(733, 351) && ship.Location == new Point(733, 467) && wolf.Location == new Point(807, 417)) { farmer.Location = new Point(376, 351);  ship.Location = new Point(276, 467);  wolf.Location = new Point(276, 417); }
            //goat in ship
            else if (farmer.Location == new Point(733, 351) && ship.Location == new Point(733, 467) && goat.Location == new Point(805, 417)) { farmer.Location = new Point(376, 351);  ship.Location = new Point(276, 467);  goat.Location = new Point(276, 417); }
            //back to start
            else if (farmer.Location == new Point(376, 351) && ship.Location == new Point(276, 467) && cabbage.Location != new Point(276, 429) && wolf.Location != new Point(276, 417) && goat.Location != new Point(276, 417)) { farmer.Location = new Point(733, 351); ship.Location = new Point(733, 467); }
            //cabbage in ship 
            else if (farmer.Location == new Point(376, 351) && ship.Location == new Point(276, 467) && cabbage.Location == new Point(276, 429)) { farmer.Location = new Point(733, 351); ship.Location = new Point(733, 467); cabbage.Location = new Point(832, 429); }
            //wolf in ship
            else if (farmer.Location == new Point(376, 351) && ship.Location == new Point(276, 467) && wolf.Location == new Point(276, 417)) { farmer.Location = new Point(733, 351); ship.Location = new Point(733, 467); wolf.Location = new Point(807, 417); }
            //goat in ship
            else if (farmer.Location == new Point(376, 351) && ship.Location == new Point(276, 467) && goat.Location == new Point(276, 417)) { farmer.Location = new Point(733, 351); ship.Location = new Point(733, 467); goat.Location = new Point(805, 417); }
            goal();
            

        }

        private void goat_move_Click(object sender, EventArgs e)
        {
            //if cabbage,wolf on the Boat
            if (cabbage.Location == new Point(832, 429)&& goat.Location == new Point(994, 417)) { cabbage.Location = new Point(939, 429); }
            if (wolf.Location == new Point(807, 417) && goat.Location == new Point(994, 417)) { wolf.Location = new Point(1074, 417); }
            if (cabbage.Location == new Point(276, 429) && goat.Location == new Point(92, 417)) { cabbage.Location = new Point(37, 429); }
            if (wolf.Location == new Point(276, 417) && goat.Location == new Point(92, 417)) { wolf.Location = new Point(172, 417); }
            // move wolf into aBoat from side
            if (goat.Location == new Point(994, 417) && ship.Location == new Point(733, 467)&& farmer.Location == new Point(733, 351)) { goat.Location = new Point(805, 417); }
            //// move wolf from aBoat into  side
            else if (goat.Location == new Point(805, 417) && ship.Location == new Point(733, 467) && farmer.Location == new Point(733, 351)) { goat.Location = new Point(994, 417); }
            // move wolf into side from aBoat
            else if (farmer.Location == new Point(376, 351)&& ship.Location == new Point(276, 467)&& goat.Location == new Point(276, 417)) { goat.Location = new Point(92, 417); }
            //// move wolf side aBoat into  aBoat
            else if (farmer.Location == new Point(376, 351) && ship.Location == new Point(276, 467) &&goat.Location==new Point(92, 417)) { goat.Location = new Point(276, 417); }
            goal();
            
        }
        
        private void goat_Click(object sender, EventArgs e)
        {

        }

        private void wolf_Click(object sender, EventArgs e)
        {

        }

        private void cabbage_Click(object sender, EventArgs e)
        {

        }

        private void ship_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
            cabbage.Location = new Point(939, 429);
            goat.Location = new Point(994, 417);
            wolf.Location = new Point(1074, 417);
            farmer.Location = new Point(733, 351);
            ship.Location = new Point(733, 467);

            label1.Visible = false;
            label1.Text = ".....";
            label2.Visible = false;
            label2.Text = ".....";
            label3.Visible = false;
            label3.Text = ".....";

            goat.Show();
            wolf.Show();
            cabbage.Show();
            farmer.Show();
            ship.Show();
        }

        private void SolveButton_Click(object sender, EventArgs e)
        {
            var initialState = new State(
                wolf.Location,
                goat.Location,
                cabbage.Location,
                farmer.Location,
                true);
            var solver = new GameSolver.Solver();
            bool solved = solver.Solve(initialState);


            if (solved)
            {
                var solution = solver.GetSolution();
                MessageBox.Show("Solution found!");
                // Do something with the solution, e.g. display it in a textbox
            }
            else
            {
                MessageBox.Show("No solution found.");
            }
        }

    }
}
