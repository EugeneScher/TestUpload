using System;

//---------------------------------------------------------------------------

//C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
//#include <vcl.h>
//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
//#pragma hdrstop

//---------------------------------------------------------------------------

//---------------------------------------------------------------------------
//C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
//#include <Classes.hpp>
//C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
//#include <Controls.hpp>
//C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
//#include <StdCtrls.hpp>
//C++ TO C# CONVERTER WARNING: The following #include directive was ignored:
//#include <Forms.hpp>
//---------------------------------------------------------------------------
public class TMainForm : TForm
{
//C++ TO C# CONVERTER TODO TASK: The following statement was not recognized, possibly due to an unrecognized macro:
__published: // IDE-managed Components
		private TGroupBox GroupBox1;
		private TGroupBox GroupBox2;
		private TEdit Editax;
		private TLabel Label1;
		private TEdit Editay;
		private TLabel Label2;
		private TGroupBox GroupBox3;
		private TLabel Label3;
		private TLabel Label4;
		private TEdit Editbx;
		private TEdit Editby;
		private TGroupBox GroupBox4;
		private TLabel Label5;
		private TLabel Label6;
		private TEdit Editdx;
		private TEdit Editdy;
		private TGroupBox GroupBox5;
		private TLabel Label7;
		private TLabel Label8;
		private TEdit Editcx;
		private TEdit Editcy;
		private TGroupBox GroupBox6;
		private TButton Button1;
		private TLabel ResultLabel;
		//---------------------------------------------------------------------------

//C++ TO C# CONVERTER NOTE: _fastcall is not available in C#:
//ORIGINAL LINE: void __fastcall Button1Click(TObject *Sender)
		private void Button1Click(TObject Sender)
		{

		 sPoint A = new sPoint();
		 sPoint B = new sPoint();
		 sPoint C = new sPoint();
		 sPoint D = new sPoint();
		 // �������� ������
		 A.x = Editax.Text.ToDouble();
		 A.y = Editay.Text.ToDouble();
		 B.x = Editbx.Text.ToDouble();
		 B.y = Editby.Text.ToDouble();
		 C.x = Editcx.Text.ToDouble();
		 C.y = Editcy.Text.ToDouble();
		 D.x = Editdx.Text.ToDouble();
		 D.y = Editdy.Text.ToDouble();
		 // ������� �������
		 sPoint AB = new sPoint();
		 sPoint BC = new sPoint();
		 sPoint CD = new sPoint();
		 sPoint AD = new sPoint();
//C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
//ORIGINAL LINE: AB=coord_vector(A,B);
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
		 AB.CopyFrom(GlobalMembers.coord_vector(new sPoint(A), new sPoint(B)));
//C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
//ORIGINAL LINE: BC=coord_vector(B,C);
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
		 BC.CopyFrom(GlobalMembers.coord_vector(new sPoint(B), new sPoint(C)));
//C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
//ORIGINAL LINE: CD=coord_vector(C,D);
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
		 CD.CopyFrom(GlobalMembers.coord_vector(new sPoint(C), new sPoint(D)));
//C++ TO C# CONVERTER TODO TASK: The following line was determined to be a copy assignment (rather than a reference assignment) - this should be verified and a 'CopyFrom' method should be created:
//ORIGINAL LINE: AD=coord_vector(A,D);
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
		 AD.CopyFrom(GlobalMembers.coord_vector(new sPoint(A), new sPoint(D)));
		 if ((AB.x == 0 && AB.y == 0) || (BC.x == 0 && BC.y == 0) || (CD.x == 0 && CD.y == 0) || (AD.x == 0 && AD.y == 0))
		 {
		  ShowMessage("��������� ������ �� �������� �����������������");
		  return;
		 }
		 // ����������� ���� ���������������
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
//ORIGINAL LINE: if (collinear_vectors(AB,CD) && collinear_vectors(BC,AD) && ortogonal_vectors(AB,BC))
		 if (GlobalMembers.collinear_vectors(new sPoint(AB), new sPoint(CD)) && GlobalMembers.collinear_vectors(new sPoint(BC), new sPoint(AD)) && GlobalMembers.ortogonal_vectors(new sPoint(AB), new sPoint(BC)))
		 {
		 ResultLabel.Caption = " ������������� ";
		 }
		 else
		 {
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
//ORIGINAL LINE: if (collinear_vectors(AB,CD) && collinear_vectors(BC,AD))
		 if (GlobalMembers.collinear_vectors(new sPoint(AB), new sPoint(CD)) && GlobalMembers.collinear_vectors(new sPoint(BC), new sPoint(AD)))
		 {
		 ResultLabel.Caption = " �������������� ";
		 }
		 else
		 {
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
//ORIGINAL LINE: if (collinear_vectors(AB,CD) || collinear_vectors(BC,AD))
		 if (GlobalMembers.collinear_vectors(new sPoint(AB), new sPoint(CD)) || GlobalMembers.collinear_vectors(new sPoint(BC), new sPoint(AD)))
		 {
		 ResultLabel.Caption = " �������� ";
		 }
		 else
		 {
		 ResultLabel.Caption = " ��������������� ����� ���� ";
		 }
		 }
		 }

		}

