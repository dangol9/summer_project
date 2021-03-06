﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Elu_application
{
    public partial class ScannedCardPage : ContentPage
    {
        private string result;
        public ScannedCardPage(string QrCodeResult)
        {
            InitializeComponent();
            result = QrCodeResult;
            
        }

        

        protected override void OnAppearing()
        {
            
            base.OnAppearing();
            DatabaseManager databasemanager = new DatabaseManager();
            var cards = databasemanager.GetAllMainCards();

                     foreach (var item in cards)
            {
                if (item.UniKood == result)
                {
                    ddlCards.Text += "Kategooria : " + (item.Kategooria) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Mõju : " + (item.Loodusvarad) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Nimetus : " + (item.Nimetus) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Elustik : " + (item.Elustik) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Turism : " + (item.Turism) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Rahulolu : " + (item.Rahuolu) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Üldine skoor : " + (item.Skoor) + "\n";
                    ddlCards.Text += "\n";
                    ddlCards.Text += "Kirjeldus : " + (item.Kirjeldus) + "\n";

                    found = true;
                }

            }
            if(found == false)
            {
                ddlCards.Text = "Ei leitud vastavat QR- Koodi";
            }
            }
        }
    }
}
