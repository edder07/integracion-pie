package proyectopie;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.util.Calendar;
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
public class FrameEvaluacionPart4 extends javax.swing.JFrame {

public static int id_usuario;    
public static String rut_del_alumno;    
public static int id_tipodiagnostico;    
public static int id_curso;
public static String nuevo_ingreso;
public static String sindrome_asociado_diagnostico;
public static String año_continuidad;
public static int numero_estudiante;
public static String diagnostico;
public static String observacion;

public static String nombre_profesional_evaluador_1;
public static String nombre_profesional_evaluador_2;
public static String nombre_profesional_evaluador_3;
public static String nombre_profesional_evaluador_4;
public static String nombre_profesional_evaluador_5;
public static String profesion_profesional_evaluador_1;
public static String profesion_profesional_evaluador_2;
public static String profesion_profesional_evaluador_3;
public static String profesion_profesional_evaluador_4;
public static String profesion_profesional_evaluador_5;
public static String rut_profesional_evaluador_1;
public static String rut_profesional_evaluador_2;
public static String rut_profesional_evaluador_3;
public static String rut_profesional_evaluador_4;
public static String rut_profesional_evaluador_5;
public static int id_profesional_evaluador_1;
public static int id_profesional_evaluador_2;
public static int id_profesional_evaluador_3;
public static int id_profesional_evaluador_4;
public static int id_profesional_evaluador_5;

public static String nombre_profesional_apoyo_1;
public static String nombre_profesional_apoyo_2;
public static String nombre_profesional_apoyo_3;
public static String nombre_profesional_apoyo_4;
public static String rut_profesional_apoyo_1;
public static String rut_profesional_apoyo_2;
public static String rut_profesional_apoyo_3;
public static String rut_profesional_apoyo_4;
public static int id_profesional_apoyo_1;
public static int id_profesional_apoyo_2;
public static int id_profesional_apoyo_3;
public static int id_profesional_apoyo_4;


public static String prueba_1;
public static String prueba_2;
public static String prueba_3;
public static String prueba_4;
public static String prueba_5;

public static String puntaje_1;
public static String puntaje_2;
public static String puntaje_3;
public static String puntaje_4;
public static String puntaje_5;

    /**
     * Creates new form FrameEvaluacionPart4
     */
    public FrameEvaluacionPart4() {
        initComponents();
         this.setLocationRelativeTo(null);
         cargar_combo_apoyo1();
         cargar_combo_apoyo2();
         cargar_combo_apoyo3();
         cargar_combo_apoyo4();
         
                
    }
    
    void cargar_combo_apoyo1() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.nombre_apoyo from profesional_apoyo where estado = 'activo'"); 
            comboapoyo1.removeAllItems();
        
