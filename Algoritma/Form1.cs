using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Threading;
using System.Threading.Tasks;

namespace Algoritma
{
    public partial class Form1 : Form
    {
        bool suruklenme_durumu;
        Point position;
        int nesne_count;
        Point nesne_start_position;
        myPanel secili_kontrol, onceki_secilen;
        public List<myPanel> sekiller;
        DegiskenListesi degisken_listesi;
        String secilen_nesne_adi;
        AlgoritmaAgaci aa = null;

        public Form1()
        {
            InitializeComponent();
        }
 
        private void Form1_Load(object sender, EventArgs e)
        {
            nesne_count = 0;
            nesne_start_position = new Point(250, 50);
            sekiller = new List<myPanel>();
            properti_temizleme();
            secilen_nesne_adi = "";
        }

        public void mp3_play(String url)
        {

            System.Media.SoundPlayer player = new System.Media.SoundPlayer();
            player.SoundLocation = @Application.StartupPath + url;// MessageBox.Show("" + Application.StartupPath + "delete.mp3");
            player.Play();

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {
            Baslat pnl = new Baslat("pnl" + Convert.ToString(nesne_count));
            panel_olustur(pnl);
        }

        void btn_Click(object sender, EventArgs e)
        {
            try
            {
                onceki_secilen =getNesne( secilen_nesne_adi);
            }
            catch (Exception)
            {}
            if (cbOtoBagla.Checked && onceki_secilen !=null && onceki_secilen != secili_kontrol )
            {
                onceki_secilen.NesneBagla(secili_kontrol);
                Refresh();
            }
            else if (cbOtoBagla.Checked && onceki_secilen == secili_kontrol)
            {
                MessageBox.Show("Nesneler kendilerine bağlanamaz");
            }
            properti_temizleme();
            btnBaglantiSil.Enabled = true;
            btnBagla.Enabled = true;
            secili_kontrol = (myPanel)sender as myPanel;
            secilen_nesne_adi = secili_kontrol.Name;
            secili_kontrol.BorderStyle = BorderStyle.FixedSingle;
            txtGoruntulenecekMetin.Enabled = secili_kontrol.MetinGoruntulensinMi;
            txtGoruntulenecekMetin.Text = secili_kontrol.GosterilecekMetin;

            cbGoruntulenecekDegisken.Enabled = secili_kontrol.CbDegiskenGosterilecekMi;
            //değişken listesi eklenecek

            txtYapilacakIslem.Enabled = secili_kontrol.YapilacakIslemGosterilecekMi;
            txtYapilacakIslem.Text = secili_kontrol.YapilacakIslem;

            Degisken_Kontrol();
            try
            {
                 secili_kontrol.GosterilecekDegiskenListesi(cbGoruntulenecekDegisken, degisken_listesi);
            }
            catch (Exception)
            {  }
           

            txtWidth.Enabled = secili_kontrol.WHGosterilecekMi;
            txtHeight.Enabled = secili_kontrol.WHGosterilecekMi;
            txtWidth.Text = Convert.ToString(secili_kontrol.Width);
            txtHeight.Text = Convert.ToString(secili_kontrol.Height);


        }

         void Mouse_Down(object sender, MouseEventArgs e)
        {

            secili_kontrol = (myPanel)sender as myPanel;
            suruklenme_durumu = true;
            secili_kontrol.Cursor = Cursors.SizeAll;
            position = e.Location;
        }

         void Mouse_Move(object sender, MouseEventArgs e)
        {
            if (secili_kontrol == null)
            {
                return;
            }
            if (suruklenme_durumu)
            {
                secili_kontrol.Left = e.X + secili_kontrol.Left - (position.X);
                secili_kontrol.Top = e.Y + secili_kontrol.Top - (position.Y);

                if (secili_kontrol.Left > 2 * (this.Width) / 3)
                {
                    //cöpü aç
                    Cop_pictureBox.Image = Algoritma.Properties.Resources.canopen;
                }
                else
                {
                    Cop_pictureBox.Image = Algoritma.Properties.Resources.canclosed;
                }
               // Refresh();
               
                main_panel.Refresh();
            }
        }

         void Mouse_Up(object sender, MouseEventArgs e)
        {
            if (secili_kontrol == null)
            {
                return;
            }
            suruklenme_durumu = false;
            secili_kontrol.Cursor = Cursors.Default;
            Rectangle r1 = new Rectangle(secili_kontrol.Left, secili_kontrol.Top, secili_kontrol.Width, secili_kontrol.Height);
            Rectangle r2 = new Rectangle(cop_panel.Left, cop_panel.Top, cop_panel.Width, cop_panel.Height);

            if (r1.IntersectsWith(r2))
            {
                try
                {
                    for (int i = 0; i < sekiller.Count; i++)
                    {
                        if (sekiller[i].Name == secili_kontrol.Name)
                        {
                            if (secili_kontrol.GetType() == typeof(Degisken))
                            {
                                degisken_listesi.DegiskenSil(Degiskenler,secili_kontrol.YapilacakIslem);
                            }
                            sekiller.Remove(sekiller[i]);
                            break;
                        }
                    }
                    main_panel.Controls.Remove(secili_kontrol);
                    mp3_play("\\delete.wav");
                    properti_temizleme();
                }
                catch (Exception)
                {}
            }  
            Cop_pictureBox.Image = Algoritma.Properties.Resources.canclosed;
        }

         void Degisken_Kontrol()
         {
             try
             {
                degisken_listesi.clear();
             }
             catch (Exception)
             {}
             
             for (int i = 0; i < sekiller.Count; i++)
             {
                 if (sekiller[i].GetType() == typeof(Degisken))
                 {
                     degisken_listesi.SetDegisken(sekiller[i].YapilacakIslem);
                 }
             }
             try
             {
                 degisken_listesi.DegiskenYazdir(Degiskenler);
             }
             catch (Exception)
             { }
         }

         public void properti_temizleme()
         {
             btnBaglantiSil.Enabled = false;
             btnBagla.Enabled = false;
             secili_kontrol = null;
             txtGoruntulenecekMetin.Enabled = false;
             cbGoruntulenecekDegisken.Enabled = false;
             txtYapilacakIslem.Enabled = false;
             for (int i = 0; i < sekiller.Count; i++)
             {
                 sekiller[i].BorderStyle = BorderStyle.None;
             }
             txtGoruntulenecekMetin.Text = "";
             cbGoruntulenecekDegisken.Items.Clear();
             txtYapilacakIslem.Text = "";

             txtHeight.Enabled = false;
             txtWidth.Enabled = false;
             txtHeight.Text = "";
             txtWidth.Text = "";
         }

         private void btnDegisken_Click(object sender, EventArgs e)
         {
             Degisken pnl = new Degisken("pnl" + Convert.ToString(nesne_count));
             degisken_listesi = new DegiskenListesi(pnl.YapilacakIslem);
             degisken_listesi.DegiskenYazdir(Degiskenler);
             panel_olustur(pnl);
         }

         private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
             {
                 e.Handled = true;
             }
             else
             {
                 e.Handled = false;
             }
         }

