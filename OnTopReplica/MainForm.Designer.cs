﻿namespace OnTopReplica
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuContextWindows = new System.Windows.Forms.ToolStripMenuItem();
            this.menuWindows = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.noneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.switchToWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectRegionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.advancedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickForwardingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clickThroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupSwitchModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextOpacity = new System.Windows.Forms.ToolStripMenuItem();
            this.menuOpacity = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.fullOpacityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuResize = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.doubleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.fitToWindowToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.halfToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quarterToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.fullscreenToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomLeftToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomRightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chromeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reduceToIconToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.languageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuLanguages = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.englishToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cestinaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danskToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.italianoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContextClose = new System.Windows.Forms.ToolStripMenuItem();
            this.fullSelectWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.danskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuFullscreenContext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.enableClickthroughToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fullExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuContext.SuspendLayout();
            this.menuWindows.SuspendLayout();
            this.menuOpacity.SuspendLayout();
            this.menuResize.SuspendLayout();
            this.menuLanguages.SuspendLayout();
            this.menuFullscreenContext.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuContext
            // 
            this.menuContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuContextWindows,
            this.switchToWindowToolStripMenuItem,
            this.selectRegionToolStripMenuItem,
            this.advancedToolStripMenuItem,
            this.menuContextOpacity,
            this.resizeToolStripMenuItem,
            this.dockToolStripMenuItem,
            this.chromeToolStripMenuItem,
            this.reduceToIconToolStripMenuItem,
            this.toolStripSeparator1,
            this.languageToolStripMenuItem,
            this.aboutToolStripMenuItem,
            this.menuContextClose});
            this.menuContext.Name = "menuContext";
            this.menuContext.Size = new System.Drawing.Size(169, 296);
            this.menuContext.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_opening);
            // 
            // menuContextWindows
            // 
            this.menuContextWindows.DropDown = this.menuWindows;
            this.menuContextWindows.Image = global::OnTopReplica.Properties.Resources.window_multiple16;
            this.menuContextWindows.Name = "menuContextWindows";
            this.menuContextWindows.Size = new System.Drawing.Size(168, 22);
            this.menuContextWindows.Text = global::OnTopReplica.Strings.MenuWindows;
            this.menuContextWindows.ToolTipText = global::OnTopReplica.Strings.MenuWindowsTT;
            // 
            // menuWindows
            // 
            this.menuWindows.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.noneToolStripMenuItem});
            this.menuWindows.Name = "menuWindows";
            this.menuWindows.OwnerItem = this.fullSelectWindowToolStripMenuItem;
            this.menuWindows.Size = new System.Drawing.Size(118, 26);
            this.menuWindows.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_Windows_opening);
            // 
            // noneToolStripMenuItem
            // 
            this.noneToolStripMenuItem.Name = "noneToolStripMenuItem";
            this.noneToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.noneToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuWindowsNone;
            // 
            // switchToWindowToolStripMenuItem
            // 
            this.switchToWindowToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.window_switch;
            this.switchToWindowToolStripMenuItem.Name = "switchToWindowToolStripMenuItem";
            this.switchToWindowToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.switchToWindowToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuSwitch;
            this.switchToWindowToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuSwitchTT;
            this.switchToWindowToolStripMenuItem.Click += new System.EventHandler(this.Menu_Switch_click);
            // 
            // selectRegionToolStripMenuItem
            // 
            this.selectRegionToolStripMenuItem.Enabled = false;
            this.selectRegionToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.regions;
            this.selectRegionToolStripMenuItem.Name = "selectRegionToolStripMenuItem";
            this.selectRegionToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.selectRegionToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuRegion;
            this.selectRegionToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuRegionTT;
            this.selectRegionToolStripMenuItem.Click += new System.EventHandler(this.Menu_Region_click);
            // 
            // advancedToolStripMenuItem
            // 
            this.advancedToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clickForwardingToolStripMenuItem,
            this.clickThroughToolStripMenuItem,
            this.groupSwitchModeToolStripMenuItem});
            this.advancedToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.xiao_wrench;
            this.advancedToolStripMenuItem.Name = "advancedToolStripMenuItem";
            this.advancedToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.advancedToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuAdvanced;
            // 
            // clickForwardingToolStripMenuItem
            // 
            this.clickForwardingToolStripMenuItem.Name = "clickForwardingToolStripMenuItem";
            this.clickForwardingToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.clickForwardingToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuClickForwarding;
            this.clickForwardingToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuClickForwardingTT;
            this.clickForwardingToolStripMenuItem.Click += new System.EventHandler(this.Menu_ClickForwarding_click);
            // 
            // clickThroughToolStripMenuItem
            // 
            this.clickThroughToolStripMenuItem.Name = "clickThroughToolStripMenuItem";
            this.clickThroughToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.clickThroughToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuClickThrough;
            this.clickThroughToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuClickThroughTT;
            this.clickThroughToolStripMenuItem.Click += new System.EventHandler(this.Menu_ClickThrough_click);
            // 
            // groupSwitchModeToolStripMenuItem
            // 
            this.groupSwitchModeToolStripMenuItem.Name = "groupSwitchModeToolStripMenuItem";
            this.groupSwitchModeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            this.groupSwitchModeToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuGroupSwitch;
            this.groupSwitchModeToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuGroupSwitchTT;
            this.groupSwitchModeToolStripMenuItem.Click += new System.EventHandler(this.Menu_GroupSwitchMode_click);
            // 
            // menuContextOpacity
            // 
            this.menuContextOpacity.DropDown = this.menuOpacity;
            this.menuContextOpacity.Image = global::OnTopReplica.Properties.Resources.window_opacity16;
            this.menuContextOpacity.Name = "menuContextOpacity";
            this.menuContextOpacity.Size = new System.Drawing.Size(168, 22);
            this.menuContextOpacity.Text = global::OnTopReplica.Strings.MenuOpacity;
            // 
            // menuOpacity
            // 
            this.menuOpacity.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
            this.menuOpacity.Name = "menuOpacity";
            this.menuOpacity.OwnerItem = this.menuContextOpacity;
            this.menuOpacity.ShowCheckMargin = true;
            this.menuOpacity.ShowImageMargin = false;
            this.menuOpacity.Size = new System.Drawing.Size(154, 92);
            this.menuOpacity.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_Opacity_opening);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Checked = true;
            this.toolStripMenuItem1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem1.Tag = 1D;
            this.toolStripMenuItem1.Text = global::OnTopReplica.Strings.MenuOp100;
            this.toolStripMenuItem1.ToolTipText = global::OnTopReplica.Strings.MenuOp100TT;
            this.toolStripMenuItem1.Click += new System.EventHandler(this.Menu_Opacity_click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem2.Tag = 0.75D;
            this.toolStripMenuItem2.Text = global::OnTopReplica.Strings.MenuOp75;
            this.toolStripMenuItem2.ToolTipText = global::OnTopReplica.Strings.MenuOp75TT;
            this.toolStripMenuItem2.Click += new System.EventHandler(this.Menu_Opacity_click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem3.Tag = 0.5D;
            this.toolStripMenuItem3.Text = global::OnTopReplica.Strings.MenuOp50;
            this.toolStripMenuItem3.ToolTipText = global::OnTopReplica.Strings.MenuOp50TT;
            this.toolStripMenuItem3.Click += new System.EventHandler(this.Menu_Opacity_click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(153, 22);
            this.toolStripMenuItem4.Tag = 0.25D;
            this.toolStripMenuItem4.Text = global::OnTopReplica.Strings.MenuOp25;
            this.toolStripMenuItem4.ToolTipText = global::OnTopReplica.Strings.MenuOp25TT;
            this.toolStripMenuItem4.Click += new System.EventHandler(this.Menu_Opacity_click);
            // 
            // fullOpacityToolStripMenuItem
            // 
            this.fullOpacityToolStripMenuItem.DropDown = this.menuOpacity;
            this.fullOpacityToolStripMenuItem.Name = "fullOpacityToolStripMenuItem";
            this.fullOpacityToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fullOpacityToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuOpacity;
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.DropDown = this.menuResize;
            this.resizeToolStripMenuItem.Enabled = false;
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.resizeToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuResize;
            // 
            // menuResize
            // 
            this.menuResize.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doubleToolStripMenuItem1,
            this.fitToWindowToolStripMenuItem1,
            this.halfToolStripMenuItem1,
            this.quarterToolStripMenuItem1,
            this.toolStripSeparator3,
            this.fullscreenToolStripMenuItem1});
            this.menuResize.Name = "menuResize";
            this.menuResize.OwnerItem = this.resizeToolStripMenuItem;
            this.menuResize.Size = new System.Drawing.Size(165, 120);
            this.menuResize.Opening += new System.ComponentModel.CancelEventHandler(this.Menu_Resize_opening);
            // 
            // doubleToolStripMenuItem1
            // 
            this.doubleToolStripMenuItem1.Name = "doubleToolStripMenuItem1";
            this.doubleToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.doubleToolStripMenuItem1.Text = global::OnTopReplica.Strings.MenuFitDouble;
            this.doubleToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Resize_Double);
            // 
            // fitToWindowToolStripMenuItem1
            // 
            this.fitToWindowToolStripMenuItem1.Name = "fitToWindowToolStripMenuItem1";
            this.fitToWindowToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.fitToWindowToolStripMenuItem1.Text = global::OnTopReplica.Strings.MenuFitOriginal;
            this.fitToWindowToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Resize_FitToWindow);
            // 
            // halfToolStripMenuItem1
            // 
            this.halfToolStripMenuItem1.Name = "halfToolStripMenuItem1";
            this.halfToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.halfToolStripMenuItem1.Text = global::OnTopReplica.Strings.MenuFitHalf;
            this.halfToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Resize_Half);
            // 
            // quarterToolStripMenuItem1
            // 
            this.quarterToolStripMenuItem1.Name = "quarterToolStripMenuItem1";
            this.quarterToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.quarterToolStripMenuItem1.Text = global::OnTopReplica.Strings.MenuFitQuarter;
            this.quarterToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Resize_Quarter);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(161, 6);
            // 
            // fullscreenToolStripMenuItem1
            // 
            this.fullscreenToolStripMenuItem1.Name = "fullscreenToolStripMenuItem1";
            this.fullscreenToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.fullscreenToolStripMenuItem1.Text = global::OnTopReplica.Strings.MenuFitFullscreen;
            this.fullscreenToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Resize_Fullscreen);
            // 
            // dockToolStripMenuItem
            // 
            this.dockToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.topLeftToolStripMenuItem,
            this.topRightToolStripMenuItem,
            this.bottomLeftToolStripMenuItem,
            this.bottomRightToolStripMenuItem});
            this.dockToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.pos_null;
            this.dockToolStripMenuItem.Name = "dockToolStripMenuItem";
            this.dockToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.dockToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuPosition;
            this.dockToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuPositionTT;
            // 
            // topLeftToolStripMenuItem
            // 
            this.topLeftToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.pos_topleft;
            this.topLeftToolStripMenuItem.Name = "topLeftToolStripMenuItem";
            this.topLeftToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.topLeftToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuPosTopLeft;
            this.topLeftToolStripMenuItem.Click += new System.EventHandler(this.Menu_Position_TopLeft);
            // 
            // topRightToolStripMenuItem
            // 
            this.topRightToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.pos_topright;
            this.topRightToolStripMenuItem.Name = "topRightToolStripMenuItem";
            this.topRightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.topRightToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuPosTopRight;
            this.topRightToolStripMenuItem.Click += new System.EventHandler(this.Menu_Position_TopRight);
            // 
            // bottomLeftToolStripMenuItem
            // 
            this.bottomLeftToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.pos_bottomleft;
            this.bottomLeftToolStripMenuItem.Name = "bottomLeftToolStripMenuItem";
            this.bottomLeftToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bottomLeftToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuPosBottomLeft;
            this.bottomLeftToolStripMenuItem.Click += new System.EventHandler(this.Menu_Position_BottomLeft);
            // 
            // bottomRightToolStripMenuItem
            // 
            this.bottomRightToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.pos_bottomright;
            this.bottomRightToolStripMenuItem.Name = "bottomRightToolStripMenuItem";
            this.bottomRightToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bottomRightToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuPosBottomRight;
            this.bottomRightToolStripMenuItem.Click += new System.EventHandler(this.Menu_Position_BottomRight);
            // 
            // chromeToolStripMenuItem
            // 
            this.chromeToolStripMenuItem.Name = "chromeToolStripMenuItem";
            this.chromeToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chromeToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuChrome;
            this.chromeToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuChromeTT;
            this.chromeToolStripMenuItem.Click += new System.EventHandler(this.Menu_Chrome_click);
            // 
            // reduceToIconToolStripMenuItem
            // 
            this.reduceToIconToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.reduce;
            this.reduceToIconToolStripMenuItem.Name = "reduceToIconToolStripMenuItem";
            this.reduceToIconToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.reduceToIconToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuReduce;
            this.reduceToIconToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuReduceTT;
            this.reduceToIconToolStripMenuItem.Click += new System.EventHandler(this.Menu_Reduce_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(165, 6);
            // 
            // languageToolStripMenuItem
            // 
            this.languageToolStripMenuItem.DropDown = this.menuLanguages;
            this.languageToolStripMenuItem.Name = "languageToolStripMenuItem";
            this.languageToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.languageToolStripMenuItem.Text = global::OnTopReplica.Strings.Language;
            // 
            // menuLanguages
            // 
            this.menuLanguages.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.englishToolStripMenuItem,
            this.cestinaToolStripMenuItem,
            this.danskToolStripMenuItem1,
            this.italianoToolStripMenuItem});
            this.menuLanguages.Name = "menuLanguages";
            this.menuLanguages.OwnerItem = this.languageToolStripMenuItem;
            this.menuLanguages.Size = new System.Drawing.Size(114, 92);
            this.menuLanguages.Text = "Dansk";
            // 
            // englishToolStripMenuItem
            // 
            this.englishToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.flag_usa;
            this.englishToolStripMenuItem.Name = "englishToolStripMenuItem";
            this.englishToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.englishToolStripMenuItem.Tag = "en-US";
            this.englishToolStripMenuItem.Text = "English";
            this.englishToolStripMenuItem.Click += new System.EventHandler(this.Menu_Language_click);
            // 
            // cestinaToolStripMenuItem
            // 
            this.cestinaToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.flag_czech;
            this.cestinaToolStripMenuItem.Name = "cestinaToolStripMenuItem";
            this.cestinaToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.cestinaToolStripMenuItem.Tag = "cs-CZ";
            this.cestinaToolStripMenuItem.Text = "Čeština";
            this.cestinaToolStripMenuItem.Click += new System.EventHandler(this.Menu_Language_click);
            // 
            // danskToolStripMenuItem1
            // 
            this.danskToolStripMenuItem1.Image = global::OnTopReplica.Properties.Resources.flag_danish;
            this.danskToolStripMenuItem1.Name = "danskToolStripMenuItem1";
            this.danskToolStripMenuItem1.Size = new System.Drawing.Size(113, 22);
            this.danskToolStripMenuItem1.Tag = "da-DK";
            this.danskToolStripMenuItem1.Text = "Dansk";
            this.danskToolStripMenuItem1.Click += new System.EventHandler(this.Menu_Language_click);
            // 
            // italianoToolStripMenuItem
            // 
            this.italianoToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.flag_ita;
            this.italianoToolStripMenuItem.Name = "italianoToolStripMenuItem";
            this.italianoToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.italianoToolStripMenuItem.Tag = "it-IT";
            this.italianoToolStripMenuItem.Text = "Italiano";
            this.italianoToolStripMenuItem.Click += new System.EventHandler(this.Menu_Language_click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.aboutToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuAbout;
            this.aboutToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuAboutTT;
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.Menu_About_click);
            // 
            // menuContextClose
            // 
            this.menuContextClose.Image = global::OnTopReplica.Properties.Resources.close_new;
            this.menuContextClose.Name = "menuContextClose";
            this.menuContextClose.Size = new System.Drawing.Size(168, 22);
            this.menuContextClose.Text = global::OnTopReplica.Strings.MenuClose;
            this.menuContextClose.Click += new System.EventHandler(this.Menu_Close_click);
            // 
            // fullSelectWindowToolStripMenuItem
            // 
            this.fullSelectWindowToolStripMenuItem.DropDown = this.menuWindows;
            this.fullSelectWindowToolStripMenuItem.Name = "fullSelectWindowToolStripMenuItem";
            this.fullSelectWindowToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.fullSelectWindowToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuWindows;
            this.fullSelectWindowToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuWindowsTT;
            // 
            // danskToolStripMenuItem
            // 
            this.danskToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.flag_danish;
            this.danskToolStripMenuItem.Name = "danskToolStripMenuItem";
            this.danskToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.danskToolStripMenuItem.Tag = "da-DA";
            this.danskToolStripMenuItem.Text = "Dansk";
            this.danskToolStripMenuItem.Click += new System.EventHandler(this.Menu_Language_click);
            // 
            // menuFullscreenContext
            // 
            this.menuFullscreenContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullSelectWindowToolStripMenuItem,
            this.fullOpacityToolStripMenuItem,
            this.enableClickthroughToolStripMenuItem,
            this.fullExitToolStripMenuItem});
            this.menuFullscreenContext.Name = "menuFullscreenContext";
            this.menuFullscreenContext.Size = new System.Drawing.Size(187, 114);
            // 
            // enableClickthroughToolStripMenuItem
            // 
            this.enableClickthroughToolStripMenuItem.Name = "enableClickthroughToolStripMenuItem";
            this.enableClickthroughToolStripMenuItem.Size = new System.Drawing.Size(186, 22);
            this.enableClickthroughToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuClickThrough;
            this.enableClickthroughToolStripMenuItem.ToolTipText = global::OnTopReplica.Strings.MenuClickThroughTT;
            this.enableClickthroughToolStripMenuItem.Click += new System.EventHandler(this.Menu_ClickThrough_click);
            // 
            // fullExitToolStripMenuItem
            // 
            this.fullExitToolStripMenuItem.Image = global::OnTopReplica.Properties.Resources.close_new;
            this.fullExitToolStripMenuItem.Name = "fullExitToolStripMenuItem";
            this.fullExitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fullExitToolStripMenuItem.Text = global::OnTopReplica.Strings.MenuQuitFullscreen;
            this.fullExitToolStripMenuItem.Click += new System.EventHandler(this.Menu_Fullscreen_ExitFullscreen_click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(264, 208);
            this.ControlBox = false;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(20, 20);
            this.Name = "MainForm";
            this.TopMost = true;
            this.menuContext.ResumeLayout(false);
            this.menuWindows.ResumeLayout(false);
            this.menuOpacity.ResumeLayout(false);
            this.menuResize.ResumeLayout(false);
            this.menuLanguages.ResumeLayout(false);
            this.menuFullscreenContext.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip menuContext;
        private System.Windows.Forms.ToolStripMenuItem menuContextWindows;
        private System.Windows.Forms.ToolStripMenuItem menuContextClose;
		private System.Windows.Forms.ContextMenuStrip menuWindows;
        private System.Windows.Forms.ToolStripMenuItem menuContextOpacity;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ContextMenuStrip menuOpacity;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reduceToIconToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem selectRegionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem noneToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem switchToWindowToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem dockToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem topLeftToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem topRightToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem bottomLeftToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomRightToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip menuResize;
		private System.Windows.Forms.ToolStripMenuItem doubleToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem fitToWindowToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem halfToolStripMenuItem1;
		private System.Windows.Forms.ToolStripMenuItem quarterToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fullscreenToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripMenuItem languageToolStripMenuItem;
		private System.Windows.Forms.ContextMenuStrip menuLanguages;
		private System.Windows.Forms.ToolStripMenuItem englishToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem italianoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cestinaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danskToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chromeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem danskToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip menuFullscreenContext;
        private System.Windows.Forms.ToolStripMenuItem fullSelectWindowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullOpacityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fullExitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem advancedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickForwardingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clickThroughToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem groupSwitchModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableClickthroughToolStripMenuItem;
    }
}

