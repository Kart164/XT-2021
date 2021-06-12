import {Storage} from './storage.js';
function task3() {
    let test=new Storage();
    test.add({name:"Max", city: "Saratov"});
    test.add({name:"Roma", age:21 ,city: "Saratov"});
    console.log(test.getAll());
    console.log(test.getById("1"));
    test.updateById("1",{name:"Roma",age:20,city: "Engels"});
    console.log(test.getById("1"));
    test.replaceById("0", {name: "Malik",age:22, city:"Volsk"});
    console.log(test.getAll());
    test.add({name:"Max", city: "Saratov"});
    console.log(test.getById("2"));
    test.deleteById("2");
    console.log(test.getAll());
};
task3();