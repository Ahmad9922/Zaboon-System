using Guna.UI2.WinForms;
using System.Drawing;
using System.Windows.Forms;

namespace Zaboon
{
    partial class ucReservationsDashboard
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTodayTotal = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTodayTotalTitle = new System.Windows.Forms.Label();
            this.lblTodayTotalValue = new System.Windows.Forms.Label();
            this.pnlTodayNew = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTodayNewTitle = new System.Windows.Forms.Label();
            this.lblTodayNewValue = new System.Windows.Forms.Label();
            this.pnlTodayCompleted = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTodayCompletedTitle = new System.Windows.Forms.Label();
            this.lblTodayCompletedValue = new System.Windows.Forms.Label();
            this.pnlTodayCancelled = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTodayCancelledTitle = new System.Windows.Forms.Label();
            this.lblTodayCancelledValue = new System.Windows.Forms.Label();
            this.pnlMonthTotal = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblMonthTotalTitle = new System.Windows.Forms.Label();
            this.lblMonthTotalValue = new System.Windows.Forms.Label();
            this.pnlYearTotal = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblYearTotalTitle = new System.Windows.Forms.Label();
            this.lblYearTotalValue = new System.Windows.Forms.Label();
            this.pnlTopService = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.lblTopServiceTitle = new System.Windows.Forms.Label();
            this.lblTopServiceName = new System.Windows.Forms.Label();
            this.lblTopServiceCount = new System.Windows.Forms.Label();
            this.lblTopServicesHeader = new System.Windows.Forms.Label();
            this.dgvTopServices = new Guna.UI2.WinForms.Guna2DataGridView();
            this.pnlTodayTotal.SuspendLayout();
            this.pnlTodayNew.SuspendLayout();
            this.pnlTodayCompleted.SuspendLayout();
            this.pnlTodayCancelled.SuspendLayout();
            this.pnlMonthTotal.SuspendLayout();
            this.pnlYearTotal.SuspendLayout();
            this.pnlTopService.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopServices)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTodayTotal
            // 
            this.pnlTodayTotal.BackColor = System.Drawing.Color.Transparent;
            this.pnlTodayTotal.Controls.Add(this.lblTodayTotalTitle);
            this.pnlTodayTotal.Controls.Add(this.lblTodayTotalValue);
            this.pnlTodayTotal.FillColor = System.Drawing.Color.White;
            this.pnlTodayTotal.Location = new System.Drawing.Point(16, 16);
            this.pnlTodayTotal.Name = "pnlTodayTotal";
            this.pnlTodayTotal.Radius = 12;
            this.pnlTodayTotal.ShadowColor = System.Drawing.Color.Black;
            this.pnlTodayTotal.ShadowDepth = 20;
            this.pnlTodayTotal.Size = new System.Drawing.Size(211, 100);
            this.pnlTodayTotal.TabIndex = 0;
            // 
            // lblTodayTotalTitle
            // 
            this.lblTodayTotalTitle.AutoSize = true;
            this.lblTodayTotalTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayTotalTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTodayTotalTitle.Name = "lblTodayTotalTitle";
            this.lblTodayTotalTitle.Size = new System.Drawing.Size(72, 13);
            this.lblTodayTotalTitle.TabIndex = 0;
            this.lblTodayTotalTitle.Text = "Today (Total)";
            // 
            // lblTodayTotalValue
            // 
            this.lblTodayTotalValue.AutoSize = true;
            this.lblTodayTotalValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTodayTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.lblTodayTotalValue.Location = new System.Drawing.Point(18, 38);
            this.lblTodayTotalValue.Name = "lblTodayTotalValue";
            this.lblTodayTotalValue.Size = new System.Drawing.Size(38, 45);
            this.lblTodayTotalValue.TabIndex = 1;
            this.lblTodayTotalValue.Text = "0";
            // 
            // pnlTodayNew
            // 
            this.pnlTodayNew.BackColor = System.Drawing.Color.Transparent;
            this.pnlTodayNew.Controls.Add(this.lblTodayNewTitle);
            this.pnlTodayNew.Controls.Add(this.lblTodayNewValue);
            this.pnlTodayNew.FillColor = System.Drawing.Color.White;
            this.pnlTodayNew.Location = new System.Drawing.Point(233, 16);
            this.pnlTodayNew.Name = "pnlTodayNew";
            this.pnlTodayNew.Radius = 12;
            this.pnlTodayNew.ShadowColor = System.Drawing.Color.Black;
            this.pnlTodayNew.ShadowDepth = 20;
            this.pnlTodayNew.Size = new System.Drawing.Size(211, 100);
            this.pnlTodayNew.TabIndex = 1;
            // 
            // lblTodayNewTitle
            // 
            this.lblTodayNewTitle.AutoSize = true;
            this.lblTodayNewTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayNewTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTodayNewTitle.Name = "lblTodayNewTitle";
            this.lblTodayNewTitle.Size = new System.Drawing.Size(69, 13);
            this.lblTodayNewTitle.TabIndex = 0;
            this.lblTodayNewTitle.Text = "Today (New)";
            // 
            // lblTodayNewValue
            // 
            this.lblTodayNewValue.AutoSize = true;
            this.lblTodayNewValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTodayNewValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTodayNewValue.Location = new System.Drawing.Point(18, 38);
            this.lblTodayNewValue.Name = "lblTodayNewValue";
            this.lblTodayNewValue.Size = new System.Drawing.Size(38, 45);
            this.lblTodayNewValue.TabIndex = 1;
            this.lblTodayNewValue.Text = "0";
            // 
            // pnlTodayCompleted
            // 
            this.pnlTodayCompleted.BackColor = System.Drawing.Color.Transparent;
            this.pnlTodayCompleted.Controls.Add(this.lblTodayCompletedTitle);
            this.pnlTodayCompleted.Controls.Add(this.lblTodayCompletedValue);
            this.pnlTodayCompleted.FillColor = System.Drawing.Color.White;
            this.pnlTodayCompleted.Location = new System.Drawing.Point(450, 16);
            this.pnlTodayCompleted.Name = "pnlTodayCompleted";
            this.pnlTodayCompleted.Radius = 12;
            this.pnlTodayCompleted.ShadowColor = System.Drawing.Color.Black;
            this.pnlTodayCompleted.ShadowDepth = 20;
            this.pnlTodayCompleted.Size = new System.Drawing.Size(211, 100);
            this.pnlTodayCompleted.TabIndex = 2;
            // 
            // lblTodayCompletedTitle
            // 
            this.lblTodayCompletedTitle.AutoSize = true;
            this.lblTodayCompletedTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayCompletedTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTodayCompletedTitle.Name = "lblTodayCompletedTitle";
            this.lblTodayCompletedTitle.Size = new System.Drawing.Size(99, 13);
            this.lblTodayCompletedTitle.TabIndex = 0;
            this.lblTodayCompletedTitle.Text = "Today (Completed)";
            // 
            // lblTodayCompletedValue
            // 
            this.lblTodayCompletedValue.AutoSize = true;
            this.lblTodayCompletedValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTodayCompletedValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(204)))), ((int)(((byte)(112)))));
            this.lblTodayCompletedValue.Location = new System.Drawing.Point(18, 38);
            this.lblTodayCompletedValue.Name = "lblTodayCompletedValue";
            this.lblTodayCompletedValue.Size = new System.Drawing.Size(38, 45);
            this.lblTodayCompletedValue.TabIndex = 1;
            this.lblTodayCompletedValue.Text = "0";
            // 
            // pnlTodayCancelled
            // 
            this.pnlTodayCancelled.BackColor = System.Drawing.Color.Transparent;
            this.pnlTodayCancelled.Controls.Add(this.lblTodayCancelledTitle);
            this.pnlTodayCancelled.Controls.Add(this.lblTodayCancelledValue);
            this.pnlTodayCancelled.FillColor = System.Drawing.Color.White;
            this.pnlTodayCancelled.Location = new System.Drawing.Point(667, 16);
            this.pnlTodayCancelled.Name = "pnlTodayCancelled";
            this.pnlTodayCancelled.Radius = 12;
            this.pnlTodayCancelled.ShadowColor = System.Drawing.Color.Black;
            this.pnlTodayCancelled.ShadowDepth = 20;
            this.pnlTodayCancelled.Size = new System.Drawing.Size(211, 100);
            this.pnlTodayCancelled.TabIndex = 3;
            // 
            // lblTodayCancelledTitle
            // 
            this.lblTodayCancelledTitle.AutoSize = true;
            this.lblTodayCancelledTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTodayCancelledTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTodayCancelledTitle.Name = "lblTodayCancelledTitle";
            this.lblTodayCancelledTitle.Size = new System.Drawing.Size(94, 13);
            this.lblTodayCancelledTitle.TabIndex = 0;
            this.lblTodayCancelledTitle.Text = "Today (Cancelled)";
            // 
            // lblTodayCancelledValue
            // 
            this.lblTodayCancelledValue.AutoSize = true;
            this.lblTodayCancelledValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblTodayCancelledValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(99)))), ((int)(((byte)(132)))));
            this.lblTodayCancelledValue.Location = new System.Drawing.Point(18, 38);
            this.lblTodayCancelledValue.Name = "lblTodayCancelledValue";
            this.lblTodayCancelledValue.Size = new System.Drawing.Size(38, 45);
            this.lblTodayCancelledValue.TabIndex = 1;
            this.lblTodayCancelledValue.Text = "0";
            // 
            // pnlMonthTotal
            // 
            this.pnlMonthTotal.BackColor = System.Drawing.Color.Transparent;
            this.pnlMonthTotal.Controls.Add(this.lblMonthTotalTitle);
            this.pnlMonthTotal.Controls.Add(this.lblMonthTotalValue);
            this.pnlMonthTotal.FillColor = System.Drawing.Color.White;
            this.pnlMonthTotal.Location = new System.Drawing.Point(16, 132);
            this.pnlMonthTotal.Name = "pnlMonthTotal";
            this.pnlMonthTotal.Radius = 12;
            this.pnlMonthTotal.ShadowColor = System.Drawing.Color.Black;
            this.pnlMonthTotal.ShadowDepth = 20;
            this.pnlMonthTotal.Size = new System.Drawing.Size(211, 100);
            this.pnlMonthTotal.TabIndex = 4;
            // 
            // lblMonthTotalTitle
            // 
            this.lblMonthTotalTitle.AutoSize = true;
            this.lblMonthTotalTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblMonthTotalTitle.Location = new System.Drawing.Point(20, 14);
            this.lblMonthTotalTitle.Name = "lblMonthTotalTitle";
            this.lblMonthTotalTitle.Size = new System.Drawing.Size(94, 13);
            this.lblMonthTotalTitle.TabIndex = 0;
            this.lblMonthTotalTitle.Text = "This Month (Total)";
            // 
            // lblMonthTotalValue
            // 
            this.lblMonthTotalValue.AutoSize = true;
            this.lblMonthTotalValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblMonthTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(184)))), ((int)(((byte)(34)))));
            this.lblMonthTotalValue.Location = new System.Drawing.Point(18, 38);
            this.lblMonthTotalValue.Name = "lblMonthTotalValue";
            this.lblMonthTotalValue.Size = new System.Drawing.Size(38, 45);
            this.lblMonthTotalValue.TabIndex = 1;
            this.lblMonthTotalValue.Text = "0";
            // 
            // pnlYearTotal
            // 
            this.pnlYearTotal.BackColor = System.Drawing.Color.Transparent;
            this.pnlYearTotal.Controls.Add(this.lblYearTotalTitle);
            this.pnlYearTotal.Controls.Add(this.lblYearTotalValue);
            this.pnlYearTotal.FillColor = System.Drawing.Color.White;
            this.pnlYearTotal.Location = new System.Drawing.Point(233, 132);
            this.pnlYearTotal.Name = "pnlYearTotal";
            this.pnlYearTotal.Radius = 12;
            this.pnlYearTotal.ShadowColor = System.Drawing.Color.Black;
            this.pnlYearTotal.ShadowDepth = 20;
            this.pnlYearTotal.Size = new System.Drawing.Size(211, 100);
            this.pnlYearTotal.TabIndex = 5;
            // 
            // lblYearTotalTitle
            // 
            this.lblYearTotalTitle.AutoSize = true;
            this.lblYearTotalTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblYearTotalTitle.Location = new System.Drawing.Point(20, 14);
            this.lblYearTotalTitle.Name = "lblYearTotalTitle";
            this.lblYearTotalTitle.Size = new System.Drawing.Size(86, 13);
            this.lblYearTotalTitle.TabIndex = 0;
            this.lblYearTotalTitle.Text = "This Year (Total)";
            // 
            // lblYearTotalValue
            // 
            this.lblYearTotalValue.AutoSize = true;
            this.lblYearTotalValue.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold);
            this.lblYearTotalValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.lblYearTotalValue.Location = new System.Drawing.Point(18, 38);
            this.lblYearTotalValue.Name = "lblYearTotalValue";
            this.lblYearTotalValue.Size = new System.Drawing.Size(38, 45);
            this.lblYearTotalValue.TabIndex = 1;
            this.lblYearTotalValue.Text = "0";
            // 
            // pnlTopService
            // 
            this.pnlTopService.BackColor = System.Drawing.Color.Transparent;
            this.pnlTopService.Controls.Add(this.lblTopServiceTitle);
            this.pnlTopService.Controls.Add(this.lblTopServiceName);
            this.pnlTopService.Controls.Add(this.lblTopServiceCount);
            this.pnlTopService.FillColor = System.Drawing.Color.White;
            this.pnlTopService.Location = new System.Drawing.Point(450, 132);
            this.pnlTopService.Name = "pnlTopService";
            this.pnlTopService.Radius = 12;
            this.pnlTopService.ShadowColor = System.Drawing.Color.Black;
            this.pnlTopService.ShadowDepth = 20;
            this.pnlTopService.Size = new System.Drawing.Size(428, 100);
            this.pnlTopService.TabIndex = 6;
            // 
            // lblTopServiceTitle
            // 
            this.lblTopServiceTitle.AutoSize = true;
            this.lblTopServiceTitle.ForeColor = System.Drawing.Color.Gray;
            this.lblTopServiceTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTopServiceTitle.Name = "lblTopServiceTitle";
            this.lblTopServiceTitle.Size = new System.Drawing.Size(126, 13);
            this.lblTopServiceTitle.TabIndex = 0;
            this.lblTopServiceTitle.Text = "Top Service (This Month)";
            // 
            // lblTopServiceName
            // 
            this.lblTopServiceName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTopServiceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.lblTopServiceName.Location = new System.Drawing.Point(22, 38);
            this.lblTopServiceName.Name = "lblTopServiceName";
            this.lblTopServiceName.Size = new System.Drawing.Size(205, 43);
            this.lblTopServiceName.TabIndex = 1;
            this.lblTopServiceName.Text = "-";
            this.lblTopServiceName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblTopServiceCount
            // 
            this.lblTopServiceCount.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.lblTopServiceCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.lblTopServiceCount.Location = new System.Drawing.Point(233, 40);
            this.lblTopServiceCount.Name = "lblTopServiceCount";
            this.lblTopServiceCount.Size = new System.Drawing.Size(163, 43);
            this.lblTopServiceCount.TabIndex = 2;
            this.lblTopServiceCount.Text = "0";
            // 
            // lblTopServicesHeader
            // 
            this.lblTopServicesHeader.AutoSize = true;
            this.lblTopServicesHeader.Font = new System.Drawing.Font("Segoe UI Semibold", 11F, System.Drawing.FontStyle.Bold);
            this.lblTopServicesHeader.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblTopServicesHeader.Location = new System.Drawing.Point(16, 248);
            this.lblTopServicesHeader.Name = "lblTopServicesHeader";
            this.lblTopServicesHeader.Size = new System.Drawing.Size(297, 20);
            this.lblTopServicesHeader.TabIndex = 8;
            this.lblTopServicesHeader.Text = "Top Services by Reservations (This Month)";
            // 
            // dgvTopServices
            // 
            this.dgvTopServices.AllowUserToAddRows = false;
            this.dgvTopServices.AllowUserToDeleteRows = false;
            this.dgvTopServices.AllowUserToResizeColumns = false;
            this.dgvTopServices.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvTopServices.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvTopServices.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Tahoma", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(234)))), ((int)(((byte)(237)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTopServices.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvTopServices.ColumnHeadersHeight = 40;
            this.dgvTopServices.ColumnHeadersVisible = false;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTopServices.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvTopServices.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvTopServices.Location = new System.Drawing.Point(16, 281);
            this.dgvTopServices.MultiSelect = false;
            this.dgvTopServices.Name = "dgvTopServices";
            this.dgvTopServices.ReadOnly = true;
            this.dgvTopServices.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvTopServices.RowHeadersVisible = false;
            this.dgvTopServices.RowTemplate.Height = 60;
            this.dgvTopServices.Size = new System.Drawing.Size(868, 280);
            this.dgvTopServices.TabIndex = 18;
            this.dgvTopServices.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.White;
            this.dgvTopServices.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopServices.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTopServices.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTopServices.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTopServices.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTopServices.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopServices.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(248)))), ((int)(((byte)(249)))));
            this.dgvTopServices.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopServices.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTopServices.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Tahoma", 9F);
            this.dgvTopServices.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvTopServices.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvTopServices.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTopServices.ThemeStyle.ReadOnly = true;
            this.dgvTopServices.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTopServices.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTopServices.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold);
            this.dgvTopServices.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            this.dgvTopServices.ThemeStyle.RowsStyle.Height = 60;
            this.dgvTopServices.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.White;
            this.dgvTopServices.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(125)))), ((int)(((byte)(255)))));
            // 
            // ucReservationsDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvTopServices);
            this.Controls.Add(this.pnlTodayTotal);
            this.Controls.Add(this.pnlTodayNew);
            this.Controls.Add(this.pnlTodayCompleted);
            this.Controls.Add(this.pnlTodayCancelled);
            this.Controls.Add(this.pnlMonthTotal);
            this.Controls.Add(this.pnlYearTotal);
            this.Controls.Add(this.pnlTopService);
            this.Controls.Add(this.lblTopServicesHeader);
            this.Name = "ucReservationsDashboard";
            this.Size = new System.Drawing.Size(895, 580);
            this.Load += new System.EventHandler(this.ucReservationsDashboard_Load);
            this.pnlTodayTotal.ResumeLayout(false);
            this.pnlTodayTotal.PerformLayout();
            this.pnlTodayNew.ResumeLayout(false);
            this.pnlTodayNew.PerformLayout();
            this.pnlTodayCompleted.ResumeLayout(false);
            this.pnlTodayCompleted.PerformLayout();
            this.pnlTodayCancelled.ResumeLayout(false);
            this.pnlTodayCancelled.PerformLayout();
            this.pnlMonthTotal.ResumeLayout(false);
            this.pnlMonthTotal.PerformLayout();
            this.pnlYearTotal.ResumeLayout(false);
            this.pnlYearTotal.PerformLayout();
            this.pnlTopService.ResumeLayout(false);
            this.pnlTopService.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTopServices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTodayTotal;
        private System.Windows.Forms.Label lblTodayTotalTitle;
        private System.Windows.Forms.Label lblTodayTotalValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTodayNew;
        private System.Windows.Forms.Label lblTodayNewTitle;
        private System.Windows.Forms.Label lblTodayNewValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTodayCompleted;
        private System.Windows.Forms.Label lblTodayCompletedTitle;
        private System.Windows.Forms.Label lblTodayCompletedValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTodayCancelled;
        private System.Windows.Forms.Label lblTodayCancelledTitle;
        private System.Windows.Forms.Label lblTodayCancelledValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlMonthTotal;
        private System.Windows.Forms.Label lblMonthTotalTitle;
        private System.Windows.Forms.Label lblMonthTotalValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlYearTotal;
        private System.Windows.Forms.Label lblYearTotalTitle;
        private System.Windows.Forms.Label lblYearTotalValue;
        private Guna.UI2.WinForms.Guna2ShadowPanel pnlTopService;
        private System.Windows.Forms.Label lblTopServiceTitle;
        private System.Windows.Forms.Label lblTopServiceName;
        private System.Windows.Forms.Label lblTopServiceCount;
        private System.Windows.Forms.Label lblTopServicesHeader;
        private Guna2DataGridView dgvTopServices;
    }
}
