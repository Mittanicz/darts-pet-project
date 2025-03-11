<template>
    <button :class="buttonClasses">{{ props.label }}</button>
</template>
<script setup lang="ts">
import {computed} from "vue";
import type {ButtonProps} from "./interfaces";

const props = defineProps<ButtonProps>()

const buttonClasses = computed(() => {
    return {
        "c-button": true,
        "c-button--secondary": props.secondary
    }
})
</script>
