using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Windows.Forms;
using AForge;
using AForge.Imaging.Filters;
using AForge.Imaging;
using AForge.Video;
using AForge.Video.DirectShow;
using System.IO.Ports;

namespace nesne_takibi_3x3_led
{
    public partial class Form1 : Form
    {
        private FilterInfoCollection VideoCapTureDevices;
        private VideoCaptureDevice Finalvideo;
        SerialPort ardino = new SerialPort();

        public Form1()
        {

            InitializeComponent();
        }

        int R;
        int G;
        int B;
       

        private void Form1_Load(object sender, EventArgs e)
        {

            VideoCapTureDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo VideoCaptureDevice in VideoCapTureDevices)
            {

                comboBox1.Items.Add(VideoCaptureDevice.Name);

            }

            comboBox1.SelectedIndex = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Finalvideo = new VideoCaptureDevice(VideoCapTureDevices[comboBox1.SelectedIndex].MonikerString);
            Finalvideo.NewFrame += new NewFrameEventHandler(Finalvideo_NewFrame);
            Finalvideo.DesiredFrameRate = 20;//saniyede kaç görüntü alsın istiyorsanız. FPS
            Finalvideo.DesiredFrameSize = new Size(360,270);//görüntü boyutları
            Finalvideo.Start();
        }

        void Finalvideo_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {

            Bitmap image = (Bitmap)eventArgs.Frame.Clone();
            Bitmap image1 = (Bitmap)eventArgs.Frame.Clone();
            pictureBox1.Image = image;



            if (rdiobtnKirmizi.Checked)
            {

                // create filter
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // set center colol and radius
                filter.CenterColor = new RGB(Color.FromArgb(215, 0, 0));
                filter.Radius = 100;
                // apply the filter
                filter.ApplyInPlace(image1);


                nesnebul(image1);

            }

            if (rdiobtnMavi.Checked)
            {

                // create filter
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // set center color and radius
                filter.CenterColor = new RGB(Color.FromArgb(30, 144, 255));
                filter.Radius = 100;
                // apply the filter
                filter.ApplyInPlace(image1);

                nesnebul(image1);

            }
            if (rdiobtnYesil.Checked)
            {

                // create filter
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // set center color and radius
                filter.CenterColor = new RGB(Color.FromArgb(0, 215, 0));
                filter.Radius = 100;
                // apply the filter
                filter.ApplyInPlace(image1);

                nesnebul(image1);



            }


            if (rdbtnElleBelirleme.Checked)
            {

                // create filter
                EuclideanColorFiltering filter = new EuclideanColorFiltering();
                // set center colol and radius
                filter.CenterColor = new RGB(Color.FromArgb(R, G, B));
                filter.Radius = 100;
                // apply the filter
                filter.ApplyInPlace(image1);

                nesnebul(image1);

            }


        }

