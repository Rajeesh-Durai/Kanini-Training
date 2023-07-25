import { platformBrowserDynamic } from '@angular/platform-browser-dynamic';

import { AppModule } from './app/app.module';
import { NavigationModule } from './app/navigation/navigation.module';

platformBrowserDynamic()
  .bootstrapModule(AppModule)
  .catch((err) => console.error(err));

platformBrowserDynamic()
  .bootstrapModule(NavigationModule)
  .catch((err) => console.error(err));
