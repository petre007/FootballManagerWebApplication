import { Component, OnInit } from '@angular/core';
import { UntypedFormControl, UntypedFormGroup } from '@angular/forms';
import { Player, PlayerServiceService } from 'D:/matlab/AN3 sem2/II/Lab1/frontend_angular/angular/coreui-free-angular-admin-template-main (1)/coreui-free-angular-admin-template-main/src/app/services/player-service.service';
import { DashboardChartsData, IChartProps } from './dashboard-charts-data';


@Component({
  templateUrl: 'dashboard.component.html',
  styleUrls: ['dashboard.component.scss']
})
export class DashboardComponent implements OnInit {
  
  constructor(private chartsData: DashboardChartsData, private playerService: PlayerServiceService) {}
  public players: Player[] = [];
  public mainChart: IChartProps = {};
  public chart: Array<IChartProps> = [];
  public trafficRadioGroup = new UntypedFormGroup({
    trafficRadio: new UntypedFormControl('Month')
  });

  ngOnInit(): void {
    this.initCharts();
    this.initPlayersData();
  }

  initCharts(): void {
    this.mainChart = this.chartsData.mainChart;
  }

  setTrafficPeriod(value: string): void {
    this.trafficRadioGroup.setValue({ trafficRadio: value });
    this.chartsData.initMainChart(value);
    this.initCharts();
  }
  initPlayersData(): void {
    this.playerService.getPlayers().subscribe(data=>{
      this.players = data
    })
  }

  deletePlayer(id: number):void {
    this.playerService.deletePlayer(id);
  }
}