            while(rs.next()) {
                
                comboapoyo1.addItem(rs.getString("nombre_apoyo"));
                
                }
                } catch (SQLException ex) {
                                   
                 }
        
        }
        
        void cargar_combo_apoyo2() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.nombre_apoyo from profesional_apoyo where estado = 'activo'"); 
            comboapoyo2.removeAllItems();
        
            while(rs.next()) {
                
                comboapoyo2.addItem(rs.getString("nombre_apoyo"));
                
                }
                } catch (SQLException ex) {
                                   
                 }
        
        }
        
        void cargar_combo_apoyo3() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.nombre_apoyo from profesional_apoyo where estado = 'activo'"); 
            comboapoyo3.removeAllItems();
        
            while(rs.next()) {
                
                comboapoyo3.addItem(rs.getString("nombre_apoyo"));
                
                }
                } catch (SQLException ex) {
                                   
                 }
        
        }
        void cargar_combo_apoyo4() {
        
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.nombre_apoyo from profesional_apoyo where estado = 'activo'"); 
            comboapoyo4.removeAllItems();
        
            while(rs.next()) {
                
                comboapoyo4.addItem(rs.getString("nombre_apoyo"));
                
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

        jPanel1 = new javax.swing.JPanel();
        jLabel2 = new javax.swing.JLabel();
        comboapoyo1 = new javax.swing.JComboBox();
        jLabel3 = new javax.swing.JLabel();
        comboapoyo2 = new javax.swing.JComboBox();
        jLabel4 = new javax.swing.JLabel();
        comboapoyo3 = new javax.swing.JComboBox();
        jLabel5 = new javax.swing.JLabel();
        comboapoyo4 = new javax.swing.JComboBox();
        jLabel6 = new javax.swing.JLabel();
        jPanel2 = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        calendaremision = new com.toedter.calendar.JCalendar();
        jButton1 = new javax.swing.JButton();
        jButton2 = new javax.swing.JButton();
        jButton3 = new javax.swing.JButton();
        jButton4 = new javax.swing.JButton();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);

        jPanel1.setBorder(new javax.swing.border.MatteBorder(null));

        jLabel2.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel2.setText("Profesional Apoyo 1");

        comboapoyo1.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        comboapoyo1.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jLabel3.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel3.setText("Profesional Apoyo 2");

        comboapoyo2.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        comboapoyo2.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jLabel4.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel4.setText("Profesional Apoyo 3");

        comboapoyo3.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        comboapoyo3.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jLabel5.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        jLabel5.setText("Profesional Apoyo 4");

        comboapoyo4.setFont(new java.awt.Font("Times New Roman", 0, 14)); // NOI18N
        comboapoyo4.setModel(new javax.swing.DefaultComboBoxModel(new String[] { "Item 1", "Item 2", "Item 3", "Item 4" }));

        jLabel6.setFont(new java.awt.Font("Times New Roman", 1, 24)); // NOI18N
        jLabel6.setText("Profesionales de apoyo");

        javax.swing.GroupLayout jPanel1Layout = new javax.swing.GroupLayout(jPanel1);
        jPanel1.setLayout(jPanel1Layout);
        jPanel1Layout.setHorizontalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel1Layout.createSequentialGroup()
                .addContainerGap(182, Short.MAX_VALUE)
                .addComponent(jLabel6)
                .addGap(143, 143, 143))
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel1Layout.createSequentialGroup()
                    .addGap(56, 56, 56)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addGroup(jPanel1Layout.createSequentialGroup()
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addComponent(jLabel4)
                                .addComponent(jLabel5))
                            .addGap(18, 18, 18)
                            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                .addComponent(comboapoyo4, javax.swing.GroupLayout.PREFERRED_SIZE, 295, javax.swing.GroupLayout.PREFERRED_SIZE)
                                .addComponent(comboapoyo3, javax.swing.GroupLayout.PREFERRED_SIZE, 295, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(jLabel2)
                                .addGap(18, 18, 18)
                                .addComponent(comboapoyo1, javax.swing.GroupLayout.PREFERRED_SIZE, 295, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(jPanel1Layout.createSequentialGroup()
                                .addComponent(jLabel3)
                                .addGap(18, 18, 18)
                                .addComponent(comboapoyo2, javax.swing.GroupLayout.PREFERRED_SIZE, 295, javax.swing.GroupLayout.PREFERRED_SIZE))))
                    .addContainerGap(74, Short.MAX_VALUE)))
        );
        jPanel1Layout.setVerticalGroup(
            jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel1Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel6)
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
            .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                .addGroup(jPanel1Layout.createSequentialGroup()
                    .addGap(60, 60, 60)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel2)
                        .addComponent(comboapoyo1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGap(18, 18, 18)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel3)
                        .addComponent(comboapoyo2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGap(18, 18, 18)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(comboapoyo3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addComponent(jLabel4))
                    .addGap(18, 18, 18)
                    .addGroup(jPanel1Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                        .addComponent(jLabel5)
                        .addComponent(comboapoyo4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addContainerGap(88, Short.MAX_VALUE)))
        );

        jPanel2.setBorder(new javax.swing.border.MatteBorder(null));

        jLabel1.setFont(new java.awt.Font("Times New Roman", 1, 24)); // NOI18N
        jLabel1.setText("Fecha de evaluacion");

        javax.swing.GroupLayout jPanel2Layout = new javax.swing.GroupLayout(jPanel2);
        jPanel2.setLayout(jPanel2Layout);
        jPanel2Layout.setHorizontalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap(212, Short.MAX_VALUE)
                .addGroup(jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(calendaremision, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(184, 184, 184))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, jPanel2Layout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(174, 174, 174))))
        );
        jPanel2Layout.setVerticalGroup(
            jPanel2Layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jPanel2Layout.createSequentialGroup()
                .addContainerGap()
                .addComponent(jLabel1)
                .addGap(61, 61, 61)
                .addComponent(calendaremision, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addContainerGap(41, Short.MAX_VALUE))
        );

        jButton1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/btnatras.png"))); // NOI18N
        jButton1.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton1MouseClicked(evt);
            }
        });

        jButton2.setText("Guardar");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jButton3.setText("Modificar");

        jButton4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/btnsiguiente.png"))); // NOI18N
        jButton4.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton4MouseClicked(evt);
            }
        });

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(22, 22, 22)
                        .addComponent(jPanel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(layout.createSequentialGroup()
                        .addContainerGap()
                        .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 175, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(109, 109, 109)
                        .addComponent(jButton2)
                        .addGap(96, 96, 96)
                        .addComponent(jButton3)))
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createSequentialGroup()
                        .addGap(50, 50, 50)
                        .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addContainerGap(81, Short.MAX_VALUE))
                    .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                        .addComponent(jButton4, javax.swing.GroupLayout.PREFERRED_SIZE, 184, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(25, 25, 25))))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(69, 69, 69)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jPanel1, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
                    .addComponent(jPanel2, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 138, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                        .addComponent(jButton1, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGroup(javax.swing.GroupLayout.Alignment.TRAILING, layout.createSequentialGroup()
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                                .addComponent(jButton2)
                                .addComponent(jButton3))
                            .addGap(8, 8, 8)))
                    .addComponent(jButton4, javax.swing.GroupLayout.PREFERRED_SIZE, 63, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton1MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton1MouseClicked
  FrameEvaluacionPart3 frame = new FrameEvaluacionPart3(); 
    frame.setVisible(true);                                                                                                                
    FrameEvaluacionPart4.this.dispose();
    }//GEN-LAST:event_jButton1MouseClicked

    private void jButton4MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton4MouseClicked
  FrameEvaluacionParte5 frame = new FrameEvaluacionParte5(); 
    frame.setVisible(true);                                                                                                                
    FrameEvaluacionPart4.this.dispose();
    }//GEN-LAST:event_jButton4MouseClicked

     void obtener_datos_evaluador_combobox(){
        String capo1=  (String)comboapoyo1.getSelectedItem().toString();
        String capo2=  (String)comboapoyo2.getSelectedItem().toString();
        String capo3=  (String)comboapoyo3.getSelectedItem().toString();
        String capo4=  (String)comboapoyo4.getSelectedItem().toString();
        
    
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
        
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" + capo1 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_apo = rs.getString("rut_apoyo");
                int id_apo = rs.getInt("id_profapoyo") ;
                id_profesional_apoyo_1 = id_apo;
                rut_profesional_apoyo_1 = rut_apo;
                 
                
                }
                } catch (SQLException ex) {
                    
                    }
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" + capo2 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_apo = rs.getString("rut_apoyo");
                int id_apo = rs.getInt("id_profapoyo") ;
                id_profesional_apoyo_2 = id_apo;
                rut_profesional_apoyo_2 = rut_apo;
                
                }
                } catch (SQLException ex) {
                    
                    }
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" + capo3 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                 String rut_apo = rs.getString("rut_apoyo");
                int id_apo = rs.getInt("id_profapoyo") ;
                id_profesional_apoyo_3 = id_apo;
                rut_profesional_apoyo_3 = rut_apo;
                
                }
                } catch (SQLException ex) {
                    
                    }
        try {
            
            ResultSet rs = st.executeQuery("select profesional_apoyo.rut_apoyo , profesional_apoyo.id_profapoyo from profesional_apoyo where profesional_apoyo.nombre_apoyo = '" + capo4 +"'"); 
           
            if(rs.next()) {
                //txtnombreapoderado.setText(rs.getString("nombre_apoderado")) ;
                String rut_apo = rs.getString("rut_apoyo");
                int id_apo = rs.getInt("id_profapoyo") ;
                id_profesional_apoyo_4 = id_apo;
                rut_profesional_apoyo_4 = rut_apo;
                
                }
                } catch (SQLException ex) {
                    
                    }
   
    }
     void obtener_nombre_apoyo(){
        String a1=  (String)comboapoyo1.getSelectedItem().toString();
        String a2=  (String)comboapoyo2.getSelectedItem().toString();
        String a3=  (String)comboapoyo3.getSelectedItem().toString();
        String a4=  (String)comboapoyo4.getSelectedItem().toString();
        
        nombre_profesional_apoyo_1 = a1;
        nombre_profesional_apoyo_2 = a2;
        nombre_profesional_apoyo_3 = a3;
        nombre_profesional_apoyo_4 = a4;

     } 
    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed

        obtener_nombre_apoyo();
        obtener_datos_evaluador_combobox();
        
        int año = calendaremision.getCalendar().get(Calendar.YEAR);
        int mes = calendaremision.getCalendar().get(Calendar.MARCH);
        int dia = calendaremision.getCalendar().get(Calendar.DAY_OF_MONTH);

        String fecha_emision =(año+"-"+mes+"-"+dia);
     
         ConexionSQL conectar = new ConexionSQL();
         Statement st = conectar.Conectar();
        try{
             st.executeUpdate("INSERT INTO ficha_diagnostico (rut_alumno, id_evaluador_1, id_evaluador_2, id_evaluador_3, id_evaluador_4, id_evaluador_5, id_apoyo_1, id_apoyo_2, id_apoyo_3, id_apoyo_4, id_tipoficha, curso_alumno, nuevo_ingreso, continuidad, diagnostico, sindrome_asociado_diagnostico, observaciones_salud, fecha_emision, prueba_1, puntaje_1, prueba_2, puntaje_2, prueba_3, puntaje_3, prueba_4, puntaje_4, prueba_5, puntaje_5,usuario,nombre_apoyo_1,nombre_apoyo_2,nombre_apoyo_3,nombre_apoyo_4,nombre_evaluador_1,nombre_evaluador_2,nombre_evaluador_3,nombre_evaluador_4,nombre_evaluador_5, numero_estudiante,ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.rut_evaluador_3 , ficha_diagnostico.rut_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.profesion_evaluador_1 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.rut_apoyo_4) VALUES ('" + rut_del_alumno +"', " + id_profesional_evaluador_1 + ", " + id_profesional_evaluador_2 +", " + id_profesional_evaluador_3 +", " + id_profesional_evaluador_4 + ", " + id_profesional_evaluador_5 +", " + id_profesional_apoyo_1 +", " + id_profesional_apoyo_2 +", " + id_profesional_apoyo_3 +", " + id_profesional_apoyo_4 + ", " + id_tipodiagnostico +" , " + id_curso +",'" + nuevo_ingreso +"','" + año_continuidad +"','" + diagnostico +"','" + sindrome_asociado_diagnostico +"', '" + observacion + "','" + fecha_emision + "','" + prueba_1 + "','" + puntaje_1 + "','" + prueba_2 +"','" + puntaje_2 + "','" + prueba_3 +"','" + puntaje_3 +"','" + prueba_4 + "','" + puntaje_4 +"','" + prueba_5 +"','" + puntaje_5 +"'," + id_usuario +",'" + nombre_profesional_apoyo_1 + "','" + nombre_profesional_apoyo_2 +"','" + nombre_profesional_apoyo_3 + "','" + nombre_profesional_apoyo_4 +"','" + nombre_profesional_evaluador_1 +"','" + nombre_profesional_evaluador_2 +"','" + nombre_profesional_evaluador_3 +"','" + nombre_profesional_evaluador_4 +"','" + nombre_profesional_evaluador_5 +"', " + numero_estudiante +" ,'" + rut_profesional_evaluador_1 +"','" + rut_profesional_evaluador_2 +"','" + rut_profesional_evaluador_3 +"','" + rut_profesional_evaluador_4 +"','" + rut_profesional_evaluador_5 +"','" + profesion_profesional_evaluador_1 +"','" + profesion_profesional_evaluador_2 +"','" + profesion_profesional_evaluador_3 + "','" + profesion_profesional_evaluador_4 + "','" + profesion_profesional_evaluador_5 +"','" + rut_profesional_apoyo_1 +"','" + rut_profesional_apoyo_2 +"','" + rut_profesional_apoyo_3 +"','" + rut_profesional_apoyo_4 + "')");
           JOptionPane.showMessageDialog(null, "Alumno ingresado correctamente");
        }
        catch (SQLException ex){
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
            java.util.logging.Logger.getLogger(FrameEvaluacionPart4.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(FrameEvaluacionPart4.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(FrameEvaluacionPart4.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(FrameEvaluacionPart4.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new FrameEvaluacionPart4().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private com.toedter.calendar.JCalendar calendaremision;
    private javax.swing.JComboBox comboapoyo1;
    private javax.swing.JComboBox comboapoyo2;
    private javax.swing.JComboBox comboapoyo3;
    private javax.swing.JComboBox comboapoyo4;
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JButton jButton4;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JPanel jPanel1;
    private javax.swing.JPanel jPanel2;
    // End of variables declaration//GEN-END:variables
}
