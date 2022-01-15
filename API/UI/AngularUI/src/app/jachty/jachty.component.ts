import { Component, OnInit } from '@angular/core';
import {SharedService} from 'src/app/shared.service';


@Component({
  selector: 'app-jachty',
  templateUrl: './jachty.component.html',
  styleUrls: ['./jachty.component.css']
})
export class JachtyComponent implements OnInit {
  zdjeciasciezka = 'assets/IMG/';  
  constructor(private service:SharedService) { }

  
  JachtyList :any=[];
  ngOnInit(): void {
    this.RefreshJachtyList();
  }

  RefreshJachtyList(){
    this.service.getJacht().subscribe(data=>{
      this.JachtyList=data;
    });
  }

  
}
