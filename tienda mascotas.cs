using System;


public class Cliente
{
    private int id_persona= 0;
    private string cedula = "";
    private string nombre = "";
    private Mascota? mascota = null; 
    

    public int Id_Persona { get => id_persona; set => id_persona = value; }
    public string Cedula { get => cedula; set => cedula = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public Mascota? Mascota { get => this.mascota; set => this.mascota = value; }
}

public class TipoMascota

    {
        private int id_tipomascota = 0;
	private string tipomascota = "";
        private string nombre = "";
        private string sexo = "";
	private int edad = 0;
        private id_persona? id_persona = null;

        public int id_tipomascota { get => this.id_tipomascota; set => this.id_tipomascota = value; }
	public string tipomascota { get => this.tipomascota; set => this.tipomascota = value; }
        public string mascota { get => this.mascota; set => this.masota = value; }
        public string Nombre { get => this.nombre; set => this.nombre = value; }
        public string sexo { get => this.sexo; set => this.sexo = value; }
        public int edad { get => this.edad; set => this.edad = value; }
        public id_persona? id_persona { get => this.id_persona; set => this.id_persona = value; }
    }


public class Mascota
{
    private int id_mascota=0;
    private string codigoMascota = "";
    private string nombre = "";
    private TipoMascota? tipomascota = null; 
    

    public int Id_Mascota { get => id_mascota; set => id_mascota = value; }
    public string CodigoMascota { get => codigoMascota; set => codigoMascota = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public TipoMascota? TipoMascota { get => this.tipomascota; set => this.tipomascota = value; }
}

public class Servicio
{
    private int id_servicio=0;
    private string nombre = "";
    private double precio;
    private string estado = "";
    private id_mascota ? id_mascota= null;	

    public int Id_Servicio { get => id_servicio; set => id_servicio = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public double Precio { get => precio; set => precio = value; }
    public string Estado { get => estado; set => estado = value; }
    public id_mascota? id_mascota { get => this.id_mascota; set => this.id_mascota = value; }
}

public class MetodoDePago
{
    private int id_pago=0;
    private string nombre = "";

    public int Id_Pago { get => id_pago; set => id_pago = value; }
    public string Nombre { get => nombre; set => nombre = value; }
}

public class Factura
{
    private int id_factura=0;
    private string num_factura = "";
    private DateTime fecha;
    private double iva;
    private double total;
    private Cliente? Cliente = null;
    private Mascota? Mascota = null;
    private MetodoDePago? MetodoDePago = null;
    private Servicio? Servicio = null ;

	
    public int Id_Factura { get => id_factura; set => id_factura = value; }
    public string Num_Factura { get => num_factura; set => num_factura = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public double IVA { get => iva; set => iva = value; }
    public double Total { get => total; set => total = value; }
    public Cliente? Cliente { get => this.Cliente; set => this.Cliente = value; }
    public Mascota? Mascota { get => this.Mascota; set => this.Mascota = value; }
    public MetodoDePago? MetodoDePago { get => this.MetodoDePago; set => this.MetodoDePago = value; }
    public Servicio? Servicio { get => this.Servicio; set => this.Servicio = value; }

	
}
