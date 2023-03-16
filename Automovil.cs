namespace Consecionaria
{

class Automovil
{
    public Automovil(string id,string marca,string modelo,int km,double Precio){
        ID=id;
        marca= Marca;
        modelo= modelo;
        km=km;
        Precio=Precio;
    }
    
public String Marca { get; set;}
public string modelo{get; set;}
public String ID{ get; set;}
public int km { get; set;}
public double Precio { get; set;}

    public override string ToString()
    {
        return $" ID:{ID} Marca {Marca} km:{km} Precio {Precio} ";
    }
}
}