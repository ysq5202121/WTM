import { Injectable, inject, InjectionToken } from '@angular/core';
import { HttpClient } from '@angular/common/http';
export const APP_CONFIG = new InjectionToken<any>('app.config');
@Injectable()
export class HttpService {
  constructor(private Http: HttpClient) {
    console.log("TCL: HttpService -> constructor -> Http", this)
  }
  PageConfig: PageConfig;
  onInit(PageConfig: PageConfig) {
    this.PageConfig = { ...this.PageConfig, ...PageConfig };
    return this;
  }
  async onTest() {
    const res = await this.Http.post('/api/_frameworkrole/search', { "SortInfo": "", "Page": 1, "Limit": 50 }).toPromise();
    console.log("TCL: HttpService -> onTest -> res", res)
  }
}
// export const HttpServiceFactory = (config: any, Http: HttpClient) => {
//   return new HttpService(config, Http);
// }
declare type PageConfig = {
  target?: string;
  apiSearch?: string;
}