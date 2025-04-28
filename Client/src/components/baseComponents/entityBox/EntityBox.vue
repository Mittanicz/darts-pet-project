<template>
    <div class="c-entityBox">
        <div class="c-entityBox__label">
            {{ props.label }}
        </div>
        <div class="c-entityBox__rightSlot">
            <slot></slot>
        </div>
    </div>
</template>

<script lang="ts" setup>
import type {EntityBoxProps} from "@/components/baseComponents/entityBox/interfaces";

const props = defineProps<EntityBoxProps>()
</script>