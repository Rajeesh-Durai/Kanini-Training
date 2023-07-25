import { AbstractControl, ValidationErrors } from '@angular/forms';

export function TempValidation(
  control: AbstractControl
): ValidationErrors | null {
  let num = control.value;
  if (isNaN(num)) {
    return { tempcheck: true };
  }
  return null;
}
