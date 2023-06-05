using System.Diagnostics;

namespace FV_RecargaTelefonica;

[DebuggerDisplay($"{{{nameof(GetDebuggerDisplay)}(),nq}}")]
public partial class FV_Pagina : ContentPage
{
	public FV_Pagina()
	{
		InitializeComponent();
	}

	private void InitializeComponent()
	{
		// Aquí se inicializan los componentes de la página, como los controles visuales. 
		// Asegúrate de agregar el código correspondiente para inicializar los controles que tienes en tu página.
	}

	public async void FV_RecargarClicked(string numero, string valor)
	{
		Models.FV_Recarga recarga = new Models.FV_Recarga();
		recarga.NumeroTelefonoEntry = numero;
		recarga.ValorRecargaPicker = valor;

		string numeroTelefono = recarga.NumeroTelefonoEntry;
		decimal valorRecarga = decimal.Parse(recarga.ValorRecargaPicker);
		bool answer = await DisplayAlert("Confirmacion", "¿Deseas recargar", "Yes", "No");
		Debug.WriteLine("Answer: " + answer);
		await DisplayAlert("Finalizó", "Recarga exitosa", "OK");
	}

	private string GetDebuggerDisplay()
	{
		return ToString();
	}
}
