import { Component, OnInit, TemplateRef, ViewChild } from '@angular/core';
import { NzDrawerRef, NzDrawerService } from 'ng-zorro-antd/drawer';

@Component({
  selector: 'page-action',
  templateUrl: './templates.html',
  styleUrls: ['./style.less']
})
export default class implements OnInit {

  constructor(private drawerService: NzDrawerService) { }
  @ViewChild('drawerTemplate', { static: false }) drawerTemplate: TemplateRef<{
    $implicit: { value: string, };
    drawerRef: NzDrawerRef<any>;
  }>;
  ngOnInit() {
  }
  id = -1;
  drawerRef: NzDrawerRef;
  onResize({ width }: { width: number }): void {
    console.log("TCL: width", width)
    this.drawerRef.nzWidth = width;
  }
  openTemplate(): void {
    const drawerRef = this.drawerRef = this.drawerService.create({
      nzTitle: 'Template',
      nzContent: this.drawerTemplate,
      nzWidth: 500,
      // nzBodyStyle: {
      //   padding: 0,
      //   height: 'calc(100vh - 55px)'
      // },
      nzContentParams: {
        value: 'this.value'
      }
    });
    console.log(drawerRef)
    drawerRef.afterOpen.subscribe(() => {
      console.log('Drawer(Template) open');
    });

    drawerRef.afterClose.subscribe(() => {
      console.log('Drawer(Template) close');
    });
  }
  // openComponent(): void {
  //   const drawerRef = this.drawerService.create<FormsComponent, { value: string }, string>({
  //     nzTitle: 'Component',
  //     nzWidth: 500,
  //     nzContent: FormsComponent,
  //     nzContentParams: {
  //       value: ''
  //     }
  //   });

  //   drawerRef.afterOpen.subscribe(() => {
  //     console.log('Drawer(Component) open');
  //   });

  //   drawerRef.afterClose.subscribe(data => {
  //     console.log(data);
  //     if (typeof data === 'string') {
  //       // this.value = data;
  //     }
  //   });
  // }
}
