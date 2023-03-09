namespace ActivityJournal
{
    partial class Home
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel_nav = new System.Windows.Forms.Panel();
            this.count_stages = new System.Windows.Forms.Label();
            this.count_research = new System.Windows.Forms.Label();
            this.count_attendence = new System.Windows.Forms.Label();
            this.count_tasks = new System.Windows.Forms.Label();
            this.count_activity = new System.Windows.Forms.Label();
            this.btn_stages = new System.Windows.Forms.Button();
            this.btn_research = new System.Windows.Forms.Button();
            this.btn_attendence = new System.Windows.Forms.Button();
            this.btn_tasks = new System.Windows.Forms.Button();
            this.btn_activity = new System.Windows.Forms.Button();
            this.lbl_page = new System.Windows.Forms.Label();
            this.panel_top = new System.Windows.Forms.Panel();
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.context_Menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.add = new System.Windows.Forms.ToolStripMenuItem();
            this.refresh = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.update = new System.Windows.Forms.ToolStripMenuItem();
            this.panel_nav.SuspendLayout();
            this.panel_top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.context_Menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_nav
            // 
            this.panel_nav.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel_nav.Controls.Add(this.count_stages);
            this.panel_nav.Controls.Add(this.count_research);
            this.panel_nav.Controls.Add(this.count_attendence);
            this.panel_nav.Controls.Add(this.count_tasks);
            this.panel_nav.Controls.Add(this.count_activity);
            this.panel_nav.Controls.Add(this.btn_stages);
            this.panel_nav.Controls.Add(this.btn_research);
            this.panel_nav.Controls.Add(this.btn_attendence);
            this.panel_nav.Controls.Add(this.btn_tasks);
            this.panel_nav.Controls.Add(this.btn_activity);
            this.panel_nav.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_nav.Location = new System.Drawing.Point(0, 80);
            this.panel_nav.Name = "panel_nav";
            this.panel_nav.Size = new System.Drawing.Size(155, 370);
            this.panel_nav.TabIndex = 0;
            // 
            // count_stages
            // 
            this.count_stages.AutoSize = true;
            this.count_stages.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.count_stages.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.count_stages.ForeColor = System.Drawing.Color.Gray;
            this.count_stages.Location = new System.Drawing.Point(123, 173);
            this.count_stages.Name = "count_stages";
            this.count_stages.Size = new System.Drawing.Size(13, 15);
            this.count_stages.TabIndex = 5;
            this.count_stages.Text = "0";
            // 
            // count_research
            // 
            this.count_research.AutoSize = true;
            this.count_research.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.count_research.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.count_research.ForeColor = System.Drawing.Color.Gray;
            this.count_research.Location = new System.Drawing.Point(124, 133);
            this.count_research.Name = "count_research";
            this.count_research.Size = new System.Drawing.Size(13, 15);
            this.count_research.TabIndex = 5;
            this.count_research.Text = "0";
            // 
            // count_attendence
            // 
            this.count_attendence.AutoSize = true;
            this.count_attendence.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.count_attendence.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.count_attendence.ForeColor = System.Drawing.Color.Gray;
            this.count_attendence.Location = new System.Drawing.Point(123, 93);
            this.count_attendence.Name = "count_attendence";
            this.count_attendence.Size = new System.Drawing.Size(13, 15);
            this.count_attendence.TabIndex = 5;
            this.count_attendence.Text = "0";
            // 
            // count_tasks
            // 
            this.count_tasks.AutoSize = true;
            this.count_tasks.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.count_tasks.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.count_tasks.ForeColor = System.Drawing.Color.Gray;
            this.count_tasks.Location = new System.Drawing.Point(124, 53);
            this.count_tasks.Name = "count_tasks";
            this.count_tasks.Size = new System.Drawing.Size(13, 15);
            this.count_tasks.TabIndex = 5;
            this.count_tasks.Text = "0";
            // 
            // count_activity
            // 
            this.count_activity.AutoSize = true;
            this.count_activity.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.count_activity.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.count_activity.ForeColor = System.Drawing.Color.Gray;
            this.count_activity.Location = new System.Drawing.Point(124, 14);
            this.count_activity.Name = "count_activity";
            this.count_activity.Size = new System.Drawing.Size(13, 15);
            this.count_activity.TabIndex = 5;
            this.count_activity.Text = "0";
            // 
            // btn_stages
            // 
            this.btn_stages.BackColor = System.Drawing.Color.Transparent;
            this.btn_stages.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_stages.FlatAppearance.BorderSize = 0;
            this.btn_stages.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_stages.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_stages.ForeColor = System.Drawing.Color.Gray;
            this.btn_stages.Location = new System.Drawing.Point(0, 160);
            this.btn_stages.Name = "btn_stages";
            this.btn_stages.Size = new System.Drawing.Size(155, 40);
            this.btn_stages.TabIndex = 4;
            this.btn_stages.Text = "Stages";
            this.btn_stages.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_stages.UseVisualStyleBackColor = false;
            this.btn_stages.Click += new System.EventHandler(this.Btn_stages_Click);
            // 
            // btn_research
            // 
            this.btn_research.BackColor = System.Drawing.Color.Transparent;
            this.btn_research.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_research.FlatAppearance.BorderSize = 0;
            this.btn_research.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_research.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_research.ForeColor = System.Drawing.Color.Gray;
            this.btn_research.Location = new System.Drawing.Point(0, 120);
            this.btn_research.Name = "btn_research";
            this.btn_research.Size = new System.Drawing.Size(155, 40);
            this.btn_research.TabIndex = 3;
            this.btn_research.Text = "Research";
            this.btn_research.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_research.UseVisualStyleBackColor = false;
            this.btn_research.Click += new System.EventHandler(this.Btn_research_Click);
            // 
            // btn_attendence
            // 
            this.btn_attendence.BackColor = System.Drawing.Color.Transparent;
            this.btn_attendence.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_attendence.FlatAppearance.BorderSize = 0;
            this.btn_attendence.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_attendence.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_attendence.ForeColor = System.Drawing.Color.Gray;
            this.btn_attendence.Location = new System.Drawing.Point(0, 80);
            this.btn_attendence.Name = "btn_attendence";
            this.btn_attendence.Size = new System.Drawing.Size(155, 40);
            this.btn_attendence.TabIndex = 2;
            this.btn_attendence.Text = "Attendence";
            this.btn_attendence.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_attendence.UseVisualStyleBackColor = false;
            this.btn_attendence.Click += new System.EventHandler(this.Btn_attendence_Click);
            // 
            // btn_tasks
            // 
            this.btn_tasks.BackColor = System.Drawing.Color.Transparent;
            this.btn_tasks.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_tasks.FlatAppearance.BorderSize = 0;
            this.btn_tasks.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_tasks.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tasks.ForeColor = System.Drawing.Color.Gray;
            this.btn_tasks.Location = new System.Drawing.Point(0, 40);
            this.btn_tasks.Name = "btn_tasks";
            this.btn_tasks.Size = new System.Drawing.Size(155, 40);
            this.btn_tasks.TabIndex = 1;
            this.btn_tasks.Text = "Tasks";
            this.btn_tasks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_tasks.UseVisualStyleBackColor = false;
            this.btn_tasks.Click += new System.EventHandler(this.Btn_task_Click);
            // 
            // btn_activity
            // 
            this.btn_activity.BackColor = System.Drawing.Color.Transparent;
            this.btn_activity.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_activity.FlatAppearance.BorderSize = 0;
            this.btn_activity.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.btn_activity.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_activity.ForeColor = System.Drawing.Color.Gray;
            this.btn_activity.Location = new System.Drawing.Point(0, 0);
            this.btn_activity.Name = "btn_activity";
            this.btn_activity.Size = new System.Drawing.Size(155, 40);
            this.btn_activity.TabIndex = 0;
            this.btn_activity.Text = "Activity";
            this.btn_activity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_activity.UseVisualStyleBackColor = false;
            this.btn_activity.Click += new System.EventHandler(this.Btn_activity_Click);
            // 
            // lbl_page
            // 
            this.lbl_page.AutoSize = true;
            this.lbl_page.ForeColor = System.Drawing.Color.White;
            this.lbl_page.Location = new System.Drawing.Point(15, 14);
            this.lbl_page.Name = "lbl_page";
            this.lbl_page.Size = new System.Drawing.Size(43, 13);
            this.lbl_page.TabIndex = 0;
            this.lbl_page.Text = "Activity";
            // 
            // panel_top
            // 
            this.panel_top.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(32)))));
            this.panel_top.Controls.Add(this.lbl_page);
            this.panel_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_top.Location = new System.Drawing.Point(0, 0);
            this.panel_top.Name = "panel_top";
            this.panel_top.Size = new System.Drawing.Size(800, 80);
            this.panel_top.TabIndex = 2;
            // 
            // dataGrid
            // 
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid.ContextMenuStrip = this.context_Menu;
            this.dataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.Location = new System.Drawing.Point(155, 80);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.Size = new System.Drawing.Size(645, 370);
            this.dataGrid.TabIndex = 3;
            this.dataGrid.CellLeave += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGrid_CellLeave);
            // 
            // context_Menu
            // 
            this.context_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.add,
            this.refresh,
            this.delete,
            this.update});
            this.context_Menu.Name = "context_Menu";
            this.context_Menu.Size = new System.Drawing.Size(114, 92);
            // 
            // add
            // 
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(113, 22);
            this.add.Text = "Add";
            this.add.Click += new System.EventHandler(this.Add_Click);
            // 
            // refresh
            // 
            this.refresh.Name = "refresh";
            this.refresh.Size = new System.Drawing.Size(113, 22);
            this.refresh.Text = "Refresh";
            // 
            // delete
            // 
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(113, 22);
            this.delete.Text = "Delete";
            // 
            // update
            // 
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(113, 22);
            this.update.Text = "Update";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(24)))), ((int)(((byte)(24)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.panel_nav);
            this.Controls.Add(this.panel_top);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Home";
            this.Text = "Activity Journal";
            this.panel_nav.ResumeLayout(false);
            this.panel_nav.PerformLayout();
            this.panel_top.ResumeLayout(false);
            this.panel_top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.context_Menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_nav;
        private System.Windows.Forms.Button btn_stages;
        private System.Windows.Forms.Button btn_research;
        private System.Windows.Forms.Button btn_attendence;
        private System.Windows.Forms.Button btn_tasks;
        private System.Windows.Forms.Button btn_activity;
        private System.Windows.Forms.Panel panel_top;
        private System.Windows.Forms.Label lbl_page;
        private System.Windows.Forms.Label count_stages;
        private System.Windows.Forms.Label count_research;
        private System.Windows.Forms.Label count_attendence;
        private System.Windows.Forms.Label count_tasks;
        private System.Windows.Forms.Label count_activity;
        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.ContextMenuStrip context_Menu;
        private System.Windows.Forms.ToolStripMenuItem add;
        private System.Windows.Forms.ToolStripMenuItem refresh;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private System.Windows.Forms.ToolStripMenuItem update;
    }
}

