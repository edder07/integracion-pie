package proyectopie;

import java.awt.event.KeyEvent;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 56962
 */
public class FrameEvaluador extends javax.swing.JFrame {

    conexion con = ProyectoPIE.conexion;
    /**
     * Creates new form FrameAlumno
     */
    public FrameEvaluador() {
        initComponents();
        this.setExtendedState(MAXIMIZED_BOTH);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        txtrutevaluador = new javax.swing.JTextField();
        txtnombreevaluador = new javax.swing.JTextField();
        txtprofesionevaluador = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();
        jButton4 = new javax.swing.JButton();
        jButton5 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setUndecorated(true);

        jLabel1.setFont(new java.awt.Font("Times New Roman", 1, 24)); // NOI18N
        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/image (3) (1).png"))); // NOI18N
        jLabel1.setText("    EVALUADOR");
        jLabel1.setAlignmentX(0.5F);

        jLabel2.setFont(new java.awt.Font("Times New Roman", 1, 12)); // NOI18N
        jLabel2.setText("INGRESE RUT DEL EVALUADOR");

        jLabel3.setFont(new java.awt.Font("Times New Roman", 1, 12)); // NOI18N
        jLabel3.setText("INGRESE NOMBRE DEL EVALUADOR");

        jLabel4.setFont(new java.awt.Font("Times New Roman", 1, 12)); // NOI18N
        jLabel4.setText("INGRESE PROFESION DEL EVALUADOR");

        txtrutevaluador.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N
        txtrutevaluador.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtrutevaluadorKeyTyped(evt);
            }
        });

        txtnombreevaluador.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N
        txtnombreevaluador.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtnombreevaluadorKeyTyped(evt);
            }
        });

        txtprofesionevaluador.setFont(new java.awt.Font("Times New Roman", 0, 12)); // NOI18N
        txtprofesionevaluador.addKeyListener(new java.awt.event.KeyAdapter() {
            public void keyTyped(java.awt.event.KeyEvent evt) {
                txtprofesionevaluadorKeyTyped(evt);
            }
        });

        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/lupa33.png"))); // NOI18N
        jButton1.setText("Buscar");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jButton2.setText("Guardar");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jButton3.setText("Modificar");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });

        jButton4.setText("Limpiar");
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });

        jButton5.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/btnatras.png"))); // NOI18N
        jButton5.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton5MouseClicked(evt);
            }
        });
        jButton5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton5ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(txtprofesionevaluador, javax.swing.GroupLayout.PREFERRED_SIZE, 495, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(layout.createSequentialGroup()
                            .addGap(62, 62, 62)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addGroup(layout.createSequentialGroup()
                                    .addComponent(jLabel2)
                                    .addGap(30, 30, 30)
                                    .addComponent(txtrutevaluador, javax.swing.GroupLayout.PREFERRED_SIZE, 148, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGap(18, 18, 18)
                                    .addComponent(jButton1))
                                .addGroup(layout.createSequentialGroup()
                                    .addComponent(jLabel3)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                    .addComponent(txtnombreevaluador, javax.swing.GroupLayout.PREFERRED_SIZE, 516, javax.swing.GroupLayout.PREFERRED_SIZE))
                                .addComponent(jLabel4)
                                .addGroup(layout.createSequentialGroup()
                                    .addGap(13, 13, 13)
                                    .addComponent(jButton5, javax.swing.GroupLayout.PREFERRED_SIZE, 174, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addGap(61, 61, 61)
                                    .addComponent(jButton2)
                                    .addGap(84, 84, 84)
                                    .addComponent(jButton3)
                                    .addGap(85, 85, 85)
                                    .addComponent(jButton4))))
                        .addGroup(layout.createSequentialGroup()
                            .addGap(289, 289, 289)
                            .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, 356, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addContainerGap(233, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(92, 92, 92)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addComponent(jLabel2)
                            .addComponent(txtrutevaluador, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addGap(78, 78, 78)
                        .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 47, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addGap(25, 25, 25)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(txtnombreevaluador, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(26, 26, 26)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(txtprofesionevaluador, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 152, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButton5, javax.swing.GroupLayout.Alignment.TRAILING, javax.swing.GroupLayout.PREFERRED_SIZE, 65, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jButton2)
                        .addComponent(jButton3)
                        .addComponent(jButton4)))
                .addGap(0, 0, Short.MAX_VALUE))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton5ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jButton5ActionPerformed

    private void jButton5MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton5MouseClicked
      Ingresos frame3 = new Ingresos(); 
    frame3.setVisible(true);                                                                                                                
    FrameEvaluador.this.dispose();
    }//GEN-LAST:event_jButton5MouseClicked

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
       String rut_evaluador = txtrutevaluador.getText();
         //String nombre_alumno = txtnombre.getText();
         //String apellido_paterno = txtapellidop.getText();
         //String apellido_materno = txtapellidom.getText();
         //Integer fono_alumno = Integer.parseInt(txtfono.getText());
         //String direccion_alumno = txtdireccion.getText();
 
        if(rut_evaluador.isEmpty() ){
          
         JOptionPane.showMessageDialog(null,"Debe inresar RUT","ERROR",JOptionPane.ERROR_MESSAGE);
        }else
         {
             
        try{
            String sql = "select profesional_evaluador.nombre_evaluador, profesional_evaluador.profesion from profesional_evaluador where profesional_evaluador.rut_evaluador= '" + rut_evaluador +"'";
            ResultSet rs = con.ejecutarSQLSelect(sql);
            if (rs.next()){
                
                txtnombreevaluador.setText(rs.getString("nombre_evaluador")) ;
                txtprofesionevaluador.setText(rs.getString("profesion")) ;
               
                
                   
            } else{
                            
                JOptionPane.showMessageDialog(null,"RUT no existe","ERROR",JOptionPane.ERROR_MESSAGE);
            }
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
        }
    }//GEN-LAST:event_jButton1ActionPerformed

     public static boolean validarRut(String rut) {
        

        boolean validacion = false;
        try {
        rut =  rut.toUpperCase();
        rut = rut.replace(".", "");
        rut = rut.replace("-", "");
        int rutAux = Integer.parseInt(rut.substring(0, rut.length() - 1));

        char dv = rut.charAt(rut.length() - 1);

        int m = 0, s = 1;
        for (; rutAux != 0; rutAux /= 10) {
        s = (s + rutAux % 10 * (9 - m++ % 6)) % 11;
        }
        if (dv == (char) (s != 0 ? s + 47 : 75)) {
        validacion = true;
        }

} catch (java.lang.NumberFormatException e) {
} catch (Exception e) {
}
return validacion;
}
    void insert_profesional_evaluador(){
        
         
        String rut_evaluador = txtrutevaluador.getText();
        String nombre_evaluador = txtnombreevaluador.getText();
        String profesion_evaluador = txtprofesionevaluador.getText();
      
 
       
            
        boolean respuesta;
        respuesta=validarRut(rut_evaluador);
        if (respuesta==false){
             JOptionPane.showMessageDialog(rootPane,"Rut Invalido","ERROR", JOptionPane.ERROR_MESSAGE);
             txtrutevaluador.grabFocus();
             
             }else {
            
        
              if(rut_evaluador.isEmpty() || txtnombreevaluador.getText().isEmpty() || txtprofesionevaluador.getText().isEmpty()){
          
               JOptionPane.showMessageDialog(null,"No deje campos en blanco","ERROR",JOptionPane.ERROR_MESSAGE);
               }else {
  
                  try{
                      
                      String sql = "INSERT INTO profesional_evaluador (rut_evaluador,nombre_evaluador,profesion,estado) VALUES ('" + rut_evaluador +"', '" + nombre_evaluador +"','" + profesion_evaluador +"','activo')";
                      PreparedStatement ps=con.getConexion().prepareStatement(sql);
                      ps.execute();
                      ps.close();
                      JOptionPane.showMessageDialog(null, "Profesional ingresado correctamente");
                      }
                  
                  catch (SQLException ex){
                      
                      JOptionPane.showMessageDialog(null, ex);
                      }
                  } 
             }
    }
    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed

           String rut_evaluador = txtrutevaluador.getText();
         //String nombre_alumno = txtnombre.getText();
         //String apellido_paterno = txtapellidop.getText();
         //String apellido_materno = txtapellidom.getText();
         //Integer fono_alumno = Integer.parseInt(txtfono.getText());
         //String direccion_alumno = txtdireccion.getText();
 
        if(rut_evaluador.isEmpty() ){
          
         JOptionPane.showMessageDialog(null,"Debe inresar RUT","ERROR",JOptionPane.ERROR_MESSAGE);
        }else
         {
             
        try{
            String sql = "select profesional_evaluador.nombre_evaluador, profesional_evaluador.profesion from profesional_evaluador where profesional_evaluador.rut_evaluador= '" + rut_evaluador +"'";
            ResultSet rs = con.ejecutarSQLSelect(sql);
            if (rs.next()){
                
                txtnombreevaluador.setText(rs.getString("nombre_evaluador")) ;
                txtprofesionevaluador.setText(rs.getString("profesion")) ;
                 JOptionPane.showMessageDialog(null, "El Profesional evaluador ya existe","Informacion",JOptionPane.INFORMATION_MESSAGE);
               
                
                   
            } else{
                insert_profesional_evaluador();
                
            }
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
        }
       
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
     txtrutevaluador.setText("");
     txtnombreevaluador.setText("");
     txtprofesionevaluador.setText("");
    }//GEN-LAST:event_jButton4ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
      
        String rut_evaluador = txtrutevaluador.getText();
        String nombre_evaluador = txtnombreevaluador.getText();
        String profesion_evaluador = txtprofesionevaluador.getText();
 
        if(rut_evaluador.isEmpty() ){
          
         JOptionPane.showMessageDialog(null,"Debe inresar RUT","ERROR",JOptionPane.ERROR_MESSAGE);
        }else
         {
             
        try{
             String sql = "UPDATE profesional_evaluador SET nombre_evaluador = '" + nombre_evaluador +"' , profesion ='" + profesion_evaluador +"' , estado = 'activo'  WHERE rut_evaluador = '" + rut_evaluador +"'";
             PreparedStatement ps=con.getConexion().prepareStatement(sql);
             ps.execute();
             ps.close();
           
             JOptionPane.showMessageDialog(null, "Profesional Actualizado correctamente");
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
        }
        
    }//GEN-LAST:event_jButton3ActionPerformed

    private void txtrutevaluadorKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtrutevaluadorKeyTyped
     
           int n=10;
        if(txtrutevaluador.getText().length()>=n){
            
            getToolkit().beep();
            evt.consume();
             JOptionPane.showMessageDialog(null,"solo 10 dijitos sin puntos","ERROR",JOptionPane.WARNING_MESSAGE);
               
       }
    }//GEN-LAST:event_txtrutevaluadorKeyTyped

    private void txtnombreevaluadorKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtnombreevaluadorKeyTyped
     
         int n=198;
        if(txtnombreevaluador.getText().length()>=n){
            
            getToolkit().beep();
            evt.consume();
            JOptionPane.showMessageDialog(null,"Exceso de caracteres","ERROR",JOptionPane.WARNING_MESSAGE);
       }
         char c=evt.getKeyChar();
        if(((c<'a' || c>'z')&&(c<'A')|c>'Z')  &&(c!='ñ')&&( c!='Ñ')  && (c!= KeyEvent.VK_SPACE))evt.consume(); 
        
         if(Character.isLowerCase(c)){
            String cad=(""+c).toUpperCase();
            c=cad.charAt(0);
            evt.setKeyChar(c);
            
        }
    }//GEN-LAST:event_txtnombreevaluadorKeyTyped

    private void txtprofesionevaluadorKeyTyped(java.awt.event.KeyEvent evt) {//GEN-FIRST:event_txtprofesionevaluadorKeyTyped
    
         int n=99;
        if(txtprofesionevaluador.getText().length()>=n){
            
            getToolkit().beep();
            evt.consume();
            JOptionPane.showMessageDialog(null,"Exceso de caracteres","ERROR",JOptionPane.WARNING_MESSAGE);
       }
         char c=evt.getKeyChar();
        if(((c<'a' || c>'z')&&(c<'A')|c>'Z')  &&(c!='ñ')&&( c!='Ñ')  && (c!= KeyEvent.VK_SPACE))evt.consume(); 
        
         if(Character.isLowerCase(c)){
            String cad=(""+c).toUpperCase();
            c=cad.charAt(0);
            evt.setKeyChar(c);
            
        }
    }//GEN-LAST:event_txtprofesionevaluadorKeyTyped

    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(FrameAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameAlumno().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JButton jButton4;
    private javax.swing.JButton jButton5;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JTextField txtnombreevaluador;
    private javax.swing.JTextField txtprofesionevaluador;
    private javax.swing.JTextField txtrutevaluador;
    // End of variables declaration//GEN-END:variables
}