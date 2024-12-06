namespace MorseCodeGame;

public partial class Form1 : Form
{
    private Label instructionLabel;
    public Form1()
    {
        InitializeComponent();
        Console.WriteLine("Form1 is being initialized...");

        // Set the background image
        this.BackColor = Color.Black;
        this.BackgroundImage = Image.FromFile("images/pilots_in_cockpit.png");
        this.BackgroundImageLayout = ImageLayout.Zoom;

        // Create and configure the label
        instructionLabel = new Label
        {
            Text = "Decode the Morse Code: SOS",
            Font = new Font("Arial", 16, FontStyle.Bold),
            ForeColor = Color.White,
            BackColor = Color.Transparent,
            AutoSize = true
        };

        // Add the label to the form
        this.Controls.Add(instructionLabel);

        // Call the method to center the label initially
        CenterLabel();

        // Handle the form's Resize event
        this.Resize += (sender, args) => CenterLabel();
    }

    private void CenterLabel()
    {
        // Center the label in the form
        instructionLabel.Location = new Point(
            (this.ClientSize.Width - instructionLabel.Width) / 2,
            (this.ClientSize.Height - instructionLabel.Height) / 2
        );
    }
}
