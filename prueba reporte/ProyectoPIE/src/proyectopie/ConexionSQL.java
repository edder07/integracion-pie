
package proyectopie;

import java.sql.*;
import javax.swing.JOptionPane;

public class ConexionSQL {
    
    public String usuario = "charles";
    public String password = "199314";
    public String url = "jdbc:sqlserver://192.168.43.72:1433;databaseName=integracion_pie;";
   
  public Connection cn = null;
  public Statement st = null;
        
  public Statement Conectar() 
        {
              
        try
       {
       
        Connection cn = DriverManager.getConnection(url,usuario,password);
       
        st=cn.createStatement(ResultSet.TYPE_SCROLL_INSENSITIVE, ResultSet.CONCUR_READ_ONLY);
       
       } catch (SQLException i)
       {
           JOptionPane.showMessageDialog(null, i);
       } 
        return st;
        
       }

    Statement prepareStatement(String insert_into_profesional_apoyo_rut_apoyo__) {
        throw new UnsupportedOperationException("Not supported yet."); //To change body of generated methods, choose Tools | Templates.
    }
}
