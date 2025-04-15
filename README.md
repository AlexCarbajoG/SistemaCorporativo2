CREATE DATABASE SYS_DCONFIG

USE SYS_DCONFIG

create table LICENCIA(
NRO_LIC     char (12),
NOM_EMP     varchar(30),
ANO_CREA_EMP     smallint,
NRO_RUC     char (20),
EMAIL_EMP     char (20),
EMP_TELF1     char (20),
EMP_TELF2     char (20),
WWW_URL     char (20),
DES_SIM_MON     char (20),
COD_PAIS     char (3),
DES_DIR_EMP     varchar (80)
PRIMARY KEY(NRO_LIC,NOM_EMP) )
GO
CREATE TABLE EJERCICIO_ACTIVO(
ANO_INI_OPE     smallint,
FEC_INI_PER     date,
FEC_FIN_PER     date)
GO
CREATE TABLE IMPORTACION(
CAR_RUT_DAT     varchar (500),
FEC_ACT     datetime)
GO
--------------------------
--TABLAS DE CONTROL DE ERRORES
---------------------
CREATE TABLE SYS_LOG_ERR(
NOM_TBL     varchar (100),
ERR_NUM     int primary key,
ERR_DES     varchar (100),
ERR_CAN     numeric (20,4))
GO
CREATE TABLE SYS_LOG_TRY(
ERR_NAME varchar (4000),
ERR_NUM int,
ERR_SEVERITY int primary key,
ERR_STATE int,
ERR_PROCEDURE varchar (4000),
ERR_LINE int,
ERR_MESSAGE varchar (4000),
FEC_ERR datetime,
FOREIGN KEY (ERR_NUM) REFERENCES SYS_LOG_ERR(ERR_NUM))
GO
---------------
--TABLAS
-------------------
CREATE TABLE DB_MENU(
COD_OPCION     char (10) PRIMARY KEY,
DES_OPCION     varchar (80),
FLG_EST_OPC     bit,
FEC_ABM     datetime)
GO
CREATE TABLE DB_USUARIO(
COD_USER     char (10) PRIMARY KEY,
DES_USER     varchar (80),
EMAIL_USER     char (20),
CLAVE_USER     char (20),
FLG_EST_USER     bit,
FEC_ABM     datetime)
GO

CREATE TABLE DB_ACCESO(
COD_USER     char (10),
COD_ALM     char (20),
COD_OPCION     char (10),
FLG_EST_ACC     bit,
FEC_ABM     datetime,
FOREIGN KEY(cod_user) REFERENCES DB_USUARIO(COD_USER),
FOREIGN KEY(COD_ALM) REFERENCES DB_ALMACEN(COD_ALM),
FOREIGN KEY(cod_opcion) REFERENCES DB_MENU(COD_OPCION))
GO


