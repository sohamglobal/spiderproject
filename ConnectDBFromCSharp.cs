//C# program to connect to Microsoft SQL Server 2017 DB with ADO.NET
//program developed by sharayu for git demo

using System;
using System.Data;
using System.Data.SqlClient;

class ConnectToSQLServer
{
public static void Main()
{
SqlConnection scon;
SqlDataAdapter sda;
DataSet ds;
string nm;
int bal;

try
{
scon=new SqlConnection("server=sohamglobal\\sqlexpress;uid=sa;pwd=microsoft;database=amazondb0815");

sda=new SqlDataAdapter("select * from accounts;",scon);

ds=new DataSet();
sda.Fill(ds,"acc");

//Console.WriteLine(ds.GetXml());
//-------

int cnt=ds.Tables["acc"].Rows.Count;
Console.WriteLine("Total records retrieved "+cnt);

for(int i=0;i<cnt;i++)
{
nm=Convert.ToString(ds.Tables["acc"].Rows[i]["accnm"]);
bal=Convert.ToInt32(ds.Tables[0].Rows[i]["balance"]);
Console.WriteLine(nm+"\t"+bal);
}


}
catch(Exception ex)
{
Console.WriteLine(ex.Message);
}

}
}
