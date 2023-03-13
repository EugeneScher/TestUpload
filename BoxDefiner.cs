public static class GlobalMembersBoxDefiner
{
	//---------------------------------------------------------------------------
//C++ TO C# CONVERTER NOTE: WINAPI is not available in C#:
//ORIGINAL LINE: WINAPI WinMain(System.IntPtr, System.IntPtr, string, int)
//C++ TO C# CONVERTER WARNING: The following constructor is declared outside of its associated class:
	public static WinMain(System.IntPtr UnnamedParameter1, System.IntPtr UnnamedParameter2, string UnnamedParameter3, int UnnamedParameter4)
	{
			try
			{
					 Application.Initialize();
					 Application.Title = "B:O:X";
					 Application.CreateForm(__classid(TMainForm), MainForm);
					 Application.Run();
			}
			catch (Exception exception)
			{
					 Application.ShowException(exception);
			}
			catch
			{
					 try
					 {
							 throw Exception("");
					 }
					 catch (Exception exception)
					 {
							 Application.ShowException(exception);
					 }
			}
			return 0;
	}
}

//---------------------------------------------------------------------------

//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma hdrstop
//---------------------------------------------------------------------------
//C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
USEFORM("Unit1.cpp", MainForm);
//---------------------------------------------------------------------------