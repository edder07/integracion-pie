package proyectopie;

import java.sql.ResultSet;
import java.sql.SQLException;
import java.sql.Statement;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.util.Calendar;
import java.util.Date;
import java.util.GregorianCalendar;
import java.util.logging.Level;
import java.util.logging.Logger;
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
public static Date frame4_fecha_emision;
public static String frame4_fechax;

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
         cargar_datos_select ();
         
                
    }
    
    void cargar_datos_select (){
        
        comboapoyo1.setSelectedItem(nombre_profesional_apoyo_1);
        comboapoyo2.setSelectedItem(nombre_profesional_apoyo_2);
        comboapoyo3.setSelectedItem(nombre_profesional_apoyo_3);
        comboapoyo4.setSelectedItem(nombre_profesional_apoyo_4);
        
        
        calendaremision.setDate(frame4_fecha_emision); 
        
        
       

    }
     void cargar_datos_select_recuperar (){
   
         nombre_profesional_apoyo_1 = (String) comboapoyo1.getSelectedItem();
         nombre_profesional_apoyo_2 = (String) comboapoyo2.getSelectedItem();
         nombre_profesional_apoyo_3 = (String) comboapoyo3.getSelectedItem();
         nombre_profesional_apoyo_4 = (String) comboapoyo4.getSelectedItem();
         frame4_fecha_emision = calendaremision.getDate();
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
                .addContainerGap(136, Short.MAX_VALUE)
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

        jButton4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/proyectopie/btnsiguiente.png"))); // NOI18N
        jButton4.addMouseListener(new java.awt.event.MouseAdapter() {
            public void mouseClicked(java.awt.event.MouseEvent evt) {
                jButton4MouseClicked(evt);
            }
        });
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
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
                .addGap(50, 50, 50)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addComponent(jPanel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton4, javax.swing.GroupLayout.PREFERRED_SIZE, 184, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(28, Short.MAX_VALUE))
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
    
    }//GEN-LAST:event_jButton1MouseClicked

    private void jButton4MouseClicked(java.awt.event.MouseEvent evt) {//GEN-FIRST:event_jButton4MouseClicked
 
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

        
        
        String eva_1=  (String)comboapoyo1.getSelectedItem().toString();
        String eva_2=  (String)comboapoyo2.getSelectedItem().toString();
        String eva_3=  (String)comboapoyo3.getSelectedItem().toString();
        String eva_4=  (String)comboapoyo4.getSelectedItem().toString();
     
        String v = "VACIO";
         //JOptionPane.showMessageDialog(null,eva_1 + eva_2,"ERROR",JOptionPane.ERROR_MESSAGE);



        if ((! eva_1.equals(v) && eva_1.equals(eva_2) ) || (! eva_1.equals(v) && eva_1.equals(eva_3)) || (! eva_1.equals(v) && eva_1.equals(eva_4)) ||  (! eva_2.equals(v) && eva_2.equals(eva_1)) || (! eva_2.equals(v) && eva_2.equals(eva_3)) || (! eva_2.equals(v) && eva_2.equals(eva_4)) ||  (! eva_3.equals(v) && eva_3.equals(eva_1)) || (! eva_3.equals(v) && eva_3.equals(eva_2)) || (! eva_3.equals(v) && eva_3.equals(eva_4))  || (! eva_4.equals(v) && eva_4.equals(eva_1)) || (! eva_4.equals(v) && eva_4.equals(eva_2)) || (! eva_4.equals(v) && eva_4.equals(eva_3))){
          JOptionPane.showMessageDialog(null,"no se puede repetir los datos","ERROR",JOptionPane.ERROR_MESSAGE);
                    
        }else{
             obtener_nombre_apoyo();
              obtener_datos_evaluador_combobox();
        
        int año = calendaremision.getCalendar().get(Calendar.YEAR);
        int mes = calendaremision.getCalendar().get(Calendar.MARCH)+1;
        int dia = calendaremision.getCalendar().get(Calendar.DAY_OF_MONTH);

        String fecha_emision =(año+"-"+mes+"-"+dia);
     
         ConexionSQL conectar = new ConexionSQL();
         Statement st = conectar.Conectar();
        try{
             st.executeUpdate("INSERT INTO ficha_diagnostico (rut_alumno, id_evaluador_1, id_evaluador_2, id_evaluador_3, id_evaluador_4, id_evaluador_5, id_apoyo_1, id_apoyo_2, id_apoyo_3, id_apoyo_4, id_tipoficha, curso_alumno, nuevo_ingreso, continuidad, diagnostico, sindrome_asociado_diagnostico, observaciones_salud, fecha_emision, prueba_1, puntaje_1, prueba_2, puntaje_2, prueba_3, puntaje_3, prueba_4, puntaje_4, prueba_5, puntaje_5,usuario,nombre_apoyo_1,nombre_apoyo_2,nombre_apoyo_3,nombre_apoyo_4,nombre_evaluador_1,nombre_evaluador_2,nombre_evaluador_3,nombre_evaluador_4,nombre_evaluador_5, numero_estudiante,ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.rut_evaluador_3 , ficha_diagnostico.rut_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.profesion_evaluador_1 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.rut_apoyo_4) VALUES ('" + rut_del_alumno +"', " + id_profesional_evaluador_1 + ", " + id_profesional_evaluador_2 +", " + id_profesional_evaluador_3 +", " + id_profesional_evaluador_4 + ", " + id_profesional_evaluador_5 +", " + id_profesional_apoyo_1 +", " + id_profesional_apoyo_2 +", " + id_profesional_apoyo_3 +", " + id_profesional_apoyo_4 + ", " + id_tipodiagnostico +" , " + id_curso +",'" + nuevo_ingreso +"','" + año_continuidad +"','" + diagnostico +"','" + sindrome_asociado_diagnostico +"', '" + observacion + "','" + fecha_emision + "','" + prueba_1 + "','" + puntaje_1 + "','" + prueba_2 +"','" + puntaje_2 + "','" + prueba_3 +"','" + puntaje_3 +"','" + prueba_4 + "','" + puntaje_4 +"','" + prueba_5 +"','" + puntaje_5 +"'," + id_usuario +",'" + nombre_profesional_apoyo_1 + "','" + nombre_profesional_apoyo_2 +"','" + nombre_profesional_apoyo_3 + "','" + nombre_profesional_apoyo_4 +"','" + nombre_profesional_evaluador_1 +"','" + nombre_profesional_evaluador_2 +"','" + nombre_profesional_evaluador_3 +"','" + nombre_profesional_evaluador_4 +"','" + nombre_profesional_evaluador_5 +"', " + numero_estudiante +" ,'" + rut_profesional_evaluador_1 +"','" + rut_profesional_evaluador_2 +"','" + rut_profesional_evaluador_3 +"','" + rut_profesional_evaluador_4 +"','" + rut_profesional_evaluador_5 +"','" + profesion_profesional_evaluador_1 +"','" + profesion_profesional_evaluador_2 +"','" + profesion_profesional_evaluador_3 + "','" + profesion_profesional_evaluador_4 + "','" + profesion_profesional_evaluador_5 +"','" + rut_profesional_apoyo_1 +"','" + rut_profesional_apoyo_2 +"','" + rut_profesional_apoyo_3 +"','" + rut_profesional_apoyo_4 + "')");
           JOptionPane.showMessageDialog(null, "Ficha ingresada correctamente");
           FrameEvaluacionPart4.frame4_fechax = fecha_emision;
           JOptionPane.showMessageDialog(null, rut_del_alumno);
           JOptionPane.showMessageDialog(null, id_tipodiagnostico);
           JOptionPane.showMessageDialog(null, fecha_emision);
           
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
        }
        
       
    }//GEN-LAST:event_jButton2ActionPerformed

   
    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
    
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
        
    
       
        ConexionSQL conectar = new ConexionSQL();
        Statement st = conectar.Conectar();
      
           
        try{
            ResultSet rs = st.executeQuery("select ficha_diagnostico.id_tipoficha , ficha_diagnostico.numero_estudiante, alumno.apellido_paterno , alumno.apellido_materno , alumno.nombres_alumno , alumno.fecha_nacimiento , ficha_diagnostico.rut_alumno , alumno.sexo_alumno , alumno.nacionalidad_alumno , curso.nombre , ficha_diagnostico.nuevo_ingreso , ficha_diagnostico.continuidad , ficha_diagnostico.diagnostico , ficha_diagnostico.sindrome_asociado_diagnostico , ficha_diagnostico.observaciones_salud , ficha_diagnostico.fecha_emision , ficha_diagnostico.rut_evaluador_1 , ficha_diagnostico.nombre_evaluador_1 , ficha_diagnostico.profesion_evaluador_1  , ficha_diagnostico.rut_evaluador_2 , ficha_diagnostico.nombre_evaluador_2 , ficha_diagnostico.profesion_evaluador_2 , ficha_diagnostico.rut_evaluador_3  , ficha_diagnostico.nombre_evaluador_3 , ficha_diagnostico.profesion_evaluador_3 , ficha_diagnostico.rut_evaluador_4, ficha_diagnostico.nombre_evaluador_4 , ficha_diagnostico.profesion_evaluador_4 , ficha_diagnostico.rut_evaluador_5 , ficha_diagnostico.nombre_evaluador_5 , ficha_diagnostico.profesion_evaluador_5 , ficha_diagnostico.prueba_1 , ficha_diagnostico.puntaje_1 , ficha_diagnostico.prueba_2 , ficha_diagnostico.puntaje_2 , ficha_diagnostico.prueba_3 , ficha_diagnostico.puntaje_3 , ficha_diagnostico.prueba_4 , ficha_diagnostico.puntaje_4 , ficha_diagnostico.prueba_5 , ficha_diagnostico.puntaje_5 , ficha_diagnostico.rut_apoyo_1 , ficha_diagnostico.nombre_apoyo_1 , ficha_diagnostico.rut_apoyo_2 , ficha_diagnostico.nombre_apoyo_2 , ficha_diagnostico.rut_apoyo_3 , ficha_diagnostico.nombre_apoyo_3 , ficha_diagnostico.rut_apoyo_4  , ficha_diagnostico.nombre_apoyo_4 , tipo_ficha.nombre_tipo from ficha_diagnostico , tipo_ficha , alumno , curso where ficha_diagnostico.curso_alumno = curso.id_curso and ficha_diagnostico.rut_alumno = alumno.rut_alumno and tipo_ficha. id_tipo = ficha_diagnostico.id_tipoficha and ficha_diagnostico.rut_alumno = '" + rut_del_alumno +"'  and ficha_diagnostico.fecha_emision = '" +  FrameEvaluacionPart4.frame4_fechax  +"' and ficha_diagnostico.id_tipoficha = " + id_tipodiagnostico +"");
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
                
                FrameEvaluacionParte5 frame = new FrameEvaluacionParte5(); 
                frame.setVisible(true);                                                                                                                
                FrameEvaluacionPart4.this.dispose();     
                   
            } else{
               
              
                JOptionPane.showMessageDialog(null,"RUT no existe","ERROR",JOptionPane.ERROR_MESSAGE);
            }
        }catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        }      
       
        
    }//GEN-LAST:event_jButton4ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
     
        
        cargar_datos_select_recuperar();
        FrameEvaluacionPart3 frame = new FrameEvaluacionPart3(); 
        frame.setVisible(true);                                                                                                                
        FrameEvaluacionPart4.this.dispose();
    }//GEN-LAST:event_jButton1ActionPerformed

     void funcion_fecha(){
         Calendar fechx = new GregorianCalendar();
      int año = calendaremision.getCalendar().get(Calendar.YEAR);
        int mes = calendaremision.getCalendar().get(Calendar.MARCH);
        int dia = calendaremision.getCalendar().get(Calendar.DAY_OF_MONTH);
        String fecha_actuall = año+"-"+ mes +"-"+ dia;
   
         try {
            SimpleDateFormat formatter = new SimpleDateFormat("yyyy-MM-dd");
            
         
            java.util.Date date = formatter.parse(fecha_actuall);
             
               FrameEvaluacionPart4.frame4_fecha_emision = date ;
        } catch (ParseException ex) {
            Logger.getLogger(FrameRutYFicha.class.getName()).log(Level.SEVERE, null, ex);
        }
    }
    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed

        obtener_nombre_apoyo();
        obtener_datos_evaluador_combobox();
        
        int año = calendaremision.getCalendar().get(Calendar.YEAR);
        int mes = calendaremision.getCalendar().get(Calendar.MARCH)+1;
        int dia = calendaremision.getCalendar().get(Calendar.DAY_OF_MONTH);

        String fecha_emision =(año+"-"+mes+"-"+dia);
     
        //funcion_fecha();
         // JOptionPane.showMessageDialog(null, frame4_fecha_emision);
        
         ConexionSQL conectar = new ConexionSQL();
         Statement st = conectar.Conectar();
        try{
             st.executeUpdate("UPDATE ficha_diagnostico SET id_evaluador_1 = " + id_profesional_evaluador_1 +" , id_evaluador_2 = " + id_profesional_evaluador_2 +" , id_evaluador_3 = " + id_profesional_evaluador_3 +" ,id_evaluador_4 = " + id_profesional_evaluador_4 +" ,id_evaluador_5 = " + id_profesional_evaluador_5 +" , id_apoyo_1 = " + id_profesional_apoyo_1 +" ,  id_apoyo_2 = " + id_profesional_apoyo_2 +" ,  id_apoyo_3 = " + id_profesional_apoyo_3 +" ,  id_apoyo_4 = " + id_profesional_apoyo_4 +" , id_tipoficha = " + id_tipodiagnostico +" , curso_alumno = " + id_curso +" ,continuidad = '"+ año_continuidad +"', nuevo_ingreso = '" + nuevo_ingreso +"' , diagnostico = '" + diagnostico +"' , sindrome_asociado_diagnostico = '" + sindrome_asociado_diagnostico +"' , observaciones_salud = '" + observacion +"' , prueba_1 = '" + prueba_1 +"' , puntaje_1 = '" + puntaje_1 +"' , prueba_2 = '" + prueba_2 +"' , puntaje_2 = '" + puntaje_2 +"' , prueba_3 = '" + prueba_3 +"' , puntaje_3 = '" + puntaje_3 +"' , prueba_4 = '" + prueba_4 +"' , puntaje_4 = '" + puntaje_4 +"' , prueba_5 = '" + prueba_5 +"' , puntaje_5 = '" + puntaje_5 +"' , usuario = " + id_usuario +"  , nombre_apoyo_1 = '" + nombre_profesional_apoyo_1 +"' , nombre_apoyo_2 = '" + nombre_profesional_apoyo_2 +"' , nombre_apoyo_3 = '" + nombre_profesional_apoyo_3 +"' , nombre_apoyo_4 = '" + nombre_profesional_apoyo_4 +"' , nombre_evaluador_1 = '" + nombre_profesional_evaluador_1 +"' , nombre_evaluador_2 = '" + nombre_profesional_evaluador_2 +"'  , nombre_evaluador_3 = '" + nombre_profesional_evaluador_3 +"' , nombre_evaluador_4 = '" + nombre_profesional_evaluador_4 +"' , nombre_evaluador_5 = '" + nombre_profesional_evaluador_5 +"' ,  numero_estudiante = " + numero_estudiante +" , rut_evaluador_1 = '" + rut_profesional_evaluador_1 +"' , rut_evaluador_2 = '" + rut_profesional_evaluador_2 +"' , rut_evaluador_3 = '" + rut_profesional_evaluador_3 +"' , rut_evaluador_4 = '" + rut_profesional_evaluador_4 +"' , rut_evaluador_5 = '" + rut_profesional_evaluador_5 +"' , profesion_evaluador_1 = '"+  profesion_profesional_evaluador_1 +"' , profesion_evaluador_2 = '"  +profesion_profesional_evaluador_2  +"' , profesion_evaluador_3 = '" + profesion_profesional_evaluador_3 +"' , profesion_evaluador_4 = '" + profesion_profesional_evaluador_4 +"' , profesion_evaluador_5 = '" + profesion_profesional_evaluador_5 +"' , rut_apoyo_1 = '" + rut_profesional_apoyo_1 +"' , rut_apoyo_2 = '" + rut_profesional_apoyo_2 +"' , rut_apoyo_3 = '" + rut_profesional_apoyo_3 +"' , rut_apoyo_4 = '" + rut_profesional_apoyo_4 +"' , fecha_emision = '" + fecha_emision +"' WHERE ficha_diagnostico.rut_alumno = '"+ rut_del_alumno +"' and ficha_diagnostico.fecha_emision = '" +  FrameEvaluacionPart4.frame4_fecha_emision + "' and ficha_diagnostico.id_tipoficha = " + id_tipodiagnostico +"");
           JOptionPane.showMessageDialog(null, "Ficha modificada correctamente");
            FrameEvaluacionPart4.frame4_fechax = fecha_emision;
           JOptionPane.showMessageDialog(null, fecha_emision);
           JOptionPane.showMessageDialog(null, FrameEvaluacionPart4.frame4_fecha_emision);
        }
        catch (SQLException ex){
            JOptionPane.showMessageDialog(null, ex);
        } 
        
    }//GEN-LAST:event_jButton3ActionPerformed

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
