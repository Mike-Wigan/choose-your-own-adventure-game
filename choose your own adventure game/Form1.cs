using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using choose_your_own_adventure_game.Properties;
using System.Media;

namespace choose_your_own_adventure_game
{

    public partial class Form1 : Form
    {
        int page = 1;//declaring veriables
        int underwear, pants, shirt, socks, coat = 0;//1 for on 2 for off
        Random randgen = new Random();
        int number, display, delay, nothing, play;
        SoundPlayer player = new SoundPlayer();
        public Form1()
        {
            InitializeComponent();//displaying stuff to start the game
            dielabel.Visible = false;
            Yesbutton.Visible = false;
            Nobutton.Visible = false;
            Dogbutton.Visible = false;
            delay = 2000;
            number = randgen.Next(1, 101);
            //display = nothing;
            Nextbutton.Text = "Next";
            outputlabel.Text = "You wake up after a refreshing sleep and have a shower";
            this.BackgroundImage = Properties.Resources.bathroom;
            SoundPlayer player = new SoundPlayer(Properties.Resources._401338__ckvoiceover__yawning);
            player.Play();

        }

        private void Dogbutton_Click(object sender, EventArgs e)
        {
            //display = nothing;//for testing
            //pagelabel.Text = Convert.ToString(display);
            if (page == 1)//switches the pages if you click dog button
            {
                page = 98;
            }
            else if (page == 2)
            {
                page = 98;
            }
            else if (page == 3)
            {
                page = 98;
            }
            else if (page == 5)
            {
                page = 98;
            }
            else if (page == 7)
            {
                page = 98;
            }
            else if (page == 8)
            {
                page = 98;
            }
            else if (page == 9)
            {
                page = 98;
            }
            else if (page == 12)
            {
                page = 98;
            }
            else if (page == 14)
            {
                page = 98;
            }
            else if (page == 15)
            {
                page = 98;
            }
            else if (page == 16)
            {
                page = 99;
            }
            else if (page == 17)
            {
                page = 99;
            }
            else if (page == 98)
            {
                page = 99;
            }
            else if (page == 99)
            {
                number = randgen.Next(1, 101);
                page = 1;
            }
            switch (page) //the following finds the page your on and displays stuff accordingly 
            {
                case 98:
                    outputlabel.Text = "You stopped and pet your dog";
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    outputlabel.Text = "By the time you finished petting your dog you were late for work";
                    Nextbutton.Visible = true;
                    break;
                case 99:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Visible = false;
                    this.BackgroundImage = null;
                    this.BackColor = Color.Black;
                    dielabel.Visible = true;
                    dielabel.Text = "You Died";
                    Yesbutton.Visible = true;
                    Yesbutton.Text = "Try again";
                    Nobutton.Visible = true;
                    Nobutton.Text = "Quit";
                    break;
            }
        }

