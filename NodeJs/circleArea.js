const readline = require("readline").createInterface({
  input: process.stdin,
  output: process.stdout,
});

readline.question("Lütfen bir değer giriniz ", (r) => {
  let circleArea = r * r * Math.PI;
  console.log(`Yarıçapı ${r} olan dairenin alanı ${circleArea}`);
  readline.close();
});
