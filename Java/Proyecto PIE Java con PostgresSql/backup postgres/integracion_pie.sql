PGDMP     &                    w           integracion_pie    11.5    11.5 I    ^           0    0    ENCODING    ENCODING        SET client_encoding = 'UTF8';
                       false            _           0    0 
   STDSTRINGS 
   STDSTRINGS     (   SET standard_conforming_strings = 'on';
                       false            `           0    0 
   SEARCHPATH 
   SEARCHPATH     8   SELECT pg_catalog.set_config('search_path', '', false);
                       false            a           1262    16399    integracion_pie    DATABASE     �   CREATE DATABASE integracion_pie WITH TEMPLATE = template0 ENCODING = 'UTF8' LC_COLLATE = 'Spanish_Spain.1252' LC_CTYPE = 'Spanish_Spain.1252';
    DROP DATABASE integracion_pie;
             postgres    false            �            1259    16400    alumno    TABLE     �  CREATE TABLE public.alumno (
    rut_alumno character varying(11) NOT NULL,
    nombres_alumno character varying(250),
    apellido_paterno character varying(50),
    apellido_materno character varying(50),
    fono_alumno integer,
    direccion_alumno character varying(350),
    fecha_nacimiento date,
    sexo_alumno character varying(50),
    nacionalidad_alumno character varying(50),
    estado character varying(11)
);
    DROP TABLE public.alumno;
       public         postgres    false            �            1259    16408 	   apoderado    TABLE     �   CREATE TABLE public.apoderado (
    rut_apoderado character varying(10) NOT NULL,
    nombre_apoderado character varying(250),
    fono_apoderado integer,
    direccion_apoderado character varying(250),
    rut_fk_alumno character varying(11)
);
    DROP TABLE public.apoderado;
       public         postgres    false            �            1259    16418 
   citaciones    TABLE     �   CREATE TABLE public.citaciones (
    id_citacion integer NOT NULL,
    fecha_citacion date,
    fecha_reunion date,
    autoridad character varying(50),
    hora character varying(20),
    descripcion_fecha character varying(100)
);
    DROP TABLE public.citaciones;
       public         postgres    false            �            1259    16416    citaciones_id_citacion_seq    SEQUENCE     �   CREATE SEQUENCE public.citaciones_id_citacion_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 1   DROP SEQUENCE public.citaciones_id_citacion_seq;
       public       postgres    false    199            b           0    0    citaciones_id_citacion_seq    SEQUENCE OWNED BY     Y   ALTER SEQUENCE public.citaciones_id_citacion_seq OWNED BY public.citaciones.id_citacion;
            public       postgres    false    198            �            1259    16426    curso    TABLE     _   CREATE TABLE public.curso (
    id_curso integer NOT NULL,
    nombre character varying(20)
);
    DROP TABLE public.curso;
       public         postgres    false            �            1259    16424    curso_id_curso_seq    SEQUENCE     �   CREATE SEQUENCE public.curso_id_curso_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 )   DROP SEQUENCE public.curso_id_curso_seq;
       public       postgres    false    201            c           0    0    curso_id_curso_seq    SEQUENCE OWNED BY     I   ALTER SEQUENCE public.curso_id_curso_seq OWNED BY public.curso.id_curso;
            public       postgres    false    200            �            1259    16466    ficha_diagnostico    TABLE     ?  CREATE TABLE public.ficha_diagnostico (
    id_fichadiagnostico integer NOT NULL,
    rut_alumno character varying(11),
    id_evaluador_1 integer,
    id_evaluador_2 integer,
    id_evaluador_3 integer,
    id_evaluador_4 integer,
    id_evaluador_5 integer,
    id_apoyo_1 integer,
    id_apoyo_2 integer,
    id_apoyo_3 integer,
    id_apoyo_4 integer,
    id_tipoficha integer,
    curso_alumno integer,
    nuevo_ingreso character varying(300),
    continuidad character varying(20),
    diagnostico character varying(600),
    sindrome_asociado_diagnostico character varying(600),
    observaciones_salud character varying(900),
    fecha_emision date,
    prueba_1 character varying(200),
    puntaje_1 character varying(50),
    prueba_2 character varying(200),
    puntaje_2 character varying(50),
    prueba_3 character varying(200),
    puntaje_3 character varying(50),
    prueba_4 character varying(200),
    puntaje_4 character varying(50),
    prueba_5 character varying(200),
    puntaje_5 character varying(50),
    usuario integer,
    nombre_apoyo_1 character varying(200),
    nombre_apoyo_2 character varying(200),
    nombre_apoyo_3 character varying(200),
    nombre_apoyo_4 character varying(200),
    nombre_evaluador_1 character varying(200),
    nombre_evaluador_2 character varying(200),
    nombre_evaluador_3 character varying(200),
    nombre_evaluador_4 character varying(200),
    nombre_evaluador_5 character varying(200),
    numero_estudiante integer,
    rut_evaluador_1 character varying(10),
    rut_evaluador_2 character varying(10),
    rut_evaluador_3 character varying(10),
    rut_evaluador_4 character varying(10),
    rut_evaluador_5 character varying(10),
    profesion_evaluador_1 character varying(200),
    profesion_evaluador_2 character varying(200),
    profesion_evaluador_3 character varying(200),
    profesion_evaluador_4 character varying(200),
    profesion_evaluador_5 character varying(200),
    rut_apoyo_1 character varying(10),
    rut_apoyo_2 character varying(10),
    rut_apoyo_3 character varying(10),
    rut_apoyo_4 character varying(10)
);
 %   DROP TABLE public.ficha_diagnostico;
       public         postgres    false            �            1259    16464 )   ficha_diagnostico_id_fichadiagnostico_seq    SEQUENCE     �   CREATE SEQUENCE public.ficha_diagnostico_id_fichadiagnostico_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 @   DROP SEQUENCE public.ficha_diagnostico_id_fichadiagnostico_seq;
       public       postgres    false    211            d           0    0 )   ficha_diagnostico_id_fichadiagnostico_seq    SEQUENCE OWNED BY     w   ALTER SEQUENCE public.ficha_diagnostico_id_fichadiagnostico_seq OWNED BY public.ficha_diagnostico.id_fichadiagnostico;
            public       postgres    false    210            �            1259    16458    profesional_apoyo    TABLE     �   CREATE TABLE public.profesional_apoyo (
    id_profapoyo integer NOT NULL,
    rut_apoyo character varying(10),
    nombre_apoyo character varying(200),
    estado character varying(10)
);
 %   DROP TABLE public.profesional_apoyo;
       public         postgres    false            �            1259    16456 "   profesional_apoyo_id_profapoyo_seq    SEQUENCE     �   CREATE SEQUENCE public.profesional_apoyo_id_profapoyo_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 9   DROP SEQUENCE public.profesional_apoyo_id_profapoyo_seq;
       public       postgres    false    209            e           0    0 "   profesional_apoyo_id_profapoyo_seq    SEQUENCE OWNED BY     i   ALTER SEQUENCE public.profesional_apoyo_id_profapoyo_seq OWNED BY public.profesional_apoyo.id_profapoyo;
            public       postgres    false    208            �            1259    16450    profesional_evaluador    TABLE     �   CREATE TABLE public.profesional_evaluador (
    id_evaluador integer NOT NULL,
    rut_evaluador character varying(10),
    nombre_evaluador character varying(200),
    profesion character varying(100),
    estado character varying(10)
);
 )   DROP TABLE public.profesional_evaluador;
       public         postgres    false            �            1259    16448 &   profesional_evaluador_id_evaluador_seq    SEQUENCE     �   CREATE SEQUENCE public.profesional_evaluador_id_evaluador_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 =   DROP SEQUENCE public.profesional_evaluador_id_evaluador_seq;
       public       postgres    false    207            f           0    0 &   profesional_evaluador_id_evaluador_seq    SEQUENCE OWNED BY     q   ALTER SEQUENCE public.profesional_evaluador_id_evaluador_seq OWNED BY public.profesional_evaluador.id_evaluador;
            public       postgres    false    206            �            1259    16442 
   tipo_ficha    TABLE     �   CREATE TABLE public.tipo_ficha (
    id_tipo integer NOT NULL,
    nombre_tipo character varying(80),
    descripcion_tipoficha character varying(150)
);
    DROP TABLE public.tipo_ficha;
       public         postgres    false            �            1259    16440    tipo_ficha_id_tipo_seq    SEQUENCE     �   CREATE SEQUENCE public.tipo_ficha_id_tipo_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.tipo_ficha_id_tipo_seq;
       public       postgres    false    205            g           0    0    tipo_ficha_id_tipo_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.tipo_ficha_id_tipo_seq OWNED BY public.tipo_ficha.id_tipo;
            public       postgres    false    204            �            1259    16434    usuario    TABLE     
  CREATE TABLE public.usuario (
    id_usuario integer NOT NULL,
    nombre_usuario character varying(100),
    pass character varying(100),
    tipo_usuario character varying(8),
    nombre_completo_usuario character varying(200),
    estado character varying(10)
);
    DROP TABLE public.usuario;
       public         postgres    false            �            1259    16432    usuario_id_usuario_seq    SEQUENCE     �   CREATE SEQUENCE public.usuario_id_usuario_seq
    AS integer
    START WITH 1
    INCREMENT BY 1
    NO MINVALUE
    NO MAXVALUE
    CACHE 1;
 -   DROP SEQUENCE public.usuario_id_usuario_seq;
       public       postgres    false    203            h           0    0    usuario_id_usuario_seq    SEQUENCE OWNED BY     Q   ALTER SEQUENCE public.usuario_id_usuario_seq OWNED BY public.usuario.id_usuario;
            public       postgres    false    202            �
           2604    16421    citaciones id_citacion    DEFAULT     �   ALTER TABLE ONLY public.citaciones ALTER COLUMN id_citacion SET DEFAULT nextval('public.citaciones_id_citacion_seq'::regclass);
 E   ALTER TABLE public.citaciones ALTER COLUMN id_citacion DROP DEFAULT;
       public       postgres    false    199    198    199            �
           2604    16545    curso id_curso    DEFAULT     p   ALTER TABLE ONLY public.curso ALTER COLUMN id_curso SET DEFAULT nextval('public.curso_id_curso_seq'::regclass);
 =   ALTER TABLE public.curso ALTER COLUMN id_curso DROP DEFAULT;
       public       postgres    false    201    200    201            �
           2604    16469 %   ficha_diagnostico id_fichadiagnostico    DEFAULT     �   ALTER TABLE ONLY public.ficha_diagnostico ALTER COLUMN id_fichadiagnostico SET DEFAULT nextval('public.ficha_diagnostico_id_fichadiagnostico_seq'::regclass);
 T   ALTER TABLE public.ficha_diagnostico ALTER COLUMN id_fichadiagnostico DROP DEFAULT;
       public       postgres    false    210    211    211            �
           2604    16461    profesional_apoyo id_profapoyo    DEFAULT     �   ALTER TABLE ONLY public.profesional_apoyo ALTER COLUMN id_profapoyo SET DEFAULT nextval('public.profesional_apoyo_id_profapoyo_seq'::regclass);
 M   ALTER TABLE public.profesional_apoyo ALTER COLUMN id_profapoyo DROP DEFAULT;
       public       postgres    false    209    208    209            �
           2604    16453 "   profesional_evaluador id_evaluador    DEFAULT     �   ALTER TABLE ONLY public.profesional_evaluador ALTER COLUMN id_evaluador SET DEFAULT nextval('public.profesional_evaluador_id_evaluador_seq'::regclass);
 Q   ALTER TABLE public.profesional_evaluador ALTER COLUMN id_evaluador DROP DEFAULT;
       public       postgres    false    206    207    207            �
           2604    16445    tipo_ficha id_tipo    DEFAULT     x   ALTER TABLE ONLY public.tipo_ficha ALTER COLUMN id_tipo SET DEFAULT nextval('public.tipo_ficha_id_tipo_seq'::regclass);
 A   ALTER TABLE public.tipo_ficha ALTER COLUMN id_tipo DROP DEFAULT;
       public       postgres    false    204    205    205            �
           2604    16437    usuario id_usuario    DEFAULT     x   ALTER TABLE ONLY public.usuario ALTER COLUMN id_usuario SET DEFAULT nextval('public.usuario_id_usuario_seq'::regclass);
 A   ALTER TABLE public.usuario ALTER COLUMN id_usuario DROP DEFAULT;
       public       postgres    false    203    202    203            L          0    16400    alumno 
   TABLE DATA               �   COPY public.alumno (rut_alumno, nombres_alumno, apellido_paterno, apellido_materno, fono_alumno, direccion_alumno, fecha_nacimiento, sexo_alumno, nacionalidad_alumno, estado) FROM stdin;
    public       postgres    false    196   g       M          0    16408 	   apoderado 
   TABLE DATA               x   COPY public.apoderado (rut_apoderado, nombre_apoderado, fono_apoderado, direccion_apoderado, rut_fk_alumno) FROM stdin;
    public       postgres    false    197   h       O          0    16418 
   citaciones 
   TABLE DATA               t   COPY public.citaciones (id_citacion, fecha_citacion, fecha_reunion, autoridad, hora, descripcion_fecha) FROM stdin;
    public       postgres    false    199   �h       Q          0    16426    curso 
   TABLE DATA               1   COPY public.curso (id_curso, nombre) FROM stdin;
    public       postgres    false    201   Cj       [          0    16466    ficha_diagnostico 
   TABLE DATA               y  COPY public.ficha_diagnostico (id_fichadiagnostico, rut_alumno, id_evaluador_1, id_evaluador_2, id_evaluador_3, id_evaluador_4, id_evaluador_5, id_apoyo_1, id_apoyo_2, id_apoyo_3, id_apoyo_4, id_tipoficha, curso_alumno, nuevo_ingreso, continuidad, diagnostico, sindrome_asociado_diagnostico, observaciones_salud, fecha_emision, prueba_1, puntaje_1, prueba_2, puntaje_2, prueba_3, puntaje_3, prueba_4, puntaje_4, prueba_5, puntaje_5, usuario, nombre_apoyo_1, nombre_apoyo_2, nombre_apoyo_3, nombre_apoyo_4, nombre_evaluador_1, nombre_evaluador_2, nombre_evaluador_3, nombre_evaluador_4, nombre_evaluador_5, numero_estudiante, rut_evaluador_1, rut_evaluador_2, rut_evaluador_3, rut_evaluador_4, rut_evaluador_5, profesion_evaluador_1, profesion_evaluador_2, profesion_evaluador_3, profesion_evaluador_4, profesion_evaluador_5, rut_apoyo_1, rut_apoyo_2, rut_apoyo_3, rut_apoyo_4) FROM stdin;
    public       postgres    false    211   �j       Y          0    16458    profesional_apoyo 
   TABLE DATA               Z   COPY public.profesional_apoyo (id_profapoyo, rut_apoyo, nombre_apoyo, estado) FROM stdin;
    public       postgres    false    209   �l       W          0    16450    profesional_evaluador 
   TABLE DATA               q   COPY public.profesional_evaluador (id_evaluador, rut_evaluador, nombre_evaluador, profesion, estado) FROM stdin;
    public       postgres    false    207   ym       U          0    16442 
   tipo_ficha 
   TABLE DATA               Q   COPY public.tipo_ficha (id_tipo, nombre_tipo, descripcion_tipoficha) FROM stdin;
    public       postgres    false    205   n       S          0    16434    usuario 
   TABLE DATA               r   COPY public.usuario (id_usuario, nombre_usuario, pass, tipo_usuario, nombre_completo_usuario, estado) FROM stdin;
    public       postgres    false    203   #o       i           0    0    citaciones_id_citacion_seq    SEQUENCE SET     I   SELECT pg_catalog.setval('public.citaciones_id_citacion_seq', 32, true);
            public       postgres    false    198            j           0    0    curso_id_curso_seq    SEQUENCE SET     A   SELECT pg_catalog.setval('public.curso_id_curso_seq', 12, true);
            public       postgres    false    200            k           0    0 )   ficha_diagnostico_id_fichadiagnostico_seq    SEQUENCE SET     W   SELECT pg_catalog.setval('public.ficha_diagnostico_id_fichadiagnostico_seq', 5, true);
            public       postgres    false    210            l           0    0 "   profesional_apoyo_id_profapoyo_seq    SEQUENCE SET     P   SELECT pg_catalog.setval('public.profesional_apoyo_id_profapoyo_seq', 4, true);
            public       postgres    false    208            m           0    0 &   profesional_evaluador_id_evaluador_seq    SEQUENCE SET     T   SELECT pg_catalog.setval('public.profesional_evaluador_id_evaluador_seq', 4, true);
            public       postgres    false    206            n           0    0    tipo_ficha_id_tipo_seq    SEQUENCE SET     E   SELECT pg_catalog.setval('public.tipo_ficha_id_tipo_seq', 12, true);
            public       postgres    false    204            o           0    0    usuario_id_usuario_seq    SEQUENCE SET     D   SELECT pg_catalog.setval('public.usuario_id_usuario_seq', 2, true);
            public       postgres    false    202            �
           2606    16407    alumno alumno_pkey 
   CONSTRAINT     X   ALTER TABLE ONLY public.alumno
    ADD CONSTRAINT alumno_pkey PRIMARY KEY (rut_alumno);
 <   ALTER TABLE ONLY public.alumno DROP CONSTRAINT alumno_pkey;
       public         postgres    false    196            �
           2606    16415    apoderado apoderado_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.apoderado
    ADD CONSTRAINT apoderado_pkey PRIMARY KEY (rut_apoderado);
 B   ALTER TABLE ONLY public.apoderado DROP CONSTRAINT apoderado_pkey;
       public         postgres    false    197            �
           2606    16423    citaciones citaciones_pkey 
   CONSTRAINT     a   ALTER TABLE ONLY public.citaciones
    ADD CONSTRAINT citaciones_pkey PRIMARY KEY (id_citacion);
 D   ALTER TABLE ONLY public.citaciones DROP CONSTRAINT citaciones_pkey;
       public         postgres    false    199            �
           2606    16547    curso curso_pkey 
   CONSTRAINT     T   ALTER TABLE ONLY public.curso
    ADD CONSTRAINT curso_pkey PRIMARY KEY (id_curso);
 :   ALTER TABLE ONLY public.curso DROP CONSTRAINT curso_pkey;
       public         postgres    false    201            �
           2606    16474 (   ficha_diagnostico ficha_diagnostico_pkey 
   CONSTRAINT     w   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT ficha_diagnostico_pkey PRIMARY KEY (id_fichadiagnostico);
 R   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT ficha_diagnostico_pkey;
       public         postgres    false    211            �
           2606    16463 (   profesional_apoyo profesional_apoyo_pkey 
   CONSTRAINT     p   ALTER TABLE ONLY public.profesional_apoyo
    ADD CONSTRAINT profesional_apoyo_pkey PRIMARY KEY (id_profapoyo);
 R   ALTER TABLE ONLY public.profesional_apoyo DROP CONSTRAINT profesional_apoyo_pkey;
       public         postgres    false    209            �
           2606    16455 0   profesional_evaluador profesional_evaluador_pkey 
   CONSTRAINT     x   ALTER TABLE ONLY public.profesional_evaluador
    ADD CONSTRAINT profesional_evaluador_pkey PRIMARY KEY (id_evaluador);
 Z   ALTER TABLE ONLY public.profesional_evaluador DROP CONSTRAINT profesional_evaluador_pkey;
       public         postgres    false    207            �
           2606    16447    tipo_ficha tipo_ficha_pkey 
   CONSTRAINT     ]   ALTER TABLE ONLY public.tipo_ficha
    ADD CONSTRAINT tipo_ficha_pkey PRIMARY KEY (id_tipo);
 D   ALTER TABLE ONLY public.tipo_ficha DROP CONSTRAINT tipo_ficha_pkey;
       public         postgres    false    205            �
           2606    16439    usuario usuario_pkey 
   CONSTRAINT     Z   ALTER TABLE ONLY public.usuario
    ADD CONSTRAINT usuario_pkey PRIMARY KEY (id_usuario);
 >   ALTER TABLE ONLY public.usuario DROP CONSTRAINT usuario_pkey;
       public         postgres    false    203            �
           2606    16548 !   ficha_diagnostico fk_curso_alumno    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_curso_alumno FOREIGN KEY (curso_alumno) REFERENCES public.curso(id_curso);
 K   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_curso_alumno;
       public       postgres    false    201    211    2746            �
           2606    16510    ficha_diagnostico fk_id_apoyo_1    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_apoyo_1 FOREIGN KEY (id_apoyo_1) REFERENCES public.profesional_apoyo(id_profapoyo);
 I   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_apoyo_1;
       public       postgres    false    209    2754    211            �
           2606    16515    ficha_diagnostico fk_id_apoyo_2    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_apoyo_2 FOREIGN KEY (id_apoyo_2) REFERENCES public.profesional_apoyo(id_profapoyo);
 I   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_apoyo_2;
       public       postgres    false    209    2754    211            �
           2606    16520    ficha_diagnostico fk_id_apoyo_3    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_apoyo_3 FOREIGN KEY (id_apoyo_3) REFERENCES public.profesional_apoyo(id_profapoyo);
 I   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_apoyo_3;
       public       postgres    false    2754    211    209            �
           2606    16525    ficha_diagnostico fk_id_apoyo_4    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_apoyo_4 FOREIGN KEY (id_apoyo_4) REFERENCES public.profesional_apoyo(id_profapoyo);
 I   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_apoyo_4;
       public       postgres    false    211    2754    209            �
           2606    16485 #   ficha_diagnostico fk_id_evaluador_1    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_evaluador_1 FOREIGN KEY (id_evaluador_1) REFERENCES public.profesional_evaluador(id_evaluador);
 M   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_evaluador_1;
       public       postgres    false    211    2752    207            �
           2606    16490 #   ficha_diagnostico fk_id_evaluador_2    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_evaluador_2 FOREIGN KEY (id_evaluador_2) REFERENCES public.profesional_evaluador(id_evaluador);
 M   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_evaluador_2;
       public       postgres    false    211    2752    207            �
           2606    16495 #   ficha_diagnostico fk_id_evaluador_3    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_evaluador_3 FOREIGN KEY (id_evaluador_3) REFERENCES public.profesional_evaluador(id_evaluador);
 M   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_evaluador_3;
       public       postgres    false    2752    207    211            �
           2606    16500 #   ficha_diagnostico fk_id_evaluador_4    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_evaluador_4 FOREIGN KEY (id_evaluador_4) REFERENCES public.profesional_evaluador(id_evaluador);
 M   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_evaluador_4;
       public       postgres    false    211    2752    207            �
           2606    16505 #   ficha_diagnostico fk_id_evaluador_5    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_evaluador_5 FOREIGN KEY (id_evaluador_5) REFERENCES public.profesional_evaluador(id_evaluador);
 M   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_evaluador_5;
       public       postgres    false    211    2752    207            �
           2606    16530 !   ficha_diagnostico fk_id_tipoficha    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_id_tipoficha FOREIGN KEY (id_tipoficha) REFERENCES public.tipo_ficha(id_tipo);
 K   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_id_tipoficha;
       public       postgres    false    2750    205    211            �
           2606    16475    apoderado fk_rut_alumno    FK CONSTRAINT     �   ALTER TABLE ONLY public.apoderado
    ADD CONSTRAINT fk_rut_alumno FOREIGN KEY (rut_fk_alumno) REFERENCES public.alumno(rut_alumno);
 A   ALTER TABLE ONLY public.apoderado DROP CONSTRAINT fk_rut_alumno;
       public       postgres    false    196    197    2740            �
           2606    16480 "   ficha_diagnostico fk_rut_de_alumno    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_rut_de_alumno FOREIGN KEY (rut_alumno) REFERENCES public.alumno(rut_alumno);
 L   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_rut_de_alumno;
       public       postgres    false    2740    196    211            �
           2606    16540    ficha_diagnostico fk_usuario    FK CONSTRAINT     �   ALTER TABLE ONLY public.ficha_diagnostico
    ADD CONSTRAINT fk_usuario FOREIGN KEY (usuario) REFERENCES public.usuario(id_usuario);
 F   ALTER TABLE ONLY public.ficha_diagnostico DROP CONSTRAINT fk_usuario;
       public       postgres    false    2748    203    211            L   �   x�]�AN�0EדS�F�8���@��ű[�TjŦ�B���������#}���9����@��[�cN��g.0�x��	�to�AH��8q�m�
i`������#���q�|oP������K;z����"����9.|�����
vBB�[�����3Z�`�fj9��(�Un�T��C���z�4�(�=U��r]�y�r���k���G�      M   |   x���! �s�"��/�1�Q���
���C_��Z"�`p�{SFn�!�K�d����ܠ���C'�ZB(%Zo�sI9[za|�[e0}����!
�SH�� ��(�;$�rJޒ���1?�      O   �  x����j�@�>�>@;�G�[!)
��^6f�.׮��56�Dg�I+�ߘ���'8d�_��y���tm�n���z�� ؏m��RV���ybL��X��V��ު��dg�S4 Fh�sN@�)��*hh��B<��hO�(��'S4
 �^LedwЦ4߆��1�OԈ��XW!�v�Uc�d}TVU��%Y�3s�!E�MR�y@������h�����ۦ��R��U�z4��WA��O�/\Mk_eט���$��GI$�y�N��HP�t�͈$u��ݴ���0w�)�>����Z�ދ���6�=<�y;(U��"3��^$���i�\���
9�:��ޭ�QT$~�D��/���@�&v I`6=�\�T$x�Ŕ�U����\�TM�*�R��U1KM��YN�k�����g      Q   K   x�3�4THJ,�L��2�4�1�9�aLNӔ��4�4�1�9�aLNӒ3;3/%���Ѐ��(Uʋ���� QA ?      [   K  x���]��0ǟ�)� ��M�х���x`ծ�b���Mbd'+-��Qz��X'|la�J�X5V��ĞQ~�0B�a��~��a�q�(�3��+	+UV����r�\�*ӅF�!�
��!+� 3��y.XSI�_�alF�L	Vm�3 ���5F`���~���0�:Ǆ+(Le�#���E�(���x:3���7���"�%7|��'��d�a"�(�p�Ss��+�OFB����ߦ��a�D"�b���'o��nϣ������:�Ϙﵿ�e�V��geѪ�է����4P!X�pVPYY��X�n��;�W�P�H�+��j�Z��vȟŲj�\X�&9��%�*׵����L���OF{A���!�����6�e��漪T&�$N���s�KXZ�5pgeV�V���p������{s��r'�����&���؟�=��)�^mѝ�X�c.h��Xg9�q���D�T��1}w"۔�1��E7r\G��?~�#�FQ��W�I, �4��Fs�3���i�P��n?�B����,4V|�ya�������r[�_�-a��^�ݜ�������U��{kz����V��	���      Y   p   x�3��st���LL.�,��2�422370�5�ts��pUpv��VsrwQ����Q��yP&�F�����ٜ��A��
�~!�~@��?�5J!���D���=... 5��      W   �   x�5�A
�0 ϛW�*�F[�K��-1+k#"^�S�"��z��̬�G�X
����~�ڥuM�*���	�hH�#)�$*�Kʞ%�@0?~�k׮�l��}�Tl�1GT��Cg�0�n����o�鿾,�1�l&(      U     x���Mj�0���)|��L��[	*�l9̢�?G�L�B�`-���xdoq�5��y�=���m�dۅj�BE	N�L�i��X�26xtj��l�lU� '�#%���?���@���.K5����w�2_T��ES��ѓ^��$凫W���Gn[r�VI��7r%x۩�7�%Rň�����K`)���`���EάU&����a����?'9�94�X��$0�{	�����3�!�]�)�x2.��l,6�G���� |�+��      S   W   x�3�,�4�LL����ʯTpMII-R��LI�I�W�,,M��M�LL.�,��2�LN,��/�442�jr(��%�qf�A��qqq Q:$     