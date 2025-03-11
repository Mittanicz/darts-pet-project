import { createApp } from 'vue'
import { createPinia } from 'pinia'

import App from './App.vue'
import router from './app/router'

import MainNav from "@/app/layout/MainNav.vue";
import {DButton} from "@/components/baseComponents";

const app = createApp(App)

app.use(createPinia())
app.use(router)

import "@/styles/styles.scss"

app.component('d-main-nav', MainNav).component("d-button", DButton);

app.mount('#app');
