namespace MorseCodeGame;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();

        //set background image
        this.BackgroundImage = Image.FromFile("images/pilots_in_cockpit.png");
        this.BackgroundImageLayout = ImageLayout.Stretch; // Ensures the image fits the window
    }
}
