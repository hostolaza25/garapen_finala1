using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3POO_3
{
    /// <summary>
    /// Irrati baten informazioa eta funtzionamendua kudeatzen duen klasea.
    /// Frekuentzia eta irratiaren izena gordetzen ditu.
    /// </summary>
    class Irratsaioa
    {
        /// <summary>
        /// Irratiaren frekuentzia gordetzen duen atributu pribatua.
        /// </summary>
        private double frek;

        /// <summary>
        /// Irratiaren izena gordetzen duen atributu pribatua.
        /// </summary>
        private string izena;

        /// <summary>
        /// Irratiaren frekuentzia lortu edo ezartzen du.
        /// </summary>
        public double Frek
        {
            get { return frek; }
            set { frek = value; }
        }

        /// <summary>
        /// Irratiaren izena lortu edo ezartzen du.
        /// </summary>
        public string Izena
        {
            get { return izena; }
            set { izena = value; }
        }

        /// <summary>
        /// Eraikitzaile lehenetsia.
        /// Frekuentzia 80 MHz balioarekin hasieratzen du.
        /// </summary>
        public Irratsaioa()
        {
            frek = 80;
        }

        /// <summary>
        /// Parametroak jasotzen dituen eraikitzailea.
        /// </summary>
        /// <param name="balorea">Hasierako frekuentzia.</param>
        /// <param name="izena">Irratiaren izena.</param>
        public Irratsaioa(double balorea, string izena)
        {
            frek = balorea;
            this.izena = izena;
        }

        /// <summary>
        /// Frekuentzia 0,5 MHz igotzen du.
        /// 108 MHz baino handiagoa bada, 80 MHz-ra itzultzen da.
        /// </summary>
        public void igo()
        {
            frek = frek + 0.5;

            if (frek > 108)
            {
                frek = 80;
            }
        }

        /// <summary>
        /// Frekuentzia 0,5 MHz jaisten du.
        /// 80 MHz baino txikiagoa bada, 108 MHz-ra pasatzen da.
        /// </summary>
        public void jaitsi()
        {
            frek = frek - 0.5;

            if (frek < 80)
            {
                frek = 108;
            }
        }

        /// <summary>
        /// Pantailan irratiaren frekuentzia eta izena erakusten ditu.
        /// </summary>
        public void seefrek()
        {
            Console.WriteLine("Frekuentzia = " + frek + " Irratsaio izena> " + izena);
        }
    }
}