namespace ViewChat
{
    partial class Form1
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
            this.dockManager1 = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.dockPanel1 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.dockPanel2 = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.memoEdit2 = new DevExpress.XtraEditors.MemoEdit();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).BeginInit();
            this.dockPanel1.SuspendLayout();
            this.dockPanel2.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dockManager1
            // 
            this.dockManager1.Form = this;
            this.dockManager1.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.dockPanel1,
            this.dockPanel2});
            this.dockManager1.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "DevExpress.XtraBars.StandaloneBarDockControl",
            "System.Windows.Forms.MenuStrip",
            "System.Windows.Forms.StatusStrip",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl",
            "DevExpress.XtraBars.Navigation.OfficeNavigationBar",
            "DevExpress.XtraBars.Navigation.TileNavPane",
            "DevExpress.XtraBars.TabFormControl",
            "DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl",
            "DevExpress.XtraBars.ToolbarForm.ToolbarFormControl"});
            // 
            // dockPanel1
            // 
            this.dockPanel1.Controls.Add(this.dockPanel1_Container);
            this.dockPanel1.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.dockPanel1.ID = new System.Guid("2729238e-07bb-4307-9dff-059b68e8a9ed");
            this.dockPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel1.Name = "dockPanel1";
            this.dockPanel1.Options.AllowDockAsTabbedDocument = false;
            this.dockPanel1.Options.AllowDockBottom = false;
            this.dockPanel1.Options.AllowDockFill = false;
            this.dockPanel1.Options.AllowDockRight = false;
            this.dockPanel1.Options.AllowDockTop = false;
            this.dockPanel1.Options.AllowFloating = false;
            this.dockPanel1.Options.ShowAutoHideButton = false;
            this.dockPanel1.Options.ShowCloseButton = false;
            this.dockPanel1.Options.ShowMaximizeButton = false;
            this.dockPanel1.Options.ShowMinimizeButton = false;
            this.dockPanel1.OriginalSize = new System.Drawing.Size(368, 200);
            this.dockPanel1.Size = new System.Drawing.Size(368, 1026);
            this.dockPanel1.Text = "User List";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Location = new System.Drawing.Point(6, 42);
            this.dockPanel1_Container.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(351, 978);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // dockPanel2
            // 
            this.dockPanel2.Controls.Add(this.dockPanel2_Container);
            this.dockPanel2.Dock = DevExpress.XtraBars.Docking.DockingStyle.Fill;
            this.dockPanel2.ID = new System.Guid("7db4e694-8c6d-4772-a4dd-7ebc853b70cb");
            this.dockPanel2.Location = new System.Drawing.Point(368, 0);
            this.dockPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel2.Name = "dockPanel2";
            this.dockPanel2.Options.AllowDockAsTabbedDocument = false;
            this.dockPanel2.Options.AllowDockBottom = false;
            this.dockPanel2.Options.AllowDockFill = false;
            this.dockPanel2.Options.AllowDockLeft = false;
            this.dockPanel2.Options.AllowDockRight = false;
            this.dockPanel2.Options.AllowDockTop = false;
            this.dockPanel2.Options.AllowFloating = false;
            this.dockPanel2.Options.ShowAutoHideButton = false;
            this.dockPanel2.Options.ShowCloseButton = false;
            this.dockPanel2.Options.ShowMaximizeButton = false;
            this.dockPanel2.Options.ShowMinimizeButton = false;
            this.dockPanel2.OriginalSize = new System.Drawing.Size(1165, 200);
            this.dockPanel2.Size = new System.Drawing.Size(1548, 1026);
            this.dockPanel2.Text = "ChatBody";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.simpleButton1);
            this.dockPanel2_Container.Controls.Add(this.memoEdit2);
            this.dockPanel2_Container.Controls.Add(this.memoEdit1);
            this.dockPanel2_Container.Location = new System.Drawing.Point(6, 42);
            this.dockPanel2_Container.Margin = new System.Windows.Forms.Padding(4);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(1536, 978);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(1461, 914);
            this.simpleButton1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 64);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = ">";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // memoEdit2
            // 
            this.memoEdit2.Location = new System.Drawing.Point(8, 914);
            this.memoEdit2.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.memoEdit2.Name = "memoEdit2";
            this.memoEdit2.Size = new System.Drawing.Size(1445, 64);
            this.memoEdit2.TabIndex = 2;
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.memoEdit1.Enabled = false;
            this.memoEdit1.Location = new System.Drawing.Point(0, 0);
            this.memoEdit1.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(1536, 862);
            this.memoEdit1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1916, 1026);
            this.Controls.Add(this.dockPanel2);
            this.Controls.Add(this.dockPanel1);
            this.Margin = new System.Windows.Forms.Padding(8, 7, 8, 7);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dockManager1)).EndInit();
            this.dockPanel1.ResumeLayout(false);
            this.dockPanel2.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Docking.DockManager dockManager1;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel1;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private DevExpress.XtraBars.Docking.DockPanel dockPanel2;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.MemoEdit memoEdit2;
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
    }
}

