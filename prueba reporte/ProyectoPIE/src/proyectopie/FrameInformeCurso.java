/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package proyectopie;

import java.awt.Color;
import java.sql.Connection;
import java.sql.DriverManager;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.HashMap;
import java.util.Map;
import java.util.logging.Level;
import java.util.logging.Logger;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import net.sf.jasperreports.engine.JRException;
import net.sf.jasperreports.engine.JasperCompileManager;
import net.sf.jasperreports.engine.JasperFillManager;
import net.sf.jasperreports.engine.JasperPrint;
import net.sf.jasperreports.engine.JasperReport;
import net.sf.jasperreports.engine.util.JRLoader;
import net.sf.jasperreports.view.JasperViewer;


/**
 *
 * @author 56962
 */
public class FrameInformeCurso extends javax.swing.JFrame {

    DefaultTableModel model= new DefaultTableModel(){
        @Override
        public boolean isCellEditable(int filas, int columnas) {
          if (columnas==6){
              return true;
          }else{
              return false;
          }
        }
    };
    public static int id_curso_informe;
    /**
     * Creates new form FrameInformeCurso
     */
    public FrameInformeCurso() {
        initComponents();
         this.getContentPane().setBackground(Color.BLUE);
         this.setLocationRelativeTo(null);
        try {
            Class.forName("com.microsoft.sqlserver.jdbc.SQLServerDriver");
        } catch (ClassNotFoundException ex) {
            Logger.getLogger(FrameEvaluacionParte5.class.getName()).log(Level.SEVERE, null, ex);
        }
        nombre_curso_label();
        this.TablaInformeCurso.setModel(model);
         model.setColumnCount(0);
                  model.addColumn("Rut Alumno");
                  model.addColumn("Nombres Alumno");
                  model.addColumn("Apellido Paterno");
                  model.addColumn("Apellido Materno");
                  model.addColumn("Nombre Diagnostico");
                
                  limpiar_tabla();
                  cargar_tabla_lista_completa();
    }
    void nombre_curso_label(){
        if (id_curso_informe == 1){
            lblnombre.setText("1° BASICO");
        }
        if (id_curso_informe == 2){
            lblnombre.setText("2° BASICO");
        }
        if (id_curso_informe == 3){
            lblnombre.setText("3° BASICO");
        }
        if (id_curso_informe == 4){
            lblnombre.setText("4° BASICO");
        }
        if (id_curso_informe == 5){
            lblnombre.setText("5° BASICO");
        }
        if (id_curso_informe == 6){
            lblnombre.setText("6° BASICO");
        }
        if (id_curso_informe == 7){
            lblnombre.setText("7° BASICO");
        }
        if (id_curso_informe == 8){
            lblnombre.setText("8° BASICO");
        }
        if (id_curso_informe == 9){
            lblnombre.setText("KINDER");
        }
        if (id_curso_informe == 10){
            lblnombre.setText("PRE-KINDER");
        }
    }
    void cargar_tabla_lista_completa(){
        
       
      
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try{
            //limpiar_tabla();
            
            ResultSet rs = st.executeQuery("select distinct ficha_diagnostico.rut_alumno 'Rut del Alumno' , alumno.nombres_alumno 'Nombres del Alumno', alumno.apellido_paterno 'Apellido Paterno' , alumno.apellido_materno 'Apellido Materno', tipo_ficha.nombre_tipo 'Nombre Diagnostico' , curso.nombre 'Curso Alumno'  from ficha_diagnostico , alumno, curso , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.curso_alumno = curso.id_curso  and ficha_diagnostico.curso_alumno = "+ id_curso_informe +"  and alumno.estado= 'activo'");
            //String sq="select * from visfunc"; 
            String [] arregl = new String[7];
            
            while (rs.next()){
                
               
                
            arregl[0] = rs.getString(1);
            arregl[1] = rs.getString(2);
            arregl[2] = rs.getString(3);
            arregl[3] = rs.getString(4);
            arregl[4] = rs.getString(5); 
            arregl[5] = rs.getString(6); 
           
        model.addRow(arregl);
             
            }
            
            
        
        }catch(Exception ex){
            
            
        }
    }
      void limpiar_tabla(){
        DefaultTableModel tb = (DefaultTableModel) TablaInformeCurso.getModel();
        int limpiar = TablaInformeCurso.getRowCount()-1;
        for (int i = limpiar; i >= 0; i--) {           
        tb.removeRow(tb.getRowCount()-1);
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

        lblnombre = new javax.swing.JLabel();
        jButton1 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        TablaInformeCurso = new javax.swing.JTable();
        jButton2 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        lblnombre.setFont(new java.awt.Font("Times New Roman", 3, 36)); // NOI18N
        lblnombre.setForeground(new java.awt.Color(255, 204, 0));
        lblnombre.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        lblnombre.setText("jLabel1");
        lblnombre.setHorizontalTextPosition(javax.swing.SwingConstants.CENTER);

        jButton1.setText("Volver");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        TablaInformeCurso.setBackground(java.awt.Color.blue);
        TablaInformeCurso.setForeground(new java.awt.Color(255, 255, 255));
        TablaInformeCurso.setModel(new javax.swing.table.DefaultTableModel(
            new Object [][] {
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null},
                {null, null, null, null}
            },
            new String [] {
                "Title 1", "Title 2", "Title 3", "Title 4"
            }
        ));
        TablaInformeCurso.setSelectionBackground(java.awt.Color.red);
        jScrollPane1.setViewportView(TablaInformeCurso);

        jButton2.setText("Generar Reporte");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton1)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 14, Short.MAX_VALUE)
                .addComponent(lblnombre, javax.swing.GroupLayout.PREFERRED_SIZE, 940, javax.swing.GroupLayout.PREFERRED_SIZE))
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(38, 38, 38)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 954, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(454, 454, 454)
                        .addComponent(jButton2)))
                .addGap(0, 0, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(lblnombre, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jButton1)))
                .addGap(46, 46, 46)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 296, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 53, Short.MAX_VALUE)
                .addComponent(jButton2)
                .addGap(26, 26, 26))
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        
        FrameCargarCursoInforme frame = new FrameCargarCursoInforme(); 
      frame.setVisible(true);                                                                                                                
      FrameInformeCurso.this.dispose();
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
       try {
            Connection con = DriverManager.getConnection("jdbc:sqlserver://192.168.50.104:1433;databaseName = integracion_pie","sa","1234321");
           
            
         
            JasperReport jr = (JasperReport) JRLoader.loadObject(getClass().getResource("Reportew_Curso.jasper"));
            Map Parametros = new HashMap();
           
            Parametros.put("ParametroCurso",id_curso_informe);
           
            
            JasperPrint jp = JasperFillManager.fillReport(jr,Parametros,con);
          
            JasperViewer jv = new JasperViewer(jp,false);
          
            jv.setTitle("Reporte Curso");
            
            jv.setVisible(true);
            } catch (SQLException ex) {
            Logger.getLogger(FrameEvaluacionParte5.class.getName()).log(Level.SEVERE, null, ex);
            JOptionPane.showMessageDialog(null, ex);
        } catch (JRException ex) {
            Logger.getLogger(FrameEvaluacionParte5.class.getName()).log(Level.SEVERE, null, ex);
            JOptionPane.showMessageDialog(null, ex);
        }
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
            java.util.logging.Logger.getLogger(FrameInformeCurso.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameInformeCurso.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameInformeCurso.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameInformeCurso.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameInformeCurso().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JTable TablaInformeCurso;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JLabel lblnombre;
    // End of variables declaration//GEN-END:variables
}
