function agregarElemento(url) {
	$.ajax({
		url: url,
		method: 'POST',
		data: { Nombre: $("#Nombre").val(), Tipo: parseInt($("#Tipo").val()), FechaCaducidad: moment($("#Fecha").val(), "dd/MM/yyyy").format("MM/DD/YY") }
	}).done(function () {		
		M.toast({ html: '"Se dio de alta correctamente"' })
	});
}

function quitarElemento(url) {
	$.ajax({
		url: url,
			method: 'POST',
		data: { "": $("#NombreEliminar").val() }
	}).done(function (data) {
		if (data == 1)			
			M.toast({ html: "Se elimino correctamente el elementos" })
		else if (data > 1)			
			M.toast({ html: "Se eliminaron correctamente " + data + " elementos" })
	});
}