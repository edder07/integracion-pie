package proyectopie;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
import static proyectopie.FrameEvaluacionPart4.frame4_fecha_emision;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 56962
 */
public class FrameRutYFicha extends javax.swing.JFrame {

    /**
     * Creates new form FrameRutYFicha
     */
    public FrameRutYFicha() {
        initComponents();
         this.setLocationRelativeTo(null);
         cargar_combo_rut_alumno();
         cargar_combo_nombre_ficha();
    }
    
     void cargar_combo_rut_alumno() {
         
         ConexionSQL conectar = new ConexionSQL();   
         Statement st = conectar.Conectar();    
         try {            
             ResultSet rs = st.executeQuery("select alumno.rut_alumno from alumno where alumno.estado = 'activo'"); 
             combo_rut.removeAllItems();
             
             while(rs.next()) {
                 
                 combo_rut.addItem(rs.getString("rut_alumno"));
                 }

                 } catch (SQLException ex) {
                     
                     }
         }
      void cargar_combo_nombre_ficha() {
         
         ConexionSQL conectar = new ConexionSQL();   
         Statement st = conectar.Conectar();    
         try {            
             ResultSet rs = st.executeQuery("select tipo_ficha.nombre_tipo from tipo_ficha"); 
             combo_ficha.removeAllItems();
            
             while(rs.next()) {
                 
                 combo_ficha.addItem(rs.getString("nombre_tipo"));
                 }

                 } catch (SQLException ex) {
                     
                     }
         }
    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        combo_rut = new javax.swing.JComboBox();
        combo_ficha = new javax.swing.JComboBox();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        combo_rut.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        combo_rut.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        combo_ficha.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        combo_ficha.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jLabel1.setFont(new java.awt.Font("Times New Roman", 1, 14)); // NOI18N
        jLabel1.setText("Seleccione RUT");

        jLabel2.setFont(new java.awt.Font("Times New Roman", 1, 14)); // NOI18N
        jLabel2.setText("Seleccione Ficha");

        jLabel3.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        jLabel3.setText("Seleccione RUT y el tipo de la ficha para realizar la evaluacion");

        jButton1.setText("Volver");
        jButton1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton1MouseClicked(evt);
            }
        });

        jButton2.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        jButton2.setText("Evaluar");
        jButton2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton2MouseClicked(evt);
            }
        });
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jButton3.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        jButton3.setText("Reevaluar");
        jButton3.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton3MouseClicked(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(72, 72, 72)
                .addComponent(jButton2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jButton3)
                .addGap(70, 70, 70))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(131, 131, 131)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jLabel1)
                            .addComponent(jLabel2))
                        .addGap(41, 41, 41)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(combo_ficha, javax.swing.GroupLayout.PREFERRED_SIZE, 247, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(combo_rut, javax.swing.GroupLayout.PREFERRED_SIZE, 247, javax.swing.GroupLayout.PREFERRED_SIZE)))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jButton1))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(114, 114, 114)
                        .addComponent(jLabel3)))
                .addContainerGap(169, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton1)
                .addGap(1, 1, 1)
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 84, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(combo_rut, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(14, 14, 14)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(combo_ficha, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2))
                .addGap(64, 64, 64)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton2)
                    .addComponent(jButton3))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton1MouseClicked
 FrameEvaluacionReevaluacion frame = new FrameEvaluacionReevaluacion(); 
    frame.setVisible(true);                                                                                                                
    FrameRutYFicha.this.dispose();
    }//GEN-LAST:event_jButton1MouseClicked

    private void jButton2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton2MouseClicked
 FrameEvaluacionPart1 frame = new FrameEvaluacionPart1(); 
    frame.setVisible(true);                                                                                                                
    FrameRutYFicha.this.dispose();
    }//GEN-LAST:event_jButton2MouseClicked

    private void jButton3MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton3MouseClicked
FrameEvaluacionPart1 frame = new FrameEvaluacionPart1(); 
    frame.setVisible(true);                                                                                                                
    FrameRutYFicha.this.dispose();
    }//GEN-LAST:event_jButton3MouseClicked

    void obtener_id_diagnostico(){
        String cdiagnostico=  (String)combo_ficha.getSelectedItem().toString();
          
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        
        try{
            ResultSet rs = st.executeQuery("select tipo_ficha.id_tipo from tipo_ficha where tipo_ficha.nombre_tipo = '" + cdiagnostico +"'");
            if (rs.next()){
                
               int id_t = rs.getInt("id_tipo") ;
               FrameEvaluacionPart4.id_tipodiagnostico = id_t;
                   
            } 
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
       
    }
    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
     
        obtener_id_diagnostico();
        String crutal=  (String)combo_rut.getSelectedItem().toString();  
        FrameEvaluacionPart4.rut_del_alumno = crutal;
     
        FrameEvaluacionPart1.frame1_numero_estudiante = 0;
        FrameEvaluacionPart1.frame1_diagnostico="";
        FrameEvaluacionPart1.frame1_curso="";
        FrameEvaluacionPart1.frame1_observacion="";
        FrameEvaluacionPart1.frame1_sindrome_asociado="";
        FrameEvaluacionPart1.frame1_nuevo_ingreso="";
        FrameEvaluacionPart1.frame1_año_continuidad="";
        
        FrameEvaluacionPart2.frame2_evaluador_1="";
        FrameEvaluacionPart2.frame2_evaluador_2="";
        FrameEvaluacionPart2.frame2_evaluador_3="";
        FrameEvaluacionPart2.frame2_evaluador_4="";
        FrameEvaluacionPart2.frame2_evaluador_5="";
        
        FrameEvaluacionPart3.frame3_prueba_1="";
        FrameEvaluacionPart3.frame3_prueba_2="";
        FrameEvaluacionPart3.frame3_prueba_3="";
        FrameEvaluacionPart3.frame3_prueba_4="";
        FrameEvaluacionPart3.frame3_prueba_5="";
        FrameEvaluacionPart3.frame3_puntaje_1="";
        FrameEvaluacionPart3.frame3_puntaje_2="";
        FrameEvaluacionPart3.frame3_puntaje_3="";
        FrameEvaluacionPart3.frame3_puntaje_4="";
        FrameEvaluacionPart3.frame3_puntaje_5="";
        
        FrameEvaluacionPart4.nombre_profesional_apoyo_1="";
        FrameEvaluacionPart4.nombre_profesional_apoyo_2="";
        FrameEvaluacionPart4.nombre_profesional_apoyo_3="";
        FrameEvaluacionPart4.nombre_profesional_apoyo_4="";
        
      
       
    }//GEN-LAST:event_jButton2ActionPerformed

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
            java.util.logging.Logger.getLogger(FrameRutYFicha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameRutYFicha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameRutYFicha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameRutYFicha.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameRutYFicha().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox combo_ficha;
    private javax.swing.JComboBox combo_rut;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    // End of variables declaration//GEN-END:variables
}
