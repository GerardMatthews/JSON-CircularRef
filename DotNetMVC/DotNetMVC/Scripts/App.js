$(function () {
	$.get("/api/shop", function (data) {
		console.log(dojox.json.ref.resolveJson(data));
		alert("Parsed cyclic data structure logged to console!");
	});
});