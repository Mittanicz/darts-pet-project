<template>
  <header>
    <img alt="Vue logo" class="logo" src="@/assets/logo.svg" width="125" height="125" />

    <div class="wrapper">
      <HelloWorld msg="You did it!" />

      <nav>
        <RouterLink to="/">Home</RouterLink>
        <RouterLink to="/about">About</RouterLink>
      </nav>
    </div>
  </header>
  <RouterView />
    <d-main-nav> </d-main-nav>
</template>
<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import { Icon } from '@iconify/vue';

import HelloWorld from './components/HelloWorld.vue'
</script>
