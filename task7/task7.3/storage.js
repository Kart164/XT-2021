export {Storage};
class Storage {
    _map;
    constructor() {
        this._map = new Map();
    }
    add(obj) {
        if (obj) { //check for empty obj
            this._map.set(this._map.size == 0 ? 0 : this._map.size-1, obj);
        }
        else {
            console.log("empty object can't be added")
        }
    }
    getAll() {
        return this._map;
    }
    getById(id) {
        if (typeof (id) == "string") {
            let res=this._map.get(id);
            if(typeof(res)=="undefined"){
                return null;
            }
            else return res;
        }
        else {
            return null;
        }
    }
    deleteById(id) {
        if (typeof (id) == "string") {
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

            if (typeof (id) == "string") {
                let curObj = this._map.get(id);
                if (typeof (curObj) == "undefined") {
                    console.log("item with this id doesn't exist");
                }
                else {
                    propsOfFirstObj=Object.keys(this._map[id]);
                    propsOfSecondObj=Object.keys(obj);
                    let j=0;
                    for (let i = 0; i < propsOfSecondObj.length; i++) {
                        if(propsOfFirstObj.includes(propsOfSecondObj[i])){
                            this._map[id][propsOfSecondObj[i]]=obj[propsOfSecondObj[i]];
                        }
                    }
                }
            }
        }
        else{
            console.log("obj is empty")
        }
    }
    replaceById(id, obj){
        if(obj){
            if (typeof (id) == "string") {
                let curObj = this._map.get(id);
                if (typeof (curObj) == "undefined") {
                    console.log("item with this id doesn't exist");
                }
                else{
                    this._map[id]=obj;
                }

            }
        }
    }
};