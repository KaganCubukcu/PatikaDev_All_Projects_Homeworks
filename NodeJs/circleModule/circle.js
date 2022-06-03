const circleArea = (r) => {
  const area = r * r * Math.PI;
  console.log(`Yarıçapı ${r} olan dairenin alanı ${area}`);
};
const circleCircumFerence = (r) => {
  const circumFerence = r * Math.PI * 2;
  console.log(`Yarıçapı ${r} olan dairenin çevresi ${circumFerence}`);
};

module.exports = { circleArea, circleCircumFerence };
