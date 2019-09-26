package proyectopie;

import java.awt.Color;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 56962
 */
public class FrameEliminarAlumno extends javax.swing.JFrame {

    conexion con = ProyectoPIE.conexion;
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
    /**
     * Creates new form FrameEliminarAlumno
     */
    public FrameEliminarAlumno() {
        initComponents();
        this.getContentPane().setBackground(Color.BLUE);
         this.setLocationRelativeTo(null);
         cargar_combo_alumno();
         this.table_alumno.setModel(model);
         model.setColumnCount(0);
                  model.addColumn("Rut Alumno");
                  model.addColumn("Nombres Alumno");
                  model.addColumn("Apellido Paterno");
                  model.addColumn("Apellido Materno");
                 
    }
     void limpiar_tabla(){
        DefaultTableModel tb = (DefaultTableModel) table_alumno.getModel();
        int limpiar = table_alumno.getRowCount()-1;
        for (int i = limpiar; i >= 0; i--) {           
        tb.removeRow(tb.getRowCount()-1);
        } 
        //cargaTicket();
    }
     
     void cargar_combo_alumno() {       
             
         try {
                  
             String sql = "select DISTINCT alumno.rut_alumno from alumno , ficha_diagnostico where alumno.rut_alumno = ficha_diagnostico.rut_alumno and alumno.estado = 'activo'";
             ResultSet rs = con.ejecutarSQLSelect(sql);
             comboalumno.removeAllItems();
              
               while(rs.next()) {
                   comboalumno.addItem(rs.getString("rut_alumno"));
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
        comboalumno = new javax.swing.JComboBox();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        table_alumno = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setUndecorated(true);

        jLabel1.setFont(new java.awt.Font("Times New Roman", 1, 14)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 204, 0));
        jLabel1.setText("Seleccione RUT del alumno");

        comboalumno.setBackground(new java.awt.Color(255, 204, 0));
        comboalumno.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jButton1.setFont(new java.awt.Font("Times New Roman", 1, 12)); // NOI18N
        jButton1.setText("Buscar");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jButton2.setFont(new java.awt.Font("Times New Roman", 1, 12)); // NOI18N
        jButton2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/cerra.png"))); // NOI18N
        jButton2.setText("            Eliminar alumno");
        jButton2.setHorizontalAlignment(javax.swing.SwingConstants.LEFT);
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jButton3.setText("Volver");
        jButton3.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton3MouseClicked(evt);
            }
        });

        table_alumno.setBackground(java.awt.Color.blue);
        table_alumno.setForeground(new java.awt.Color(255, 255, 255));
        table_alumno.setModel(new javax.swing.table.DefaultTableModel(
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
        table_alumno.setSelectionBackground(java.awt.Color.red);
        jScrollPane1.setViewportView(table_alumno);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(43, 43, 43)
                        .addComponent(jLabel1)
                        .addGap(42, 42, 42)
                        .addComponent(comboalumno, javax.swing.GroupLayout.PREFERRED_SIZE, 217, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(59, 59, 59)
                        .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 92, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(237, 237, 237)
                        .addComponent(jButton2, javax.swing.GroupLayout.PREFERRED_SIZE, 217, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jButton3))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(79, 79, 79)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 499, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(37, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton3)
                .addGap(22, 22, 22)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(comboalumno, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton1))
                .addGap(30, 30, 30)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 50, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 123, Short.MAX_VALUE)
                .addComponent(jButton2)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton3MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton3MouseClicked
MenuPrincipal frame = new MenuPrincipal(); 
    frame.setVisible(true);                                                                                                                
    FrameEliminarAlumno.this.dispose();
    }//GEN-LAST:event_jButton3MouseClicked

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
    
         
        String alumno = (String) comboalumno.getSelectedItem();
       
 
        if(alumno.isEmpty()){
          
         JOptionPane.showMessageDialog(null,"No deje campos en blanco","ERROR",JOptionPane.ERROR_MESSAGE);
        }else
         {
         
        
             try{
             
                 String sql = "update alumno set estado ='inactivo' where alumno.rut_alumno = '" + alumno +"'";
                 PreparedStatement ps=con.getConexion().prepareStatement(sql);
                 ps.execute();
                 ps.close();
                 JOptionPane.showMessageDialog(null, "Alumno eliminado correctamente");
                 cargar_combo_alumno();
                 limpiar_tabla();
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
        }
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
     
          String rut = comboalumno.getSelectedItem().toString();
        
       
        try{
            limpiar_tabla();
            
            String sql = "select distinct ficha_diagnostico.rut_alumno \"Rut del Alumno\" , alumno.nombres_alumno \"Nombres del Alumno\", alumno.apellido_paterno \"Apellido Paterno\" , alumno.apellido_materno \"Apellido Materno\" from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo and ficha_diagnostico.rut_alumno = '" + rut +"'";
            ResultSet rs = con.ejecutarSQLSelect(sql);
            //String sq="select * from visfunc"; 
            String [] arregl = new String[5];
            
            while (rs.next()){
                
               
                
            arregl[0] = rs.getString(1);
            arregl[1] = rs.getString(2);
            arregl[2] = rs.getString(3);
            arregl[3] = rs.getString(4);
           
           
        model.addRow(arregl);
             
            }
            
            
        
        }catch(Exception ex){
            
            
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
            java.util.logging.Logger.getLogger(FrameEliminarAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameEliminarAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameEliminarAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameEliminarAlumno.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameEliminarAlumno().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JComboBox comboalumno;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable table_alumno;
    // End of variables declaration//GEN-END:variables
}
