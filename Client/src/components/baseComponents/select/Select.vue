<template>
    <div :class="formElementClasses">
        <label class="c-label">
            {{ props.label }}
        </label>
        <div class="c-formElement__wrapper" @click="isOpen = !isOpen">
            <div class="c-select__displayValue">
                {{ displayValue }}
            </div>
            <select v-model="modelValue" v-if="false" class="c-select__input">
                <option v-for="(item) in props.items" :value="item.value" :index="item.value">
                    {{ item.value }}
                </option>
            </select>
            <div class="c-formElement__icon">
                <svg xmlns="http://www.w3.org/2000/svg" width="24" height="24" viewBox="0 0 24 24"><path fill="currentColor" d="M8.12 9.29L12 13.17l3.88-3.88a.996.996 0 1 1 1.41 1.41l-4.59 4.59a.996.996 0 0 1-1.41 0L6.7 10.7a.996.996 0 0 1 0-1.41c.39-.38 1.03-.39 1.42 0"/></svg>
            </div>
        </div>
        <span v-if="props.helperText" class="c-formElement__helperText">{{ props.helperText }}</span>
        <span v-if="props.validationMessage" class="c-formElement__validationMessage">{{ props.validationMessage }}</span>
        <ul class="c-select__list">
            <li class="c-select__item" v-for="(item, index) in props.items" :index="item.value" @click="pickValue(index)">
                {{ item.label }}
            </li>
        </ul>
    </div>
</template>

<script lang="ts" setup>

import {computed, ref} from "vue";
import type {SelectProps} from "@/components/baseComponents/select/interfaces/selectProps.ts";

const props = defineProps<SelectProps>()

const modelValue = defineModel()

const isOpen = ref<boolean>(false)

const formElementClasses = computed(() => {
    return {
        "c-formElement": true,
        "is-error": props.validationMessage || props.isError,
        "is-success": props.isSuccess,
        "is-open": isOpen.value,
    }
})

const displayValue = computed(() => {
    return props.items.find(item => item.value === modelValue.value)?.label;
})

function pickValue(index: number) {
    modelValue.value = props.items[index].value;
    isOpen.value = false;
}

</script>