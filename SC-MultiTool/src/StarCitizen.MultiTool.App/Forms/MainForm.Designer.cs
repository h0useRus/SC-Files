namespace NSW.StarCitizen.MultiTool.Forms;

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
        var resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        tbGamePath = new TextBox();
        SuspendLayout();
        // 
        // tbGamePath
        // 
        tbGamePath.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
        tbGamePath.Location = new Point(12, 12);
        tbGamePath.Name = "tbGamePath";
        tbGamePath.ReadOnly = true;
        tbGamePath.Size = new Size(728, 23);
        tbGamePath.TabIndex = 0;
        tbGamePath.WordWrap = false;
        // 
        // MainForm
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(884, 461);
        Controls.Add(tbGamePath);
        Icon = (Icon)resources.GetObject("$this.Icon");
        MinimumSize = new Size(900, 500);
        Name = "MainForm";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "MainForm";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox tbGamePath;
}