         private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
         {
             if (!char.IsDigit(e.KeyChar) && (e.KeyChar != (char)Keys.Back))
             {
                 e.Handled = true;
             }
             else
             {
                 e.Handled = false;
             }
         }

         private void btnBekle_Click(object sender, EventArgs e)
         {
             Bekle pnl = new Bekle("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }

         public void panel_olustur(myPanel pnl)
         {
             pnl.Click += new EventHandler(btn_Click);
             pnl.MouseDown += new MouseEventHandler(Mouse_Down);
             pnl.MouseMove += new MouseEventHandler(Mouse_Move);
             pnl.MouseUp += new MouseEventHandler(Mouse_Up);

             if (nesne_count <= 5)
             {
                 pnl.Left = nesne_start_position.X;
                 pnl.Top = nesne_start_position.Y + nesne_count * 60;
             }
             else
             {
                 pnl.Left = nesne_start_position.X + 400;
                 pnl.Top = nesne_start_position.Y;
             }
             main_panel.Controls.Add(pnl);
             nesne_count++;
             sekiller.Add(pnl);// nesne listesi
             main_panel.Controls.Add(pnl);
         }

         private void btnDugum_Click(object sender, EventArgs e)
         {
             Dugum pnl = new Dugum("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }

         private void btnDur_Click(object sender, EventArgs e)
         {
             Dur pnl = new Dur("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }

         private void btnIslem_Click(object sender, EventArgs e)
         {
             Islem pnl = new Islem("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }

         private void txtWidth_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 secili_kontrol.Width = Convert.ToInt16(txtWidth.Text);
                 secili_kontrol.Refresh();
             }
             catch (Exception) { }
         }

         private void txtHeight_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 secili_kontrol.Height = Convert.ToInt16(txtHeight.Text);
                 secili_kontrol.Refresh();
             }
             catch (Exception) { }
         }

         private void txtYapilacakIslem_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 secili_kontrol.YapilacakIslem = txtYapilacakIslem.Text;
                 secili_kontrol.Refresh();
             }
             catch (Exception)
             {
             }
         }

         private void txtGoruntulenecekMetin_TextChanged(object sender, EventArgs e)
         {
             try
             {
                 secili_kontrol.GosterilecekMetin = txtGoruntulenecekMetin.Text;
                 secili_kontrol.Refresh();
             }
             catch (Exception)
             {}
         }

         private void btnGiris_Click(object sender, EventArgs e)
         {
             Giris pnl = new Giris("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }

         private void btnCikis_Click(object sender, EventArgs e)
         {
             Cikis pnl = new Cikis("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }

         private void btnEger_Click(object sender, EventArgs e)
         {
             Eger pnl = new Eger("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }

         private void tabControlProperti_Selecting(object sender, TabControlCancelEventArgs e)
         {
             Degisken_Kontrol();
         }

         private void cbGoruntulenecekDegisken_SelectedIndexChanged(object sender, EventArgs e)
         {
             if (secili_kontrol.GetType() ==typeof(Giris))
             {
                 Giris giris = (Giris)(secili_kontrol);
                 giris.DegiskenAdi = cbGoruntulenecekDegisken.SelectedItem.ToString();
             }
             else if (secili_kontrol.GetType() == typeof(Cikis))
             {
                 Cikis cikis = (Cikis)(secili_kontrol);
                 cikis.DegiskenAdi = cbGoruntulenecekDegisken.SelectedItem.ToString();
             }
             this.Refresh();
         }

         private void btnBaglantiSil_Click(object sender, EventArgs e)
         {
             secili_kontrol.CizgileriSil();
            // Refresh();
             main_panel.Refresh();
         }

         private void btnBagla_Click(object sender, EventArgs e)
         {
             if (onceki_secilen != null && onceki_secilen != secili_kontrol)
             {
                 onceki_secilen.NesneBagla(secili_kontrol);
             }
             else if (onceki_secilen.Name == secili_kontrol.Name)
             {
                 MessageBox.Show("Nesneler kendilerine bağlanamaz");
             }
             else
             {
                 MessageBox.Show("Bağlamak için Nesne seçin !");
             }
           //  MessageBox.Show("onceki secilenname :" + onceki_secilen.Name + " ,seçilen name :" + secili_kontrol.Name);
             Refresh();
             
         }

         public myPanel getNesne(String Name)
         {
             myPanel nesne = new Baslat("ilk") ;
             for (int i = 0; i < sekiller.Count; i++)
             {
                 if (sekiller [i].Name == Name)
                 {
                     nesne = sekiller[i];
                     break;
                 }
             }
             return nesne;
         }

         private void button1_Click(object sender, EventArgs e)
         {
            
             try
             {
                 degisken_listesi.clear();
             }
             catch (Exception){}
           
             for (int i = 0; i < sekiller.Count; i++)
             {
                 if (sekiller[i].GetType() ==typeof(Degisken))
                 {
                     degisken_listesi.SetDegisken(sekiller[i].YapilacakIslem);
                 }
                 if (sekiller[i].GetType() == typeof(Baslat))
                 {
                      aa = new AlgoritmaAgaci((Baslat)sekiller[i]);
                 }
                 sekiller[i].BorderStyle = BorderStyle.None;
             }
             try
             {
               
                 Thread thread = new Thread(new ThreadStart(aa.Calistir));
                 thread.Start();
                
             }
             catch (Exception)
             {  }
         }

         private void main_panel_Paint(object sender, PaintEventArgs e)
         {
             Graphics g = e.Graphics;
             
             Pen myPen = new Pen(System.Drawing.Color.Red, 2);
             Brush brush = System.Drawing.Brushes.Black; 
             for (int i = 0; i < sekiller.Count; i++)
             {
                 if ((sekiller[i].GetType() == typeof(Eger)))
                 {
                     if (sekiller[i].Next1 != null)
                     {
                         int N1_x = (sekiller[i].Left + sekiller[i].Width / 2);
                         int N1_y = (sekiller[i].Top + sekiller[i].Height / 2);

                         int N2_x = (sekiller[i].Next1.Left + sekiller[i].Next1.Width / 2);
                         int N2_y = (sekiller[i].Next1.Top + sekiller[i].Next1.Height / 2);

                         g.DrawLine(myPen, N1_x, N1_y, N2_x, N2_y);
                         N1_x += sekiller[i].Next1.Left;
                         N1_y += sekiller[i].Next1.Top;
                         N1_x /= 2; N1_y /= 2;

                         g.DrawString("E", new Font("Arial", 10), brush, new Point(N1_x, N1_y));

                     }
                     if (sekiller[i].Next2 != null)
                     {
                         int N1_x = (sekiller[i].Left + sekiller[i].Width / 2);
                         int N1_y = (sekiller[i].Top + sekiller[i].Height / 2);

                         int N2_x = (sekiller[i].Next2.Left + sekiller[i].Next2.Width / 2);
                         int N2_y = (sekiller[i].Next2.Top + sekiller[i].Next2.Height / 2);

                         g.DrawLine(myPen, N1_x, N1_y, N2_x, N2_y);
                         N1_x += sekiller[i].Next2.Left;
                         N1_y += sekiller[i].Next2.Top;
                         N1_x /= 2; N1_y /= 2;
                         g.DrawString("H", new Font("Arial", 10), brush, new Point(N1_x, N1_y));

                     }
                 }
                 else
                 {
                     if (sekiller[i].Next1 != null)
                     {
                         int N1_x = (sekiller[i].Left + sekiller[i].Width/2);
                         int N1_y = (sekiller[i].Top + sekiller[i].Height/2);

                          int N2_x = (sekiller[i].Next1.Left + sekiller[i].Next1.Width/2);
                         int N2_y = (sekiller[i].Next1.Top + sekiller[i].Next1.Height/2);
                         g.DrawLine(myPen, N1_x, N1_y, N2_x,N2_y);
                     }
                 }
                
             }            
         }

         private void btnfor_Click(object sender, EventArgs e)
         {
             for_ pnl = new for_("pnl" + Convert.ToString(nesne_count));
             panel_olustur(pnl);
         }
    }
}
