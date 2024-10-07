using FilmsApp.Models;

namespace FilmsApp.Views;

public partial class WriteCommentPage : ContentPage
{
    Movie movie;
	public WriteCommentPage(Movie movie)
	{
        this.movie = movie;
		InitializeComponent();
	}

    private void Slider_ValueChanged(object sender, ValueChangedEventArgs args)
    {
        mark.Text = $"Ваша оценка: {(int)(args.NewValue / 1) * 1}";
    }

    private void Button_Clicked(object sender, EventArgs e)
    {
        movie.Comments.Add(new Comment()
        {
            CommentText = editor.Text,
            Mark = (int)(slider.Value / 1) * 1
        });
        Navigation.PopModalAsync();
    }
}