using NSW.StarCitizen.MultiTool.Themes;

namespace NSW.StarCitizen.MultiTool.Forms;

public partial class MainForm : Form
{
    private readonly ThemeManager _themeManager;

    public MainForm(ThemeManager themeManager)
    {
        _themeManager = themeManager;
        InitializeComponent();
        ApplyTheme(themeManager.DefaultTheme);
    }

    private void ApplyTheme(Theme theme)
    {
        foreach (Control control in Controls)
        {
            control.Font = theme.UiFont;
        }

        // Form
        BackColor = theme.BackGround;
        FormBorderColor = theme.Border;

        // tbGamePath
        tbGamePath.BackColor = theme.PanelBackGround;
        tbGamePath.ForeColor = theme.Text;
        tbGamePath.BorderStyle = BorderStyle.FixedSingle;
    }
}
