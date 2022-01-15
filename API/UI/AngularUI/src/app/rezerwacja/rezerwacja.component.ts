import { Component, OnInit, Input } from '@angular/core';
import {SharedService} from 'src/app/shared.service';

@Component({
  selector: 'app-rezerwacja',
  templateUrl: './rezerwacja.component.html',
  styleUrls: ['./rezerwacja.component.css']
})
export class RezerwacjaComponent implements OnInit {

  constructor(private service:SharedService) { }
  @Input()

  RezerwacjaList:any=[];



  ngOnInit(): void {
    this.refreshRezerwacjaList();
  }

  refreshRezerwacjaList(){
    this.service.getRezerwacja().subscribe(data=>{
       this.RezerwacjaList=data;
    });
  }

 DodajRezerwacje(){
  var idjachtu= (<HTMLInputElement>document.getElementById('i_jacht')).value;
  var dataod= new Date((<HTMLInputElement>document.getElementById('i_dataod')).value);
  var datado= new Date((<HTMLInputElement>document.getElementById('i_datado')).value);
  var email= (<HTMLInputElement>document.getElementById('i_email')).value;

  var val={R_J_ID:idjachtu,
  R_DataWypozyczenia:dataod,
  R_DataOddania:datado,
  R_Email:email};

  this.service.addRezerwacja(val).subscribe(res=>{alert(res.toString());

    this.refreshRezerwacjaList();
  });
  }
}
