export {Storage};
class Storage {
    _map;
    constructor() {
        this._map = new Map();
    }
    add(obj) {
        if (obj) { //check for empty obj
            this._map.set(this._map.size.toString(), obj);
        }
        else {
            console.log("empty object can't be added")
        }
    }
    getAll() {
        return this._map;
    }
    getById(id) {
        if (typeof (id) == "string"|| typeof(id)=="number") {
            let res=this._map.get(id);
            if(typeof(res)=="undefined"){
                return null;
            }
            else return res;
        }
    }
    deleteById(id) {
        if (typeof (id) == "string"|| typeof(id)=="number") {
            let deletedObj = this._map.get(id);
            if (typeof (deletedObj) == "undefined") {
                return null;
            }
            else {
                this._map.delete(id);
                return deletedObj;
            }
        }
        else {
            return null;
        }
    }
    updateById(id, obj) {
        if (obj) {
            let propsOfFirstObj = [];
            let propsOfSecondObj = [];
            if (typeof (id) == "string"|| typeof(id)=="number") {
                let curObj = this._map.get(id);
                if (typeof (curObj) == "undefined") {
                    console.log("item with this id doesn't exist");
                }
                else {
                    propsOfFirstObj=Object.keys(this._map.get(id));
                    propsOfSecondObj=Object.keys(obj);
                    for (let i = 0; i < propsOfSecondObj.length; i++) {
                        if(propsOfFirstObj.includes(propsOfSecondObj[i])){
                            curObj[propsOfSecondObj[i]]=obj[propsOfSecondObj[i]];
                        }
                    }
                    this._map.set(id,curObj);
                }
            }
        }
        else{
            console.log("obj is empty")
        }
    }
    replaceById(id, obj){
        if(obj){
            if (typeof (id) == "string"|| typeof(id)=="number") {
                let curObj = this._map.get(id);
                if (typeof (curObj) == "undefined") {
                    console.log("item with this id doesn't exist");
                }
                else{
                    this._map.set(id,obj);
                }

            }
        }
    }
};