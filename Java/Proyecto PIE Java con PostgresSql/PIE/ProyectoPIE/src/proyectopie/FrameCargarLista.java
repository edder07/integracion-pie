package proyectopie;

import java.awt.Color;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import javax.swing.JOptionPane;
import javax.swing.table.DefaultTableModel;
import static proyectopie.FrameCargarDiagnostico.fecha_table;
import static proyectopie.FrameCargarDiagnostico.id_tipoficha;
import static proyectopie.FrameCargarDiagnostico.rut_table;
import static proyectopie.FrameEvaluacionPart4.id_tipodiagnostico;
import static proyectopie.FrameEvaluacionPart4.rut_del_alumno;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author 56962
 */
public class FrameCargarLista extends javax.swing.JFrame {

    conexion con = ProyectoPIE.conexion;
    
    public static String diagnostico;
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
     * Creates new form FrameCargarLista
     */
    public FrameCargarLista() {
        initComponents();
        this.getContentPane().setBackground(Color.BLUE);
         this.setLocationRelativeTo(null);
          this.tabla_lista_completa.setModel(model);
                  model.setColumnCount(0);
                  model.addColumn("Rut Alumno");
                  model.addColumn("Nombres Alumno");
                  model.addColumn("Apellido Paterno");
                  model.addColumn("Apellido Materno");
                  model.addColumn("Curso Alumno");
                  model.addColumn("Fecha Diagnostico");
                  limpiar_tabla();
                  cargar_tabla_lista_completa();
    
    }
    void cargar_tabla_lista_completa(){
        
       
        try{
            //limpiar_tabla();
            
            String sql = "select ficha_diagnostico.rut_alumno \"Rut del Alumno\" , alumno.nombres_alumno \"Nombres del Alumno\", alumno.apellido_paterno \"Apellido Paterno\" , alumno.apellido_materno \"Apellido Materno\", tipo_ficha.nombre_tipo \"Nombre Diagnostico\" , ficha_diagnostico.fecha_emision \"Fecha Diagnostico\" from ficha_diagnostico , alumno , tipo_ficha where ficha_diagnostico.rut_alumno = alumno.rut_alumno and ficha_diagnostico.id_tipoficha = tipo_ficha.id_tipo  and alumno.estado= 'activo' order by ficha_diagnostico.rut_alumno asc";
            ResultSet rs = con.ejecutarSQLSelect(sql);
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
        DefaultTableModel tb = (DefaultTableModel) tabla_lista_completa.getModel();
        int limpiar = tabla_lista_completa.getRowCount()-1;
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

        jButton1 = new javax.swing.JButton();
        jLabel1 = new javax.swing.JLabel();
        jButton2 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        tabla_lista_completa = new javax.swing.JTable();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setUndecorated(true);

        jButton1.setFont(new java.awt.Font("Times New Roman", 1, 14)); // NOI18N
        jButton1.setText("Cargar");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jLabel1.setFont(new java.awt.Font("Times New Roman", 1, 24)); // NOI18N
        jLabel1.setForeground(new java.awt.Color(255, 204, 0));
        jLabel1.setHorizontalAlignment(javax.swing.SwingConstants.CENTER);
        jLabel1.setText("Lista completa de alumnos P.I.E");

        jButton2.setText("Volver");
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

        tabla_lista_completa.setBackground(java.awt.Color.blue);
        tabla_lista_completa.setForeground(new java.awt.Color(255, 255, 255));
        tabla_lista_completa.setModel(new javax.swing.table.DefaultTableModel(
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
        tabla_lista_completa.setSelectionBackground(java.awt.Color.red);
        tabla_lista_completa.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                tabla_lista_completaMouseClicked(evt);
            }
        });
        jScrollPane1.setViewportView(tabla_lista_completa);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jLabel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jButton2))
                    .addGroup(layout.createSequentialGroup()
                        .addGap(22, 22, 22)
                        .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 911, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(24, Short.MAX_VALUE))
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addGap(0, 0, Short.MAX_VALUE)
                .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 98, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addGap(426, 426, 426))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jButton2)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jLabel1)
                .addGap(18, 18, 18)
                .addComponent(jScrollPane1, javax.swing.GroupLayout.PREFERRED_SIZE, 297, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 43, Short.MAX_VALUE)
                .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 44, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents
    
    private void jButton2MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton2MouseClicked
    FrameBuscadores frame = new FrameBuscadores(); 
    frame.setVisible(true);                                                                                                                
    FrameCargarLista.this.dispose();
    }//GEN-LAST:event_jButton2MouseClicked

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
        // TODO add your handling code here:
    }//GEN-LAST:event_jButton2ActionPerformed

     void obtener_id_tipo_diagnostico(){
         String tipo_diagnostico = diagnostico;
        
        try{
            String sql = "select tipo_ficha.id_tipo from tipo_ficha where tipo_ficha.nombre_tipo = '" + tipo_diagnostico +"'";
            ResultSet rs = con.ejecutarSQLSelect(sql);
            if (rs.next()){
                
                id_tipoficha =rs.getInt("id_tipo") ;
               
             
                
                   
            } else{
               
              
                JOptionPane.showMessageDialog(null,"Lo sentimos","ERROR",JOptionPane.ERROR_MESSAGE);
            }
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        }
     }
    
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
    
        obtener_id_tipo_diagnostico();
        
        String rut_evaluador_1;
        String rut_evaluador_2;
        String rut_evaluador_3;
        String rut_evaluador_4;
        String rut_evaluador_5;
        String nombre_evaluador_1;
        String nombre_evaluador_2;
        String nombre_evaluador_3;
        String nombre_evaluador_4;
        String nombre_evaluador_5;
        String profesion_evaluador_1;
        String profesion_evaluador_2;
        String profesion_evaluador_3;
        String profesion_evaluador_4;
        String profesion_evaluador_5;
        
        String rut_apoyo_1;
        String rut_apoyo_2;
        String rut_apoyo_3;
        String rut_apoyo_4;
        String nombre_apoyo_1;
        String nombre_apoyo_2;
        String nombre_apoyo_3;
        String nombre_apoyo_4;
        
        String pruebax_1;
        String pruebax_2;
        String pruebax_3;
        String pruebax_4;
        String pruebax_5;
        
        String puntajex_1;
        String puntajex_2;
        String puntajex_3;
        String puntajex_4;
        String puntajex_5;
        
        

        String fecha_emision = fecha_table;
        id_tipodiagnostico=id_tipoficha;
        rut_del_alumno=rut_table;
          
        try{
            String sql = "select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" + rut_del_alumno +"'  and ficha_diagnostico.fecha_emision = '" + fecha_emision +"' and ficha_diagnostico.id_tipoficha = " + id_tipodiagnostico +"";
            ResultSet rs = con.ejecutarSQLSelect(sql);
            if (rs.next()){
              
                
                id_tipodiagnostico = rs.getInt("id_tipoficha");
                FrameEvaluacionParte5.numero_estudiante = rs.getInt("numero_estudiante");
                FrameEvaluacionParte5.apellido_paterno = rs.getString("apellido_paterno");
                FrameEvaluacionParte5.apellido_materno = rs.getString("apellido_materno");
                FrameEvaluacionParte5.nombre_alumno = rs.getString("nombres_alumno");
                FrameEvaluacionParte5.fecha_nacimiento = rs.getString("fecha_nacimiento");
                FrameEvaluacionParte5.rut_alumno = rs.getString("rut_alumno");
                FrameEvaluacionParte5.sexo = rs.getString("sexo_alumno");
                FrameEvaluacionParte5.nacionalidad_alumno = rs.getString("nacionalidad_alumno");
                FrameEvaluacionParte5.curso = rs.getString("nombre");
                FrameEvaluacionParte5.nuevo_ingreso = rs.getString("nuevo_ingreso");
                FrameEvaluacionParte5.continuidad = rs.getString("continuidad");
                FrameEvaluacionParte5.diagnostico = rs.getString("diagnostico");
                FrameEvaluacionParte5.sindrome_Asociado = rs.getString("sindrome_asociado_diagnostico");
                FrameEvaluacionParte5.observacion_salud = rs.getString("observaciones_salud");
                FrameEvaluacionParte5.fecha_emision = rs.getString("fecha_emision");
                FrameEvaluacionPart4.frame4_fecha_emision = rs.getDate("fecha_emision");
                FrameEvaluacionPart4.frame4_fechax = rs.getString("fecha_emision");
                rut_evaluador_1 = rs.getString("rut_evaluador_1");
                nombre_evaluador_1 = rs.getString("nombre_evaluador_1");
                profesion_evaluador_1 = rs.getString("profesion_evaluador_1");
                rut_evaluador_2 = rs.getString("rut_evaluador_2");
                nombre_evaluador_2 = rs.getString("nombre_evaluador_2");
                profesion_evaluador_2 = rs.getString("profesion_evaluador_2");
                rut_evaluador_3 = rs.getString("rut_evaluador_3");
                nombre_evaluador_3 = rs.getString("nombre_evaluador_3");
                profesion_evaluador_3 = rs.getString("profesion_evaluador_3");
                rut_evaluador_4 = rs.getString("rut_evaluador_4");
                nombre_evaluador_4 = rs.getString("nombre_evaluador_4");
                profesion_evaluador_4 = rs.getString("profesion_evaluador_4");
                rut_evaluador_5 = rs.getString("rut_evaluador_5");
                nombre_evaluador_5 = rs.getString("nombre_evaluador_5");
                profesion_evaluador_5 = rs.getString("profesion_evaluador_5");
                FrameEvaluacionParte5.profesionales_evaluadores = "<html><body>" +rut_evaluador_1+ "  -  "+nombre_evaluador_1+"  -  "+profesion_evaluador_1+" <br>"+rut_evaluador_2+"  -  "+nombre_evaluador_2+"  -  "+profesion_evaluador_2+"<br>"+rut_evaluador_3+"  -  "+nombre_evaluador_3+"  -  "+profesion_evaluador_3+" <br> "+rut_evaluador_4+"  -  "+nombre_evaluador_4+"  -  "+profesion_evaluador_4+" <br>"+rut_evaluador_5+"  -  "+nombre_evaluador_5+"  -  "+profesion_evaluador_5+"</body></html>" ;
                pruebax_1 = rs.getString("prueba_1");
                puntajex_1 = rs.getString("puntaje_1");
                pruebax_2 = rs.getString("prueba_2");
                puntajex_2 = rs.getString("puntaje_2");
                pruebax_3 = rs.getString("prueba_3");
                puntajex_3 = rs.getString("puntaje_3");
                pruebax_4 = rs.getString("prueba_4");
                puntajex_4 = rs.getString("puntaje_4");
                pruebax_5 = rs.getString("prueba_5");
                puntajex_5 = rs.getString("puntaje_5");
                FrameEvaluacionParte5.puntaje_y_pruebas = "<html><body>Prueba 1:  "+pruebax_1+ "  Puntaje:  "+puntajex_1+"<br>Prueba 2:  "+pruebax_2+"  Puntaje 2:  "+puntajex_2+"<br> Prueba 3:  "+pruebax_3+"  Puntaje 3:  "+puntajex_3+"<br>Prueba 4:  "+pruebax_4+"  Puntaje 4:  "+puntajex_4+"<br> Prueba 5:  "+pruebax_5+"  Puntaje 5:  "+puntajex_5+"</body></html>" ;
                rut_apoyo_1 = rs.getString("rut_apoyo_1");
                nombre_apoyo_1 = rs.getString("nombre_apoyo_1");
                rut_apoyo_2 = rs.getString("rut_apoyo_2");
                nombre_apoyo_2 = rs.getString("nombre_apoyo_2");
                rut_apoyo_3 = rs.getString("rut_apoyo_3");
                nombre_apoyo_3 = rs.getString("nombre_apoyo_3");
                rut_apoyo_4 = rs.getString("rut_apoyo_4");
                nombre_apoyo_4 = rs.getString("nombre_apoyo_4");
                FrameEvaluacionParte5.profesionales_apoyo = "<html><body> "+rut_apoyo_1+ "  -  "+nombre_apoyo_1+"<br>"+rut_apoyo_2+"  -  "+nombre_apoyo_2+"<br>"+rut_apoyo_3+"  -  "+nombre_apoyo_3+"<br>"+rut_apoyo_4+"  -  "+nombre_apoyo_4+"</body></html>" ;              
                
                FrameEvaluacionPart4.ingresar_activo = "-";
                FrameEvaluacionPart4.modificar_activo = "activo";
                FrameEvaluacionPart4.apoyo_activo = "-";
                FrameEvaluacionPart4.apoyo_todos = "activo";
                FrameEvaluacionPart2.evaluador_activo = "-";
                FrameEvaluacionPart2.evaluador_todo = "activo";
                FrameEvaluacionParte5 frame = new FrameEvaluacionParte5(); 
                frame.setVisible(true);                                                                                                                
                FrameCargarLista.this.dispose();
                   
            } else{
               
              
                JOptionPane.showMessageDialog(null,"Intente nuevamente","ERROR",JOptionPane.ERROR_MESSAGE);
            }
        }catch (SQLException ex){
            //JOptionPane.showMessageDialog(null, ex);
        }      
    }//GEN-LAST:event_jButton1ActionPerformed

    private void tabla_lista_completaMouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_tabla_lista_completaMouseClicked
      
         int row = tabla_lista_completa.getSelectedRow();
        rut_table=tabla_lista_completa.getValueAt(row, 0).toString();
        fecha_table = (String) tabla_lista_completa.getModel().getValueAt(row, 5);
        diagnostico=tabla_lista_completa.getValueAt(row, 4).toString();
       
        
    }//GEN-LAST:event_tabla_lista_completaMouseClicked

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
            java.util.logging.Logger.getLogger(FrameCargarLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameCargarLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameCargarLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameCargarLista.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameCargarLista().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JTable tabla_lista_completa;
    // End of variables declaration//GEN-END:variables
  
}
