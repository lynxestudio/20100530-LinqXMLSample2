
// This file has been generated by the GUI designer. Do not modify.

public partial class MainWindow
{
	private global::Gtk.VBox vbox1;

	private global::Gtk.HBox hbox2;

	private global::Gtk.Entry txtQuery;

	private global::Gtk.Button btnBuscar;

	private global::Gtk.Frame frame2;

	private global::Gtk.Alignment GtkAlignment;

	private global::Gtk.HBox hbox4;

	private global::Gtk.RadioButton rbCodigo;

	private global::Gtk.RadioButton rbIdArticulo;

	private global::Gtk.RadioButton rbNombre;

	private global::Gtk.Label GtkLabel5;

	private global::Gtk.HBox hbox5;

	private global::Gtk.ScrolledWindow scrolledwindow1;

	private global::Gtk.TreeView Resultados;

	protected virtual void Build()
	{
		global::Stetic.Gui.Initialize(this);
		// Widget MainWindow
		this.Name = "MainWindow";
		this.Title = global::Mono.Unix.Catalog.GetString("Buscar en artículos");
		this.WindowPosition = ((global::Gtk.WindowPosition)(4));
		// Container child MainWindow.Gtk.Container+ContainerChild
		this.vbox1 = new global::Gtk.VBox();
		this.vbox1.Name = "vbox1";
		this.vbox1.Spacing = 6;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox2 = new global::Gtk.HBox();
		this.hbox2.Name = "hbox2";
		this.hbox2.Spacing = 6;
		// Container child hbox2.Gtk.Box+BoxChild
		this.txtQuery = new global::Gtk.Entry();
		this.txtQuery.CanFocus = true;
		this.txtQuery.Name = "txtQuery";
		this.txtQuery.IsEditable = true;
		this.txtQuery.InvisibleChar = '●';
		this.hbox2.Add(this.txtQuery);
		global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.txtQuery]));
		w1.Position = 0;
		// Container child hbox2.Gtk.Box+BoxChild
		this.btnBuscar = new global::Gtk.Button();
		this.btnBuscar.CanFocus = true;
		this.btnBuscar.Name = "btnBuscar";
		this.btnBuscar.UseUnderline = true;
		this.btnBuscar.Label = global::Mono.Unix.Catalog.GetString("Consultar");
		this.hbox2.Add(this.btnBuscar);
		global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.btnBuscar]));
		w2.Position = 1;
		w2.Expand = false;
		w2.Fill = false;
		this.vbox1.Add(this.hbox2);
		global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
		w3.Position = 0;
		w3.Expand = false;
		w3.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.frame2 = new global::Gtk.Frame();
		this.frame2.Name = "frame2";
		this.frame2.ShadowType = ((global::Gtk.ShadowType)(0));
		// Container child frame2.Gtk.Container+ContainerChild
		this.GtkAlignment = new global::Gtk.Alignment(0F, 0F, 1F, 1F);
		this.GtkAlignment.Name = "GtkAlignment";
		this.GtkAlignment.LeftPadding = ((uint)(12));
		// Container child GtkAlignment.Gtk.Container+ContainerChild
		this.hbox4 = new global::Gtk.HBox();
		this.hbox4.Name = "hbox4";
		this.hbox4.Spacing = 6;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rbCodigo = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Código"));
		this.rbCodigo.CanFocus = true;
		this.rbCodigo.Name = "rbCodigo";
		this.rbCodigo.DrawIndicator = true;
		this.rbCodigo.UseUnderline = true;
		this.rbCodigo.Group = new global::GLib.SList(global::System.IntPtr.Zero);
		this.hbox4.Add(this.rbCodigo);
		global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.rbCodigo]));
		w4.Position = 0;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rbIdArticulo = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("IdArticulo"));
		this.rbIdArticulo.CanFocus = true;
		this.rbIdArticulo.Name = "rbIdArticulo";
		this.rbIdArticulo.DrawIndicator = true;
		this.rbIdArticulo.UseUnderline = true;
		this.rbIdArticulo.Group = this.rbCodigo.Group;
		this.hbox4.Add(this.rbIdArticulo);
		global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.rbIdArticulo]));
		w5.Position = 1;
		// Container child hbox4.Gtk.Box+BoxChild
		this.rbNombre = new global::Gtk.RadioButton(global::Mono.Unix.Catalog.GetString("Nombre"));
		this.rbNombre.CanFocus = true;
		this.rbNombre.Name = "rbNombre";
		this.rbNombre.DrawIndicator = true;
		this.rbNombre.UseUnderline = true;
		this.rbNombre.Group = this.rbCodigo.Group;
		this.hbox4.Add(this.rbNombre);
		global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.rbNombre]));
		w6.Position = 2;
		this.GtkAlignment.Add(this.hbox4);
		this.frame2.Add(this.GtkAlignment);
		this.GtkLabel5 = new global::Gtk.Label();
		this.GtkLabel5.Name = "GtkLabel5";
		this.GtkLabel5.LabelProp = global::Mono.Unix.Catalog.GetString("<b>Buscar en</b>");
		this.GtkLabel5.UseMarkup = true;
		this.frame2.LabelWidget = this.GtkLabel5;
		this.vbox1.Add(this.frame2);
		global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.frame2]));
		w9.Position = 1;
		w9.Expand = false;
		w9.Fill = false;
		// Container child vbox1.Gtk.Box+BoxChild
		this.hbox5 = new global::Gtk.HBox();
		this.hbox5.Name = "hbox5";
		this.hbox5.Spacing = 6;
		// Container child hbox5.Gtk.Box+BoxChild
		this.scrolledwindow1 = new global::Gtk.ScrolledWindow();
		this.scrolledwindow1.CanFocus = true;
		this.scrolledwindow1.Name = "scrolledwindow1";
		this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
		// Container child scrolledwindow1.Gtk.Container+ContainerChild
		this.Resultados = new global::Gtk.TreeView();
		this.Resultados.CanFocus = true;
		this.Resultados.Name = "Resultados";
		this.scrolledwindow1.Add(this.Resultados);
		this.hbox5.Add(this.scrolledwindow1);
		global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.scrolledwindow1]));
		w11.Position = 0;
		this.vbox1.Add(this.hbox5);
		global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox5]));
		w12.Position = 2;
		this.Add(this.vbox1);
		if ((this.Child != null))
		{
			this.Child.ShowAll();
		}
		this.DefaultWidth = 400;
		this.DefaultHeight = 300;
		this.Show();
		this.DeleteEvent += new global::Gtk.DeleteEventHandler(this.OnDeleteEvent);
		this.btnBuscar.Clicked += new global::System.EventHandler(this.OnBtnBuscarClicked);
	}
}