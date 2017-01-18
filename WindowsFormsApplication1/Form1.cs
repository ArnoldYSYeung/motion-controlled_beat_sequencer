// Author: Arnold Yeung
// Date: November 2015
// Title: Motion-Controlled Beat Sequencer
// arnoldyeung.com

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Collections.Concurrent;
using System.Threading;
using System.Media;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        // class variables
        float avgX, avgY, avgZ;                                 // average of the last 100 values
        int result;
        int bytesToRead;
        int newByte;                                            // holder for read bytes
        int startRead = 0;                                      // count which value is outputted in the data series
        int state = 0;                                          // state of current state machine
        int moveThreshold = 25;                                 // increase in value needed to indicate movement
        int xDiff = 0, yDiff = 0, zDiff = 0;                    // measures difference in acceleration form average
        int maxXDiff = 0, maxYDiff = 0, maxZDiff = 0;           // measures the maximum xDiff, yDiff, and zDiff of a given queue
        int waitTimer = 0;                                      // counts number of timer intervals
        int waitDuration = 2500;                                // amount of time to wait between each move

        int beatNumber = 0;                                     // indicate which beat we're programming
        int playBeatNumber = 0;                                 // indicate which beat we're playing
        TextBox curText;
        int playing = 0;                                        // flag that indicates if beat is playing (1)
        int tickWaitCounter = 0;                                // this is used to count ticks from the timer


        string[] serialPortNames = SerialPort.GetPortNames();           // get port names
        ConcurrentQueue<int> xQueue = new ConcurrentQueue<int>();       // queue receiving x data
        ConcurrentQueue<int> yQueue = new ConcurrentQueue<int>();       // queue receiving y data
        ConcurrentQueue<int> zQueue = new ConcurrentQueue<int>();       // queue receiving z data

        Image orientImage;

        SoundPlayer kick = new SoundPlayer("C:/Final/WindowsFormsApplication1 - Creative/"
                    + "Audio/kick.wav");
        SoundPlayer snare = new SoundPlayer("C:/Final/WindowsFormsApplication1 - Creative/"
                    + "Audio/snare.wav");
        SoundPlayer alert = new SoundPlayer("C:/Final/WindowsFormsApplication1 - Creative/"
                    + "Audio/alert.wav");
        SoundPlayer gun = new SoundPlayer("C:/Final/WindowsFormsApplication1 - Creative/"
                    + "Audio/gun.wav");
        SoundPlayer hihat = new SoundPlayer("C:/Final/WindowsFormsApplication1 - Creative/"
                    + "Audio/hihat.wav");
        SoundPlayer closedhat = new SoundPlayer("C:/Final/WindowsFormsApplication1 - Creative/"
                    + "Audio/closedhat.wav");



        public Form1()
        {
            InitializeComponent();
            comPortDropDown.Items.AddRange(serialPortNames);
            statusBox.Text = "Disconnected.";
            orientBox.Text = "";
        }

        private void beat0Button_Click(object sender, EventArgs e)
        {
            beatNumber = 0;
        }

        private void beat1Button_Click(object sender, EventArgs e)
        {
            beatNumber = 1;
        }

        private void beat2Button_Click(object sender, EventArgs e)
        {
            beatNumber = 2;
        }

        private void beat3Button_Click(object sender, EventArgs e)
        {
            beatNumber = 3;
        }

        private void beat4Button_Click(object sender, EventArgs e)
        {
            beatNumber = 4;
        }

        private void beat5Button_Click(object sender, EventArgs e)
        {
            beatNumber = 5;
        }

        private void beat6Button_Click(object sender, EventArgs e)
        {
            beatNumber = 6;
        }

        private void beat8Button_Click(object sender, EventArgs e)
        {
            beatNumber = 7;
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playButton.Text == "Play")
            {
                playButton.Text = "Stop";
                // turn off read
                readButton.Checked = false; readButton.AutoCheck = false;
                unreadButton.Checked = true; unreadButton.AutoCheck = false;
                playing = 1;                // start playing beat
                tickWaitCounter = 0;
                playBeatNumber = 0;
                statusBox.Text = "Playing...";
                orientImage = Image.FromFile("C:/Final/WindowsFormsApplication1 - Creative/"
                    + "Pictures/drake.gif");
                orientPicBox.Image = orientImage;
            }
            else
            {
                playButton.Text = "Play";
                readButton.AutoCheck = true;
                unreadButton.AutoCheck = true;
                playing = 0;                // stop playing beat
                if (serialPort1.IsOpen == true)
                {
                    statusBox.Text = "Device is connected.";
                }
                else
                {
                    statusBox.Text = "Disconnected.";
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            serialPort1.Close();                // close serialPort
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if(connectButton.Text == "Connect")
            {
                // connect to serialPort1
                if(comPortDropDown.Text != null)    // if there's something in the dropdown box
                {
                    serialPort1.PortName = comPortDropDown.SelectedItem.ToString();
                    serialPort1.Open();
                    statusBox.Text = "Connected to device.";
                    connectButton.Text = "Disconnect";
                }
            }
            else    // "Disconnect"
            {
                serialPort1.Close();            // close serial port
                connectButton.Text = "Connect";
                statusBox.Text = "Disconnected.";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (readButton.Checked == true && serialPort1.IsOpen == true)      // if read data is activated
            {
                // assume starts at 255

                bytesToRead = serialPort1.BytesToRead;      // number of bytes in received buffer

                while (bytesToRead > 0 && serialPort1.IsOpen == true)      // while there are bytes to read
                {
                    statusBox.Text = "Reading data...";

                    newByte = serialPort1.ReadByte();                      // read byte

                    if (newByte == 255)
                    {
                        // wait until start at 255
                        startRead = 1;                  // indicate the beginning of data series
                    }
                    else
                    {
                        startRead++;                    // increment startRead

                        if (startRead == 2)              // x data
                        {
                            xQueue.Enqueue(newByte);
                            xBox.Text = newByte.ToString();
                        }
                        else if (startRead == 3)         // y data
                        {
                            yQueue.Enqueue(newByte);
                            yBox.Text = newByte.ToString();
                        }
                        else if (startRead == 4)              // at end of data series (z data)
                        {
                            zQueue.Enqueue(newByte);
                            zBox.Text = newByte.ToString();
                            startRead = 0;
                        }
                    }
                    bufferBox.Text = bytesToRead.ToString();
                    bytesToRead = serialPort1.BytesToRead;
                }


            }
            else                // read data is not activateed
            {
                if (playButton.Text == "Play")
                {
                    if (serialPort1.IsOpen)
                    {
                        statusBox.Text = "Connected to device.";
                    }
                    else
                    {
                        statusBox.Text = "Disconnected.";
                    }
                }
                else
                {
                    statusBox.Text = "Playing...";
                }

            }
            if(playButton.Text == "Play")
            {
                // determine orientation of the Gumstick
                if (avgX == 0 && avgY == 0 && avgZ == 0)             // start empty
                {
                    orientBox.Text = "";
                }
                else if (avgY < 150 && avgZ < 150 && avgX > 150)      // vertical
                {
                    orientBox.Text = "Vertical Upside Down";    // upside down
                    orientImage = Image.FromFile("C:/Final/WindowsFormsApplication1 - Creative/"
                        + "Pictures/upsidedown.png");
                }
                else if (avgY < 150 && avgZ < 150 && avgX < 100)      // vertical
                {
                    orientBox.Text = "Vertical Upright";   //rightside up
                    orientImage = Image.FromFile("C:/Final/WindowsFormsApplication1 - Creative/"
                        + "Pictures/upright.png");
                }
                else if (avgX < 150 && avgY < 150 && avgZ > 150)       // flat
                {
                    orientBox.Text = "Facing Heavens";
                    orientImage = Image.FromFile("C:/Final/WindowsFormsApplication1 - Creative/"
                        + "Pictures/up.png");
                }
                else if (avgX < 150 && avgY < 150 && avgZ < 100)       // flat
                {
                    orientBox.Text = "Facing Hell";
                    orientImage = Image.FromFile("C:/Final/WindowsFormsApplication1 - Creative/"
                        + "Pictures/down.png");
                }
                else if (avgX < 150 && avgZ < 150 && avgY > 150)          // sideways
                {
                    orientBox.Text = "Facing Left";
                    orientImage = Image.FromFile("C:/Final/WindowsFormsApplication1 - Creative/"
                        + "Pictures/left.png");
                }
                else if (avgX < 150 && avgZ < 150 && avgY < 100)
                {
                    orientBox.Text = "Facing Right";
                    orientImage = Image.FromFile("C:/Final/WindowsFormsApplication1 - Creative/"
                        + "Pictures/right.png");
                }
                else
                {
                    // wait
                }
                orientPicBox.Image = orientImage;
            }
           
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            int count = 0;
            float sum = 0;             
            int xCount = xQueue.Count;
            int yCount = yQueue.Count;
            int zCount = zQueue.Count;
            int moveX = 0;                      // indicate movement in X direction
            int moveY = 0;                      // indicate movement in Y direction
            int moveZ = 0;                      // indicate movement in Z direction
            int resetWaitTimer = 0;             // indicate to reset the waitTimer
            int xIndex = 255, yIndex = 255, zIndex = 255;       // used to determine which motion is fastest

            int i;

            if (tickWaitCounter == 3 && playing == 1)           // restart tickWaitCounter every 150 ms
            {
                tickWaitCounter = 0;
                curText = (TextBox)this.Controls["kickPanel" + playBeatNumber.ToString()]; // access textbox
                if (curText.Text == "1")                    // if button is on
                {
                    kick.PlaySync();                        // play sound
                }
                curText = (TextBox)this.Controls["snarePanel" + playBeatNumber.ToString()]; // access textbox
                if (curText.Text == "1")                    // if button is on
                {
                    snare.PlaySync();                        // play sound
                }
                curText = (TextBox)this.Controls["hihatPanel" + playBeatNumber.ToString()]; // access textbox
                if (curText.Text == "1")                    // if button is on
                {
                    hihat.PlaySync();                        // play sound
                }
                curText = (TextBox)this.Controls["closedhatPanel" + playBeatNumber.ToString()]; // access textbox
                if (curText.Text == "1")                    // if button is on
                {
                    closedhat.PlaySync();                        // play sound
                }
                curText = (TextBox)this.Controls["alertPanel" + playBeatNumber.ToString()]; // access textbox
                if (curText.Text == "1")                    // if button is on
                {
                    alert.PlaySync();                        // play sound
                }
                curText = (TextBox)this.Controls["gunPanel" + playBeatNumber.ToString()]; // access textbox
                if (curText.Text == "1")                    // if button is on
                {
                    gun.PlaySync();                        // play sound
                }
                playBeatNumber++;                   // move on to the next beat
                if (playBeatNumber == 8)            // reset playBeatNumber
                    playBeatNumber = 0;

            }

            
            
            // calculate average of last 100 x data
            if (xCount >= 100)
            {
                for(i = 0; i < (xCount - 100); i++)             // trim down queue to 100 sized
                {
                    xQueue.TryDequeue(out result);
                    if(result > (avgX + moveThreshold) && avgX > 0)                    // if there's sig increase in acceleration    
                    {
                        xDiff = result - (int) avgX;                                    // difference from average
                        if(xDiff > maxXDiff)                                            // if the difference is greater than the max previously observed difference
                        {
                            maxXDiff = xDiff;                                           // update the maximum difference
                        }
                        xIndex = i;
                    }
                }

                while (xQueue.TryDequeue(out result))               // add up remaining x data
                {
                    count++;
                    sum = result + sum;
                    if (result > (avgX + moveThreshold) && avgX > 0)                    // if there's sig increase in acceleration    
                    {
                        xDiff = result - (int)avgX;                                    // difference from average
                        if (xDiff > maxXDiff)                                            // if the difference is greater than the max previously observed difference
                        {
                            maxXDiff = xDiff;                                           // update the maximum difference
                        }
                        xIndex = count + i;
                    }
                }

                avgX = sum / count;                                // calculate avgX
                count = 0;
                sum = 0;
                xAvgBox.Text = avgX.ToString();
            }

            // calculate average of last 100 y data
            if (yCount >= 100)
            {
                for (i = 0; i < (yCount - 100); i++)             // trim down queue to 100 sized
                {
                    yQueue.TryDequeue(out result);
                    if (result > (avgY + moveThreshold) && avgY > 0)                    // if there's sig increase in acceleration    
                    {
                        yDiff = result - (int)avgY;                                    // difference from average
                        if (yDiff > maxYDiff)                                            // if the difference is greater than the max previously observed difference
                        {
                            maxYDiff = yDiff;                                           // update the maximum difference
                        }
                        yIndex = i;
                    }
                }

                while (yQueue.TryDequeue(out result))               // add up remaining y data
                {
                    count++;
                    sum = result + sum;
                    if (result > (avgY + moveThreshold) && avgY > 0)                    // if there's sig increase in acceleration    
                    {
                        yDiff = result - (int)avgY;                                    // difference from average
                        if (yDiff > maxYDiff)                                            // if the difference is greater than the max previously observed difference
                        {
                            maxYDiff = yDiff;                                           // update the maximum difference
                        }
                        yIndex = count + i;
                    }
                }

                avgY = sum / count;                                // calculate avgY
                count = 0;
                sum = 0;
                yAvgBox.Text = avgY.ToString();
            }

            // calculate average of last 100 z data
            if (zCount >= 100)
            {
                for (i = 0; i < (zCount - 100); i++)             // trim down queue to 100 sized
                {
                    zQueue.TryDequeue(out result);
                    if (result < (avgZ - moveThreshold) && avgZ > 0)                    // if there's sig increase in acceleration    
                    {
                        zDiff = (int)avgZ - result;       // difference from average
                        if (zDiff > maxZDiff)                                            // if the difference is greater than the max previously observed difference
                        {
                            maxZDiff = zDiff;                                           // update the maximum difference
                        }
                        zIndex = i;
                    }
                }

                while (zQueue.TryDequeue(out result))               // add up remaining z data
                {
                    count++;
                    sum = result + sum;
                    if (result < (avgZ - moveThreshold) && avgZ > 0)                    // if there's sig increase in acceleration    
                    {
                        zDiff = (int)avgZ - result;                   // difference from average
                        if (zDiff > maxZDiff)                                            // if the difference is greater than the max previously observed difference
                        {
                            maxZDiff = zDiff;                                           // update the maximum difference
                        }
                        zIndex = count + i;
                    }
                }

                avgZ = sum / count;                                // calculate avgZ
                count = 0;
                sum = 0;
                zAvgBox.Text = avgZ.ToString();
            }

            /*
            // determine which movement was made first
            if (xIndex < yIndex && xIndex > zIndex)              // movement in x
            {
                moveX = 1;
            }
            else if (yIndex < xIndex && yIndex < zIndex)         // movement in y
            {
                moveY = 1;
            }
            else if (zIndex < xIndex && zIndex < yIndex)         // movement in z
            {
                moveZ = 1;
            }
            */
            // determine which movement was made
            if(maxXDiff > maxYDiff && maxXDiff > maxZDiff)              // movement in x
            {
                moveX = 1;
            }
            else if(maxYDiff > maxXDiff && maxYDiff > maxZDiff)         // movement in y
            {
                moveY = 1;
            }
            else if(maxZDiff > maxXDiff && maxZDiff > maxYDiff)         // movement in z
            {
                moveZ = 1;
            }

            // update state

            if (waitTimer >= waitDuration / timer.Interval)         // if wait for 2 seconds
            {
                resetWaitTimer = 1;
                state = 0;                                 // return to state 0
            }
            else if (state == 0 && moveX == 1)              // state 1 (kick)
            {
                waitTimer = 0;
                gestureLstBox.Items.Add("Kick");           // arrive from state 0 to 1
                kick.PlaySync();

                curText = (TextBox) this.Controls["kickPanel" + beatNumber.ToString()]; // access textbox
                if (curText.Text == "")             // turn on beat
                {
                    curText.Text = "1";
                    curText.BackColor = Color.Yellow;

                }
                else                                // turn off beat
                {
                    curText.Text = "";
                    curText.BackColor = Color.WhiteSmoke;
                }

                state = 1;
                // do not reset waitTimer
            }
            else if (state == 0 && moveZ == 1)              // state 2 (gun)
            {
                waitTimer = 0;
                gestureLstBox.Items.Add("Gun");
                gun.PlaySync();

                curText = (TextBox)this.Controls["gunPanel" + beatNumber.ToString()]; // access textbox
                if (curText.Text == "")             // turn on beat
                {
                    curText.Text = "1";
                    curText.BackColor = Color.Yellow;
                }
                else                                // turn off beat
                {
                    curText.Text = "";
                    curText.BackColor = Color.WhiteSmoke;
                }
                state = 2;                                  // arrive from state 0 to 2
                // do not reset waitTimer
            }
            else if (state == 2 && moveX == 1)              // state 3 (none)
            {
                waitTimer = 0;
                state = 3;                                  // arrive from state 2 to 3
            }
            else if (state == 3 && moveY == 1)              // state 4 (hihat)
            {
                waitTimer = 0;
                gestureLstBox.Items.Add("Hi-Hat");
                hihat.PlaySync();
                curText = (TextBox)this.Controls["hihatPanel" + beatNumber.ToString()]; // access textbox
                if (curText.Text == "")             // turn on beat
                {
                    curText.Text = "1";
                    curText.BackColor = Color.Yellow;
                }
                else                                // turn off beat
                {
                    curText.Text = "";
                    curText.BackColor = Color.WhiteSmoke;
                }

                state = 4;                                  // arrive from state 3 to 4 (then back to 0)
            }
            else if (state == 0 && moveY == 1)              // state 5 (snare)
            {
                waitTimer = 0;
                gestureLstBox.Items.Add("Snare");           // arrive from state 0 to 5
                snare.PlaySync();
                curText = (TextBox)this.Controls["snarePanel" + beatNumber.ToString()]; // access textbox
                if (curText.Text == "")             // turn on beat
                {
                    curText.Text = "1";
                    curText.BackColor = Color.Yellow;
                }
                else                                // turn off beat
                {
                    curText.Text = "";
                    curText.BackColor = Color.WhiteSmoke;
                }

                state = 5;
                // do not reset waitTimer
            }
            else if (state == 5 && moveX == 1)              // state 6 (closedhat)
            {
                waitTimer = 0;
                gestureLstBox.Items.Add("Closed-Hat");
                closedhat.PlaySync();
                curText = (TextBox)this.Controls["closedhatPanel" + beatNumber.ToString()]; // access textbox
                if (curText.Text == "")             // turn on beat
                {
                    curText.Text = "1";
                    curText.BackColor = Color.Yellow;
                }
                else                                // turn off beat
                {
                    curText.Text = "";
                    curText.BackColor = Color.WhiteSmoke;
                }

                state = 6;
            }
            else if(state == 1 && moveY == 1)               // state 7 (alert)
            {
                waitTimer = 0;
                gestureLstBox.Items.Add("Alert");
                alert.PlaySync();
                curText = (TextBox)this.Controls["alertPanel" + beatNumber.ToString()]; // access textbox
                if (curText.Text == "")             // turn on beat
                {
                    curText.Text = "1";
                    curText.BackColor = Color.Yellow;
                }
                else                                // turn off beat
                {
                    curText.Text = "";
                    curText.BackColor = Color.WhiteSmoke;
                }

                state = 7;
            }



            // reset differences
            xDiffBox.Text = xDiff.ToString();
            yDiffBox.Text = yDiff.ToString();
            zDiffBox.Text = zDiff.ToString();

            xDiff = 0;  moveX = 0;  maxXDiff = 0;
            yDiff = 0;  moveY = 0;  maxYDiff = 0;
            zDiff = 0;  moveZ = 0;  maxZDiff = 0;
            waitTimer++;                        // indicate 1 timer interval has passed

            if(resetWaitTimer == 1)
            {
                waitTimer = 0;                  // reset waitTimer
            }


            stateBox.Text = state.ToString();

            tickWaitCounter++;      // indicate that 1 timer interval has passed
            // assuming 50 ms, per timer interval and 90 bpm (i.e. 1.5 beats per second),
            // the tickWaitCounter would count 3 times (150 ms) for each tick.
            
        }
    }
}
