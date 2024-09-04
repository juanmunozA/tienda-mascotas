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
    private id_persona? id_persona = null;
    private id_mascota? id_mascota = null;
    private id_pago? id_pago = null;
    private id_servicio? id_servicio = null ;

	
    public int Id_Factura { get => id_factura; set => id_factura = value; }
    public string Num_Factura { get => num_factura; set => num_factura = value; }
    public DateTime Fecha { get => fecha; set => fecha = value; }
    public double IVA { get => iva; set => iva = value; }
    public double Total { get => total; set => total = value; }
    public id_persona? id_persona { get => this.id_persona; set => this.id_persona = value; }
    public id_mascota? id_mascota { get => this.id_mascota; set => this.id_mascota = value; }
    public id_pago? id_pago { get => this.id_pago; set => this.id_pago = value; }
    public id_servicio? id_servicio { get => this.id_servicio; set => this.id_servicio = value; }

	
}

public class Program
{
    public static void Main(string[] args)
    {
        // Crear algunos métodos de pago
        MetodoDePago pago1 = new MetodoDePago { Id_Pago = 1, Nombre = "Efectivo" };
        MetodoDePago pago2 = new MetodoDePago { Id_Pago = 2, Nombre = "Tarjeta" };

        // Crear algunas mascotas
        Mascota mascota1 = new Mascota { Id_Mascota = 1, CodigoMascota = "DP307", Nombre = "Perro" };
        Mascota mascota2 = new Mascota { Id_Mascota = 2, CodigoMascota = "NE428", Nombre = "Gato" };
        Mascota mascota3 = new Mascota { Id_Mascota = 3, CodigoMascota = "SA589", Nombre = "Ave" };

        // Crear algunos clientes
        Cliente cliente1 = new Cliente { Id_Persona = 1, Cedula = "203", Nombre = "Sara" };
        Cliente cliente2 = new Cliente { Id_Persona = 2, Cedula = "407", Nombre = "Julian" };
        Cliente cliente3 = new Cliente { Id_Persona = 3, Cedula = "584", Nombre = "Jeronimo" };

        // Crear algunos servicios
        Servicio servicio1 = new Servicio { Id_Servicio = 1, Nombre = "Alquiler", Precio = 60000, Estado = "Proceso" };
        Servicio servicio2 = new Servicio { Id_Servicio = 2, Nombre = "Inyección", Precio = 40000, Estado = "Finalizado" };
        Servicio servicio3 = new Servicio { Id_Servicio = 3, Nombre = "Revisión", Precio = 120000, Estado = "Proceso" };
        Servicio servicio4 = new Servicio { Id_Servicio = 4, Nombre = "Desparasitacion", Precio = 90000, Estado = "Finalizado" };

        // Crear facturas basadas en la tabla de la imagen
        List<Factura> facturas = new List<Factura>
        {
            new Factura
            {
                Id_Factura = 1,
                Num_Factura = "A0010",
                Fecha = new DateTime(2024, 5, 10),
                IVA = 6000,
                Total = 66000,
                Id_Persona = cliente1.Id_Persona,
                Cód_Mascota = mascota1.Id_Mascota,
                Id_Pago = pago1.Id_Pago,
                Id_Servicio = servicio1.Id_Servicio
            },
            new Factura
            {
                Id_Factura = 2,
                Num_Factura = "A0011",
                Fecha = new DateTime(2024, 3, 12),
                IVA = 0,
                Total = 40000,
                Id_Persona = cliente2.Id_Persona,
                Cód_Mascota = mascota2.Id_Mascota,
                Id_Pago = pago2.Id_Pago,
                Id_Servicio = servicio2.Id_Servicio
            },
            new Factura
            {
                Id_Factura = 3,
                Num_Factura = "A0012",
                Fecha = new DateTime(2023, 8, 25),
                IVA = 12000,
                Total = 132000,
                Id_Persona = cliente3.Id_Persona,
                Cód_Mascota = mascota3.Id_Mascota,
                Id_Pago = pago1.Id_Pago,
                Id_Servicio = servicio3.Id_Servicio
            },
            new Factura
            {
                Id_Factura = 4,
                Num_Factura = "A0010",
                Fecha = new DateTime(2024, 5, 11),
                IVA = 9000,
                Total = 99000,
                Id_Persona = cliente1.Id_Persona,
                Cód_Mascota = mascota1.Id_Mascota,
                Id_Pago = pago2.Id_Pago,
                Id_Servicio = servicio4.Id_Servicio
            }
        };

        // Mostrar las facturas generadas
        foreach (var factura in facturas)
        {
            var cliente = factura.Id_Persona == 1 ? cliente1 : factura.Id_Persona == 2 ? cliente2 : cliente3;
            var mascota = factura.Cód_Mascota == 1 ? mascota1 : factura.Cód_Mascota == 2 ? mascota2 : mascota3;
            var servicio = factura.Id_Servicio == 1 ? servicio1 : factura.Id_Servicio == 2 ? servicio2 : factura.Id_Servicio == 3 ? servicio3 : servicio4;
            var metodoPago = factura.Id_Pago == 1 ? pago1 : pago2;

            Console.WriteLine($"Factura: {factura.Num_Factura}");
            Console.WriteLine($"Fecha: {factura.Fecha.ToShortDateString()}");
            Console.WriteLine($"Cliente: {cliente.Nombre} (Cédula: {cliente.Cedula})");
            Console.WriteLine($"Mascota: {mascota.Nombre} (Código: {mascota.CodigoMascota})");
            Console.WriteLine($"Servicio: {servicio.Nombre}, Estado: {servicio.Estado}, Precio: {servicio.Precio}");
            Console.WriteLine($"Método de Pago: {metodoPago.Nombre}");
            Console.WriteLine($"Total con IVA: {factura.Total}\n");
        }
    }
}