        private void Yesbutton_Click(object sender, EventArgs e)
        {
            //display = nothing;
            //pagelabel.Text = Convert.ToString(display);
            if (page == 1)//switches pages when yes button is clicked
            {
                page = 2;
            }
            else if (page == 2)
            {
                page = 4;
            }
            else if (page == 3)
            {
                page = 4;
            }
            else if (page == 4)
            {
                page = 6;
            }
            else if (page == 5)
            {
                page = 8;
            }
            else if (page == 7)
            {
                page = 8;
            }
            else if (page == 9)
            {
                page = 12;
            }
            else if (page == 8)
            {
                page = 12;
            }
            else if (page == 12)
            {
                page = 13;
            }
            else if (page == 14)
            {
                page = 16;
            }
            else if (page == 15)
            {
                page = 16;
            }
            else if (page == 97)
            {
                page = 1;
            }
            else if (page == 98)
            {
                page = 99;
            }
            else if (page == 99)
            {
                number = randgen.Next(1, 101);
                page = 1;
            }

            switch (page)
            {//figures out what page your on and displays correct information
                case 1:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    Nextbutton.Visible = true;
                    outputlabel.Visible = true;
                    this.BackgroundImage = Properties.Resources.bedroom;
                    Nextbutton.Text = "Next";
                    outputlabel.Text = "You wake up after a refreshing sleep and have a shower";
                    break;
                case 2:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on underwear";
                    underwear = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put on pants or pet your dog?";
                    Yesbutton.Text = "Put on pants";
                    Nobutton.Text = "Don't put on pants";
                    break;
                case 3:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on underwear";
                    underwear = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put on pants or pet your dog?";
                    Yesbutton.Text = "Put on pants";
                    Nobutton.Text = "Don't put on pants";
                    break;
                case 4:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on pants";
                    pants = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Which leg do you put in first?";
                    Yesbutton.Text = "Left";
                    Nobutton.Text = "Right";
                    Dogbutton.Visible = false;
                    break;
                case 5:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on pants";
                    pants = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    outputlabel.Text = "Do you put on a shirt or pet your dog?";
                    Yesbutton.Text = "Put on a shirt";
                    Nobutton.Text = "Don't put on a shirt";
                    break;
                case 6:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You stumble while putting on your pants and hit your head on the bed post";
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    Yesbutton.Visible = false;
                    Nextbutton.Visible = true;
                    break;
                case 7:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on pants";
                    pants = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put on a shirt or pet your dog?";
                    Yesbutton.Text = "Put on a shirt";
                    Nobutton.Text = "Don't put on a shirt";
                    break;
                case 8:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You try to put on a shirt";
                    shirt = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    if (number <= 25)
                    {
                        dielabel.Visible = false;
                        Yesbutton.Visible = false;
                        Nobutton.Visible = false;
                        Dogbutton.Visible = false;
                        outputlabel.Text = "You Tried to put on your shirt but fell and struck your head on your bed post";
                        outputlabel.Refresh();
                        Thread.Sleep(delay);
                        Nextbutton.Visible = true;
                    }
                    else
                    {
                        dielabel.Visible = false;
                        Yesbutton.Visible = false;
                        Nobutton.Visible = false;
                        Dogbutton.Visible = false;
                        outputlabel.Text = "You put on a shirt";
                        outputlabel.Refresh();
                        Thread.Sleep(delay);
                        Yesbutton.Visible = true;
                        Nobutton.Visible = true;
                        Dogbutton.Visible = true;
                        outputlabel.Visible = true;
                        outputlabel.Text = "Do you put on socks or pet your dog?";
                        Yesbutton.Text = "Put on socks";
                        Nobutton.Text = "Don't put on socks";
                    }
                    break;
                case 9:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on a shirt";
                    shirt = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put on socks or pet your dog?";
                    Yesbutton.Text = "Put on socks";
                    Nobutton.Text = "Don't put on socks";
                    break;
                case 12:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You try to put on socks";
                    socks = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put them on well standing or sitting?";
                    Yesbutton.Text = "Put them on while sitting";
                    Nobutton.Text = "Put them on while standing";
                    break;
                case 13:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You sat on your bed but your mom walked in and startled you. You hit your head off the ceiling fan";
                    Nextbutton.Visible = true;
                    break;
                case 14:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on socks";
                    socks = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Visible = true;
                    outputlabel.Text = "Do you put on a coat or pet your dog?";
                    Yesbutton.Text = "Put on a coat";
                    Nobutton.Text = "Don't put on a coat";
                    break;
                case 15:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on socks";
                    socks = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Visible = true;
                    outputlabel.Text = "Do you put on a coat or pet your dog?";
                    Yesbutton.Text = "Put on a coat";
                    Nobutton.Text = "Don't put on a coat";
                    break;
                case 16:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on a coat";
                    coat = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    outputlabel.Text = "You step outside after having breakfast your neighbour across the street is snowblowing the driveway";
                    Dogbutton.Text = "Next";
                    if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "You wore everything and had a normal day";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing socks but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks. You have a normal day";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a socks or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear, pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or socks. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or a coat. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing anything! You are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a socks. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a shirt. your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing pants. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing underwear. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    break;
                case 17:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on a coat";
                    coat = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    outputlabel.Text = "You step outside after having breakfast your neighbour across the street is snowblowing the driveway";
                    Dogbutton.Text = "Next";
                    if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "You wore everything and had a normal day";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing socks but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks. You have a normal day";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a socks or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear, pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or socks. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or a coat. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing anything! You are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a socks. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a shirt. your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing pants. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing underwear. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    break;
                case 99:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Visible = false;
                    this.BackgroundImage = null;
                    this.BackColor = Color.Black;
                    dielabel.Visible = true;
                    dielabel.Text = "You Died";
                    Yesbutton.Visible = true;
                    Yesbutton.Text = "Try again";
                    Nobutton.Visible = true;
                    Nobutton.Text = "Quit";
                    break;
            }
        }