        public void nesnebul(Bitmap image)
        {
            BlobCounter blobCounter = new BlobCounter();
            blobCounter.MinWidth = 5;
            blobCounter.MinHeight = 5;
            blobCounter.FilterBlobs = true;
            blobCounter.ObjectsOrder = ObjectsOrder.Size;
            BitmapData objectsData = image.LockBits(new Rectangle(0, 0, image.Width, image.Height), ImageLockMode.ReadOnly, image.PixelFormat);
            Grayscale grayscaleFilter = new Grayscale(0.2125, 0.7154, 0.0721);
            UnmanagedImage grayImage = grayscaleFilter.Apply(new UnmanagedImage(objectsData));
            image.UnlockBits(objectsData);


            blobCounter.ProcessImage(image);
            Rectangle[] rects = blobCounter.GetObjectsRectangles();
            Blob[] blobs = blobCounter.GetObjectsInformation();
            pictureBox2.Image = image;

            if (rdiobtnTekCisimTakibi.Checked)
            {
                //Tekli cisim Takibi Single Tracking--------

                foreach (Rectangle recs in rects)
                {
                    if (rects.Length > 0)
                    {
                        Rectangle objectRect = rects[0];
                        //Graphics g = Graphics.FromImage(image);
                        Graphics g = pictureBox1.CreateGraphics();
                        using (Pen pen = new Pen(Color.FromArgb(252, 3, 26), 2))
                        {
                            g.DrawRectangle(pen, objectRect);
                        }
                        //Cizdirilen Dikdörtgenin Koordinatlari aliniyor.
                        int objectX = objectRect.X + (objectRect.Width / 2);
                        int objectY = objectRect.Y + (objectRect.Height / 2);
                        //  g.DrawString(objectX.ToString() + "X" + objectY.ToString(), new Font("Arial", 12), Brushes.Red, new System.Drawing.Point(250, 1));

                        g.Dispose();

                        if (chkKoordinatiGoster.Checked)
                        {
                            this.Invoke((MethodInvoker)delegate
                            {
                                richTextBox1.Text = objectRect.Location.ToString() + "\n" + richTextBox1.Text + "\n"; ;
                            });
                        }

                        g.Dispose();

                        if (objectX <= 120 && objectY <= 90)
                        {
                            ardino.Write("1");
                        }
                        else if (objectX <= 240 && objectX > 120 && objectY <= 90)
                        {
                            ardino.Write("2");
                        }
                        else if (objectX > 240 && objectY <= 90)
                        {
                            ardino.Write("3");
                        }
                        else if (objectX <= 120 && objectY > 90 && objectY <= 180)
                        {
                            ardino.Write("4");
                        }
                        else if (objectX <= 240 && objectX > 120 && objectY > 90 && objectY <= 180)
                        {
                            ardino.Write("5");
                        }
                        else if (objectX > 240 && objectY > 90 && objectY <= 180)
                        {
                            ardino.Write("6");
                        }
                        else if (objectX <= 120 && objectY > 180)
                        {
                            ardino.Write("7");
                        }
                        else if (objectX <= 240 && objectX > 120 && objectY > 180)
                        {
                            ardino.Write("8");
                        }
                        else if (objectX > 240 && objectY > 180)
                        {
                            ardino.Write("9");
                        }
                    }
                    else
                    {
                        ardino.Write("r");
                    }
                                   
                    
                }
            }


            if (rdiobtnCokCisimTakibi.Checked)
            {
                //Multi tracking Çoklu cisim Takibi-------

                for (int i = 0; rects.Length > i; i++)
                {
                    Rectangle objectRect = rects[i];
                    //Graphics g = Graphics.FromImage(image);
                    Graphics g = pictureBox1.CreateGraphics();
                    using (Pen pen = new Pen(Color.FromArgb(252, 3, 26), 2))
                    {
                        g.DrawRectangle(pen, objectRect);
                        g.DrawString((i + 1).ToString(), new Font("Arial", 12), Brushes.Red, objectRect);
                    }
                    //Cizdirilen Dikdörtgenin Koordinatlari aliniyor.
                    int objectX = objectRect.X + (objectRect.Width / 2);
                    int objectY = objectRect.Y + (objectRect.Height / 2);
                    //  g.DrawString(objectX.ToString() + "X" + objectY.ToString(), new Font("Arial", 12), Brushes.Red, new System.Drawing
                    if (chkboxMesafeOlcer.Checked)
                    {

                        if (rects.Length > 1)
                        {
                            for (int j = 0; j < rects.Length - 1; j++)
                            {
                                int ilkx = (rects[j].Right + rects[j].Left) / 2;
                                int ilky = (rects[j].Top + rects[j].Bottom) / 2;

                                int ikix = (rects[j + 1].Right + rects[j + 1].Left) / 2;
                                int ikiy = (rects[j + 1].Top + rects[j + 1].Bottom) / 2;

                                g = pictureBox1.CreateGraphics();
                                //g.DrawLine(Pens.Red, rects[j].Location, rects[j + 1].Location);
                                //g.DrawLine(Pens.Blue, rects[0].Location, rects[rects.Length - 1].Location);
                                g.DrawLine(Pens.Red, ilkx, ilky, ikix, ikiy);

                            }
                        }
                        if (rects.Length == 2)
                        {

                            Rectangle ilk = rects[0];
                            Rectangle iki = rects[1];

                            int ilkX = ilk.X + (ilk.Width / 2);
                            int ilkY = ilk.Y + (ilk.Height / 2);

                            int ikiX = iki.X + (iki.Width / 2);
                            int ikiY = iki.Y + (iki.Height / 2);

                            //1 pixel (X) = 0.0264583333333334 centimeter [cm]

                            double formul = Math.Floor((Math.Sqrt((Math.Pow((ilkX - ikiX), 2)) + Math.Pow((ilkY - ikiY), 2))) * 0.0264);

                            string uzaklikY = "Y-" + Convert.ToString(ilkX - ikiX);
                            string uzaklikX = "X-" + Convert.ToString(ilkY - ikiY);

                            string distance = uzaklikX + " " + uzaklikY;

                            AForge.Imaging.Drawing.Line(objectsData, new IntPoint((int)ilkX, (int)ilkY), new IntPoint((int)ikiX, (int)ikiY), Color.Blue);
                            this.Invoke((MethodInvoker)delegate
                            {
                                richTextBox2.Text = formul.ToString() + " cm\n" + richTextBox2.Text + " cm\n"; ;
                            });


                            if (chkboxMesafeKordinati.Checked)
                            {

                                this.Invoke((MethodInvoker)delegate
                                {
                                    richTextBox3.Text = distance.ToString() + "\n" + richTextBox3.Text + "\n"; ;
                                });

                            }
                        }
                    }
                    g.Dispose();

                    //     this.Invoke((MethodInvoker)delegate
                    //{
                    //    richTextBox1.Text = objectRect.Location.ToString() + "\n" + richTextBox1.Text + "\n"; ;
                    //});
                }
            }
        }



private void button2_Click(object sender, EventArgs e)
        {
            if (Finalvideo.IsRunning)
            {
                Finalvideo.Stop();

            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            R = trackBar1.Value;
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            G = trackBar2.Value;
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            B = trackBar3.Value;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (Finalvideo.IsRunning)
            {
                Finalvideo.Stop();

            }

            Application.Exit();
        }

        private void baglan_Click(object sender, EventArgs e)
        {
            try
            {
                String portName = comboBox2.Text;
                ardino.PortName = portName;
                ardino.BaudRate = 9600;
                ardino.Open();
                tool.Text = "bağlandı";
            }
            catch (Exception)
            {

                tool.Text = " Porta bağlanmadı ,uygun portu seçin";
            }
        }

        private void bagkes_Click(object sender, EventArgs e)
        {
            try
            {
                ardino.Close();
                tool.Text = "Port bağlantısı kesildi ";
            }
            catch (Exception)
            {

                tool.Text = "İlk önce bağlan sonra bağlantıyı kes";
            }

        }

       
    }
}

    
