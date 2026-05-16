namespace NSW.StarCitizen.MultiTool.Themes;

/// <summary>
/// Theme palette:
/// #0B0F14 main background
/// #101926 panel background
/// #152233 panel border
/// #2DE2E6 neon cyan accent
/// #F6A21A amber highlight
/// #C7D1E0 primary text
/// #7E8CA3 secondary text
/// </summary>
public sealed class StarCitizenTheme : Theme
{
    public override Color BackGround { get; } = ColorTranslator.FromHtml("#0B0F14");
    public override Color PanelBackGround { get; } = ColorTranslator.FromHtml("#101926");
    public override Color Border { get; } = ColorTranslator.FromHtml("#152233");
    public override Color AccentPrimary { get; } = ColorTranslator.FromHtml("#2DE2E6");
    public override Color AccentSecondary { get; } = ColorTranslator.FromHtml("#F6A21A");
    public override Color Text { get; } = ColorTranslator.FromHtml("#C7D1E0");
    public override Color TextReadOnly { get; } = ColorTranslator.FromHtml("#7E8CA3");
    public override Font UiFont { get; } = new("Segoe UI", 10f, FontStyle.Regular);
    public override Font UiFontSmall { get; } = new("Segoe UI", 9f, FontStyle.Regular);
    public override Font UiFontHeader { get; } = new("Segoe UI", 11f, FontStyle.Bold);
    public override Font Mono { get; } = new("Consolas", 9.5f, FontStyle.Regular);
}
