

// const testArray = [3 ,5 ,7, 9]

// function myFunction(item){
//     return item;
// }
 
// function myForEach(array,callback){
//     for(let index=0; index<array.length;index++){
//         array [index] =0; callback(array[index],index,array)
//     }
// }
// myForEach(testArray,myFunction)





const numbers = [45, 84, 92, 109];

const newArray = numbers.map(myFunction2);

function myFunction2(num) {
  return num * 7;
}

const testArray = [45, 84, 92, 109];
const testArray2=[]
function mymap(array,callback){
    for (let index=0; array.length>index; index++)
    array[index]=callback(array[index],length,array)
    testArray2.push(array[index])
}



const ages = [17, 16.5, 18.5, 45];
const result = ages.filter(checkTeens);

function checkTeens(age) {
  return age >= 18;
}