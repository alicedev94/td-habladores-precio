	 	--HABLADORES DE PRECIO INVENTARIO POR TIENDA (DATATABLE)
	SELECT DISTINCT TOP 100
       T1.[Referencia] Codigo
      ,T1.[Nombre] Nombre
      ,T5.[Marca] Marca
      ,T4.[CantidadDiasGarantia] Garantia
      ,isNull(T3.[Barra], 0) Codigo_Barra
      ,T2.[Precio] PrecioaMostrar
      ,0 PrecioTachado
      ,T6.Inventario
      ,T6.CodigoSucursal
	  ,T6.Sucursal
	  ,T6.CodArea
  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 
  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]
  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]
  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]
  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]
  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]
  WHERE T1.[Referencia] LIKE 'L%'  AND T2.Cod_ListaPrecio = 6 AND T3.[NumeroUnidades] > 0
  AND T6.CodigoSucursal = 4 AND T6.Inventario > 0 AND T6.CodArea = 'EXH-VD';
	
	--HABLADORES DE PRECIO INVENTARIO POR TIENDA (CODIGO)
	SELECT DISTINCT TOP (100)
       T1.[Referencia] Codigo
      ,T1.[Nombre] Nombre
      ,T5.[Marca] Marca
      ,T4.[CantidadDiasGarantia] Garantia
      ,isNull(T3.[Barra], 0) Codigo_Barra
      ,T2.[Precio] PrecioaMostrar
      ,0 PrecioTachado
      ,T6.Inventario
      ,T6.CodigoSucursal
	  ,T6.Sucursal
	  ,T6.CodArea
  FROM [DB_AWS_MELE].[dbo].[Transaccional.Productos] T1 
  INNER JOIN [DB_AWS_MELE].[dbo].[ListasPrecios] T2 ON T1.Referencia = T2.[Cod_Producto]
  INNER JOIN [DB_AWS_MELE].[dbo].[Transaccional.Empaques] T3 ON  T1.[IdProducto] = T3.[IdProducto]
  INNER JOIN [DB_AWS_MELE].[dbo].[ProductosGarantias] T4 ON T1.[Referencia] = T4.[Cod_Producto]
  INNER JOIN [DB_AWS_MELE].[dbo].[Marcas] T5 ON T4.[Cod_Marca] = T5.[Cod_Marca]
  INNER JOIN [TIENDAS_MELE].[dbo].[TM_VW_ExistenciaTiendasMele] T6 ON T2.[Cod_Producto] = T6.[CodArticulo]
  WHERE T1.[Referencia] LIKE 'L%' AND T1.[Referencia] IN ('LB-00000006', 'LB-000000001') AND T2.Cod_ListaPrecio = 6 AND T3.[NumeroUnidades] > 0
  AND T6.CodigoSucursal = '13' AND T6.Inventario > 0 AND T6.CodArea = 'EXH-VD';




