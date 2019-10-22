using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        string[] v = new string[27];
        Random rnd = new Random();
        string[] a = new string[27];
        string[] b = new string[27];
        string[] c = new string[27];
        int[] viz = new int[27];
        int i, m,s;
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            v[1] = "What is the tendency of a car with rear-wheel drive if you accelerate too strongly in the curve?";
            a[1]= "The car follows, without deviation, the steering wheel race";
            b[1]= "The car tends to slide backwards out of the curve"; //CORRECT
            c[1]= "The front wheels turn empty";
            v[2] = "What obligations does the driver have when driving on public roads?";
            a[2]= "To circulate only if monthly medical check-up is performed";
            b[2] = "To circulate only on the road sectors to which access is allowed and to comply with the rules regarding the maximum authorized total masses admitted by the competent authority";//CORRECT
            c[2] = "To inform, in time, the road administrators, with the possible maximum and minimum speed limits";
            v[3] = "What is meant by the ecological driving of a vehicle?";
            a[3] = "The obligation to permanently use biodegradable fuel";
            b[3] = "Urban trips by bicycle, on foot or by other means that do not pollute the atmosphere";
            c[3] = "A set of behavioral measures, control or verification of the vehicle, through which an important energy saving and environmental protection is achieved";// CORRECT
            v[4] = "In wounds with hemorrhage, it will be considered, in the initial phase:";
            a[4] = "Wound cleaning and dressing";
            b[4] = "Wound dressing";
            c[4] = "Stopping bleeding";//   CORRECT
            v[5] = "At the signal of a policeman located in an intersection, with his arm raised vertically, you have the obligation:";
            a[5] = "To move with maximum caution";
            b[5] = "Slow down";
            c[5] = "Stop, no matter what direction you are traveling";// CORRECT
            v[6] = "What is the difference between stopping and stationary?";
            a[6] = "None";
            b[6] = "The difference is the duration of immobilization of the vehicle";// CORRECT
            c[6] = "The difference is in the way of placing and securing the vehicle on the road";
            v[7] = "What obligations come back to the signal of the railway agent from the level crossings, executed with a red light device or with the fluorescent-reflecting stick?";
            a[7] = "Reduce speed only until you cross the railway";
            b[7] = "Stop the vehicle";// CORRECT
            c[7] = "Slow down and stop only if a rail vehicle is running";
            v[8] = "When approaching the stations provided with the alveola, when you are traveling on the lane next to the approach, and the driver of the public transport vehicle for persons signals the departure from the station:";
            a[8] = "Stop compulsory";
            b[8] = "Reduce speed and, if necessary, stop";// CORRECT
            c[8] = "Increase speed";
            v[9] = "On a three lane highway, traffic was blocked. Where will the intervention vehicles travel?";
            a[9] = "On the emergency band";// CORRECT
            b[9] = "Between the left band and the middle band";
            c[9] = "Between the right band and the middle band";
            v[10] = "Which roads are allowed to stop and park vehicles on the left side, in the direction of travel?";
            a[10] = "On roads with low traffic";
            b[10] = "On one-way roads, if at least one lane remains free";// CORRECT
            c[10] = "On any road";
            v[11] = "How should you proceed when you arrive behind a tram stop in a pedestrian-free station?";
            a[11] = "Stop next to the last door";
            b[11] = "To stop behind it and resume your journey only after the tram doors have been closed";// CORRECT
            c[11] = "Stop at a distance of 25m tram";
            v[12] = "Is it advisable to keep or store certain items on the floor of the vehicle?";
            a[12] = "Yes, as long as they do not hinder us in operating the vehicle controls";
            b[12] = "Yes, if there is no other place to place small objects";
            c[12] = "No, because there is the possibility of rolling these objects, which can reach under pedals and create dangerous situations";// CORRECT
            v[13] = "How is the first aid granted in the case of cut wounds?";
            a[13] = "Cover the wound and stop the bleeding, then transport the injured to the doctor or hospital";// CORRECT
            b[13] = "Stop bleeding by sewing the wound";
            c[13] = "Carry the wound to the doctor, without doing anything else";
            v[14] = "What are the obligations of the driver of a motor vehicle traveling in the border area?";
            a[14] = "Immediately stop the vehicle at the regulatory signals of the border guards in the area of ​​competence";// CORRECT
            b[14] = "To reduce the speed below the legal limit";
            c[14] = "To circulate with the meeting phase in operation, because it is in the border area";
            v[15] = "When encountering a heavy vehicle with a light one, on a narrow public road, to make the crossing possible it will maneuver with the rear:";
            a[15] = "The light vehicle";// CORRECT
            b[15] = "The heavy vehicle";
            c[15] = "At free will";
            v[16] = "What is the significance of the longitudinal marking applied in the form of a continuous line on the axis of public roads?";
            a[16] = "Helps drivers orient themselves at night";
            b[16] = "Does not allow its violation by the drivers of vehicles";// CORRECT
            c[16] = "Allows the vehicles to pass";
            v[17] = "You have injured a pedestrian crossing the irregular road. What legal obligations do you have?";
            a[17] = "Immediately notify the police, do not modify or delete the accident and remain in place";// CORRECT
            b[17] = "Present yourself urgently to the nearest police station";
            c[17] = "Because the guilt does not belong to you, you can continue the road if the accident is not serious";
            v[18] = "How does the driver proceed when, when approaching a level crossing with the railway without barriers, the red lights next to the attention indicator on the cross turn on and off alternatively?";
            a[18] = "It reduces the speed and stops only when the train is approaching";
            b[18] = "Stop the vehicle without passing the indicator";// CORRECT
            c[18] = "It reduces speed and, after being assured, continues its movement";
            v[19] = "Until the victim is transported to the hospital, the waiting position can be:";
            a[19] = "A position as comfortable as possible";
            b[19] = "A position that allows a good breath";// CORRECT
            c[19] = "A convenient position for transportt";
            v[20] = "How does the driver of the vehicle proceed when, being in a commune, in the immediate vicinity of a pedestrian crossing marked as such, he intends to overtake a moving vehicle?";
            a[20] = "Execute the speeding with slow speed";
            b[20] = "Do not overtake";// CORRECT
            c[20] = "Execute the speed with high speed";
            v[21] = "What obligations do you have for the signals of the railway agents, placed at the level crossing with a railway?";
            a[21] = "No obligation, because the railway agents direct the train linings";
            b[21] = "To conform to the significance of their signals";//CORRECT
            c[21] = "Slow down, make sure, and if the train is not moving, you can continue crossing the railway carefully.";
            v[22] = "What is meant by the distance of 100 m to signal the change of direction of walking outside the locality?";
            a[22] = "Distance from the rear-wheel drive vehicle";
            b[22] = "The distance traveled from the moment of signaling the intention to perform the maneuver and the place where the change of direction of walking occurs";//CORRECT
            c[22] = "Distance from the place of finishing the overtaking maneuver";
            v[23] = "In which of the following situations is the driver of a motor vehicle obliged to use the meeting or road lights?";
            a[23] = "In the case of poorly illuminated circulation arteries, when visibility is reduced, in walking, both in localities and outside them";//CORRECT
            b[23] = "In the case of parking at night on the road side of the national roads or in the case of parking the vehicle in specially arranged, but not illuminated places";
            c[23] = "During daytime on national roads, in situations where traffic is overcrowded";
            v[24] = "What indicates the greater effort made when operating the brake pedal?";
            a[24] = "Bending of the receiving cylinders and pistons"; //CORRECT
            b[24] = "Breaking the parking brake cable";
            c[24] = "Lack of fluid from the braking system.";
            v[25] = "Can you leave the car trailer you are driving at night on a public road?";
            a[25] = "Yes, because the trailer is not in the vehicle category";//CORRECT
            b[25] = "No, because in this case parking is prohibited";
            c[25] = "Yes, if the position lights are on";
            v[26] = "Stopping is forbidden";
            a[26] = "In the area where the indicator 'Prohibited parking' is installed";
            b[26] = "In the area of ​​the indicator 'Overcoming prohibited' "; //CORRECT
            c[26] = "In the access roads that serve the properties adjacent to public roads";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            roundButton1.Visible = false;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            textBox1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton3.Visible = true;
            label8.Visible = label9.Visible = label10.Visible = true;
            i = rnd.Next(1, 21); ;
            while(viz[i]==1)
            i = rnd.Next(1, 21) ;
            radioButton1.Text = a[i];
            radioButton2.Text = b[i];
            radioButton3.Text = c[i];
            textBox1.Text = v[i];
            m = Convert.ToInt32(label8.Text);
            s = Convert.ToInt32(label10.Text);
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            radioButton1.Checked = radioButton2.Checked=radioButton3.Checked=false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i = rnd.Next(1, 27);
            while (viz[i] == 1) i = rnd.Next(1, 27);
            radioButton1.Text = a[i];
            radioButton2.Text = b[i];
            radioButton3.Text = c[i];
            textBox1.Text = v[i];
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            s = s - 1;
            if (s == -1) { s = 59; m--; }
            if (m == 0 && s == 0)
            {
                timer1.Stop();
                label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = button2.Visible = button3.Visible = button4.Visible = textBox1.Visible = radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = false;
                textBox6.Visible = button5.Visible = true;
            }
            label8.Text = Convert.ToString(m);
            label10.Text = Convert.ToString(s);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true || radioButton2.Checked == true || radioButton3.Checked == true)
            {
                int x = Convert.ToInt32(label5.Text);
                x--;
                label5.Text = Convert.ToString(x);
                if (i == 1)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 2)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 3)
                {
                    if (radioButton3.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 4)
                {
                    if (radioButton3.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 5)
                {
                    if (radioButton3.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 6)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 7)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 8)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 9)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 10)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 11)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 12)
                {
                    if (radioButton3.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 13)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 14)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 15)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 16)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 17)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 18)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 19)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 20)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 21)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 22)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 23)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 24)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 25)
                {
                    if (radioButton1.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                if (i == 26)
                {
                    if (radioButton2.Checked == true)
                    {
                        x = Convert.ToInt32(label6.Text);
                        x++;
                        label6.Text = Convert.ToString(x);
                    }
                    else
                    {
                        x = Convert.ToInt32(label7.Text);
                        x++;
                        label7.Text = Convert.ToString(x);
                    }
                }
                radioButton1.Checked = radioButton2.Checked = radioButton3.Checked = false;
                viz[i] = 1;
                int ok = 1;
                for (int k = 1; k <= 26; k++)
                    if (viz[k] == 0) ok = 0;
                if (ok == 0)
                {
                    i = rnd.Next(1, 27);
                    while (viz[i] == 1) i = rnd.Next(1, 27);
                    textBox1.Text = v[i];
                    radioButton1.Text = a[i];
                    radioButton2.Text = b[i];
                    radioButton3.Text = c[i];

                }
                else
                {
                    int q = Convert.ToInt32(label7.Text);
                    if(q<=4)
                    {
                        label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = button2.Visible = button3.Visible = button4.Visible = textBox1.Visible = radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = false;
                        textBox4.Visible = textBox5.Visible = button5.Visible = true;
                    }
                    else
                    {
                        label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = button2.Visible = button3.Visible = button4.Visible = textBox1.Visible = radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = false;
                        textBox2.Visible = textBox3.Visible = button5.Visible = true;
                    }
                }
                int y = Convert.ToInt32(label7.Text);
                if(y>4)
                {
                    label8.Visible=label9.Visible=label10.Visible=label1.Visible = label2.Visible = label3.Visible = label4.Visible = label5.Visible = label6.Visible = label7.Visible = button2.Visible = button3.Visible = button4.Visible = textBox1.Visible = radioButton1.Visible = radioButton2.Visible = radioButton3.Visible = false;
                    textBox2.Visible = textBox3.Visible = button5.Visible=true;
                }
            }
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form2 ss = new Form2();
            this.Dispose();
            ss.Show();
        }
    }
}
