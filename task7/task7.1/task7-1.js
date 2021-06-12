let str;
let words = [];
let letters = [];
function task1() {
    str=getString();
    words = getAllWords(words, str);
    letters = getAllRepeatingLetters(letters, words);
    words = deleteAllRepeatingLetters(words, letters);
    words = deleteEmptyWords(words);
    document.getElementById("result1").innerHTML=getResult(words);
};
function getResult(words) {
    let res="";
    for (let i = 0; i < words.length-1; i++) {
        res=res.concat(words[i]," ");
    }
    res=res.concat(words[words.length-1]);
    return res;
}
function getString() {
    return document.getElementById("input-Task1").value;
}
function getAllWords(words, str) {
    str = str.toLowerCase();
    words = str.split(" ");
    let separators = ["?", "!", ":", ";", ",", "."];
    for (let i = 0; i < words.length; i++) {
        for (let j = 0; j < separators.length; j++) {
            let wordlength = words[i].indexOf(separators[j]);
            if (wordlength >= 0) {
                words[i] = words[i].substr(0, wordlength);
            }
        }
    }
    return words;
};
function getAllRepeatingLetters(letters, words) {
    for (let i = 0; i < words.length; i++) {
        let count = 0;
        let pos = 0;
        for (let j = 0; j < words[i].length; j++) {
            count = 0;
            pos = words[i].indexOf(words[i][j], j);
            while (pos != -1) {
                count++;
                pos = words[i].indexOf(words[i][j], pos + 1);
            }
            if (count > 1) {
                letters.push(words[i][j]);
            }
        }
    }
    return letters;
};
function deleteAllRepeatingLetters(words, letters) {
    for (let i = 0; i < words.length; i++) {
        for (let j = 0; j < letters.length; j++) {
            while (words[i].indexOf(letters[j]) != -1) {
                words[i] = words[i].replace(letters[j], "");
            }
        }
    }
    return words;
};
function deleteEmptyWords(words) {
    for (let i = 0; i < words.length; i++) {
        if (words[i] == "") {
            words.splice(i, 1);
        }
    }
    return words
};