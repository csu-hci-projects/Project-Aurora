var topLeft = document.getElementById("topleft");
var topRight = document.getElementById("topright");
var bottomLeft = document.getElementById("bottomleft");
var bottomRight = document.getElementById("bottomright");

var centerB = document.getElementById("center");
var centerB1 = document.getElementById("center1");
var centerB2 = document.getElementById("center2");
var centerB3 = document.getElementById("center3");

var startTimeFirstDelta;
var startTimeSecondDelta;
var startTimeThirdDelta;
var startTimeFourthDelta;

function centerStart() {
	centerB.style.visibility = "hidden";
	topLeft.style.visibility = "visible";
	startTimeFirstDelta = Date.now();
}
function first() {
	topLeft.style.visibility = "hidden";
	centerB1.style.visibility = "visible";
	if (startTimeFirstDelta) {
		var endTime = Date.now();
		var difference = endTime - startTimeFirstDelta;
		console.log("D1: " + difference);
	}
}
function firstCenter() {
	centerB1.style.visibility = "hidden";
	bottomRight.style.visibility = "visible";
	startTimeSecondDelta = Date.now();
}
function second() {
	bottomRight.style.visibility = "hidden";
	centerB2.style.visibility = "visible";
	if (startTimeSecondDelta) {
		var endTime = Date.now();
		var difference = endTime - startTimeSecondDelta;
		console.log("D2: " + difference);
	}
}
function secondCenter() {
	centerB2.style.visibility = "hidden";
	bottomLeft.style.visibility = "visible";
	startTimeThirdDelta = Date.now();
}
function third() {
	bottomLeft.style.visibility = "hidden";
	centerB3.style.visibility = "visible";
	if (startTimeThirdDelta) {
		var endTime = Date.now();
		var difference = endTime - startTimeThirdDelta;
		console.log("D3: " + difference);
	}
}
function thirdCenter() {
	centerB3.style.visibility = "hidden";
	topRight.style.visibility = "visible";
	startTimeFourthDelta = Date.now();
}
function fourth() {
	topRight.style.visibility = "hidden";
	if (startTimeFourthDelta) {
		var endTime = Date.now();
		var difference = endTime - startTimeFourthDelta;
		console.log("D4: " + difference);
	}
}
