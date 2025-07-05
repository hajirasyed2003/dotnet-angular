

import { Component } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { UserRegistration } from '../model/user-registration';
import { ReactiveFormsModule } from '@angular/forms';
import { NgIf, JsonPipe } from '@angular/common'; 

@Component({
  selector: 'app-reactive-registration',
  standalone: true,
  templateUrl: './reactive-registration.html',
  imports: [ReactiveFormsModule, NgIf, JsonPipe]
})
export class ReactiveRegistration {
  registrationForm: FormGroup;
  submittedData: UserRegistration | null = null;

  constructor(private fb: FormBuilder) {
    this.registrationForm = this.fb.group({
      fullName: ['', Validators.required],
      email: ['', [Validators.required, Validators.email]],
      gender: ['', Validators.required],
      country: ['', Validators.required],
      agreeToTerms: [false, Validators.requiredTrue]
    });
  }

  onSubmit() {
    if (this.registrationForm.valid) {
      this.submittedData = this.registrationForm.value;
    }
  }
}
