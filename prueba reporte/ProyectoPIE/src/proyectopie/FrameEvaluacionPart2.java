package proyectopie;

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
public class FrameEvaluacionPart2 extends javax.swing.JFrame {

    public static String frame2_evaluador_1;
    public static String frame2_evaluador_2;
    public static String frame2_evaluador_3;
    public static String frame2_evaluador_4;
    public static String frame2_evaluador_5;
    /**
     * Creates new form FrameEvaluacionPart2
     */
    public FrameEvaluacionPart2() {
        initComponents();
         this.setLocationRelativeTo(null);
         cargar_combo_ev1();
         cargar_combo_ev2();
         cargar_combo_ev3();
         cargar_combo_ev4();
         cargar_combo_ev5();
         cargar_datos_combo_frame();
                
    }
    void cargar_datos_combo_frame(){
        comboev1.setSelectedItem(frame2_evaluador_1);
        comboev2.setSelectedItem(frame2_evaluador_2);
        comboev3.setSelectedItem(frame2_evaluador_3);
        comboev4.setSelectedItem(frame2_evaluador_4);
        comboev5.setSelectedItem(frame2_evaluador_5);
    }
    
    
    void cargar_datos_combo_frame_recuperar(){
          
        frame2_evaluador_1 = (String) comboev1.getSelectedItem();
       
        frame2_evaluador_2 = (String) comboev2.getSelectedItem();
      
        frame2_evaluador_3 = (String) comboev3.getSelectedItem();
       
        frame2_evaluador_4 = (String) comboev4.getSelectedItem();
       
        frame2_evaluador_5 = (String) comboev5.getSelectedItem();
       
    }
    
    
    
        void cargar_combo_ev1() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.nombre_evaluador from profesional_evaluador "); 
            comboev1.removeAllItems();
        
