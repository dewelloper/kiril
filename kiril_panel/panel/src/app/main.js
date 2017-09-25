"use strict";
Object.defineProperty(exports, "__esModule", { value: true });
const platform_browser_dynamic_1 = require("@angular/platform-browser-dynamic");
const i18n_providers_1 = require("./i18n-providers");
const app_module_1 = require("./app.module");
const core_1 = require("@angular/core");
core_1.enableProdMode();
//platformBrowserDynamic().bootstrapModule(AppModule);
i18n_providers_1.getTranslationProviders().then(providers => {
    const options = { providers };
    platform_browser_dynamic_1.platformBrowserDynamic().bootstrapModule(app_module_1.AppModule, options);
});
//# sourceMappingURL=main.js.map