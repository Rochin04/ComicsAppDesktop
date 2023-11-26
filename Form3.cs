using ComicsAPPDesktop.Model;
//using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ComicsAPPDesktop
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        public void ULTIMOINTENTOAVL()
        {
            ComicsModel comics = new ComicsModel();
            int datos = Convert.ToInt32(textBox8.Text);
            string publisher = comics.Publisher;
            string tags = comics.Tags;
            string? dateadded = comics.DateAdded;
            string? daterelease = comics.DateAdded;
            string? type = comics.Type;
            string? writer = comics.Writer;
            string? artist = comics.Artist;
            publisher = textBox1.Text;
            tags = textBox2.Text;
            dateadded = textBox3.Text;
            daterelease = textBox4.Text;
            type = textBox5.Text;
            writer = textBox6.Text;
            artist = textBox7.Text;
            llenadoDatos(datos, publisher, tags, dateadded, daterelease, type,  writer, artist);
        }
        public void llenadoDatos(int datos, string publisher, string tags, string dateadded, string daterelease, string type, string writer, string artist)
        {
            string[] comicslist = new string[datos];
            for (int i = 0; i < datos; i++)
            {
                comicslist[i] = publisher + tags + dateadded + daterelease + type + writer + artist;
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                break;
            }
            for(int i = 0; i < datos;i++)
            {
                MessageBox.Show(comicslist[i]);
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //try
            //{
            //    if (textBox8.Text.Trim() != "")
            //    {
            //        datos = int.Parse(textBox8.Text.Trim());
            //        Comics = new string[datos];
            //        for (int i = 0; i < datos; i++)
            //        {
            //            Comics[i] = textBox1.Text + textBox2.Text + textBox3.Text + textBox4.Text + textBox5.Text + textBox6.Text + textBox7.Text;
            //            //Interaction.InputBox("Llena los datos del comic a registrar");
            //        }
            //    }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }
        #region Them
        private void darToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Black;
            toolStrip1.ForeColor = Color.White;
            toolStrip1.BackColor = Color.Black;
            label1.ForeColor = Color.White;
            label2.ForeColor = Color.White;
            label3.ForeColor = Color.White;
            label4.ForeColor = Color.White;
            label5.ForeColor = Color.White;
            label6.ForeColor = Color.White;
            label7.ForeColor = Color.White;
            label8.ForeColor = Color.White;
            label9.ForeColor = Color.White;
            textBox1.ForeColor = Color.White;
            textBox1.BackColor = Color.Black;
            textBox2.ForeColor = Color.White;
            textBox2.BackColor = Color.Black;
            textBox3.ForeColor = Color.White;
            textBox3.BackColor = Color.Black;
            textBox4.ForeColor = Color.White;
            textBox4.BackColor = Color.Black;
            textBox5.ForeColor = Color.White;
            textBox5.BackColor = Color.Black;
            textBox6.ForeColor = Color.White;
            textBox6.BackColor = Color.Black;
            textBox7.ForeColor = Color.White;
            textBox7.BackColor = Color.Black;
            button1.ForeColor = Color.White;
            button1.BackColor = Color.Black;
            button2.ForeColor = Color.White;
            button2.BackColor = Color.Black;
        }
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
            toolStrip1.ForeColor = Color.Black;
            toolStrip1.BackColor = Color.White;
            label1.ForeColor = Color.Black;
            label2.ForeColor = Color.Black;
            label3.ForeColor = Color.Black;
            label4.ForeColor = Color.Black;
            label5.ForeColor = Color.Black;
            label6.ForeColor = Color.Black;
            label7.ForeColor = Color.Black;
            label8.ForeColor = Color.Black;
            label9.ForeColor = Color.Black;
            textBox1.ForeColor = Color.Black;
            textBox1.BackColor = Color.White;
            textBox2.ForeColor = Color.Black;
            textBox2.BackColor = Color.White;
            textBox3.ForeColor = Color.Black;
            textBox3.BackColor = Color.White;
            textBox4.ForeColor = Color.Black;
            textBox4.BackColor = Color.White;
            textBox5.ForeColor = Color.Black;
            textBox5.BackColor = Color.White;
            textBox6.ForeColor = Color.Black;
            textBox6.BackColor = Color.White;
            textBox7.ForeColor = Color.Black;
            textBox7.BackColor = Color.White;
            button1.ForeColor = Color.Black;
            button1.BackColor = Color.White;
            button2.ForeColor = Color.Black;
            button2.BackColor = Color.White;
        }
        #endregion
        #region Arreglo
        private void button3_Click(object sender, EventArgs e)//List<ComicsModel> comcicsList)
        {
            ULTIMOINTENTOAVL();
        }
        //public void AddComic()
        //{
        //    ComicsModel[] ListaComicsM = new ComicsModel[1];
        //    for (int i = 0; i < 1; i++)
        //    {
        //        ComicsModel comicsM = new ComicsModel();
        //        comicsM.Tags = textBox2.Text;
        //        comicsM.Publisher = textBox1.Text;
        //        comicsM.DateAdded = textBox3.Text;
        //        comicsM.DateRelease = textBox4.Text;
        //        comicsM.Type = textBox5.Text;
        //        comicsM.Writer = textBox6.Text;
        //        comicsM.Artist = textBox7.Text;
        //        ListaComicsM[i] = comicsM;
        //    }
        //}
        //private void ShowComicsInListView(List<ComicsModel> comicsList)
        //{
        //    // Limpia los elementos anteriores en el ListView
        //    listView1.Items.Clear();

        //    // Itera sobre la lista de ComicsModel y agrega cada instancia como un nuevo elemento al ListView
        //    foreach (ComicsModel comics in comicsList)
        //    {
        //        ListViewItem listViewItem = new ListViewItem(new[]
        //        {
        //            comics.Publisher,
        //            comics.Tags,
        //            comics.DateAdded,
        //            comics.DateRelease,
        //            comics.Type,
        //            comics.Writer,
        //            comics.Artist
        //        });

        //        // Agrega el ListViewItem al ListView
        //        listView1.Items.Add(listViewItem);
        //    }
        //}

        //private void AddComicsModelToArrayAndShowInListView()
        //{
        //    List<ComicsModel> comicsList = new List<ComicsModel>();

        //    for (int i = 0; i < 1; i++)
        //    {
        //        // Crea una nueva instancia de ComicsModel
        //        ComicsModel comicsM = new ComicsModel();

        //        // Asigna los valores de los TextBox a las propiedades de ComicsModel
        //        comicsM.Publisher = textBox1.Text;
        //        comicsM.Tags = textBox2.Text;
        //        comicsM.DateAdded = textBox3.Text;
        //        comicsM.DateRelease = textBox4.Text;
        //        comicsM.Type = textBox5.Text;
        //        comicsM.Writer = textBox6.Text;
        //        comicsM.Artist = textBox7.Text;

        //        // Agrega la instancia de ComicsModel a la lista
        //        comicsList.Add(comicsM);

        //        // Puedes realizar más acciones aquí si es necesario
        //    }

        //    // Muestra los valores en el ListView
        //    ShowComicsInListView(comicsList);
        //}
        #endregion
        //public void Array()
        //{
        //    ComicsModel comicsM = new ComicsModel();
        //    comicsM.Publisher = textBox1.Text;
        //    comicsM.Tags = textBox2.Text;
        //    comicsM.DateAdded = textBox3.Text;
        //    comicsM.DateRelease = textBox4.Text;
        //    comicsM.Type = textBox5.Text;
        //    comicsM.Writer = textBox6.Text;
        //    comicsM.Artist = textBox7.Text;
        //    ComicsModel[] ListaComicsM = new ComicsModel[5];
        //    for (int i = 0; i < 5; i++)
        //    {
        //        ListaComicsM[i] = comicsM;
        //        if (ListaComicsM[i] != null)
        //        {
        //            ListaComicsM[i] = comicsM;
        //            //ListaComicsM[i] = $"{ListaComicsM[i].Publisher} {ListaComicsM[i].Tags} {ListaComicsM[i].DateAdded} {ListaComicsM[i].DateRelease} {ListaComicsM[i].Type} {ListaComicsM[i].Writer} {ListaComicsM[i].Artist}";
        //            //ListaComicsM[i] = ListaComicsM[i].Publisher + " " + ListaComicsM[i].Tags + " " + ListaComicsM[i].DateAdded + " " + ListaComicsM[i].DateRelease + " " + ListaComicsM[i].Type + " " + ListaComicsM[i].Writer + " " + ListaComicsM[i].Artist;
        //        }
        //    }
        ////datos = textBox8.Text;
        //ComicsModel[]? arrayComic = new ComicsModel[datos];
        //arrayComic[0] = comics;
        //arrayComic[1] = comics;
        //MessageBox.Show(arrayComic.Length.ToString());
        //for (int i = 0; i < datos; i++)
        //{
        //    if (arrayComic[i] != null)
        //    {
        //        arrayComic[i] = arrayComic[i].Publisher + " " + arrayComic[i].Tags + " " + arrayComic[i].DateAdded + " " + arrayComic[i].DateRelease + " " + arrayComic[i].Type + " " + arrayComic[i].Writer + " " + arrayComic[i].Artist;

        //    }
        //    //Interaction.InputBox("Llena los datos del comic a registrar");
        //}
        //for (int i = 0; i < datos; i++)
        //{
        //    if (arrayComic[i] != null)
        //    {
        //        MessageBox.Show(arrayComic[i].Publisher + " " + arrayComic[i].Tags + " " + arrayComic[i].DateAdded + " " + arrayComic[i].DateRelease + " " + arrayComic[i].Type + " " + arrayComic[i].Writer + " " + arrayComic[i].Artist);
        //    }
        //}
        //}
        #region Eventos
        private void listView1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void textBox7_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox5_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void label9_Click(object sender, EventArgs e)
        {
        }
        private void label8_Click(object sender, EventArgs e)
        {
        }
        private void label7_Click(object sender, EventArgs e)
        {
        }
        private void label6_Click(object sender, EventArgs e)
        {
        }
        private void label5_Click(object sender, EventArgs e)
        {
        }
        private void label4_Click(object sender, EventArgs e)
        {
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }
        private void button2_Click(object sender, EventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
        }
        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
