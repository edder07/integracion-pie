/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proyectopie;

/**
 *
 * @author 56962
 */
public class ProyectoPIE {

     
         public static conexion conexion = new conexion();
         public static int usua = 0;
    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
     if(conexion.crearConexion()){
            logeo m = new logeo();
            m.setVisible(true);
     }
    }
    
}
