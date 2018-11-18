﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowCapture
{
    public partial class Form3 : Form
    {
        //private string saveLocation = "";
        public static string pictureSaveLocation { get; set; }

        public Form3()
        {
            InitializeComponent();
            
        }

        private void choose_Click(object sender, EventArgs e)
        {
            //var picker = new Windows.Storage.Pickers.FileOpenPicker();
            //picker.ViewMode = Windows.Storage.Pickers.PickerViewMode.Thumbnail;
            //picker.SuggestedStartLocation = Windows.Storage.Pickers.PickerLocationId.PicturesLibrary;
            //picker.FileTypeFilter.Add(".jpg");
            //picker.FileTypeFilter.Add(".jpeg");
            //picker.FileTypeFilter.Add(".png");
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Choose saving location";
            fbd.RootFolder = Environment.SpecialFolder.Desktop;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                saveLocation.Text = fbd.SelectedPath;
                pictureSaveLocation = fbd.SelectedPath;
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdp3 = new OpenFileDialog();
            if (ofdp3.ShowDialog() == DialogResult.OK)
            {
                ofdp3.Title = "Location of program 3";
                p3Location.Text = ofdp3.FileName;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdp1 = new OpenFileDialog();
            if (ofdp1.ShowDialog() == DialogResult.OK)
            {
                ofdp1.Title = "Location of program 1";
                p1Location.Text = ofdp1.FileName;

            }
        }

        private void chooseButtonP2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofdp2 = new OpenFileDialog();
            if (ofdp2.ShowDialog() == DialogResult.OK)
            {
                ofdp2.Title = "Location of program 2";
                p2Location.Text = ofdp2.FileName;

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void p3Location_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void saveLocation_TextChanged(object sender, EventArgs e)
        {
            pictureSaveLocation = saveLocation.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
