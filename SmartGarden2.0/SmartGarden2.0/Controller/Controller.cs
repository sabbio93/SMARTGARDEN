﻿

using SmartGarden.View;
using System;
using System.Windows.Forms;

namespace SmartGarden.Control
{
    public class Controller
    {
        private readonly GestioneGiardino _gestioneGiardino; //GestioneGiardino è il model

        public Controller(GestioneGiardino gestioneGiardino)
        {
            _gestioneGiardino = gestioneGiardino;
        }

        public bool CreateLoginForm()
        {
            using (var loginForm = new LoginForm())
            {
                var result = loginForm.ShowDialog();

                if (result == DialogResult.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        internal void CambiaViewSettore(string nomeSettore)
        {

            Settore settore = _gestioneGiardino.Giardino.Settori.TrovaSettore(nomeSettore);

            using (var pianteForm = new Form())
            {
                PianteView pianteView = new PianteView(settore);
                pianteView.Dock = DockStyle.Fill;
                pianteForm.Text = "Piante di " + settore.Nome;
                pianteForm.Size = new System.Drawing.Size(1000,400);
                pianteForm.Controls.Add(pianteView);
                pianteForm.ShowDialog();
            }
        }

        internal void CaricaInfoGiardino()
        {
            _gestioneGiardino.ProvaCaricamentoInfo();
        }

        internal void SettaTimer()
        {
            _gestioneGiardino.SettaTimer();
        }

        internal void CaricaTreeView()
        {
            _gestioneGiardino.CaricaTreeView();
        }
    }
}
