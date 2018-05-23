package md52288b9dfb5e193f9ef9d5c2c6f7b7047;


public class pantallaInicial
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("Propishare.Resources.layout.pantallaInicial, Propishare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", pantallaInicial.class, __md_methods);
	}


	public pantallaInicial () throws java.lang.Throwable
	{
		super ();
		if (getClass () == pantallaInicial.class)
			mono.android.TypeManager.Activate ("Propishare.Resources.layout.pantallaInicial, Propishare, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
