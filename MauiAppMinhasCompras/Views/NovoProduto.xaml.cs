using MauiAppMinhasCompras.Models;

namespace MauiAppMinhasCompras.Views;

public partial class NovoProduto : ContentPage
{
	public NovoProduto()
	{
		InitializeComponent();
	}

	private async void ToolbarItem_Clicked(object sender, EventArgs e)
	{
		try
		{
			Produto p = new Produto
			{
				Descricao = txt_descricao.Text,
				Quantidade = Convert.ToDouble(txt_quantidade.Text),
				Preco = Convert.ToDouble(txt_preco.Text)
			}; // Cria uma nova inst�ncia de Produto com os valores atribu�dos (em NovoProduto.xaml)

            await App.Db.Insert(p); // O produto � criado
            await DisplayAlert("Sucesso!", "Registro Inserido", "OK");

		}
		catch (Exception ex)
		{
			await DisplayAlert("Ops", ex.Message, "Ok"); // Se houver um problema vai aparecer uma mensagem de erro
        }
	}
}