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
          <d-select label="Select" name="select" :items="selectItems" />
          <d-entity-box label="ADMIN">
              <Icon icon="material-symbols:home-rounded" />
          </d-entity-box>
      </div>
  </div>
</template>
<script setup lang="ts">

import {computed, ref} from "vue";
import {Icon} from "@iconify/vue";
import DSelect from "@/components/baseComponents/select/Select.vue";

defineProps<{
    msg: string
}>()

let jablko = ref<number>(0);
let banan = ref<number>(0);
const inputValue = ref<string>("dupa")

const selectItems = [
    {
    label: "Apple",
    value: 1
    },
    {
        label: "Hruska",
        value: 2
    },
]

const allFruits = computed(() => {
    return jablko.value + banan.value;
})
</script>