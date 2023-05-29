using MauiApp1.Clases;


namespace MauiApp1;

public partial class MainPage : ContentPage
{
    private bool sedanInfoVisible = false;
    private bool pickUpInfoVisible = false;
    private bool suvInfoVisible = false;
    private bool cuatroPorCuatroInfoVisible = false;
    private List<Button> buttons = new List<Button>();

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnCounterClicked(object sender, EventArgs e)
    {
        if (sedanInfoVisible)
        {
            sedanInfoVisible = false;
            sedanLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            Sedan sedan = new Sedan();
            sedan.Marca = "Toyota";
            sedan.Modelo = "Corolla";
            sedan.Color = "Gris Perlado";
            sedan.Anio = 2024;
            sedan.Placa = "PJT1287";
            sedan.Tipo = "Sedán";
            sedan.Bodykit = "Si";
            sedan.Aleron = "Si";
            sedan.nitrogeno = "Si";


            sedan.Encender();
            sedan.Acelerar(40);
            sedan.Bocina();
            sedan.Arranque_rapido();
            sedan.Apagar();

            string sedanInfo = $"Marca: {sedan.Marca}\nModelo: {sedan.Modelo}\nColor: {sedan.Color}\nAño: {sedan.Anio}\nPlaca: {sedan.Placa}\nTipo: {sedan.Tipo}\nAleron: {sedan.Aleron}\nBodykit: {sedan.Bodykit}\nNitrogeno: {sedan.nitrogeno}";
            sedanLabel.Text = sedanInfo; // Muestra la información


            sedanInfoVisible = true;
        }
    }
    private void OnCounterClicked1(object sender, EventArgs e)
    {
        if (pickUpInfoVisible)
        {
            pickUpInfoVisible = false;
            pickUpLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            PickUp pickUp = new PickUp();
            pickUp.Marca = "Ford";
            pickUp.Modelo = "Ranger";
            pickUp.Color = "Rojo Escarlata";
            pickUp.Anio = 2024;
            pickUp.Placa = "PJT13274";
            pickUp.Tipo = "PickUp";
            pickUp.suspension = "SI";
            pickUp.DeTrabajo = "Si";
            pickUp.llantasdeenduro = "Si";
            pickUp.Encender();
            pickUp.Acelerar(50);
            pickUp.Bocina();
            pickUp.Cargar();
            pickUp.Apagar();

            string pickUpInfo = $"Marca: {pickUp.Marca}\nModelo: {pickUp.Modelo}\nColor: {pickUp.Color}\nAño: {pickUp.Anio}\nPlaca: {pickUp.Placa}\nTipo: {pickUp.Tipo}\nSuspension: {pickUp.suspension}\nModo trabajo: {pickUp.DeTrabajo}\nLLantas: {pickUp.llantasdeenduro}";
            pickUpLabel.Text = pickUpInfo; // Muestra la información

            pickUpInfoVisible = true;
        }

    }
    private void OnCounterClicked2(object sender, EventArgs e)
    {
        if (suvInfoVisible)
        {
            suvInfoVisible = false;
            suvLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            SUV suv = new SUV();
            suv.Marca = "Jeep";
            suv.Modelo = "Wrangler";
            suv.Color = "Negro";
            suv.Anio = 2024;
            suv.Placa = "PJT12354";
            suv.Tipo = "SUV";
            suv.respiradero = "Si";
            suv.winche = "Si";
            suv.repuestos = "No";
            suv.Encender();
            suv.Acelerar(60);
            suv.Bocina();
            suv.ActivarTraccion4x4();
            suv.Apagar();

            string suvInfo = $"Marca: {suv.Marca}\nModelo: {suv.Modelo}\nColor: {suv.Color}\nAño: {suv.Anio}\nPlaca: {suv.Placa}\nTipo: {suv.Tipo}\nRespiradero: {suv.respiradero}\nWinche: {suv.winche}\nRepuestos: {suv.repuestos}";
            suvLabel.Text = suvInfo; // Muestra la información

            suvInfoVisible = true;
        }
    }
    private void OnCounterClicked3(object sender, EventArgs e)
    {
        if (cuatroPorCuatroInfoVisible)
        {
            cuatroPorCuatroInfoVisible = false;
            cuatroPorCuatroLabel.Text = string.Empty; // Oculta la información
        }
        else
        {
            CuatroPorCuatro cuatroPorCuatro = new CuatroPorCuatro();
            cuatroPorCuatro.Marca = "Land Rover";
            cuatroPorCuatro.Modelo = "Defender";
            cuatroPorCuatro.Color = "Gris";
            cuatroPorCuatro.Anio = 2024;
            cuatroPorCuatro.Placa = "PJT8594";
            cuatroPorCuatro.Tipo = "4x4";
            cuatroPorCuatro.turbo = "Si";
            cuatroPorCuatro.doble = "Si";
            cuatroPorCuatro.asientos = 2;
            cuatroPorCuatro.Encender();
            cuatroPorCuatro.Acelerar(70);
            cuatroPorCuatro.Bocina();
            cuatroPorCuatro.terreno();
            cuatroPorCuatro.Apagar();

            string cuatroPorCuatroInfo = $"Marca: {cuatroPorCuatro.Marca}\nModelo: {cuatroPorCuatro.Modelo}\nColor: {cuatroPorCuatro.Color}\nAño: {cuatroPorCuatro.Anio}\nPlaca: {cuatroPorCuatro.Placa}\nTipo: {cuatroPorCuatro.Tipo}\nTurbo: {cuatroPorCuatro.turbo}\nDoble: {cuatroPorCuatro.doble}\nAsientos: {cuatroPorCuatro.asientos}";
            cuatroPorCuatroLabel.Text = cuatroPorCuatroInfo; // Muestra la información

            cuatroPorCuatroInfoVisible = true;
        }
    }




}

