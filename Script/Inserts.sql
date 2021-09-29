-- bodega
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('1', 'San Juan', 'A');
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('2', 'San Pedro', 'A');
INSERT INTO `sic`.`bodegas` (`codigo_bodega`, `nombre_bodega`, `estatus_bodega`) VALUES ('3', 'San Cristobal', 'A');

-- proveedores
INSERT INTO `sic`.`proveedores` (`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`, `estatus_proveedor`) VALUES ('1', 'Wilmer', '18 av Zona 14', '123', '232323', 'A');
INSERT INTO `sic`.`proveedores` (`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`, `estatus_proveedor`) VALUES ('2', 'Jorge', '15 av Zona 15', '456', '234234', 'A');
INSERT INTO `sic`.`proveedores` (`codigo_proveedor`, `nombre_proveedor`, `direccion_proveedor`, `telefono_proveedor`, `nit_proveedor`, `estatus_proveedor`) VALUES ('3', 'Brayan', '11 av Zona 10', '333', '252627', 'A');

-- marcas
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('1', 'Supra', 'A');
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('2', 'Jordan', 'A');
INSERT INTO `sic`.`marcas` (`codigo_marca`, `nombre_marca`, `estatus_marca`) VALUES ('3', 'Nike', 'A');

-- lineas
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('1', 'Linea1', 'A');
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('2', 'Linea2', 'A');
INSERT INTO `sic`.`lineas` (`codigo_linea`, `nombre_linea`, `estatus_linea`) VALUES ('3', 'Linea3', 'A');

-- productos
INSERT INTO `sic`.`productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES ('1', 'Camisa', '1', '1', '100', 'A');
INSERT INTO `sic`.`productos` (`codigo_producto`, `nombre_producto`, `codigo_linea`, `codigo_marca`, `existencia_producto`, `estatus_producto`) VALUES ('2', 'Pantalon', '2', '2', '100', 'A');