--------------------------------
--TABLAS DE PARAMETROS
------------------------------------------
--REGION FISICA
CREATE TABLE DB_REG_FIS(
COD_REG     smallint PRIMARY KEY, 
DES_REG     varchar (80),
COD_USER     char (10),
FEC_ABM     datetime
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--UBIGEO
CREATE TABLE DB_UBI_GEO(
COD_PAIS     char (3),
DES_PAIS     varchar (80),
COD_DPTO     smallint,
DES_DPTO     varchar (80),
COD_CIU     smallint,
DES_CIU     varchar (80),
COD_BARR     smallint,
DES_BARR     varchar (80),
CAR_IDIOMA     varchar (30),
DES_CON     varchar (80),
COD_REG     smallint,
UBI_LATITUD     varchar (80),
UBI_LONGITUD     varchar (80),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(cod_pais, cod_dpto, cod_ciu, cod_barr),
FOREIGN KEY (COD_REG) REFERENCES DB_REG_FIS(COD_REG),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--SEGMENTOS COMERCIALES
CREATE TABLE DB_SEG_COM(
COD_SEG     char (10),
DES_SEG     varchar (80),
COD_SSEG     char (10),
DES_SSEG     varchar (80),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(cod_seg, cod_sseg),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--MARCAS DE ARTICULOS
CREATE TABLE DB_MAR_ART(
COD_MAR     char (10) PRIMARY KEY,
DES_MAR     varchar (80),
COD_USER     char (10),
FEC_ABM     datetime,
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--FAMILIA DE ARTICULOS
CREATE TABLE DB_FMA_ART(
COD_CAT     char (10),
DES_CAT     varchar (80),
COD_LIN     char (10),
DES_LIN     varchar (80),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(cod_cat, cod_lin),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--LOCAL
CREATE TABLE DB_LOCACION(
FLG_DEP_CEN     bit,
COD_LOC     char (20)PRIMARY KEY,
DES_LOC     varchar (80),
FEC_CREA     datetime,
DES_NOM_ENC     varchar (80),
FLG_LOC_VIR     bit,
COD_PAIS     char (3),
COD_DPTO     smallint,
COD_CIU     smallint,
COD_BARR     smallint,
DES_DIR_LOC     varchar (80),
VAL_ZLOC_ALT     numeric (20,4),
VAL_ZLOC_SUP     numeric (20,4),
VAL_COB_ESP     smallint,
COD_USER     char (10),
FEC_ABM     datetime,
CONSTRAINT FK_LOCAL_UBIGEO FOREIGN KEY(COD_PAIS, COD_DPTO, COD_CIU, COD_BARR) REFERENCES DB_UBI_GEO(COD_PAIS, COD_DPTO, COD_CIU, COD_BARR),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--ALMACEN
CREATE TABLE DB_ALMACEN(
COD_ALM     char (20) PRIMARY KEY,
DES_ALM     varchar (80),
FEC_CREA     datetime,
COD_LOC     char (20),
DES_NOM_ENC     varchar (80),
VAL_ZALM_ALT     numeric (20,4),
VAL_ZALM_SUP     numeric (20,4),
FLG_AMB_CTRL     bit,
FLG_ALM_RET     bit,
COD_USER     char (10),
FEC_ABM     datetime,
FOREIGN KEY (COD_LOC) REFERENCES DB_LOCACION (COD_LOC),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--PERSONA
CREATE TABLE DB_PERSONA(
COD_PER     char (10) PRIMARY KEY,
DES_PER     varchar (80),
FLG_PER_JUR     bit,
FLG_SEX_PER     bit,
COD_PAIS     char (3),
COD_DPTO     smallint,
COD_CIU     smallint,
COD_BARR     smallint,
DES_DIR     varchar (80),
NRO_RUC     char (20),
EMAIL_EMP     char (20),
EMP_TELF1     char (20),
EMP_TELF2     char (20),
WWW_URL     char (20),
COD_USER     char (10),
FEC_ABM     datetime,
CONSTRAINT FK_PERSONA_UBIGEO FOREIGN KEY (COD_PAIS, COD_DPTO, COD_CIU, COD_BARR) REFERENCES DB_UBI_GEO(COD_PAIS, COD_DPTO, COD_CIU, COD_BARR),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO


--TRABAJADOR
CREATE TABLE DB_TRABAJADOR(
COD_TRA     char (10) PRIMARY KEY,
COD_PER     char (10),
FLG_INH_MOV     bit,
FEC_ABM     datetime,
FOREIGN KEY (COD_PER) REFERENCES DB_PERSONA (COD_PER))
GO
--VENDEDOR
CREATE TABLE DB_VENDEDOR(
COD_VEN     char (10)PRIMARY KEY,
COD_TRA     char (10),
FLG_INH_MOV     bit,
FEC_ABM     datetime,
FOREIGN KEY (COD_TRA) REFERENCES DB_TRABAJADOR (COD_TRA))
GO
CREATE TABLE DB_CLIENTE(
COD_CLI     char (10) PRIMARY KEY,
COD_PER     char (10),
COD_GRP_EMP     char (10),
COD_VEN     char (10),
COD_SEG     char (10),
COD_SSEG     char (10),
FLG_INH_MOV     bit,
FEC_ABM     datetime,
FOREIGN KEY (COD_VEN) REFERENCES DB_VENDEDOR(COD_VEN),
FOREIGN KEY (COD_PER) REFERENCES DB_PERSONA (COD_PER),
FOREIGN KEY (COD_SEG,COD_SSEG) REFERENCES DB_SEG_COM(COD_SEG,COD_SSEG))
GO
CREATE TABLE DB_PROVEEDOR(
COD_PRV     char (10) PRIMARY KEY,
COD_PER     char (10),
FLG_INH_MOV     bit,
VAL_TIE_ATC     smallint,
VAL_CMN_UMO     numeric (20,4),
FEC_ABM     datetime,
FOREIGN KEY (COD_PER) REFERENCES DB_PERSONA (COD_PER))
GO

CREATE TABLE DB_FABRICANTE(
COD_FABRICANTE     char (20) PRIMARY KEY,
COD_PER     char (10),
FEC_ABM     datetime,
FOREIGN KEY (COD_PER) REFERENCES DB_PERSONA (COD_PER))
GO
--ARTICULO
CREATE TABLE DB_ARTICULO(
COD_ART     char (20)PRIMARY KEY,
COD_UNICO     char (20),
COD_PADRE     char (20),
DES_ART     varchar (80),
COD_FABRICANTE     char (20),
CAR_UND_VTAP     varchar (20),
CAR_UND_VTAS     varchar (20),
VAL_NCOMP_VTAS     smallint,
CAR_UND_COMPACK     numeric (20,4),
COD_CAT     char (10),
COD_LIN     char (10),
COD_MAR     char (10),
COD_PRV     char (10),
VAL_TAS_IVA     numeric (6,4),
VAL_PUM_UMO     numeric (20,4),
VAL_CUN_UMO     numeric (20,4),
VAL_SSG_ESP     numeric (20,4),
VAL_STK_EXP     numeric (20,4),
VAL_VTA_MIN     numeric (20,4),
FLG_ORIGEN     bit,
FLG_VTA_LIBRE     bit,
FLG_ART_CTR     bit,
FLG_ART_FRA     bit,
FLG_CAD_FRIO     bit,
FLG_ART_INA     bit,
FLG_INH_VTA     bit,
FLG_INH_COM     bit,
CAR_ADICIONAL     varchar (80),
COD_USER     char (10),
FEC_ABM     datetime,
FOREIGN KEY (COD_FABRICANTE) REFERENCES DB_FABRICANTE (COD_FABRICANTE),
FOREIGN KEY (COD_CAT,COD_LIN) REFERENCES DB_FMA_ART(COD_CAT,COD_LIN),
FOREIGN KEY (COD_MAR) REFERENCES DB_MAR_ART (COD_MAR),
FOREIGN KEY (COD_PRV) REFERENCES DB_PROVEEDOR (COD_PRV),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO (COD_USER))
GO

CREATE TABLE DB_LOTE_ART(
NRO_LOTE     char (20) primary key,
COD_ART     char (20),
COD_PRV     char (10),
FLG_CON_CONS     bit,
FLG_CON_CANJE     bit,
COD_CARTA     char (10),
FEC_INI_LOTE     date,
FEC_FIN_LOTE     date,
VAL_MAX_CANJE     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (COD_PRV) REFERENCES DB_PROVEEDOR(COD_PRV),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
-------------------------------------------------------
--TABLAS DE MOVIMIENTO
-------------------------------------------------------
--NUMEROS CORRELATIVOS
CREATE TABLE HB_NRO_CORR(
NRO_OCO     char (20),
NRO_PED     char (20))
GO
--STOCK POR ALMACEN
CREATE TABLE HB_STK_ALM(
COD_ART     char (20),
COD_ALM     char (20),
NRO_LOTE     char (20),
VAL_SINI_UND     numeric (20,4),
VAL_SINI_UMO     numeric (20,4),
VAL_ENT_UND     numeric (20,4),
VAL_ENT_UMO     numeric (20,4),
VAL_SAL_UND     numeric (20,4),
VAL_SAL_UMO     numeric (20,4),
VAL_SFIN_UND     numeric (20,4),
VAL_SFIN_UMO     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(cod_art, cod_alm, nro_lote),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER),
FOREIGN KEY (NRO_LOTE) REFERENCES DB_LOTE_ART(NRO_LOTE),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (COD_ALM) REFERENCES DB_ALMACEN (COD_ALM))
GO
--CABECERA ORDEN DE COMPRA
CREATE TABLE HB_OCO_CAB(
COD_LOC     char (20),
DOC_NRO_OCO     char (20),
COD_PRV     char (10),
FEC_MOV     datetime,
NRO_RUC     char (20),
DOC_REF     char (10),
TXT_OBSERVACION     varchar(60),
FLG_EST_OCO     bit,
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_nro_oco),
FOREIGN KEY (COD_LOC) REFERENCES DB_LOCACION (COD_LOC),
FOREIGN KEY (COD_PRV) REFERENCES DB_PROVEEDOR(COD_PRV),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--DETALLE ORDEN DE COMPRA
CREATE TABLE HB_OCO_DET(
DOC_NRO_OCO     char (20),
NRO_LINEA     smallint,
COD_ART     char (20),
FEC_REC_MER     datetime,
VAL_VTA_UND     numeric (20,4),
VAL_BONV_UND     numeric (20,4),
VAL_MON_UMO     numeric (20,4),
VAL_CVT_UMO     numeric (20,4),
VAL_IVA_UMO     numeric (20,4),
VAL_ENT_UND     numeric (20,4),
VAL_SAL_UND     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_nro_oco, nro_linea),
FOREIGN KEY (DOC_NRO_OCO) REFERENCES HB_OCO_CAB (DOC_NRO_OCO),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--CABECERA DE COMPRA HISTORICO
CREATE TABLE HB_MCOM_CAB(
COD_LOC     char (20),
TIP_DOC_COM     char(1),
DOC_NRO     char (20),
FEC_MOV     datetime,
COD_PRV     char (10),
DOC_NRO_OCO     char (20),
TXT_OBSERVACION     varchar(60),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(tip_doc_com, doc_nro),
FOREIGN KEY (COD_LOC) REFERENCES DB_LOCACION (COD_LOC),
FOREIGN KEY (COD_PRV) REFERENCES DB_PROVEEDOR(COD_PRV),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--DETALLE COMPRA HISTORICO
CREATE TABLE HB_MCOM_DET(
TIP_DOC_COM     char(1),
DOC_NRO     char (20),
NRO_LINEA     smallint,
COD_ALM     char (20),
COD_ART     char (20),
VAL_COM_UND     numeric (20,4),
VAL_BONC_UND     numeric (20,4),
VAL_MON_UMO     numeric (20,4),
VAL_IVA_UMO     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(tip_doc_com, doc_nro, nro_linea),
FOREIGN KEY (tip_doc_com, doc_nro) REFERENCES HB_MCOM_CAB(tip_doc_com, doc_nro),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (COD_ALM) REFERENCES DB_ALMACEN (COD_ALM))
GO
--CABECERA CANJE
CREATE TABLE HB_CJE_CAB(
COD_LOC     char (20),
DOC_NRO     char (20),
FEC_REM_CJE     datetime,
COD_PRV     char (10),
DOC_REF     char (10),
TXT_OBSERVACION     varchar(60),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_nro),
FOREIGN KEY (COD_LOC) REFERENCES DB_LOCACION (COD_LOC),
FOREIGN KEY (COD_PRV) REFERENCES DB_PROVEEDOR(COD_PRV),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--DETALLE DE CANJE
CREATE TABLE HB_CJE_DET(
DOC_NRO     char (20),
NRO_LINEA     smallint,
COD_ALM     char (20),
COD_ART     char (20),
NRO_LOTE     char (20),
VAL_REM_UND     numeric (20,4),
VAL_REM_UMO     numeric (20,4),
VAL_IVA_REM     numeric (20,4),
FEC_REC_CJE     datetime,
VAL_CJE_UND     numeric (20,4),
VAL_CJE_UMO     numeric (20,4),
VAL_IVA_CJE     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_nro, nro_linea),
FOREIGN KEY (DOC_NRO) REFERENCES HB_CJE_CAB (DOC_NRO),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (NRO_LOTE) REFERENCES DB_LOTE_ART (NRO_LOTE),
FOREIGN KEY (COD_ALM) REFERENCES DB_ALMACEN (COD_ALM),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
---------------------
--CABECERA DE TRANSFERENCIA
CREATE TABLE HB_TRA_CAB(
DOC_ORD_TRA     char (20),
FEC_TRANSF     datetime,
TXT_MOTIVO     char (20),
COD_LOC_EMI     char (20),
COD_ALM_EMI     char (20),
COD_LOC_REC     char (20),
COD_ALM_REC     char (20),
VAL_FLT_UMO     numeric (20,4),
DOC_REF     char (10),
TXT_OBSERVACION     varchar(60),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_ord_tra),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--AJUSTES DEL STOCK CABECERA
CREATE TABLE HB_AJU_CAB(
DOC_ORD_TRA char(20),
DOC_AJU     char (20) PRIMARY KEY,
FEC_AJU     datetime,
TXT_MOTIVO     char (20),
COD_ALM_EMI     char (20),
COD_ALM_REC     char (20),
DOC_REF     char (10),
TXT_OBSERVACION     varchar(60),
COD_USER     char (10),
FEC_ABM     datetime,
FOREIGN KEY(DOC_ORD_TRA) REFERENCES HB_TRA_CAB (DOC_ORD_TRA),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--AJUSTES DEL STOCK DETALLE
CREATE TABLE HB_AJU_DET(
DOC_ORD_TRA char(20),
DOC_AJU     char (20),
NRO_LINEA     smallint,
COD_ART     char (20),
NRO_LOTE     char (20),
VAL_SAL_UND     numeric (20,4),
VAL_SAL_UMO     numeric (20,4),
VAL_ENT_UND     numeric (20,4),
VAL_ENT_UMO     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_ord_tra, nro_linea),
FOREIGN KEY (DOC_AJU) REFERENCES HB_AJU_CAB(DOC_AJU),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (NRO_LOTE) REFERENCES DB_LOTE_ART (NRO_LOTE),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO

--TRANSFERENCIA EN CURSO ENTRE ALMACENES
CREATE TABLE HB_TRA_DET(
DOC_ORD_TRA     char (20),
NRO_LINEA     smallint,
COD_ART     char (20),
NRO_LOTE     char (20),
VAL_SAL_UND     numeric (20,4),
VAL_SAL_UMO     numeric (20,4),
VAL_ENT_UND     numeric (20,4),
VAL_ENT_UMO     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_ord_tra, nro_linea),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (NRO_LOTE) REFERENCES DB_LOTE_ART (NRO_LOTE),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO


--CABECERA DE PEDIDO
CREATE TABLE HB_PED_CAB(
COD_LOC     char (20),
DOC_NRO_PED     char (20),
COD_CLI     char (10),
FEC_MOV     datetime,
COD_VEN     char (10),
NRO_RUC     char (20),
DOC_REF     char (10),
TXT_OBSERVACION     varchar(60),
FLG_EST_PED     bit,
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_nro_ped),
FOREIGN KEY (COD_LOC) REFERENCES DB_LOCACION(COD_LOC),
FOREIGN KEY (COD_CLI) REFERENCES DB_CLIENTE (COD_CLI),
FOREIGN KEY (COD_VEN) REFERENCES DB_VENDEDOR (COD_VEN),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO



--DETALLE PEDIDO
CREATE TABLE HB_PED_DET(
DOC_NRO_PED     char (20),
NRO_LINEA     smallint,
COD_ART     char (20),
FEC_ENT_MER     datetime,
VAL_VTA_UND     numeric (20,4),
VAL_BONV_UND     numeric (20,4),
VAL_MON_UMO     numeric (20,4),
VAL_CVT_UMO     numeric (20,4),
VAL_IVA_UMO     numeric (20,4),
VAL_ENT_UND     numeric (20,4),
VAL_SAL_UND     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(doc_nro_ped, nro_linea),
FOREIGN KEY (DOC_NRO_PED) REFERENCES HB_PED_CAB(DOC_NRO_PED), 
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO


--MOVIMIENTO DE VENTA CABECERA
CREATE TABLE HB_MVTA_CAB(
COD_LOC     char (20),
TIP_DOC_COM     char(1),
DOC_NRO     char (20),
FEC_MOV     datetime,
COD_CLI     char (10),
COD_VEN     char (10),
NRO_RUC     char (20),
DOC_REF     char (10),
TXT_OBSERVACION     varchar(60),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(tip_doc_com, doc_nro),
FOREIGN KEY (COD_LOC) REFERENCES DB_LOCACION(COD_LOC),
FOREIGN KEY (COD_CLI) REFERENCES DB_CLIENTE (COD_CLI),
FOREIGN KEY (COD_VEN) REFERENCES DB_VENDEDOR (COD_VEN),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--MOVI DE VENTA DETALLE
CREATE TABLE HB_MVTA_DET(
TIP_DOC_COM     char(1),
DOC_NRO     char (20),
NRO_LINEA     smallint,
COD_ART     char (20),
COD_ALM     char (20),
NRO_LOTE     char (20),
VAL_VTA_UND     numeric (20,4),
VAL_BONV_UND     numeric (20,4),
VAL_MON_UMO     numeric (20,4),
VAL_CVT_UMO     numeric (20,4),
VAL_IVA_UMO     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
PRIMARY KEY(tip_doc_com, doc_nro, nro_linea),
FOREIGN KEY(tip_doc_com, doc_nro) REFERENCES HB_MVTA_CAB(tip_doc_com, doc_nro),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (NRO_LOTE) REFERENCES DB_LOTE_ART (NRO_LOTE),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER),
FOREIGN KEY (COD_ALM) REFERENCES DB_ALMACEN(COD_ALM))
GO
--INVENTARIO FISICO
CREATE TABLE HB_INVFIS_CAB(
DOC_NRO     char (20),
FEC_MOV     datetime,
COD_AUTO     char (20),
DOC_REF     char (10),
TXT_MOTIVO     char (20),
COD_USER     char (10),
TXT_OBSERVACION     varchar(60),
FLG_EST_AJU     bit,
FEC_ABM     datetime,
PRIMARY KEY(doc_nro),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER))
GO
--INVENTARIO FISICO DETALLE
CREATE TABLE HB_INVFIS_DET(
DOC_NRO     char (20),
NRO_LINEA     smallint,
COD_ART     char (20),
VAL_COSTO_UNIT     numeric (20,4),
COD_ALM     char (20),
NRO_LOTE     char (20),
COD_PRV char(10),
VAL_SALINI_UND     numeric (20,4),
VAL_SALINI_UMO     numeric (20,4),
VAL_AJUENT_UND     numeric (20,4),
VAL_AJUSAL_UND     numeric (20,4),
VAL_SALFIN_UND     numeric (20,4),
VAL_SALFIN_UMO     numeric (20,4),
COD_USER     char (10),
FEC_ABM     datetime,
FOREIGN KEY (DOC_NRO) REFERENCES HB_INVFIS_CAB(DOC_NRO),
FOREIGN KEY (COD_ART) REFERENCES DB_ARTICULO (COD_ART),
FOREIGN KEY (NRO_LOTE) REFERENCES DB_LOTE_ART (NRO_LOTE),
FOREIGN KEY (COD_USER) REFERENCES DB_USUARIO(COD_USER),
FOREIGN KEY (COD_ALM) REFERENCES DB_ALMACEN(COD_ALM))
GO
