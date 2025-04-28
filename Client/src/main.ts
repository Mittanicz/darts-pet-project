import { createApp } from 'vue'
import { createPinia } from 'pinia'

import App from './App.vue'
import router from './app/router'

import MainNav from "@/app/layout/MainNav.vue";
import {DButton, DInput, DEntityBox, DSelect} from "@/components/baseComponents";

const app = createApp(App)

app.use(createPinia())
app.use(router)

import "@/styles/styles.scss"

app.component('d-main-nav', MainNav).component("d-button", DButton).component("d-select", DSelect).component("d-input", DInput).component("d-entity-box", DEntityBox);

app.mount('#app');
