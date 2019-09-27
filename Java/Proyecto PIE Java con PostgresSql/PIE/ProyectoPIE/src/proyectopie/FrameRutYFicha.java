package proyectopie;

import java.awt.Color;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.GregorianCalendar;
import java.util.logging.Level;
import java.util.logging.Logger;
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

    conexion con = ProyectoPIE.conexion;
    public static String evaluar_activo;
    public static String reevaluar_activo;
    
    /**
     * Creates new form FrameRutYFicha
     */
    public FrameRutYFicha() {
        initComponents();
         this.getContentPane().setBackground(Color.BLUE);
         this.setLocationRelativeTo(null);
         cargar_combo_rut_alumno();
         cargar_combo_nombre_ficha();
         visible_invisible_botones();
         
    }
    void visible_invisible_botones(){
        if (evaluar_activo == "activo"){
           
            jButton2.setVisible(true);
            jButton3.setVisible(false);

        }
        if (reevaluar_activo == "activo"){
            
            jButton3.setVisible(true);
            jButton2.setVisible(false);

        }
    }
    
     void cargar_combo_rut_alumno() {
        
         try {            
             String sql = "select alumno.rut_alumno from alumno where alumno.estado = 'activo'";
             ResultSet rs = con.ejecutarSQLSelect(sql);
             combo_rut.removeAllItems();
             
             while(rs.next()) {
                 
                 combo_rut.addItem(rs.getString("rut_alumno"));
                 }

                 } catch (SQLException ex) {
                     
                     }
         }
      void cargar_combo_nombre_ficha() {
         
       
         try {            
             String sql = "select tipo_ficha.nombre_tipo from tipo_ficha";
             ResultSet rs = con.ejecutarSQLSelect(sql);
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
        setUndecorated(true);

        combo_rut.setBackground(new java.awt.Color(255, 204, 0));
        combo_rut.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        combo_rut.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        combo_ficha.setBackground(new java.awt.Color(255, 204, 0));
        combo_ficha.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        combo_ficha.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jLabel1.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 204, 0));
        jLabel1.setText("Seleccione RUT");

        jLabel2.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        jLabel2.setForeground(new java.awt.Color(255, 204, 0));
        jLabel2.setText("Seleccione Ficha");

        jLabel3.setFont(new java.awt.Font("Times New Roman", 1, 24)); // NOI18N
        jLabel3.setForeground(new java.awt.Color(255, 204, 0));
        jLabel3.setText("Seleccione RUT y el tipo de la ficha para realizar la evaluacion");

        jButton1.setText("Volver");
        jButton1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton1MouseClicked(evt);
            }
        });

        jButton2.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        jButton2.setText("Evaluar");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jButton3.setFont(new java.awt.Font("Times New Roman", 1, 18)); // NOI18N
        jButton3.setText("Reevaluar");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
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
                        .addComponent(jButton1)))
                .addContainerGap(222, Short.MAX_VALUE))
            .addGroup(layout.createSequentialGroup()
                .addGap(72, 72, 72)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jLabel3)
                        .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                    .addGroup(layout.createSequentialGroup()
                        .addComponent(jButton2)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jButton3)
                        .addGap(70, 70, 70))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton1)
                .addGap(13, 13, 13)
                .addComponent(jLabel3)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 65, Short.MAX_VALUE)
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

    void obtener_id_diagnostico(){
        String cdiagnostico=  (String)combo_ficha.getSelectedItem().toString();
          
     
        
        try{
            String sql = "select tipo_ficha.id_tipo from tipo_ficha where tipo_ficha.nombre_tipo = '" + cdiagnostico +"'";
            ResultSet rs = con.ejecutarSQLSelect(sql);
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
        
       
        try {
            
            String sql = "select ficha_diagnostico.rut_alumno, ficha_diagnostico.id_fichadiagnostico from ficha_diagnostico where ficha_diagnostico.rut_alumno = '" + crutal +"'";
            ResultSet rs = con.ejecutarSQLSelect(sql);
            if(rs.next()) {
                 JOptionPane.showMessageDialog(null, "El alumno ya tiene una primera evaluacion","Error",JOptionPane.ERROR_MESSAGE);
               
                
                }else{
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
        funcion_fecha();
        
        FrameEvaluacionPart4.ingresar_activo = "activo";
        FrameEvaluacionPart4.modificar_activo = "_";
        FrameEvaluacionPart4.apoyo_activo = "activo";
        FrameEvaluacionPart4.apoyo_todos = "-";
        FrameEvaluacionPart2.evaluador_activo = "activo";
        FrameEvaluacionPart2.evaluador_todo = "-";
        FrameEvaluacionPart1 frame = new FrameEvaluacionPart1(); 
        frame.setVisible(true);                                                                                                                
        FrameRutYFicha.this.dispose();
       
            }
                } catch (SQLException ex) {
                                   
                 }
     
        
       
        
     
        
      
       
    }//GEN-LAST:event_jButton2ActionPerformed

    void select_reevaluar(){
       
        try{
            String sql = "select ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" +  FrameEvaluacionPart4.rut_del_alumno +"' and ficha_diagnostico.id_tipoficha = " +  FrameEvaluacionPart4.id_tipodiagnostico +"  ORDER BY ficha_diagnostico.fecha_emision DESC FETCH FIRST 1 ROWS ONLY";
            ResultSet rs = con.ejecutarSQLSelect(sql);
            if (rs.next()){
                
               
               
                FrameEvaluacionPart1.frame1_numero_estudiante = rs.getInt("numero_estudiante");
                FrameEvaluacionPart1.frame1_curso = rs.getString("nombre");
                FrameEvaluacionPart1.frame1_nuevo_ingreso = rs.getString("nuevo_ingreso");
                FrameEvaluacionPart1.frame1_año_continuidad = rs.getString("continuidad");
                FrameEvaluacionPart1.frame1_diagnostico = rs.getString("diagnostico");
                FrameEvaluacionPart1.frame1_sindrome_asociado = rs.getString("sindrome_asociado_diagnostico");
                FrameEvaluacionPart1.frame1_observacion = rs.getString("observaciones_salud");
                FrameEvaluacionPart4.frame4_fecha_emision = rs.getDate("fecha_emision");
                FrameEvaluacionPart4.frame4_fechax = rs.getString("fecha_emision");
                
                FrameEvaluacionPart2.frame2_evaluador_1 = rs.getString("nombre_evaluador_1");
                FrameEvaluacionPart2.frame2_evaluador_2 = rs.getString("nombre_evaluador_2");
                FrameEvaluacionPart2.frame2_evaluador_3 = rs.getString("nombre_evaluador_3");
                FrameEvaluacionPart2.frame2_evaluador_4 = rs.getString("nombre_evaluador_4");
                FrameEvaluacionPart2.frame2_evaluador_5 = rs.getString("nombre_evaluador_5");
                
                FrameEvaluacionPart3.frame3_prueba_1 = rs.getString("prueba_1");
                FrameEvaluacionPart3.frame3_puntaje_1 = rs.getString("puntaje_1");
                FrameEvaluacionPart3.frame3_prueba_2 = rs.getString("prueba_2");
                FrameEvaluacionPart3.frame3_puntaje_2 = rs.getString("puntaje_2");
                FrameEvaluacionPart3.frame3_prueba_3 = rs.getString("prueba_3");
                FrameEvaluacionPart3.frame3_puntaje_3 = rs.getString("puntaje_3");
                FrameEvaluacionPart3.frame3_prueba_4 = rs.getString("prueba_4");
                FrameEvaluacionPart3.frame3_puntaje_4 = rs.getString("puntaje_4");
                FrameEvaluacionPart3.frame3_prueba_5 = rs.getString("prueba_5");
                FrameEvaluacionPart3.frame3_puntaje_5 = rs.getString("puntaje_5");
                FrameEvaluacionPart4.nombre_profesional_apoyo_1 = rs.getString("nombre_apoyo_1");
                FrameEvaluacionPart4.nombre_profesional_apoyo_2 = rs.getString("nombre_apoyo_2");
                FrameEvaluacionPart4.nombre_profesional_apoyo_3 = rs.getString("nombre_apoyo_3");
                FrameEvaluacionPart4.nombre_profesional_apoyo_4 = rs.getString("nombre_apoyo_4");
             
                 JOptionPane.showMessageDialog(null,  FrameEvaluacionPart4.frame4_fecha_emision);
          
                FrameEvaluacionPart4.apoyo_activo = "activo";
                FrameEvaluacionPart4.apoyo_todos = "-";
                FrameEvaluacionPart2.evaluador_activo = "activo";
                FrameEvaluacionPart2.evaluador_todo = "-";
                FrameEvaluacionPart1 frame = new FrameEvaluacionPart1(); 
                frame.setVisible(true);                                                                                                                
                FrameRutYFicha.this.dispose();
                
            
        }else{
                JOptionPane.showMessageDialog(null,"Para relizar una reevaluacion se nesesita una evaluacion previa","ERROR",JOptionPane.ERROR_MESSAGE);
            }
            
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
    }
    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        
        FrameEvaluacionPart4.ingresar_activo = "activo";
        FrameEvaluacionPart4.modificar_activo = "_";
        obtener_id_diagnostico();
        String crutal=  (String)combo_rut.getSelectedItem().toString();  
        FrameEvaluacionPart4.rut_del_alumno = crutal;
        select_reevaluar();
        
    }//GEN-LAST:event_jButton3ActionPerformed

    void funcion_fecha(){
         Calendar fechx = new GregorianCalendar();
        int año = fechx.get(Calendar.YEAR);
        int mes = fechx.get(Calendar.MONTH)+1;
        int dia = fechx.get(Calendar.DAY_OF_MONTH);
        String fecha_actuall = año+"-"+ mes +"-"+ dia;
   
         try {
            SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
            
         
            java.util.Date date = formatter.parse(fecha_actuall);
             
               FrameEvaluacionPart4.frame4_fecha_emision = date ;
        } catch (ParseException ex) {
            Logger.getLogger(FrameRutYFicha.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
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
