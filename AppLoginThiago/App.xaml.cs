﻿namespace AppLoginThiago
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        //
        protected override Window CreateWindow(IActivationState? activationState)
        {

            var window = base.CreateWindow(activationState);
            window.Width = 400;
            window.Height = 700;

            return new Window(new AppShell());
        }
    } //Fecha Classe
} //Fecha Namespace