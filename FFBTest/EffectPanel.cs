using System.Windows.Forms;

namespace FFBTest
{
    public abstract class EffectPanel : TableLayoutPanel
    {
        protected const string errMsgCap = "Effect specific data error";

        protected EffectPanel()
        {
            this.ColumnCount = 2;
            this.RowCount = 1;
            GrowStyle = TableLayoutPanelGrowStyle.AddRows;
        }

        public abstract DataClasses.EffectTypeData PassEffectData();
    }
}
