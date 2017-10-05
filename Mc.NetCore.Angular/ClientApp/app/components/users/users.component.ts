import { Component, Inject } from '@angular/core';
import { Http } from '@angular/http';
import { User } from '../../interfaces';

@Component({
    selector: 'users',
    templateUrl: './users.component.html'
})
export class UsersComponent {
    private title: 'Users';
    private users: User[];

    constructor(http: Http, @Inject('BASE_URL') baseUrl: string) {
        http.get(baseUrl + 'api/users').subscribe(result => {
            this.users = result.json() as User[];
        }, error => console.error(error));
    }
}