            while(rs.next()) {
                
                comboev1.addItem(rs.getString("nombre_evaluador"));
                
                }
                } catch (SQLException ex) {
                                   
                 }
        
        }
        
        void cargar_combo_ev2() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.nombre_evaluador from profesional_evaluador "); 
            comboev2.removeAllItems();
        
            while(rs.next()) {
                
                comboev2.addItem(rs.getString("nombre_evaluador"));
                
                }
                } catch (SQLException ex) {
                                   
                 }
        
        }
        
        void cargar_combo_ev3() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.nombre_evaluador from profesional_evaluador "); 
            comboev3.removeAllItems();
        
            while(rs.next()) {
                
                comboev3.addItem(rs.getString("nombre_evaluador"));
                
                }
                } catch (SQLException ex) {
                                   
                 }
        
        }
        void cargar_combo_ev4() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.nombre_evaluador from profesional_evaluador "); 
            comboev4.removeAllItems();
        
            while(rs.next()) {
                
                comboev4.addItem(rs.getString("nombre_evaluador"));
                
                }
                } catch (SQLException ex) {
                                   
                 }
        
        }
        void cargar_combo_ev5() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.nombre_evaluador from profesional_evaluador "); 
            comboev5.removeAllItems();
        
            while(rs.next()) {
                
                comboev5.addItem(rs.getString("nombre_evaluador"));
                
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

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        comboev1 = new javax.swing.JComboBox();
        comboev2 = new javax.swing.JComboBox();
        comboev3 = new javax.swing.JComboBox();
        comboev4 = new javax.swing.JComboBox();
        comboev5 = new javax.swing.JComboBox();
        jButton1 = new javax.swing.JButton();
        jLabel7 = new javax.swing.JLabel();
        jButton2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jLabel1.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel1.setText("Ingrese Evaluador 1");

        jLabel2.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel2.setText("Ingrese Evaluador 2");

        jLabel3.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel3.setText("Ingrese Evaluador 3");

        jLabel4.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel4.setText("Ingrese Evaluador 4");

        jLabel5.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel5.setText("Ingrese Evaluador 5");

        comboev1.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        comboev2.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        comboev3.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        comboev4.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        comboev5.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));
        comboev5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                comboev5ActionPerformed(evt);
            }
        });

        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/btnsiguiente.png"))); // NOI18N
        jButton1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton1MouseClicked(evt);
            }
        });
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jLabel7.setFont(new java.awt.Font("Times New Roman", 1, 24)); // NOI18N
        jLabel7.setText("Evaluadores");

        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/btnatras.png"))); // NOI18N
        jButton2.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton2MouseClicked(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(136, 136, 136)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel2)
                        .addGap(18, 18, 18)
                        .addComponent(comboev2, javax.swing.GroupLayout.PREFERRED_SIZE, 263, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addGap(18, 18, 18)
                        .addComponent(comboev3, javax.swing.GroupLayout.PREFERRED_SIZE, 263, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel4)
                        .addGap(18, 18, 18)
                        .addComponent(comboev4, javax.swing.GroupLayout.PREFERRED_SIZE, 263, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel5)
                        .addGap(18, 18, 18)
                        .addComponent(comboev5, javax.swing.GroupLayout.PREFERRED_SIZE, 263, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(18, 18, 18)
                        .addComponent(comboev1, javax.swing.GroupLayout.PREFERRED_SIZE, 263, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(179, 179, 179)
                        .addComponent(jLabel7)))
                .addContainerGap(254, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton2, javax.swing.GroupLayout.PREFERRED_SIZE, 175, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 175, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(52, 52, 52)
                .addComponent(jLabel7)
                .addGap(36, 36, 36)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(comboev1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel2)
                    .addComponent(comboev2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3)
                    .addComponent(comboev3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel4)
                    .addComponent(comboev4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5)
                    .addComponent(comboev5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 187, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton2, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void comboev5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_comboev5ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_comboev5ActionPerformed

    private void jButton2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton2MouseClicked
  FrameEvaluacionPart1 frame = new FrameEvaluacionPart1(); 
    frame.setVisible(true);                                                                                                                
    FrameEvaluacionPart2.this.dispose();
    }//GEN-LAST:event_jButton2MouseClicked

    private void jButton1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton1MouseClicked
  
    }//GEN-LAST:event_jButton1MouseClicked

    void obtener_datos_evaluador_combobox(){
        String cev1=  (String)comboev1.getSelectedItem().toString();
        String cev2=  (String)comboev2.getSelectedItem().toString();
        String cev3=  (String)comboev3.getSelectedItem().toString();
        String cev4=  (String)comboev4.getSelectedItem().toString();
        String cev5=  (String)comboev5.getSelectedItem().toString();
    
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" + cev1 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_ev = rs.getString("rut_evaluador");
                String profesion_ev = rs.getString("profesion");
                int id_ev = rs.getInt("id_evaluador") ;
                FrameEvaluacionPart4.id_profesional_evaluador_1 = id_ev;
                 FrameEvaluacionPart4.rut_profesional_evaluador_1 = rut_ev;
                  FrameEvaluacionPart4.profesion_profesional_evaluador_1 = profesion_ev;
                
                }
                } catch (SQLException ex) {
                    
                    }
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" + cev2 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_ev = rs.getString("rut_evaluador");
                String profesion_ev = rs.getString("profesion");
                int id_ev = rs.getInt("id_evaluador") ;
                FrameEvaluacionPart4.id_profesional_evaluador_2 = id_ev;
                 FrameEvaluacionPart4.rut_profesional_evaluador_2 = rut_ev;
                  FrameEvaluacionPart4.profesion_profesional_evaluador_2 = profesion_ev;
                
                }
                } catch (SQLException ex) {
                    
                    }
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" + cev3 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_ev = rs.getString("rut_evaluador");
                String profesion_ev = rs.getString("profesion");
                int id_ev = rs.getInt("id_evaluador") ;
                FrameEvaluacionPart4.id_profesional_evaluador_3 = id_ev;
                 FrameEvaluacionPart4.rut_profesional_evaluador_3 = rut_ev;
                  FrameEvaluacionPart4.profesion_profesional_evaluador_3 = profesion_ev;
                
                }
                } catch (SQLException ex) {
                    
                    }
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" + cev4 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_ev = rs.getString("rut_evaluador");
                String profesion_ev = rs.getString("profesion");
                int id_ev = rs.getInt("id_evaluador") ;
                FrameEvaluacionPart4.id_profesional_evaluador_4 = id_ev;
                FrameEvaluacionPart4.rut_profesional_evaluador_4 = rut_ev;
                FrameEvaluacionPart4.profesion_profesional_evaluador_4 = profesion_ev;
                
                }
                } catch (SQLException ex) {
                    
                    }
        try {
            
            ResultSet rs = st.executeQuery("select profesional_evaluador.rut_evaluador, profesional_evaluador.profesion , profesional_evaluador.id_evaluador from profesional_evaluador where profesional_evaluador.nombre_evaluador = '" + cev5 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_ev = rs.getString("rut_evaluador");
                String profesion_ev = rs.getString("profesion");
                int id_ev = rs.getInt("id_evaluador") ;
                FrameEvaluacionPart4.id_profesional_evaluador_5 = id_ev;
                 FrameEvaluacionPart4.rut_profesional_evaluador_5 = rut_ev;
                  FrameEvaluacionPart4.profesion_profesional_evaluador_5 = profesion_ev;
                
                }
                } catch (SQLException ex) {
                    
                    }
    }
    
    void obtener_nombre_evaluador(){
        String e1=  (String)comboev1.getSelectedItem().toString();
        String e2=  (String)comboev2.getSelectedItem().toString();
        String e3=  (String)comboev3.getSelectedItem().toString();
        String e4=  (String)comboev4.getSelectedItem().toString();
        String e5=  (String)comboev5.getSelectedItem().toString();
        
        FrameEvaluacionPart4.nombre_profesional_evaluador_1 = e1;
        FrameEvaluacionPart4.nombre_profesional_evaluador_2 = e2;
        FrameEvaluacionPart4.nombre_profesional_evaluador_3 = e3;
        FrameEvaluacionPart4.nombre_profesional_evaluador_4 = e4;
        FrameEvaluacionPart4.nombre_profesional_evaluador_5 = e5;
    }
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed

                    
        String eva_1=  (String)comboev1.getSelectedItem().toString();
        String eva_2=  (String)comboev2.getSelectedItem().toString();
        String eva_3=  (String)comboev3.getSelectedItem().toString();
        String eva_4=  (String)comboev4.getSelectedItem().toString();
        String eva_5=  (String)comboev5.getSelectedItem().toString();
        String v = "VACIO";
         //JOptionPane.showMessageDialog(null,eva_1 + eva_2,"ERROR",JOptionPane.ERROR_MESSAGE);



        if ((! eva_1.equals(v) && eva_1.equals(eva_2) ) || (! eva_1.equals(v) && eva_1.equals(eva_3)) || (! eva_1.equals(v) && eva_1.equals(eva_4)) || (! eva_1.equals(v) && eva_1.equals(eva_5)) || (! eva_2.equals(v) && eva_2.equals(eva_1)) || (! eva_2.equals(v) && eva_2.equals(eva_3)) || (! eva_2.equals(v) && eva_2.equals(eva_4)) || (! eva_2.equals(v) && eva_2.equals(eva_5)) || (! eva_3.equals(v) && eva_3.equals(eva_1)) || (! eva_3.equals(v) && eva_3.equals(eva_2)) || (! eva_3.equals(v) && eva_3.equals(eva_4)) || (! eva_3.equals(v) && eva_3.equals(eva_5)) || (! eva_4.equals(v) && eva_4.equals(eva_1)) || (! eva_4.equals(v) && eva_4.equals(eva_2)) || (! eva_4.equals(v) && eva_4.equals(eva_3)) || (! eva_4.equals(v) && eva_4.equals(eva_5)) || (! eva_5.equals(v) && eva_5.equals(eva_1)) || (! eva_5.equals(v) && eva_5.equals(eva_2)) || (! eva_5.equals(v) && eva_5.equals(eva_3)) || (! eva_5.equals(v) && eva_5.equals(eva_4))){
          JOptionPane.showMessageDialog(null,"no se puede repetir los datos","ERROR",JOptionPane.ERROR_MESSAGE);
                    
        }else{
           
            obtener_nombre_evaluador();
            obtener_datos_evaluador_combobox();
            cargar_datos_combo_frame_recuperar();
            FrameEvaluacionPart3 frame = new FrameEvaluacionPart3(); 
            frame.setVisible(true);                                                                                                                
            FrameEvaluacionPart2.this.dispose();
           
        }
      
    }//GEN-LAST:event_jButton1ActionPerformed

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
            java.util.logging.Logger.getLogger(FrameEvaluacionPart2.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameEvaluacionPart2.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameEvaluacionPart2.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameEvaluacionPart2.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameEvaluacionPart2().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox comboev1;
    private javax.swing.JComboBox comboev2;
    private javax.swing.JComboBox comboev3;
    private javax.swing.JComboBox comboev4;
    private javax.swing.JComboBox comboev5;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel7;
    // End of variables declaration//GEN-END:variables
}
