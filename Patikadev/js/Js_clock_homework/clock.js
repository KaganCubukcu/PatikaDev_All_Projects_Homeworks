"use strict";
//Get Name
const getName = prompt("Isminizi giriniz");
document.getElementById("myName").innerHTML = getName;

//Weekdays
const weekday = [
  "Pazar",
  "Pazartesi",
  "Salı",
  "Çarşamba",
  "Perşembe",
  "Cuma",
  "Cumartesi",
];

// Clock //
function showTime() {
  let date = new Date();
  let hh = date.getHours();
  let mm = date.getMinutes();
  let ss = date.getSeconds();
  let dd = weekday[date.getDay()];

  hh = hh < 10 ? "0" + hh : hh;
  mm = mm < 10 ? "0" + mm : mm;
  ss = ss < 10 ? "0" + ss : ss;

  let time = hh + ":" + mm + ":" + ss + "" + dd;

  document.getElementById("myClock").innerText = time;

  var t = setTimeout(function () {
    showTime();
  }, 1000);
}
showTime();
