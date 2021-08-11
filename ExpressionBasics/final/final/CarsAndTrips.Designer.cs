
namespace final {
  partial class CarsAndTrips {
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

    #region Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.components = new System.ComponentModel.Container();
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode1 = new DevExpress.DataAccess.Json.JsonSchemaNode("root", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode2 = new DevExpress.DataAccess.Json.JsonSchemaNode("carid", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode3 = new DevExpress.DataAccess.Json.JsonSchemaNode("car", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode4 = new DevExpress.DataAccess.Json.JsonSchemaNode("vin", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode5 = new DevExpress.DataAccess.Json.JsonSchemaNode("trips", true, DevExpress.DataAccess.Json.JsonNodeType.Array);
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode6 = new DevExpress.DataAccess.Json.JsonSchemaNode("carid", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode7 = new DevExpress.DataAccess.Json.JsonSchemaNode("tripid", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<long>));
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode8 = new DevExpress.DataAccess.Json.JsonSchemaNode("length", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(System.Nullable<double>));
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode9 = new DevExpress.DataAccess.Json.JsonSchemaNode("start_location", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
      DevExpress.DataAccess.Json.JsonSchemaNode jsonSchemaNode10 = new DevExpress.DataAccess.Json.JsonSchemaNode("end_location", true, DevExpress.DataAccess.Json.JsonNodeType.Property, typeof(string));
      this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
      this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
      this.pageInfo1 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.pageInfo2 = new DevExpress.XtraReports.UI.XRPageInfo();
      this.ReportHeader = new DevExpress.XtraReports.UI.ReportHeaderBand();
      this.label1 = new DevExpress.XtraReports.UI.XRLabel();
      this.Detail = new DevExpress.XtraReports.UI.DetailBand();
      this.table1 = new DevExpress.XtraReports.UI.XRTable();
      this.tableRow1 = new DevExpress.XtraReports.UI.XRTableRow();
      this.tableCell1 = new DevExpress.XtraReports.UI.XRTableCell();
      this.tableRow2 = new DevExpress.XtraReports.UI.XRTableRow();
      this.tableCell3 = new DevExpress.XtraReports.UI.XRTableCell();
      this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
      this.GroupHeader1 = new DevExpress.XtraReports.UI.GroupHeaderBand();
      this.table2 = new DevExpress.XtraReports.UI.XRTable();
      this.tableRow3 = new DevExpress.XtraReports.UI.XRTableRow();
      this.tableCell6 = new DevExpress.XtraReports.UI.XRTableCell();
      this.tableCell7 = new DevExpress.XtraReports.UI.XRTableCell();
      this.tableCell5 = new DevExpress.XtraReports.UI.XRTableCell();
      this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
      this.table3 = new DevExpress.XtraReports.UI.XRTable();
      this.tableRow4 = new DevExpress.XtraReports.UI.XRTableRow();
      this.tableCell9 = new DevExpress.XtraReports.UI.XRTableCell();
      this.tableCell10 = new DevExpress.XtraReports.UI.XRTableCell();
      this.tableCell8 = new DevExpress.XtraReports.UI.XRTableCell();
      this.jsonDataSource1 = new DevExpress.DataAccess.Json.JsonDataSource(this.components);
      this.Title = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailCaption1 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailData1 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailCaption2 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailData2 = new DevExpress.XtraReports.UI.XRControlStyle();
      this.DetailData3_Odd = new DevExpress.XtraReports.UI.XRControlStyle();
      this.PageInfo = new DevExpress.XtraReports.UI.XRControlStyle();
      this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
      ((System.ComponentModel.ISupportInitialize)(this.table1)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.table2)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.table3)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
      // 
      // TopMargin
      // 
      this.TopMargin.Name = "TopMargin";
      // 
      // BottomMargin
      // 
      this.BottomMargin.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.pageInfo1,
            this.pageInfo2});
      this.BottomMargin.Name = "BottomMargin";
      // 
      // pageInfo1
      // 
      this.pageInfo1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.pageInfo1.Name = "pageInfo1";
      this.pageInfo1.PageInfo = DevExpress.XtraPrinting.PageInfo.DateTime;
      this.pageInfo1.SizeF = new System.Drawing.SizeF(325F, 23F);
      this.pageInfo1.StyleName = "PageInfo";
      // 
      // pageInfo2
      // 
      this.pageInfo2.LocationFloat = new DevExpress.Utils.PointFloat(325F, 0F);
      this.pageInfo2.Name = "pageInfo2";
      this.pageInfo2.SizeF = new System.Drawing.SizeF(325F, 23F);
      this.pageInfo2.StyleName = "PageInfo";
      this.pageInfo2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopRight;
      this.pageInfo2.TextFormatString = "Page {0} of {1}";
      // 
      // ReportHeader
      // 
      this.ReportHeader.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.label1});
      this.ReportHeader.HeightF = 38.12501F;
      this.ReportHeader.Name = "ReportHeader";
      // 
      // label1
      // 
      this.label1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.label1.Name = "label1";
      this.label1.SizeF = new System.Drawing.SizeF(650F, 24.19433F);
      this.label1.StyleName = "Title";
      this.label1.Text = "Cars and Trips";
      // 
      // Detail
      // 
      this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel1,
            this.table1});
      this.Detail.HeightF = 129.75F;
      this.Detail.KeepTogether = true;
      this.Detail.Name = "Detail";
      // 
      // table1
      // 
      this.table1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 17.08333F);
      this.table1.Name = "table1";
      this.table1.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow1,
            this.tableRow2});
      this.table1.SizeF = new System.Drawing.SizeF(650F, 55.99999F);
      // 
      // tableRow1
      // 
      this.tableRow1.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell1});
      this.tableRow1.Name = "tableRow1";
      this.tableRow1.Weight = 0.5D;
      // 
      // tableCell1
      // 
      this.tableCell1.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.tableCell1.Name = "tableCell1";
      this.tableCell1.StyleName = "DetailCaption1";
      this.tableCell1.StylePriority.UseBorders = false;
      this.tableCell1.Text = "Car";
      this.tableCell1.Weight = 0.50524019681490384D;
      // 
      // tableRow2
      // 
      this.tableRow2.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell3});
      this.tableRow2.Name = "tableRow2";
      this.tableRow2.Weight = 0.5D;
      // 
      // tableCell3
      // 
      this.tableCell3.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.tableCell3.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'Car: {0} ({1})\', [car], [vin])")});
      this.tableCell3.Name = "tableCell3";
      this.tableCell3.StyleName = "DetailData1";
      this.tableCell3.StylePriority.UseBorders = false;
      this.tableCell3.Weight = 0.50524019681490384D;
      // 
      // DetailReport
      // 
      this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.GroupHeader1,
            this.Detail1});
      this.DetailReport.DataMember = "trips";
      this.DetailReport.DataSource = this.jsonDataSource1;
      this.DetailReport.Level = 0;
      this.DetailReport.Name = "DetailReport";
      // 
      // GroupHeader1
      // 
      this.GroupHeader1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table2});
      this.GroupHeader1.GroupUnion = DevExpress.XtraReports.UI.GroupUnion.WithFirstDetail;
      this.GroupHeader1.HeightF = 28F;
      this.GroupHeader1.Name = "GroupHeader1";
      // 
      // table2
      // 
      this.table2.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.table2.Name = "table2";
      this.table2.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow3});
      this.table2.SizeF = new System.Drawing.SizeF(650F, 28F);
      // 
      // tableRow3
      // 
      this.tableRow3.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell6,
            this.tableCell7,
            this.tableCell5});
      this.tableRow3.Name = "tableRow3";
      this.tableRow3.Weight = 1D;
      // 
      // tableCell6
      // 
      this.tableCell6.Name = "tableCell6";
      this.tableCell6.StyleName = "DetailCaption2";
      this.tableCell6.Text = "Start Location";
      this.tableCell6.Weight = 0.39819659893329329D;
      // 
      // tableCell7
      // 
      this.tableCell7.Name = "tableCell7";
      this.tableCell7.StyleName = "DetailCaption2";
      this.tableCell7.Text = "End Location";
      this.tableCell7.Weight = 0.37753091665414662D;
      // 
      // tableCell5
      // 
      this.tableCell5.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.tableCell5.Name = "tableCell5";
      this.tableCell5.StyleName = "DetailCaption2";
      this.tableCell5.StylePriority.UseBorders = false;
      this.tableCell5.StylePriority.UseTextAlignment = false;
      this.tableCell5.Text = "Length";
      this.tableCell5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
      this.tableCell5.Weight = 0.22427248441256009D;
      // 
      // Detail1
      // 
      this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.table3});
      this.Detail1.HeightF = 25F;
      this.Detail1.Name = "Detail1";
      // 
      // table3
      // 
      this.table3.LocationFloat = new DevExpress.Utils.PointFloat(0F, 0F);
      this.table3.Name = "table3";
      this.table3.OddStyleName = "DetailData3_Odd";
      this.table3.Rows.AddRange(new DevExpress.XtraReports.UI.XRTableRow[] {
            this.tableRow4});
      this.table3.SizeF = new System.Drawing.SizeF(650F, 25F);
      // 
      // tableRow4
      // 
      this.tableRow4.Cells.AddRange(new DevExpress.XtraReports.UI.XRTableCell[] {
            this.tableCell9,
            this.tableCell10,
            this.tableCell8});
      this.tableRow4.Name = "tableRow4";
      this.tableRow4.Weight = 11.5D;
      // 
      // tableCell9
      // 
      this.tableCell9.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[start_location]")});
      this.tableCell9.Name = "tableCell9";
      this.tableCell9.StyleName = "DetailData2";
      this.tableCell9.Weight = 0.39819659893329329D;
      // 
      // tableCell10
      // 
      this.tableCell10.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[end_location]")});
      this.tableCell10.Name = "tableCell10";
      this.tableCell10.StyleName = "DetailData2";
      this.tableCell10.Weight = 0.37753089317908656D;
      // 
      // tableCell8
      // 
      this.tableCell8.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.tableCell8.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "[length]"),
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "BackColor", "iif(\n  [length] > 800, \'OrangeRed\',\n  [length] > 600, \'Orange\',\n  [length] > 400," +
                    " \'Yellow\',\n  [length] > 200, \'LightYellow\',\n  null)")});
      this.tableCell8.Name = "tableCell8";
      this.tableCell8.StyleName = "DetailData2";
      this.tableCell8.StylePriority.UseBorders = false;
      this.tableCell8.StylePriority.UseTextAlignment = false;
      this.tableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight;
      this.tableCell8.Weight = 0.22427248441256009D;
      // 
      // jsonDataSource1
      // 
      this.jsonDataSource1.ConnectionName = "JsonConnection";
      this.jsonDataSource1.Name = "jsonDataSource1";
      jsonSchemaNode5.Nodes.Add(jsonSchemaNode6);
      jsonSchemaNode5.Nodes.Add(jsonSchemaNode7);
      jsonSchemaNode5.Nodes.Add(jsonSchemaNode8);
      jsonSchemaNode5.Nodes.Add(jsonSchemaNode9);
      jsonSchemaNode5.Nodes.Add(jsonSchemaNode10);
      jsonSchemaNode1.Nodes.Add(jsonSchemaNode2);
      jsonSchemaNode1.Nodes.Add(jsonSchemaNode3);
      jsonSchemaNode1.Nodes.Add(jsonSchemaNode4);
      jsonSchemaNode1.Nodes.Add(jsonSchemaNode5);
      this.jsonDataSource1.Schema = jsonSchemaNode1;
      // 
      // Title
      // 
      this.Title.BackColor = System.Drawing.Color.Transparent;
      this.Title.BorderColor = System.Drawing.Color.Black;
      this.Title.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.Title.BorderWidth = 1F;
      this.Title.Font = new System.Drawing.Font("Arial", 14.25F);
      this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
      this.Title.Name = "Title";
      this.Title.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      // 
      // DetailCaption1
      // 
      this.DetailCaption1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(94)))), ((int)(((byte)(178)))));
      this.DetailCaption1.BorderColor = System.Drawing.Color.White;
      this.DetailCaption1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
      this.DetailCaption1.BorderWidth = 2F;
      this.DetailCaption1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
      this.DetailCaption1.ForeColor = System.Drawing.Color.White;
      this.DetailCaption1.Name = "DetailCaption1";
      this.DetailCaption1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailCaption1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailData1
      // 
      this.DetailData1.BorderColor = System.Drawing.Color.Transparent;
      this.DetailData1.Borders = DevExpress.XtraPrinting.BorderSide.Left;
      this.DetailData1.BorderWidth = 2F;
      this.DetailData1.Font = new System.Drawing.Font("Arial", 8.25F);
      this.DetailData1.ForeColor = System.Drawing.Color.Black;
      this.DetailData1.Name = "DetailData1";
      this.DetailData1.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailData1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailCaption2
      // 
      this.DetailCaption2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(110)))), ((int)(((byte)(190)))));
      this.DetailCaption2.BorderColor = System.Drawing.Color.White;
      this.DetailCaption2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
      this.DetailCaption2.BorderWidth = 2F;
      this.DetailCaption2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
      this.DetailCaption2.ForeColor = System.Drawing.Color.White;
      this.DetailCaption2.Name = "DetailCaption2";
      this.DetailCaption2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailCaption2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailData2
      // 
      this.DetailData2.BorderColor = System.Drawing.Color.Transparent;
      this.DetailData2.Borders = DevExpress.XtraPrinting.BorderSide.Left;
      this.DetailData2.BorderWidth = 2F;
      this.DetailData2.Font = new System.Drawing.Font("Arial", 8.25F);
      this.DetailData2.ForeColor = System.Drawing.Color.Black;
      this.DetailData2.Name = "DetailData2";
      this.DetailData2.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailData2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // DetailData3_Odd
      // 
      this.DetailData3_Odd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(245)))), ((int)(((byte)(248)))));
      this.DetailData3_Odd.BorderColor = System.Drawing.Color.Transparent;
      this.DetailData3_Odd.Borders = DevExpress.XtraPrinting.BorderSide.None;
      this.DetailData3_Odd.BorderWidth = 1F;
      this.DetailData3_Odd.Font = new System.Drawing.Font("Arial", 8.25F);
      this.DetailData3_Odd.ForeColor = System.Drawing.Color.Black;
      this.DetailData3_Odd.Name = "DetailData3_Odd";
      this.DetailData3_Odd.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      this.DetailData3_Odd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft;
      // 
      // PageInfo
      // 
      this.PageInfo.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold);
      this.PageInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(70)))), ((int)(((byte)(80)))));
      this.PageInfo.Name = "PageInfo";
      this.PageInfo.Padding = new DevExpress.XtraPrinting.PaddingInfo(6, 6, 0, 0, 100F);
      // 
      // xrLabel1
      // 
      this.xrLabel1.ExpressionBindings.AddRange(new DevExpress.XtraReports.UI.ExpressionBinding[] {
            new DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "FormatString(\'Long trip average: {0:n2}\', [trips][[length] > 200].avg([length]))")});
      this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(0F, 85.79165F);
      this.xrLabel1.Multiline = true;
      this.xrLabel1.Name = "xrLabel1";
      this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96F);
      this.xrLabel1.SizeF = new System.Drawing.SizeF(559.375F, 23F);
      this.xrLabel1.Text = "xrLabel1";
      // 
      // CarsAndTrips
      // 
      this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.TopMargin,
            this.BottomMargin,
            this.ReportHeader,
            this.Detail,
            this.DetailReport});
      this.ComponentStorage.AddRange(new System.ComponentModel.IComponent[] {
            this.jsonDataSource1});
      this.DataSource = this.jsonDataSource1;
      this.Font = new System.Drawing.Font("Arial", 9.75F);
      this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Title,
            this.DetailCaption1,
            this.DetailData1,
            this.DetailCaption2,
            this.DetailData2,
            this.DetailData3_Odd,
            this.PageInfo});
      this.Version = "21.1";
      ((System.ComponentModel.ISupportInitialize)(this.table1)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.table2)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.table3)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

    }

    #endregion

    private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
    private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
    private DevExpress.XtraReports.UI.XRPageInfo pageInfo1;
    private DevExpress.XtraReports.UI.XRPageInfo pageInfo2;
    private DevExpress.XtraReports.UI.ReportHeaderBand ReportHeader;
    private DevExpress.XtraReports.UI.XRLabel label1;
    private DevExpress.XtraReports.UI.DetailBand Detail;
    private DevExpress.XtraReports.UI.XRTable table1;
    private DevExpress.XtraReports.UI.XRTableRow tableRow1;
    private DevExpress.XtraReports.UI.XRTableCell tableCell1;
    private DevExpress.XtraReports.UI.XRTableRow tableRow2;
    private DevExpress.XtraReports.UI.XRTableCell tableCell3;
    private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
    private DevExpress.XtraReports.UI.GroupHeaderBand GroupHeader1;
    private DevExpress.XtraReports.UI.XRTable table2;
    private DevExpress.XtraReports.UI.XRTableRow tableRow3;
    private DevExpress.XtraReports.UI.XRTableCell tableCell5;
    private DevExpress.XtraReports.UI.XRTableCell tableCell6;
    private DevExpress.XtraReports.UI.XRTableCell tableCell7;
    private DevExpress.XtraReports.UI.DetailBand Detail1;
    private DevExpress.XtraReports.UI.XRTable table3;
    private DevExpress.XtraReports.UI.XRTableRow tableRow4;
    private DevExpress.XtraReports.UI.XRTableCell tableCell8;
    private DevExpress.XtraReports.UI.XRTableCell tableCell9;
    private DevExpress.XtraReports.UI.XRTableCell tableCell10;
    private DevExpress.DataAccess.Json.JsonDataSource jsonDataSource1;
    private DevExpress.XtraReports.UI.XRControlStyle Title;
    private DevExpress.XtraReports.UI.XRControlStyle DetailCaption1;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData1;
    private DevExpress.XtraReports.UI.XRControlStyle DetailCaption2;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData2;
    private DevExpress.XtraReports.UI.XRControlStyle DetailData3_Odd;
    private DevExpress.XtraReports.UI.XRControlStyle PageInfo;
    private DevExpress.XtraReports.UI.XRLabel xrLabel1;
  }
}
