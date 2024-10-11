using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TClicker
{
    public partial class TClicker : Form
    {
        #region Variables
        bool isClicking = false;
        bool cps = false;
        bool randomMode = false;
        Thread thread;
        Input input;
        Random rnd = new Random();
        List<Keys> keys = new List<Keys>();
        Dictionary<string, Keys> keyToEnum = new Dictionary<string, Keys>();
        Dictionary<Keys, string> enumToKey = new Dictionary<Keys, string>();
        #endregion

        #region Setup
        public TClicker()
        {
            InitializeComponent();
        }

        private void TClicker_Load(object sender, EventArgs e)
        {
            input = new Input();
            input.KeyDown += KeyPressed;
            foreach (Keys key in Enum.GetValues(typeof(Keys)))
            {
                string keyName = key.ToString();
                keyToEnum[keyName] = key;
                enumToKey[key] = keyName;
            }
            foreach (string tecla in enumToKey.Values)
            {
                this.ChecklistKeys.Items.Add(tecla);
            }
            ChecklistKeys.SetItemChecked(102, true);
            keys.Add(Keys.F5);
            thread = new Thread(this.Clicker);
            thread.IsBackground = true;
            thread.Start();
        }
        #endregion

        #region EventHandlers
        private void ClickButtonClicked(object sender, EventArgs e) => ToggleClicking();
        private void CPSCheckboxChanged(object sender, EventArgs e)
        {
            cps = DisplayCPS.Checked;
            if (cps)
            {
                unit.Text = "CPS.";
                unit0.Text = "CPS.";
            }
            else
            {
                unit.Text = "Ms.";
                unit0.Text = "Ms.";
            }
        }

        private void RandomCheckboxChanged(object sender, EventArgs e)
        {
            if (RandomMode.Checked)
            {
                unit0.Visible = true;
                maxValue.Visible = true;
                minValue.Visible = true;
                hyphen.Visible = true;
                RandomLabel.Visible = true;
                FixedLabel.Visible = false;
                fixedInterval.Visible = false;
                unit.Visible = false;
            }
            else
            {
                unit0.Visible = false;
                maxValue.Visible = false;
                minValue.Visible = false;
                hyphen.Visible = false;
                RandomLabel.Visible = false;
                FixedLabel.Visible = true;
                fixedInterval.Visible = true;
                unit.Visible = true;
            }
        }
        private void KeyPressed(object sender, KeyEventArgs e)
        {
            if (keys.Contains(e.KeyData))
            {
                ToggleClicking();
            }
        }
        private void KeySelected(object sender, EventArgs e)
        {
            keys.Clear();
            foreach (string item in ChecklistKeys.CheckedItems)
                keys.Add(keyToEnum[item]);
        }
        #endregion

        #region Utilities
        private void ToggleClicking()
        {
            if (!isClicking)
            {
                StartButton.Text = "Parar de clicar!";
                isClicking = true;
            }
            else
            {
                StartButton.Text = "Começar a clicar!";
                isClicking = false;
            }
        }
        private int[] GetRandomInterval()
        {
            int texto1 = Convert.ToInt32(minValue.Text);
            int texto2 = Convert.ToInt32(maxValue.Text);
            if (cps)
            {
                texto1 = 1000 / texto1;
                texto2 = 1000 / texto2;
            }
            int[] produto = { texto1, texto2 };
            return produto;
        }
        private int GetInterval()
        {
            int texto = Convert.ToInt32(fixedInterval.Text);
            if (cps)
            {
                texto = 1000 / texto;
            }
            return texto;
        }
        private int Intervalo()
        {
            if (randomMode)
                return rnd.Next(GetRandomInterval()[0], GetRandomInterval()[1] + 1);
            else
                return GetInterval();
        }
        #endregion

        #region ClickerThread
        private void Clicker()
        {
            int ticks = 0;
            int intervalo = Intervalo();
            Stopwatch watch = new Stopwatch();
            while (true)
            {
                watch.Restart();
                if (isClicking && ticks % intervalo == 0)
                {
                    click(this.RightButton.Checked);
                    intervalo = Intervalo();
                }
                ticks++;
                while (watch.ElapsedMilliseconds < 1)
                {

                }
            }
        }
        private void click(bool right = false)
        {
            int x = Cursor.Position.X;
            int y = Cursor.Position.Y;
            if (!right)
                Output.ClickAtPosition(x, y);
            else
                Output.RightClickAtPosition(x, y);
        }
        #endregion
    }
}
