let debounceHandle = null;

export function registerDebounce(dotNetRef, delay) {
    return {
        onInput: (value) => {
            if (debounceHandle) {
                clearTimeout(debounceHandle);
            }
            debounceHandle = setTimeout(() => {
                dotNetRef.invokeMethodAsync("OnDebouncedInput", value);
            }, delay);
        },
        dispose: () => {
            if (debounceHandle) {
                clearTimeout(debounceHandle);
            }
        }
    };
}
