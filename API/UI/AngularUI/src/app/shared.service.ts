import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable, observable } from 'rxjs';
@Injectable({
  providedIn: 'root'
})
export class SharedService {
readonly APIUrl='http://localhost:49915/api'

  constructor(private http:HttpClient) { }

  getJacht():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Jacht')

  }

  getKlient():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Klient')

  }


  getRezerwacja():Observable<any[]>{
    return this.http.get<any>(this.APIUrl+'/Rezerwacja')

  }

  addKlient(val:any){
    return this.http.post(this.APIUrl+'/Klient',val)
  }

  addRezerwacja(val:any){
    return this.http.post(this.APIUrl+'/Rezerwacja',val)
  }

  updateKlient(val:any){
    return this.http.put(this.APIUrl+'/Klient',val)
  }


  updateRezerwacja(val:any){
    return this.http.put(this.APIUrl+'/Rezerwacja',val)
  }

  deleteKlient(val:any){
    return this.http.delete(this.APIUrl+'/Klient/'+val)
  }

  deleteRezerwacja(val:any){
    return this.http.delete(this.APIUrl+'/Rezerwacja/'+val)
  }

  

}
