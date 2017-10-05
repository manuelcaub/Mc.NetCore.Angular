import { Http } from '@angular/http';
import { Injectable } from "@angular/core";

@Injectable()
export class HttpService {

    constructor(private http: Http) {
    }

    public get<T>(endPoint: string) : T[] {
        let elements : T[] = [];
        this.http.get(endPoint).subscribe(result => {
            elements = result.json() as T[];
        }, error => console.error(error));
        return elements;
    }
}