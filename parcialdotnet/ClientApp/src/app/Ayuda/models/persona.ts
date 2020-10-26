import{Apoyo} from './apoyo';
export class Persona {
    constructor(){
        this.apoyo = new Apoyo();
    }
    identificacion: string;
    nombre: string;
    apellido: string
    sexo: string;
    edad: number;
    apoyo:Apoyo;
    
}
