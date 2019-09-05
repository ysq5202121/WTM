import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './layout.component.html',
  styleUrls: ['./layout.component.less']
})
export class LayoutComponent {
  isCollapsed = false;
  onCollapsed() {
    this.isCollapsed = !this.isCollapsed;
  }
}
