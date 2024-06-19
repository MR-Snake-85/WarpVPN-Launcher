using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Warp
{
    partial class Main_Form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_Form));
            TabControl = new TabControl();
            ProxyTab = new TabPage();
            label5 = new Label();
            UProxy_button = new Button();
            RStats_button = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            SProxy_button = new Button();
            WarpTab = new TabPage();
            StopWarp_button = new Button();
            LogBox = new TextBox();
            label7 = new Label();
            label6 = new Label();
            SWarp_button = new Button();
            ListLocations = new ListBox();
            CheckBoxLocation = new CheckBox();
            TabControl.SuspendLayout();
            ProxyTab.SuspendLayout();
            WarpTab.SuspendLayout();
            SuspendLayout();
            // 
            // TabControl
            // 
            TabControl.Controls.Add(ProxyTab);
            TabControl.Controls.Add(WarpTab);
            TabControl.Location = new Point(4, 4);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(602, 419);
            TabControl.TabIndex = 0;
            // 
            // ProxyTab
            // 
            ProxyTab.Controls.Add(label5);
            ProxyTab.Controls.Add(UProxy_button);
            ProxyTab.Controls.Add(RStats_button);
            ProxyTab.Controls.Add(label4);
            ProxyTab.Controls.Add(label3);
            ProxyTab.Controls.Add(label2);
            ProxyTab.Controls.Add(label1);
            ProxyTab.Controls.Add(SProxy_button);
            ProxyTab.Location = new Point(4, 24);
            ProxyTab.Name = "ProxyTab";
            ProxyTab.Padding = new Padding(3);
            ProxyTab.Size = new Size(594, 391);
            ProxyTab.TabIndex = 0;
            ProxyTab.Text = "Proxy";
            ProxyTab.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(438, 46);
            label5.Name = "label5";
            label5.Size = new Size(0, 15);
            label5.TabIndex = 5;
            // 
            // UProxy_button
            // 
            UProxy_button.Location = new Point(4, 345);
            UProxy_button.Name = "UProxy_button";
            UProxy_button.Size = new Size(114, 39);
            UProxy_button.TabIndex = 4;
            UProxy_button.Text = "Unset Proxy";
            UProxy_button.UseVisualStyleBackColor = true;
            UProxy_button.Click += UProxy_button_Click;
            // 
            // RStats_button
            // 
            RStats_button.Location = new Point(6, 173);
            RStats_button.Name = "RStats_button";
            RStats_button.Size = new Size(114, 39);
            RStats_button.TabIndex = 4;
            RStats_button.Text = "Realod Stats";
            RStats_button.UseVisualStyleBackColor = true;
            RStats_button.Click += RStats_button_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(438, 82);
            label4.Name = "label4";
            label4.Size = new Size(0, 15);
            label4.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(375, 82);
            label3.Name = "label3";
            label3.Size = new Size(45, 15);
            label3.TabIndex = 2;
            label3.Text = "Status :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(375, 46);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 2;
            label2.Text = "Address :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(438, 3);
            label1.Name = "label1";
            label1.Size = new Size(57, 30);
            label1.TabIndex = 1;
            label1.Text = "Stats";
            // 
            // SProxy_button
            // 
            SProxy_button.Location = new Point(4, 0);
            SProxy_button.Name = "SProxy_button";
            SProxy_button.Size = new Size(114, 39);
            SProxy_button.TabIndex = 0;
            SProxy_button.Text = "Set Proxy";
            SProxy_button.UseVisualStyleBackColor = true;
            SProxy_button.Click += SPButton_Click;
            // 
            // WarpTab
            // 
            WarpTab.Controls.Add(StopWarp_button);
            WarpTab.Controls.Add(LogBox);
            WarpTab.Controls.Add(label7);
            WarpTab.Controls.Add(label6);
            WarpTab.Controls.Add(SWarp_button);
            WarpTab.Controls.Add(ListLocations);
            WarpTab.Controls.Add(CheckBoxLocation);
            WarpTab.Location = new Point(4, 24);
            WarpTab.Name = "WarpTab";
            WarpTab.Padding = new Padding(3);
            WarpTab.Size = new Size(594, 391);
            WarpTab.TabIndex = 1;
            WarpTab.Text = "Warp";
            WarpTab.UseVisualStyleBackColor = true;
            // 
            // StopWarp_button
            // 
            StopWarp_button.Location = new Point(6, 62);
            StopWarp_button.Name = "StopWarp_button";
            StopWarp_button.Size = new Size(75, 23);
            StopWarp_button.TabIndex = 6;
            StopWarp_button.Text = "Stop Warp";
            StopWarp_button.UseVisualStyleBackColor = true;
            StopWarp_button.Click += StopWarp_button_Click;
            // 
            // LogBox
            // 
            LogBox.BackColor = Color.White;
            LogBox.Location = new Point(8, 91);
            LogBox.Multiline = true;
            LogBox.Name = "LogBox";
            LogBox.ReadOnly = true;
            LogBox.Size = new Size(435, 289);
            LogBox.TabIndex = 5;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(307, 10);
            label7.Name = "label7";
            label7.Size = new Size(0, 15);
            label7.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(198, 10);
            label6.Name = "label6";
            label6.Size = new Size(103, 15);
            label6.TabIndex = 3;
            label6.Text = "Selected Country :";
            // 
            // SWarp_button
            // 
            SWarp_button.Location = new Point(6, 6);
            SWarp_button.Name = "SWarp_button";
            SWarp_button.Size = new Size(75, 23);
            SWarp_button.TabIndex = 2;
            SWarp_button.Text = "Start Warp";
            SWarp_button.UseVisualStyleBackColor = true;
            SWarp_button.Click += button1_Click;
            // 
            // ListLocations
            // 
            ListLocations.FormattingEnabled = true;
            ListLocations.ItemHeight = 15;
            ListLocations.Items.AddRange(new object[] { "United States", "Austria", "Belgium", "Bulgaria", "Brazil", "Canada", "Switzerland", "Czech Republic", "Germany", "Denmark", "Estonia", "Spain", "Finland", "France", "United Kingdom", "Hungary", "Ireland", "India", "Italy", "Japan", "Latvia", "Netherlands", "Norway", "Poland", "Romania", "Serbia", "Sweden", "Singapore", "Slovakia", "Ukraine" });
            ListLocations.Location = new Point(449, 31);
            ListLocations.Name = "ListLocations";
            ListLocations.Size = new Size(139, 349);
            ListLocations.TabIndex = 1;
            ListLocations.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // CheckBoxLocation
            // 
            CheckBoxLocation.AutoSize = true;
            CheckBoxLocation.Location = new Point(449, 6);
            CheckBoxLocation.Name = "CheckBoxLocation";
            CheckBoxLocation.Size = new Size(139, 19);
            CheckBoxLocation.TabIndex = 0;
            CheckBoxLocation.Text = "Use Custom Location";
            CheckBoxLocation.UseVisualStyleBackColor = true;
            CheckBoxLocation.CheckedChanged += CheckBoxLocation_CheckedChanged;
            // 
            // Main_Form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(610, 425);
            Controls.Add(TabControl);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Main_Form";
            Text = "Warp VPN";
            FormClosing += Main_Form_FormClosing;
            TabControl.ResumeLayout(false);
            ProxyTab.ResumeLayout(false);
            ProxyTab.PerformLayout();
            WarpTab.ResumeLayout(false);
            WarpTab.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl TabControl;
        private TabPage ProxyTab;
        private TabPage WarpTab;
        private Button SProxy_button;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private Button UProxy_button;
        private Button RStats_button;
        private Label label5;
        private CheckBox CheckBoxLocation;
        private ListBox ListLocations;
        private Label label6;
        private Button SWarp_button;
        private Label label7;
        private TextBox LogBox;
        private Button StopWarp_button;
    }
}
