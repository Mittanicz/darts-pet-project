<template>
  <div class="greetings">
    <h1 class="green">{{ msg }}</h1>
    <h3>
      You’ve successfully created a project with
      <a href="https://vite.dev/" target="_blank" rel="noopener">Vite</a> +
      <a href="https://vuejs.org/" target="_blank" rel="noopener">Vue 3</a>. What's next?
    </h3>
        <d-button label="Apple" @click="jablko = jablko + 1" />
        <d-button secondary @click="banan = banan + 2" label="Bananaaaa" />
        Hodnota jablka: {{jablko}}
      Hodnota bananu: {{banan}}

      All fruits: {{allFruits}}
      <div class="c-formElement">
          <label for="name" class="c-label">Label</label>
          <div class="c-formElement__wrapper">
                <input id="name" name="name" class="c-input" type="text">
              <div class="c-formElement__icon">X</div>
          </div>
          <span class="c-formElement__helperText">Pomocna textace</span>
          <span class="c-formElement__validationMessage">Validacni hlaska</span>
      </div>
  </div>
</template>
<script setup lang="ts">

import {computed, ref} from "vue";

defineProps<{
    msg: string
}>()

let jablko = ref<number>(0);
let banan = ref<number>(0);

const allFruits = computed(() => {
    return jablko.value + banan.value;
})
</script>