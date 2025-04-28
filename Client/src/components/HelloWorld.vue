<template>
    <nav class="asd"></nav>
  <div class="greetings">
    <h1 class="green">{{ msg }}</h1>
        <d-button label="Apple" @click="jablko = jablko + 1" />
        <d-button secondary @click="banan = banan + 2" label="Bananaaaa" />
        Hodnota jablka: {{jablko}}
      Hodnota bananu: {{banan}}

      All fruits: {{allFruits}}
      <div style="width: 300px">
          <d-input v-model="inputValue" label="Test label" name="test" />
          {{ inputValue }}
      </div>
      <div style="width: 300px">
          <div class="c-entityBox">
              <div class="c-entityBox__label">
                  USER
              </div>
              <div class="c-entityBox__rightSlot">
                  <span>
                  X
                  </span>
                  <span>
                    X
                  </span>
                  <span>
                    X
                  </span>
              </div>
          </div>
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
const inputValue = ref<string>("dupa")

const allFruits = computed(() => {
    return jablko.value + banan.value;
})
</script>