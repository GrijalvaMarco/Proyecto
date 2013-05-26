using System;
using Gtk;

public partial class MainWindow: Gtk.Window
{	
	public MainWindow (): base (Gtk.WindowType.Toplevel)
	{
		Build ();
	}

	protected void OnDeleteEvent (object sender, DeleteEventArgs a)
	{
		Application.Quit ();
		a.RetVal = true;
	}
	
	protected void OnBtnEntrarClicked (object sender, EventArgs e)
	{
		
		Proyecto.Autenticacion auth = new Proyecto.Autenticacion ();
		if (auth.valido (this.txtLogin.Text.Trim (), this.txtPassword.Text.Trim ())) {
			MessageDialog md = new MessageDialog (
				null, 
		      	DialogFlags.Modal,
		  		MessageType.Info, 
		      	ButtonsType.None, "Bienvenido usuario " + this.txtLogin.Text.Trim ()  
			);
			md.Show ();
		NuevoForm nuevo = new NuevoForm();
		nuevo.Show();
		} else {
			MessageDialog md = new MessageDialog (
				null, 
		      	DialogFlags.Modal,
		  		MessageType.Error, 
		      	ButtonsType.None, "Usted es un intruso " 
			);
			md.Show ();
			
		}
	}
	

}