		//---------------------------------------------------------------------------
//C++ TO C# CONVERTER NOTE: _fastcall is not available in C#:
//ORIGINAL LINE: __fastcall TMainForm(TComponent* Owner) : TForm(Owner)
		public TMainForm(TComponent Owner) : base(Owner)
		{
		}
}
public class sPoint
{
  public double x;
  public double y;
}

public static class GlobalMembers
{
	//---------------------------------------------------------------------------
//C++ TO C# CONVERTER NOTE: 'extern' variable declarations are not required in C#:
	//extern PACKAGE TMainForm *MainForm;
// ������ ����� �������

	public static double le(sPoint a1, sPoint a2)
	{
	 return Math.Sqrt((a1.x - a2.x) * (a1.x - a2.x) + (a1.y - a2.y) * (a1.y - a2.y));
	}
// ���������� �������  ---------------------------------------------------------

	public static sPoint coord_vector(sPoint begin, sPoint end)
	{
	 sPoint v = new sPoint();
	 v.x = end.x - begin.x;
	 v.y = end.y - begin.y;
//C++ TO C# CONVERTER TODO TASK: The following line was determined to contain a copy constructor call - this should be verified and a copy constructor should be created:
//ORIGINAL LINE: return v;
	 return new sPoint(v);
	}
// ������� ������������ --------------------------------------------------------

	public static bool ortogonal_vectors(sPoint v1, sPoint v2)
	{
	 if ((v1.x * v2.x + v1.y * v2.y) == 0)
	 {
		 return true;
	 }
	 else
	 {
		 return false;
	 }
	}

	//---------------------------------------------------------------------------

	//---------------------------------------------------------------------------
	//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
	//#pragma package(smart_init)
	//C++ TO C# CONVERTER TODO TASK: There is no equivalent to most C++ 'pragma' directives in C#:
	//#pragma resource "*.dfm"
	public static TMainForm MainForm;
	// ������� ����������� ---------------------------------------------------------
	public static bool collinear_vectors(sPoint v1,sPoint v2)
	{
	 if ((v1.x == 0.0 && v2.x == 0.0) || (v1.y == 0.0 && v2.y == 0.0))
	 {
	  return true;
	 }
	 else
	 {
	  if (v2.x == 0.0 || v2.y == 0.0)
	  {
		  return false;
	  }
	  else
	  {
	   if ((v1.x / v2.x) == (v1.y / v2.y))
	   {
		   return true;
	   }
	   else
	   {
		   return false;
	   }
	  }
	 }
	}
	//---------------------------------------------------------------------------



}