<template>
    <div :class="formElementClasses">
        <label :for="props.name" class="c-label">
            {{ props.label }}
        </label>
        <div class="c-formElement__wrapper">
            <input v-model="modelValue" :id="props.name" :name="props.name" class="c-input" :type="props.type">
            <div class="c-formElement__icon">
                <slot name="icon"></slot>
            </div>
        </div>
        <span v-if="props.helperText" class="c-formElement__helperText">{{ props.helperText }}</span>
        <span v-if="props.validationMessage" class="c-formElement__validationMessage">{{ props.validationMessage }}</span>
    </div>
</template>

<script setup lang="ts">

import type {InputProps} from "@/components/baseComponents/input/interfaces";
import {computed} from "vue";

const props = withDefaults(defineProps<InputProps>(), {
    type: "text",
});

const modelValue = defineModel()

const formElementClasses = computed(() => {
    return {
        "c-formElement": true,
        "is-error": props.validationMessage || props.isError,
        "is-success": props.isSuccess
    }
})
</script>