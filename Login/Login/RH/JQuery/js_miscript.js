$(document).on("ready",function(){
		
		$("#btnCancelar").on("click",function(){
			window.location.href="nueva_cotizacion.php";
		});
		
		//CREACION DE ARREGLO MULTIDIMENCIONAL
		var contador = 1,ind=0,sub =0;
		var descripcion,cantidad,precio_compra, precio_venta, iva, impuesto,serie;
		var lista_prods = [];
		var band = false;
		
		$("#inlineRadio2").on("click",function()
		{
			$("#txtSerie").removeAttr("disabled");
		});

		$("#inlineRadio1").on("click",function()
		{
			$("#txtSerie").attr("disabled","disabled");
		});
		
		$("#btnAgreagar").on("click",function(e){
			e.preventDefault();
			descripcion = document.getElementById("txtDescripcion").value;
			cantidad = document.getElementById("npdCantidad").value;
			precio_compra = document.getElementById("npdPrecioCompra").value;
			iva = "1"+"."+document.getElementById("npdIVA").value;
			impuesto = "1"+"."+document.getElementById("npdImpuestoRubber").value;
			serie = document.getElementById("txtSerie").value;
			
			if (descripcion.length < 3)
			{
				alert("Favor de agregar la descripcion y validar que sea mayor que 3 letras.");
			}
			else if(cantidad<=0)
			{
				alert("Debes de ingresar una cantidad mayor a 0 ");				
			}
			else 
			{
				
				for (var i = 0 ; i < ind; i++) 
				{
					
					if (descripcion.toUpperCase() == lista_prods[i][0])
					{
						band =true;

					}

				}

			
				
				if (!band) 
				{

					if(impuesto==0)
					{
						precio_venta = (precio_compra*parseFloat(iva));
					}
					else if(impuesto>0)
					{
						precio_venta = precio_compra*parseFloat(impuesto);	
					}
					if (serie=="")
					{
						serie="N/A"
					}
					var producto = [];				

					producto[0] = descripcion.toUpperCase();
					producto[1] = cantidad;
					producto[2] = parseFloat(precio_compra).toFixed(2);
					producto[3] = parseFloat(iva).toFixed(2);
					producto[4] = parseFloat(precio_venta).toFixed(2);
					producto[5] = parseFloat(impuesto).toFixed(2);
					producto[6] = parseFloat(precio_venta*cantidad).toFixed(2);
					producto[7] = serie.toUpperCase();

					lista_prods[ind] = producto
							
					var obj = $('<tr><td class="text-center active">'+contador+'</td><td class="info text-center">'+lista_prods[ind][0]+'</td><td class="info text-center">'+lista_prods[ind][1]+'</td><td class="info text-center">'+lista_prods[ind][2]+'</td>'+'</td><td class="info text-center">'+lista_prods[ind][3]+' %</td>'+'</td><td class="info text-center">'+lista_prods[ind][4]+' </td>'+'</td><td class="info text-center">'+lista_prods[ind][5]+' %</td>'+'</td><td class="info text-center">'+lista_prods[ind][6]+'</td>'+'</td><td class="info text-center">'+lista_prods[ind][7]+'</td>');
								
					sub =  sub + parseFloat(precio_venta); 
					
					$("#total").text(sub.toFixed(2));

					$("#cabecera").append(obj);
					
					ind++;
					contador++;
					
				}
				else
				{
					alert("Ya existe ese producto");
					band=false;
				}
			}
			

		});


		//var NuevaSalida = Array(contador);
		$("#btnFinalizar").on("click",function(e){
			e.preventDefault();
				var cotizacion = new Array(7);

				var miJSON = JSON.stringify(lista_prods);
				var encargado = document.getElementById("txtEmpleado").value;
				var usuario = <?php echo $_SESSION['usr']; ?>;

				$.ajax({
					beforeSend: function(){					
						alert("Cargando...");

					},
					url: "",
					type: "POST",
					data: "ne="+ind+"& datos=" + miJSON+"& encargado="+encargado.toUpperCase()+"& usuario="+usuario.toUpperCase(),
					success: function(resp){
						if (resp==false) 
						{
							alert("Atención: es posible que el folio que estas tratando de ingresar ya este como agotado o no exista favor de validar");
						}
						else
						{
							alert("Producto retirado del almacen correctamente");
							window.location.href="salida_producto.php";
						}
						console.log(resp);
					},
					error: function(jqXHR,estado,error){
						console.log(estado);
						console.log(error);
					},
					complete: function(jqXHR,estado){
						console.log(estado);

					},
					timeout:10000
				});
			
			
		});




	});