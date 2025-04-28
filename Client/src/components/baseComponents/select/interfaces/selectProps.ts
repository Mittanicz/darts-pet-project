import type {SelectItem} from "@/components/baseComponents/select/interfaces/selectItem.ts";

export interface SelectProps {
    isError?: boolean;
    isSuccess?: boolean;
    label: string;
    name: string;
    helperText?: string;
    validationMessage?: string;
    items: SelectItem[];
}