$(function () {
	$.get("/api/shop", function (data) {
		console.log(dojox.json.ref.resolveJson(data));
	});
});