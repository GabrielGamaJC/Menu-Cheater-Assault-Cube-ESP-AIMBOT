﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic.Logging;
using ezOverLay;
using System.Security.Permissions;
using swed32;
using System.IO;
using System.Security.Cryptography.X509Certificates;

namespace ACMenu2
{
    public partial class Form1 : Form
    {
        
        ez ez = new ez();
        methods? m;
        Entity localPlayer = new Entity();
        List<Entity> entities = new List<Entity>();
        
        [DllImport("user32.dll")]

        static extern short GetAsyncKeyState(Keys vKey);
        public Form1()
        {
            InitializeComponent();
        }

        public Boolean box = false;
        public Boolean line = false;
        public Boolean aimb = false;
        public Boolean amigo = false;
        public Boolean ammo = false;
        public Boolean health = false;
        public IntPtr ptr;
        private void Form1_Load(object sender, EventArgs e)
        {

            CheckForIllegalCrossThreadCalls = false;
            m = new methods();
            if (m != null)
            {
                ez.SetInvi(this);
                ez.DoStuff("AssaultCube", this);
                Thread thread = new Thread(main) { IsBackground = true };
                thread.Start();
            }
            m.mem.GetProcess("ac_client");
            var modulobase = m.mem.GetModuleBase(".exe");
            ptr = m.mem.ReadPointer(modulobase, 0x00195404);
            var balas = m.mem.ReadBytes(ptr, 0x140, 4);
           

            //int i = 0;
        }
      //funcões menu
       

        void main()
        {
            while (true)
            {
                localPlayer = m.ReadLocalPlayer();
                entities = m.ReadEntities(localPlayer);

                entities = entities.OrderBy(o => o.mag).ToList();
                if (aimb == true)
                {
                    if (GetAsyncKeyState(Keys.LShiftKey) < 0)
                {
                    if (entities.Count > 0)
                    {
                        foreach (var ent in entities)
                        {
                            if (ent.team != localPlayer.team)
                            {
                                var angles = m.CalcAngles(localPlayer, ent);
                               
                                 m.aim(localPlayer, angles.X, angles.Y);
                                break;
                                
                            }
                        }
                    }
                }
               }

                box = variavel.ESPBOX;
                line = variavel.ESPLINE;
                aimb = variavel.Aimbot;
                amigo = variavel.ESPAmigo;
                ammo = variavel.ammo;
                health = variavel.health;
                if (ammo == true) 
                {
                    m.mem.WriteBytes(ptr, 0x140, BitConverter.GetBytes(998));
                }

                if (health == true)
                {
                    m.mem.WriteBytes(ptr, 0xEC, BitConverter.GetBytes(998));
                }

                Form1 f = this;
                f.Refresh();

                Thread.Sleep(20);
            }
        }
        
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen red = new Pen(Color.Red, 2);
            Pen green = new Pen(Color.Green, 2);


            foreach (var ent in entities.ToList())
            {
                var wtsFeet = m.WorldToScreen(m.ReadMatrix(), ent.feet, this.Width, this.Height);
                var wtsHead = m.WorldToScreen(m.ReadMatrix(), ent.head, this.Width, this.Height);

                if (wtsFeet.X > 0)
                {
                    if (localPlayer.team == ent.team)
                    {
                        if (amigo == true) {
                            if (line == true)
                            {
                                g.DrawLine(green, new Point(Width / 2, Height), wtsFeet);
                            }
                            // g.DrawLine(green, new Point(Width / 2, Height), wtsFeet);
                            if (box == true)
                            {
                                g.DrawRectangle(green, m.CalcRec(wtsFeet, wtsHead));
                            }
                            }
                       
                    }
                    else
                    {
                        //line = true;
                        if (line == true)
                        {
                            g.DrawLine(red, new Point(Width / 2, Height), wtsFeet);
                        }
                       if (box == true)
                        {
                            g.DrawRectangle(red, m.CalcRec(wtsFeet, wtsHead));
                        }
                    }
                }
            }
        }
    }
}
