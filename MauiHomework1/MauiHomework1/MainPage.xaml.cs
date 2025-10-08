namespace MauiHomework1;

public partial class MainPage : ContentPage
{
    int count = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnSubmitClicked(object sender, EventArgs e)
    {
        NameEntry.Text = "";
        AgeSlider.Value = 20;
        GenderMaleRadioButton.IsChecked = true;
        AgreementCheckBox.IsChecked = false;
        PhoneEntry.Text = "";
    }

    private void AgreementCheckBox_OnCheckedChanged(object? sender, CheckedChangedEventArgs e)
    {
        SubmitBtn.IsEnabled = e.Value;
    }

    private void PhoneEntry_OnTextChanged(object? sender, TextChangedEventArgs e)
    {
        if (sender is not Entry entry)
        {
            return;
        }
        var digitsOnly = new string(e.NewTextValue.Where(char.IsDigit).ToArray());

        if (e.NewTextValue != digitsOnly)
        {
            entry.Text = digitsOnly;
        }
        entry.TextColor = digitsOnly.Length == 10 ? Colors.Green : Colors.Red;
    }

    private void TapGestureRecognizer_OnTapped(object? sender, TappedEventArgs e)
    {
        AgreementCheckBox.IsChecked = !AgreementCheckBox.IsChecked;
    }
}