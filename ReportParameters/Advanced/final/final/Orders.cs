using DevExpress.XtraReports.UI;
using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;

namespace final {
  public partial class Orders : DevExpress.XtraReports.UI.XtraReport {
    public Orders() {
      InitializeComponent();
    }

    private void Orders_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
      if (sender is XtraReport report) {
        bool lowThresholdUsable = false;
        var lowThresholdObject = report.Parameters["LinePriceLowThreshold"].Value;
        if (lowThresholdObject != null) {
          decimal lowThreshold = Convert.ToDecimal(lowThresholdObject);
          // Greater zero and greater than random limit value
          lowThresholdUsable = lowThreshold > 0 && lowThreshold < 1000;
        }

        bool highThresholdUsable = false;
        var highThresholdObject = report.Parameters["LinePriceHighThreshold"].Value;
        if (highThresholdObject != null) {
          decimal highThreshold = Convert.ToDecimal(highThresholdObject);
          // Greater than random limit value
          highThresholdUsable = highThreshold > 500;
        }

        report.Parameters["LinePriceLowThresholdUsable"].Value = lowThresholdUsable;
        report.Parameters["LinePriceHighThresholdUsable"].Value = highThresholdUsable;
      }
    }
  }
}
