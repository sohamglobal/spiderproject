//JDBC program to connect and communicate with MySQL 8 Database from Java 11

import java.sql.*;

class JDBCWithMySQL
{
public static void main(String args[])
{
Connection con;
Statement st;
ResultSet rs;

try
{
Class.forName("com.mysql.cj.jdbc.Driver");

con=DriverManager.getConnection("jdbc:mysql://localhost:3306/visadb?user=root&password=crosspolo&useSSL=false&allowPublicKeyRetrieval=true");

st=con.createStatement();
rs=st.executeQuery("select accnm,balance from accounts;");

while(rs.next())
{
System.out.print(rs.getString("accnm")+"\t");
System.out.println(rs.getDouble(2));
}

con.close();
}
catch(Exception e)
{
System.out.println(e);
}

}
}