        private void Nobutton_Click(object sender, EventArgs e)
        {
            //display = nothing;
            //pagelabel.Text = Convert.ToString(display);
            if (page == 1)//switches the page when no button is clicked on a specfic page
            {
                page = 3;
            }
            else if (page == 2)
            {
                page = 5;
            }
            else if (page == 3)
            {
                page = 5;
            }
            else if (page == 4)
            {
                page = 7;
            }
            else if (page == 5)
            {
                page = 9;
            }
            else if (page == 7)
            {
                page = 9;
            }
            else if (page ==8)
            {
                page = 15;
            }
            else if (page == 9)
            {
                page = 15;
            }
            else if (page == 12)
            {
                page = 14;
            }
            else if (page == 14)
            {
                page = 17;
            }
            else if (page == 15)
            {
                page = 17;
            }
            else if (page == 97)
            {
                this.Close();
            }
            else if (page == 98)
            {
                page = 99;
            }
            else if (page == 99)
            {
                this.Close();
            }

            switch (page)
            {//figures out what page your on and displays the correct information
                case 1:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    Nextbutton.Visible = true;
                    outputlabel.Visible = true;
                    this.BackgroundImage = Properties.Resources.bedroom;
                    Nextbutton.Text = "Next";
                    outputlabel.Text = "You wake up after a refreshing sleep and have a shower";
                    break;
                case 2:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on underwear";
                    underwear = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Visible = true;
                    outputlabel.Text = "Do you put on pants or pet your dog?";
                    Yesbutton.Text = "Put on pants";
                    Nobutton.Text = "Don't put on pants";
                    break;
                case 3:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on underwear";
                    underwear = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put on pants or pet your dog?";
                    Yesbutton.Text = "Put on pants";
                    Nobutton.Text = "Don't put on pants";
                    break;
                case 4:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "which leg do you put in first?";
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    outputlabel.Visible = true;
                    Yesbutton.Text = "Left";
                    Nobutton.Text = "Right";

                    break;
                case 5:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on pants";
                    pants = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Visible = true;
                    outputlabel.Text = "Do you put on a shirt or pet your dog?";
                    Yesbutton.Text = "Put on a shirt";
                    Nobutton.Text = "Don't put on a shirt";
                    break;
                case 6:
                    outputlabel.Text = "You stumble while putting on your pants and hit your head on the bed post";
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    Yesbutton.Visible = false;
                    Nextbutton.Visible = true;
                    break;
                case 7:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on pants";
                    pants = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put on a shirt or pet your dog?";
                    Yesbutton.Text = "Put on a shirt";
                    Nobutton.Text = "Don't put on a shirt";
                    break;
                case 8:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You try to put on a shirt";
                    shirt = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    if (number <= 25)
                    {
                        dielabel.Visible = false;
                        Yesbutton.Visible = false;
                        Nobutton.Visible = false;
                        Dogbutton.Visible = false;
                        outputlabel.Text = "You Tried to put on your shirt but fell and struck your head on your bed post";
                        outputlabel.Refresh();
                        Thread.Sleep(delay);
                        Nextbutton.Visible = true;
                    }
                    else
                    {
                        dielabel.Visible = false;
                        Yesbutton.Visible = false;
                        Nobutton.Visible = false;
                        Dogbutton.Visible = false;
                        outputlabel.Text = "You put on a shirt";
                        outputlabel.Refresh();
                        Thread.Sleep(delay);
                        Yesbutton.Visible = true;
                        Nobutton.Visible = true;
                        Dogbutton.Visible = true;
                        outputlabel.Visible = true;
                        outputlabel.Text = "Do you put on socks or pet your dog?";
                        Yesbutton.Text = "Put on socks";
                        Nobutton.Text = "Don't put on socks";
                    }
                    break;
                case 9:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on a shirt";
                    shirt = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Visible = true;
                    outputlabel.Text = "Do you put on socks or pet your dog?";
                    Yesbutton.Text = "Put on socks";
                    Nobutton.Text = "Don't put on socks";
                    break;
                case 12:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You try put on socks";
                    socks = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Text = "Do you put them on well standing or sitting?";
                    Yesbutton.Text = "Put them on while sitting";
                    Nobutton.Text = "Put them on while standing";
                    break;
                case 13:
                    dielabel.Visible = false;
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You sat on your bed but your mom walked in and startled you. You hit your head off the ceiling fan";
                    Nextbutton.Visible = true;
                    break;
                case 14:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on socks";
                    socks = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Visible = true;
                    outputlabel.Text = "Do you put on a coat or pet your dog?";
                    Yesbutton.Text = "Put on a coat";
                    Nobutton.Text = "Don't put on a coat";
                    break;
                case 15:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on socks";
                    socks = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Dogbutton.Visible = true;
                    outputlabel.Visible = true;
                    outputlabel.Text = "Do you put on a coat or pet your dog?";
                    Yesbutton.Text = "Put on a coat";
                    Nobutton.Text = "Don't put on a coat";
                    break;
                case 16:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You put on a coat";
                    coat = 1;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    outputlabel.Text = "You step outside after having breakfast your neighbour across the street is snowblowing the driveway";
                    Dogbutton.Text = "Next";
                    if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "You wore everything and had a normal day";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing socks but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks. You have a normal day";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a socks or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear, pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or socks. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or a coat. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing anything! You are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a socks. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a shirt. your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing pants. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing underwear. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    break;
                case 17:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Text = "You didn't put on a coat";
                    coat = 2;
                    outputlabel.Refresh();
                    Thread.Sleep(delay);
                    outputlabel.Text = "You step outside after having breakfast your neighbour across the street is snowblowing the driveway";
                    Dogbutton.Text = "Next";
                    if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "You wore everything and had a normal day";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt. Your neighbour gives you a look";
                        Dogbutton.Text = "Next";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing socks but no one notices";
                        Nextbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks. You have a normal day";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a socks or a coat. You freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear, pants or a shirt. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or socks. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or pants or a coat. Your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. Your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing a shirt or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or socks or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing underwear or a shirt or a coat. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your not wearing pants or a shirt or socks. your neighbour gives you a look";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your not wearing anything! You are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 2 && coat == 1)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 2 && socks == 1 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a socks. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 2 && shirt == 1 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a shirt. your neighbour faints";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 2 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing pants. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 2 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing underwear. you freeze to death";
                        Dogbutton.Visible = true;
                    }
                    else if (underwear == 1 && pants == 1 && shirt == 2 && socks == 2 && coat == 2)
                    {
                        outputlabel.Text = "Your only wearing a coat. you are arrested";
                        Dogbutton.Visible = true;
                    }
                    break;
                case 99:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Visible = false;
                    this.BackgroundImage = null;
                    this.BackColor = Color.Black;
                    dielabel.Visible = true;
                    dielabel.Text = "You Died";
                    Yesbutton.Visible = true;
                    Yesbutton.Text = "Try again";
                    Nobutton.Visible = true;
                    Nobutton.Text = "Quit";
                    break;
            }
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.bedroom;//displaying stuff rigth after you start the game
            //display = nothing;
            //pagelabel.Text = Convert.ToString(display);
            Yesbutton.Visible = true;
            Nobutton.Visible = true;
            Dogbutton.Visible = true;
            Nextbutton.Text = "Next";
            Dogbutton.Text = "Pet the dog";
            Yesbutton.Text = "Put on underwear";
            Nobutton.Text = "Don't put on underwear";
            outputlabel.Text = "After your shower do you put on underwear or pet your dog?";
            Nextbutton.Visible = false;
            if (page == 98)//displays stuff when on a specfic page
            {
                Yesbutton.Visible = false;
                Nobutton.Visible = false;
                Dogbutton.Visible = false;
                outputlabel.Visible = false;
                this.BackgroundImage = null;
                this.BackColor = Color.Black;
                dielabel.Visible = true;
                dielabel.Text = "You Died";
                Yesbutton.Visible = true;
                Yesbutton.Text = "Try again";
                Nobutton.Visible = true;
                Nobutton.Text = "Quit";
            }
            else if (page == 8)
            {
                number = randgen.Next(1, 101);
                page = 99;
            }
            else if (page == 13)
            {
                number = randgen.Next(1, 101);
                page = 99;
            }
            else if (page == 6)
            {
                number = randgen.Next(1, 101);
                page = 99;
            }
            else if (page == 16)
            {
                page = 97;
            }
            else if (page == 17)
            {
                page = 97;
            }
            switch (page)
            {
                case 97://figuring out what page your on and displaying the correct information
                    Yesbutton.Visible = false;
                    Nobutton.Visible= false;
                    Dogbutton.Visible= false;
                    outputlabel.Visible = false;
                    dielabel.Visible = true;
                    this.BackgroundImage = null;
                    this.BackColor = Color.Blue;
                    dielabel.Text = "You Win";
                    Yesbutton.Visible = true;
                    Nobutton.Visible = true;
                    Yesbutton.Text = "Play again";
                    Nobutton.Text = "Quit";
                    break;
                case 98:
                    SoundPlayer player = new SoundPlayer(Properties.Resources.marioDeathwav);
                    player.Play();
                    break;
                case 99:
                    Yesbutton.Visible = false;
                    Nobutton.Visible = false;
                    Dogbutton.Visible = false;
                    outputlabel.Visible = false;
                    this.BackgroundImage = null;
                    this.BackColor = Color.Black;
                    dielabel.Visible = true;
                    dielabel.Text = "You Died";
                    Yesbutton.Visible = true;
                    Yesbutton.Text = "Try again";
                    Nobutton.Visible = true;
                    Nobutton.Text = "Quit";
                    break;
            }

        }
    }
}
