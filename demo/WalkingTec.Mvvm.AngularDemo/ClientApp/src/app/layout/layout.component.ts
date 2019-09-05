import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.less']
})
export class LayoutComponent {
  tabs = ['Tab 1', 'Tab 2'];
  isCollapsed = false;
  onCollapsed() {
    this.isCollapsed = !this.isCollapsed;
  }
}
