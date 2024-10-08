using System;

public class Clientes
{
    private int idCliente = 0;
    private string cedula = "";
    private string nombre = "";
    private Mascotas? mascota = null;

    public int IdCliente { get => idCliente; set => idCliente = value; }
    public string Cedula { get => cedula; set => cedula = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public Mascotas? Mascota { get => mascota; set => mascota = value; }
}

public class TiposMascota
{
    private int idTipoMascota = 0;
    private string tipoMascota = "";
    private string nombre = "";
    private string sexo = "";
    private int edad = 0;
    private Clientes? cliente = null;

    public int IdTipoMascota { get => idTipoMascota; set => idTipoMascota = value; }
    public string TipoMascota { get => tipoMascota; set => tipoMascota = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public string Sexo { get => sexo; set => sexo = value; }
    public int Edad { get => edad; set => edad = value; }
    public Clientes? Cliente { get => cliente; set => cliente = value; }
}

public class Mascotas
{
    private int idMascota = 0;
    private string codigoMascota = "";
    private string nombre = "";
    private TiposMascota? tipoMascota = null;

    public int IdMascota { get => idMascota; set => idMascota = value; }
    public string CodigoMascota { get => codigoMascota; set => codigoMascota = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public TiposMascota? TipoMascota { get => tipoMascota; set => tipoMascota = value; }
}

public class Servicios
{
    private int idServicio = 0;
    private string nombre = "";
    private double precio = 0.0; 
    private string estado = "";
    private Mascotas? mascota = null;

    public int IdServicio { get => idServicio; set => idServicio = value; }
    public string Nombre { get => nombre; set => nombre = value; }
    public double Precio { get => precio; set => precio = value; }
    public string Estado { get => estado; set => estado = value; }
    public Mascotas? Mascota { get => mascota; set => mascota = value; }
}

public class MetodosDePago
{
    private int idPago = 0;
    private string nombre = "";

    public int IdPago { get => idPago; set => idPago = value; }
    public string Nombre { get => nombre; set => nombre = value; }
}

public class Facturas
{
    private int idFactura = 0;
    private string numFactura = "";
    private DateTime fecha;
    private double iva;
    private double total;
    private Clientes? cliente = null;
    private Mascotas? mascota = null;
    private MetodosDePago? metodoDePago = null;
    private Servicios? servicio = null;

    public int IdFactura { get => idFactura; set => idFactura = value; }
    public string NumFactura { get => numFactura; set => numFactura = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public double IVA { get => iva; set => iva = value; }
    public double Total { get => total; set => total = value; }
    public Clientes? Cliente { get => cliente; set => cliente = value; }
    public Mascotas? Mascota { get => mascota; set => mascota = value; }
    public MetodosDePago? MetodoDePago { get => metodoDePago; set => metodoDePago = value; }
    public Servicios? Servicio { get => servicio; set => servicio = value; }
}
