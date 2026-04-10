namespace NSW.StarCitizen.MultiTool.Themes;

public abstract class Theme
{
    public abstract Color BackGround { get; }
    public abstract Color Border { get; }
    public abstract Color PanelBackGround { get; }
    public abstract Color AccentPrimary { get; }
    public abstract Color AccentSecondary { get; }
    public abstract Color Text { get; }
    public abstract Color TextReadOnly { get; }

    public abstract Font UiFont { get; }
    public abstract Font UiFontSmall { get; }
    public abstract Font UiFontHeader { get; }
    public abstract Font Mono { get; }
}
