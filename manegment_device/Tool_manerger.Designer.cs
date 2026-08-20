using System.ComponentModel;

namespace manegment_device;

partial class Tool_manerger
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

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
        listBox1 = new System.Windows.Forms.ListBox();
        SuspendLayout();
        // 
        // listBox1
        // 
        listBox1.FormattingEnabled = true;
        listBox1.Location = new System.Drawing.Point(314, 35);
        listBox1.Name = "listBox1";
        listBox1.Size = new System.Drawing.Size(413, 379);
        listBox1.TabIndex = 0;
        // 
        // Tool_manerger
        // 
        AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        ClientSize = new System.Drawing.Size(800, 626);
        Controls.Add(listBox1);
        Text = "Tool_manerger";
        ResumeLayout(false);
    }

    private System.Windows.Forms.ListBox listBox1;

    #endregion
}