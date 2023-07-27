using CommunityToolkit.Maui.Views;

namespace MauiApp7;

/// <summary>
/// The button popup.
/// </summary>
public partial class ButtonPopup : Popup
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ButtonPopup"/> class.
    /// </summary>
    public ButtonPopup()
	{
		this.InitializeComponent();
        this.Size = new Size(400, 400);
    }

    /// <summary>
    /// Button_S the clicked.
    /// </summary>
    /// <param name="sender">The sender.</param>
    /// <param name="e">The e.</param>
    private void Button_Clicked(object? sender, EventArgs e) => this.Close();
}