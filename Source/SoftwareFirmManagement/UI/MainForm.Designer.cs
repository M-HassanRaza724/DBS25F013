using ComponentFactory.Krypton.Toolkit;
using System.Drawing;

namespace SoftwareFirmManagement.UI
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
            this.MainPalette = new ComponentFactory.Krypton.Toolkit.KryptonPalette(this.components);
            this.kryptonManager1 = new ComponentFactory.Krypton.Toolkit.KryptonManager(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_max_min = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btn_size = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.pnl_main = new System.Windows.Forms.Panel();
            this.pnl_user_management = new System.Windows.Forms.Panel();
            this.btn_employee_management = new System.Windows.Forms.Button();
            this.btn_admin_management = new System.Windows.Forms.Button();
            this.btn_customer_management = new System.Windows.Forms.Button();
            this.pnl_dashboard = new System.Windows.Forms.Panel();
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.pnl_services = new System.Windows.Forms.Panel();
            this.pnl_order_management = new System.Windows.Forms.Panel();
            this.header1 = new SoftwareFirmManagement.UI.Header();
            this.sidePanel1 = new SoftwareFirmManagement.UI.SidePanel();
            this.pnl_reviews = new System.Windows.Forms.Panel();
            this.btn_reviews = new System.Windows.Forms.Button();
            this.btn_order_management = new System.Windows.Forms.Button();
            this.btn_services = new System.Windows.Forms.Button();
            this.btn_menu = new System.Windows.Forms.Button();
            this.btn_dashboard = new System.Windows.Forms.Button();
            this.btn_user_management = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnl_user_management.SuspendLayout();
            this.pnl_dashboard.SuspendLayout();
            this.pnl_menu.SuspendLayout();
            this.pnl_services.SuspendLayout();
            this.pnl_order_management.SuspendLayout();
            this.pnl_reviews.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainPalette
            // 
            this.MainPalette.BasePaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonAlternate.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateDisabled.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateDisabled.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(45)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(35)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(45)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(35)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateTracking.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonAlternate.StateTracking.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonAlternate.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCluster.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Content.LongText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Content.LongText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Content.LongText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Content.LongText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.Rounding = 10;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Border.Width = 4;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.LongText.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.Padding = new System.Windows.Forms.Padding(0);
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonCluster.StateCommon.Content.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Content.LongText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Content.LongText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCluster.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonCluster.StateTracking.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateTracking.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCluster.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCluster.StateTracking.Content.ShortText.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom1.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DarkBlue;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.DarkBlue;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateDisabled.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateDisabled.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(180)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(180)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom1.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateTracking.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom1.StateTracking.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom1.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateDisabled.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(45)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(100)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateDisabled.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(180)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(180)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCustom2.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DarkBlue;
            this.MainPalette.ButtonStyles.ButtonCustom2.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DarkBlue;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCustom3.OverrideFocus.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.DarkBlue;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.DarkBlue;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateDisabled.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(35)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateDisabled.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCustom3.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateTracking.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonCustom3.StateTracking.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonCustom3.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonInputControl.OverrideDefault.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(75)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(110)))), ((int)(((byte)(60)))), ((int)(((byte)(230)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonInputControl.StateCommon.Content.ShortText.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(180)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(65)))), ((int)(((byte)(180)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(50)))), ((int)(((byte)(200)))));
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonInputControl.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonListItem.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonListItem.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonListItem.OverrideDefault.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.MainPalette.ButtonStyles.ButtonListItem.OverrideDefault.Content.Padding = new System.Windows.Forms.Padding(5, -1, -1, -1);
            this.MainPalette.ButtonStyles.ButtonListItem.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonListItem.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Content.Padding = new System.Windows.Forms.Padding(5, -1, -1, -1);
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Border.Width = 1;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Content.Image.Effect = ComponentFactory.Krypton.Toolkit.PaletteImageEffect.Disabled;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonListItem.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateDisabled.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(80)))), ((int)(((byte)(60)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(60)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateDisabled.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(45)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(35)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(75)))), ((int)(((byte)(45)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(60)))), ((int)(((byte)(35)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(70)))), ((int)(((byte)(40)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(90)))), ((int)(((byte)(50)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPalette.ButtonStyles.ButtonLowProfile.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.OverrideDefault.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedNormal.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedPressed.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCheckedTracking.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Back.ImageAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Rounding = 20;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Border.Width = 3;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.LongText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateDisabled.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateDisabled.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateDisabled.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(40)))), ((int)(((byte)(140)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateDisabled.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(80)))), ((int)(((byte)(120)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateDisabled.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateDisabled.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Back.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(45)))), ((int)(((byte)(190)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(35)))), ((int)(((byte)(210)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.ColorAngle = 135F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Color1 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StatePressed.Content.ShortText.Color2 = System.Drawing.Color.MidnightBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Back.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(40)))), ((int)(((byte)(240)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.ColorAngle = 45F;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Color1 = System.Drawing.Color.DarkBlue;
            this.MainPalette.ButtonStyles.ButtonStandalone.StateTracking.Content.ShortText.Color2 = System.Drawing.Color.DarkBlue;
            this.MainPalette.CalendarDay.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.CalendarDay.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.CalendarDay.StateCommon.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Form;
            this.MainPalette.CalendarDay.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.CalendarDay.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.CalendarDay.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.CalendarDay.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.CalendarDay.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.CalendarDay.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.CalendarDay.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.Cargo.Font1 = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.Cargo.Font2 = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ContextMenu.StateCommon.ItemHighlight.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ContextMenu.StateCommon.ItemHighlight.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ContextMenu.StateCommon.ItemHighlight.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ContextMenu.StateCommon.ItemHighlight.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.ContextMenu.StateCommon.ItemHighlight.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ContextMenu.StateCommon.ItemTextStandard.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ContextMenu.StateCommon.ItemTextStandard.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ContextMenu.StateCommon.ItemTextStandard.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.ControlStyles.ControlAlternate.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ControlStyles.ControlAlternate.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.ControlStyles.ControlAlternate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ControlStyles.ControlAlternate.StateCommon.Border.Rounding = 20;
            this.MainPalette.ControlStyles.ControlAlternate.StateCommon.Border.Width = 3;
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Border.Rounding = 20;
            this.MainPalette.ControlStyles.ControlCommon.StateCommon.Border.Width = 1;
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Border.Rounding = 20;
            this.MainPalette.ControlStyles.ControlGroupBox.StateCommon.Border.Width = 1;
            this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.MainPalette.FormStyles.FormMain.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.MainPalette.FormStyles.FormMain.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.MainPalette.FormStyles.FormMain.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.MainPalette.FormStyles.FormMain.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.FormStyles.FormMain.StateCommon.Border.Rounding = 20;
            this.MainPalette.FormStyles.FormMain.StateCommon.Border.Width = 0;
            this.MainPalette.GridStyles.GridCommon.StateCommon.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.None;
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.DataCell.Content.Padding = new System.Windows.Forms.Padding(-1, 3, -1, 3);
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.DrawBorders = ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom;
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Border.Width = 2;
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderColumn.Content.Padding = new System.Windows.Forms.Padding(5, -1, -1, 0);
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateCommon.HeaderRow.Content.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.Background.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.Background.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.HeaderColumn.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.HeaderColumn.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.HeaderColumn.Back.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.GridStyles.GridCommon.StateDisabled.HeaderRow.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateDisabled.HeaderRow.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateSelected.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridCommon.StateSelected.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.GridStyles.GridList.StateCommon.BackStyle = ComponentFactory.Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Border.ColorAlign = ComponentFactory.Krypton.Toolkit.PaletteRectangleAlign.Local;
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Border.Rounding = 20;
            this.MainPalette.GridStyles.GridList.StateCommon.DataCell.Border.Width = 1;
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Back.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Rounding = 10;
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Border.Width = 1;
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.InputControlStyles.InputControlCommon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.InputControlStyles.InputControlCommon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.InputControlStyles.InputControlCommon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.InputControlStyles.InputControlCommon.StateCommon.Border.Rounding = 20;
            this.MainPalette.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.InputControlStyles.InputControlCommon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Back.ColorAngle = 90F;
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.ColorAngle = 0F;
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.ColorStyle = ComponentFactory.Krypton.Toolkit.PaletteColorStyle.Linear;
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.False;
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.Rounding = 20;
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Border.Width = 1;
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Content.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Content.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.InputControlStyles.InputControlRibbon.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.LabelStyles.LabelCaptionPanel.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.LabelStyles.LabelCaptionPanel.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.LabelStyles.LabelCaptionPanel.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.LabelStyles.LabelCaptionPanel.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAliasGridFit;
            this.MainPalette.LabelStyles.LabelCommon.OverrideFocus.DrawFocus = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.MainPalette.LabelStyles.LabelCommon.OverrideFocus.ShortText.Color1 = System.Drawing.Color.Fuchsia;
            this.MainPalette.LabelStyles.LabelCommon.OverrideFocus.ShortText.Color2 = System.Drawing.Color.Purple;
            this.MainPalette.LabelStyles.LabelCommon.OverrideFocus.ShortText.ColorAngle = 45F;
            this.MainPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.MainPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.LabelStyles.LabelCommon.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.MainPalette.LabelStyles.LabelCustom1.OverrideFocus.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.LabelStyles.LabelCustom1.OverrideFocus.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(50)))), ((int)(((byte)(220)))));
            this.MainPalette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(235)))));
            this.MainPalette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainPalette.LabelStyles.LabelTitleControl.StateCommon.ShortText.Hint = ComponentFactory.Krypton.Toolkit.PaletteTextHint.AntiAlias;
            this.MainPalette.PanelStyles.PanelCommon.StateCommon.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.PanelStyles.PanelCommon.StateCommon.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.MainPalette.PanelStyles.PanelCommon.StateCommon.GraphicsHint = ComponentFactory.Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            // 
            // kryptonManager1
            // 
            this.kryptonManager1.GlobalPalette = this.MainPalette;
            this.kryptonManager1.GlobalPaletteMode = ComponentFactory.Krypton.Toolkit.PaletteModeManager.Custom;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_max_min);
            this.panel1.Controls.Add(this.btn_size);
            this.panel1.Controls.Add(this.header1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(60, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(905, 50);
            this.panel1.TabIndex = 5;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_close.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.Form;
            this.btn_close.Location = new System.Drawing.Point(869, 12);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(24, 24);
            this.btn_close.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_close.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_close.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_close.StateCommon.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Close;
            this.btn_close.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_close.StatePressed.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btn_close.StatePressed.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btn_close.StatePressed.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Cross_Mark;
            this.btn_close.StateTracking.Back.Color1 = System.Drawing.Color.WhiteSmoke;
            this.btn_close.StateTracking.Back.Color2 = System.Drawing.Color.WhiteSmoke;
            this.btn_close.StateTracking.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Cross_Mark;
            this.btn_close.TabIndex = 9;
            this.btn_close.Values.Text = "";
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_max_min
            // 
            this.btn_max_min.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_max_min.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.btn_max_min.Location = new System.Drawing.Point(793, 12);
            this.btn_max_min.Name = "btn_max_min";
            this.btn_max_min.Size = new System.Drawing.Size(24, 24);
            this.btn_max_min.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_max_min.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_max_min.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_max_min.StateCommon.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Horizontal_Line;
            this.btn_max_min.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_max_min.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_max_min.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_max_min.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_max_min.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_max_min.StateTracking.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Minimize_Window_colored_;
            this.btn_max_min.TabIndex = 8;
            this.btn_max_min.Values.Text = "";
            this.btn_max_min.Click += new System.EventHandler(this.kryptonButton3_Click);
            // 
            // btn_size
            // 
            this.btn_size.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btn_size.ButtonStyle = ComponentFactory.Krypton.Toolkit.ButtonStyle.ButtonSpec;
            this.btn_size.Location = new System.Drawing.Point(831, 12);
            this.btn_size.Name = "btn_size";
            this.btn_size.Size = new System.Drawing.Size(24, 24);
            this.btn_size.StateCommon.Back.Color1 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_size.StateCommon.Back.Color2 = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.btn_size.StateCommon.Back.Draw = ComponentFactory.Krypton.Toolkit.InheritBool.True;
            this.btn_size.StateCommon.Back.Image = global::SoftwareFirmManagement.Properties.Resources.Normal_Screen;
            this.btn_size.StateCommon.Back.ImageStyle = ComponentFactory.Krypton.Toolkit.PaletteImageStyle.CenterMiddle;
            this.btn_size.StatePressed.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_size.StatePressed.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_size.StateTracking.Back.Color1 = System.Drawing.Color.Transparent;
            this.btn_size.StateTracking.Back.Color2 = System.Drawing.Color.Transparent;
            this.btn_size.TabIndex = 7;
            this.btn_size.Values.Text = "";
            this.btn_size.Click += new System.EventHandler(this.btn_size_Click);
            // 
            // pnl_main
            // 
            this.pnl_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(38)))));
            this.pnl_main.Location = new System.Drawing.Point(60, 50);
            this.pnl_main.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_main.Name = "pnl_main";
            this.pnl_main.Size = new System.Drawing.Size(905, 485);
            this.pnl_main.TabIndex = 6;
            // 
            // pnl_user_management
            // 
            this.pnl_user_management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.pnl_user_management.Controls.Add(this.btn_employee_management);
            this.pnl_user_management.Controls.Add(this.btn_admin_management);
            this.pnl_user_management.Controls.Add(this.btn_customer_management);
            this.pnl_user_management.Controls.Add(this.btn_user_management);
            this.pnl_user_management.Location = new System.Drawing.Point(0, 300);
            this.pnl_user_management.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_user_management.Name = "pnl_user_management";
            this.pnl_user_management.Size = new System.Drawing.Size(60, 50);
            this.pnl_user_management.TabIndex = 7;
            // 
            // btn_employee_management
            // 
            this.btn_employee_management.FlatAppearance.BorderSize = 0;
            this.btn_employee_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_employee_management.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_employee_management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_employee_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_employee_management.Location = new System.Drawing.Point(0, 100);
            this.btn_employee_management.Name = "btn_employee_management";
            this.btn_employee_management.Size = new System.Drawing.Size(230, 50);
            this.btn_employee_management.TabIndex = 3;
            this.btn_employee_management.Text = "Employee Management";
            this.btn_employee_management.UseVisualStyleBackColor = true;
            this.btn_employee_management.Click += new System.EventHandler(this.btn_employee_management_Click);
            // 
            // btn_admin_management
            // 
            this.btn_admin_management.FlatAppearance.BorderSize = 0;
            this.btn_admin_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_management.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_admin_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_management.Location = new System.Drawing.Point(0, 150);
            this.btn_admin_management.Name = "btn_admin_management";
            this.btn_admin_management.Size = new System.Drawing.Size(230, 50);
            this.btn_admin_management.TabIndex = 2;
            this.btn_admin_management.Text = "Admin Management";
            this.btn_admin_management.UseVisualStyleBackColor = true;
            // 
            // btn_customer_management
            // 
            this.btn_customer_management.FlatAppearance.BorderSize = 0;
            this.btn_customer_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_customer_management.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_customer_management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_customer_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_customer_management.Location = new System.Drawing.Point(0, 50);
            this.btn_customer_management.Name = "btn_customer_management";
            this.btn_customer_management.Size = new System.Drawing.Size(230, 50);
            this.btn_customer_management.TabIndex = 1;
            this.btn_customer_management.Text = "Customer Management";
            this.btn_customer_management.UseVisualStyleBackColor = true;
            this.btn_customer_management.Click += new System.EventHandler(this.btn_customer_management_Click);
            // 
            // pnl_dashboard
            // 
            this.pnl_dashboard.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.pnl_dashboard.Controls.Add(this.btn_dashboard);
            this.pnl_dashboard.Location = new System.Drawing.Point(0, 50);
            this.pnl_dashboard.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_dashboard.Name = "pnl_dashboard";
            this.pnl_dashboard.Size = new System.Drawing.Size(60, 50);
            this.pnl_dashboard.TabIndex = 8;
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.pnl_menu.Controls.Add(this.btn_menu);
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(60, 50);
            this.pnl_menu.TabIndex = 9;
            // 
            // pnl_services
            // 
            this.pnl_services.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.pnl_services.Controls.Add(this.btn_services);
            this.pnl_services.Location = new System.Drawing.Point(0, 100);
            this.pnl_services.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_services.Name = "pnl_services";
            this.pnl_services.Size = new System.Drawing.Size(60, 50);
            this.pnl_services.TabIndex = 7;
            // 
            // pnl_order_management
            // 
            this.pnl_order_management.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.pnl_order_management.Controls.Add(this.btn_order_management);
            this.pnl_order_management.Location = new System.Drawing.Point(0, 200);
            this.pnl_order_management.Margin = new System.Windows.Forms.Padding(0);
            this.pnl_order_management.Name = "pnl_order_management";
            this.pnl_order_management.Size = new System.Drawing.Size(60, 50);
            this.pnl_order_management.TabIndex = 10;
            // 
            // header1
            // 
            this.header1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.header1.Dock = System.Windows.Forms.DockStyle.Left;
            this.header1.Location = new System.Drawing.Point(0, 0);
            this.header1.Name = "header1";
            this.header1.Size = new System.Drawing.Size(352, 50);
            this.header1.TabIndex = 3;
            // 
            // sidePanel1
            // 
            this.sidePanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.sidePanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel1.Location = new System.Drawing.Point(0, 0);
            this.sidePanel1.Name = "sidePanel1";
            this.sidePanel1.Size = new System.Drawing.Size(60, 535);
            this.sidePanel1.TabIndex = 4;
            // 
            // pnl_reviews
            // 
            this.pnl_reviews.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(50)))));
            this.pnl_reviews.Controls.Add(this.btn_reviews);
            this.pnl_reviews.Location = new System.Drawing.Point(0, 150);
            this.pnl_reviews.Name = "pnl_reviews";
            this.pnl_reviews.Size = new System.Drawing.Size(60, 50);
            this.pnl_reviews.TabIndex = 11;
            // 
            // btn_reviews
            // 
            this.btn_reviews.FlatAppearance.BorderSize = 0;
            this.btn_reviews.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reviews.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reviews.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_reviews.Image = global::SoftwareFirmManagement.Properties.Resources.Popular;
            this.btn_reviews.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_reviews.Location = new System.Drawing.Point(0, 0);
            this.btn_reviews.Margin = new System.Windows.Forms.Padding(0);
            this.btn_reviews.Name = "btn_reviews";
            this.btn_reviews.Size = new System.Drawing.Size(230, 50);
            this.btn_reviews.TabIndex = 3;
            this.btn_reviews.Text = "Orders";
            this.btn_reviews.UseVisualStyleBackColor = true;
            this.btn_reviews.Click += new System.EventHandler(this.btn_reviews_Click);
            // 
            // btn_order_management
            // 
            this.btn_order_management.FlatAppearance.BorderSize = 0;
            this.btn_order_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_order_management.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_order_management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_order_management.Image = global::SoftwareFirmManagement.Properties.Resources.List;
            this.btn_order_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_order_management.Location = new System.Drawing.Point(0, 0);
            this.btn_order_management.Margin = new System.Windows.Forms.Padding(0);
            this.btn_order_management.Name = "btn_order_management";
            this.btn_order_management.Size = new System.Drawing.Size(230, 50);
            this.btn_order_management.TabIndex = 2;
            this.btn_order_management.Text = "Orders";
            this.btn_order_management.UseVisualStyleBackColor = true;
            this.btn_order_management.Click += new System.EventHandler(this.btn_order_management_Click);
            // 
            // btn_services
            // 
            this.btn_services.FlatAppearance.BorderSize = 0;
            this.btn_services.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_services.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_services.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_services.Image = global::SoftwareFirmManagement.Properties.Resources.Service;
            this.btn_services.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_services.Location = new System.Drawing.Point(0, 0);
            this.btn_services.Margin = new System.Windows.Forms.Padding(0);
            this.btn_services.Name = "btn_services";
            this.btn_services.Size = new System.Drawing.Size(230, 50);
            this.btn_services.TabIndex = 1;
            this.btn_services.Text = "Services";
            this.btn_services.UseVisualStyleBackColor = true;
            this.btn_services.Click += new System.EventHandler(this.btn_services_Click);
            // 
            // btn_menu
            // 
            this.btn_menu.FlatAppearance.BorderSize = 0;
            this.btn_menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menu.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_menu.Image = global::SoftwareFirmManagement.Properties.Resources.Slider;
            this.btn_menu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_menu.Location = new System.Drawing.Point(0, 0);
            this.btn_menu.Name = "btn_menu";
            this.btn_menu.Size = new System.Drawing.Size(230, 50);
            this.btn_menu.TabIndex = 1;
            this.btn_menu.Text = "Menu";
            this.btn_menu.UseVisualStyleBackColor = true;
            this.btn_menu.Click += new System.EventHandler(this.btn_menu_Click);
            // 
            // btn_dashboard
            // 
            this.btn_dashboard.FlatAppearance.BorderSize = 0;
            this.btn_dashboard.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dashboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_dashboard.Image = global::SoftwareFirmManagement.Properties.Resources.Dashboard_Layout_filled_;
            this.btn_dashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_dashboard.Location = new System.Drawing.Point(0, 0);
            this.btn_dashboard.Name = "btn_dashboard";
            this.btn_dashboard.Size = new System.Drawing.Size(230, 50);
            this.btn_dashboard.TabIndex = 1;
            this.btn_dashboard.Text = "Dashboard";
            this.btn_dashboard.UseVisualStyleBackColor = true;
            // 
            // btn_user_management
            // 
            this.btn_user_management.FlatAppearance.BorderSize = 0;
            this.btn_user_management.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user_management.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user_management.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(210)))));
            this.btn_user_management.Image = global::SoftwareFirmManagement.Properties.Resources.User_Default_small_;
            this.btn_user_management.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user_management.Location = new System.Drawing.Point(0, 0);
            this.btn_user_management.Name = "btn_user_management";
            this.btn_user_management.Size = new System.Drawing.Size(230, 50);
            this.btn_user_management.TabIndex = 0;
            this.btn_user_management.Text = "User Management";
            this.btn_user_management.UseVisualStyleBackColor = true;
            this.btn_user_management.Click += new System.EventHandler(this.btn_user_management_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(965, 535);
            this.Controls.Add(this.pnl_reviews);
            this.Controls.Add(this.pnl_order_management);
            this.Controls.Add(this.pnl_services);
            this.Controls.Add(this.pnl_menu);
            this.Controls.Add(this.pnl_dashboard);
            this.Controls.Add(this.pnl_user_management);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sidePanel1);
            this.Controls.Add(this.pnl_main);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Palette = this.MainPalette;
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Custom;
            this.Text = "SoftwareFirm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.pnl_user_management.ResumeLayout(false);
            this.pnl_dashboard.ResumeLayout(false);
            this.pnl_menu.ResumeLayout(false);
            this.pnl_services.ResumeLayout(false);
            this.pnl_order_management.ResumeLayout(false);
            this.pnl_reviews.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ComponentFactory.Krypton.Toolkit.KryptonPalette MainPalette;
        private ComponentFactory.Krypton.Toolkit.KryptonManager kryptonManager1;
        private UI.Header header1;
        private UI.SidePanel sidePanel1;
        private System.Windows.Forms.Panel panel1;
        private KryptonButton btn_close;
        private KryptonButton btn_max_min;
        private KryptonButton btn_size;
        private System.Windows.Forms.Panel pnl_main;
        private System.Windows.Forms.Panel pnl_user_management;
        private System.Windows.Forms.Button btn_user_management;
        private System.Windows.Forms.Button btn_customer_management;
        private System.Windows.Forms.Button btn_employee_management;
        private System.Windows.Forms.Button btn_admin_management;
        private System.Windows.Forms.Panel pnl_dashboard;
        private System.Windows.Forms.Button btn_dashboard;
        private System.Windows.Forms.Button btn_menu;
        private System.Windows.Forms.Panel pnl_menu;
        private System.Windows.Forms.Panel pnl_services;
        private System.Windows.Forms.Button btn_services;
        private System.Windows.Forms.Panel pnl_order_management;
        private System.Windows.Forms.Button btn_order_management;
        private System.Windows.Forms.Panel pnl_reviews;
        private System.Windows.Forms.Button btn_reviews;
    }
}

