import { registerLocaleData } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import zh from '@angular/common/locales/zh';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { ComponentModule } from '../component';
import { AppRoutingModule } from './app-route.routing';
import { IconsProviderModule } from './icons-provider.module';
import { LayoutComponent } from './layout/layout.component';

registerLocaleData(zh);

@NgModule({
   declarations: [
      LayoutComponent
   ],
   imports: [
      BrowserModule,
      AppRoutingModule,
      IconsProviderModule,
      FormsModule,
      HttpClientModule,
      BrowserAnimationsModule,
      ComponentModule
   ],
   providers: [],
   bootstrap: [
      LayoutComponent
   ]
})
export class AppModule { }
