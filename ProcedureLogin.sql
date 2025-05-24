
/* se cambia el delimitador de linea para poder almacenar en
el sistema gestor el código del procedimiento
Se puede utilizar cualquier caracater 
*************************************************   */

delimiter //  
CREATE PROCEDURE IngresoLogin(IN Usuario VARCHAR(20), IN Pass VARCHAR(15))

/* =============================================================================
Se colocan dos parametros de entrada por eso son in
uno para el nombre de usuario y el otro para la contraseña
observar que la longitud debe ser igual que la longitud del atributo de la tabla
===================================================================================  */
BEGIN
  /* Proyecto en la consulta el rol que tiene el usuario que ingresa */
  
  SELECT NombreRol
	FROM usuarios u INNER JOIN roles r ON u.RolUsuario = r.RolUsuario
		WHERE NombreUsuario = Usuario AND PasswordUsuario = Pass /* se compara con los parametros */
			AND Activo = 1; /* el usuario debe estar activo */
END 
//

/* ==========================
Si queremos probar el procedure se usa call
====================================================== */

CALL IngresoLogin('dato1', 'dato2')//

/* ===============================
Si los datos de los parametros existen la consulta arroja 1 FILA
Si los datos de los parametros NO EXISTEN la consulta arroja 0 FILAS
============================================================================= */