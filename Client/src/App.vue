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
    <nav class="l-mainNav">
        <a href="" class="l-mainNav__button">
            <i>X</i>
            Sprava uzivatelu
        </a>
        <a href="" class="l-mainNav__button l-mainNav__button--cta">
            S
        </a>
        <a href="" class="l-mainNav__button">
            H
        </a>
    </nav>
</template>
<script setup lang="ts">
import { RouterLink, RouterView } from 'vue-router'
import HelloWorld from './components/HelloWorld.vue'
</script>
