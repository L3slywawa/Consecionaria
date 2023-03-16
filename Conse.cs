namespace Consecionaria;

class Conse
{
    public Conse(int LimiteAutomoviles)
    {

        Automoviles = new List<Automovil>();
        Limite = Limite;
    }
    public List<Automovil> Automoviles { get; set; }

    public int Limite { get; set; }
    public int NumeroActual { get; set; }



    public void AgregarAuto(Automovil a)//resibe agrega
    {
        if (a != null && NumeroActual != Limite)
        {
            Automovil? AutoEncontrado = Automoviles.Find((b) => b.ID == a.ID);
            if (AutoEncontrado == null)
            {
                Automoviles.Add(a);
                NumeroActual++;
            }
        }
    }

    public void MostrarAuto(string ID)//ecorre la lista e imprime
    {
        Automovil? AutoEncontrado = Automoviles.Find((a) => a.ID == ID);
        if (AutoEncontrado != null)
        {
            Console.WriteLine(AutoEncontrado.ToString());
        }

    }
    public void EliminarAuto(string ID)
    {
        if (ID != "" && NumeroActual != Limite)
        {
            Automovil? AutoEncontrado = Automoviles.Find((a) => a.ID == ID);
            if (AutoEncontrado != null)
            {
                Automoviles.Remove(AutoEncontrado);
                NumeroActual--;
            }
        }
    }

    public void vaciarConsesionaria(Automovil a)
    {
        Automoviles.Clear();
    }

    public void MostrarAutomoviles()
    {
        foreach (Automovil a in Automoviles)
        {
            Console.WriteLine(a.ToString());
        }
    }
}
