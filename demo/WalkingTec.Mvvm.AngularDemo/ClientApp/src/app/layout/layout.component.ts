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
    if (!this.isCollapsed) {
      this.siderWidth = 250;
    }
  }
  siderWidth = 250;
  contentHeight = 200;
  id = -1;

  onSideResize({ width }: { width: number }): void {
    cancelAnimationFrame(this.id);
    if (width < 100 && !this.isCollapsed) {
      this.isCollapsed = true;
    }
    this.id = requestAnimationFrame(() => {
      this.siderWidth = width;
    });
  }
}
