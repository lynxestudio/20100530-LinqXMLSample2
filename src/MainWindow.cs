using System;
using Gtk;
using System.Xml.Linq;
using System.Collections.Generic;
using System.Linq;


public partial class MainWindow : Gtk.Window
{
	public MainWindow () : base(Gtk.WindowType.Toplevel)
	{
		Build ();
		AddColumns(Resultados);
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	protected virtual void OnBtnBuscarClicked (object sender, System.EventArgs e)
	{
		ListStore store = new ListStore(typeof(string));
		if(System.IO.File.Exists("articulos.xml")){
		string col = "Codigo";
		if(rbNombre.Active)col = "Nombre";
		if(rbIdArticulo.Active)col = "IdArticulo";
		Resultados.EnableGridLines = TreeViewGridLines.Horizontal;
		XElement xml = XElement.Load("articulos.xml");
		var q = from s in xml.Elements("Table").Elements(col)
		where  s.Value.Contains(txtQuery.Text)
		select s;
		foreach(string r in q){
		store.AppendValues(r);
		}
		Resultados.Model = store;
		}else
		using(Dialog dia = new MessageDialog(this,DialogFlags.Modal,
			                               MessageType.Error,
			                               ButtonsType.Ok,"No existe el archivo XML",null)){
			dia.Run();
			dia.Destroy();
		}
	}
	
	//se crear las columnas del Grid
	void AddColumns (TreeView treeView)	{
			CellRendererText rendererText = new CellRendererText ();
			string[] s = {"Resultado"};
			TreeViewColumn column;
			for(int i = 0;i < s.Length;i++){
				column =  new TreeViewColumn (s[i], rendererText, "text", i);
				treeView.AppendColumn (column); 	}
		}
}