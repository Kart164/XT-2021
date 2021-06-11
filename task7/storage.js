export class Storage{
    _map;
    constructor(){
        this._map=new Map();
    }
    constructor(arr){
        this._map=new Map();
        if(Array.isArray(arr)){
            for (let i = 0; i < arr.length; i++) {
                this._map.set(i, arr[i]);
            }
        }
        else{
            console.log("arr isn't an array. created an empty storage")
        }
    }
    add(obj) {
        if(obj){ //check for empty obj
            console.log("empty object can't be added")
        }
        else{
            this._map.set(this._map.size-1, obj);
        }
    }
    getAll(){
        return this._map;
    }
    getById(id){
        if(typeof(id)=="string"){
            for (let curID of this._map.keys()) { //I do this using "for" because the ID could be formed not from the index
                if(curID==id){
                    return this._map[curID];
                }
            }
            return null;
        }
        else{
            return null;
        }
    }
    deleteById(id){
        if(typeof(id)=="string"){
            let deletedObj=this._map.get(id);
            if (typeof(deletedObj)=="undefined"){
                return null;
            }
            else{
                this._map.delete(id);
                return deletedObj;
            }
        }
        else{
            return null;
        }
    }
    replaceById(id, obj){
        let propsOfFirstObj=[];
        let propsOfSecondObj=[];
        
    }

}