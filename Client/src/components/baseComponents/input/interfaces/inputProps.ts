import type {InputType} from "@/components/baseComponents/input/interfaces/inputType.ts";

export interface InputProps {
    isError?: boolean;
    isSuccess?: boolean;
    label: string;
    type?: InputType;
    name: string;
    helperText?: string;
    validationMessage?: string;
}