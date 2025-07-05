
import { Component } from '@angular/core';
import { UserRegistration } from '../model/user-registration';
import { FormsModule } from '@angular/forms';
import { NgIf, JsonPipe } from '@angular/common'; 

@Component({
  selector: 'app-template-driven-registration',
  standalone: true,
  templateUrl: './template-driven-registration.html',
  imports: [FormsModule, NgIf, JsonPipe],
})
export class TemplateDrivenRegistration {
  user: UserRegistration = {
    fullName: '',
    email: '',
    gender: '',
    country: '',
    agreeToTerms: false
  };

  submittedData: UserRegistration | null = null;

  onSubmit(form: any) {
    if (form.valid) {
      this.submittedData = { ...this.user };
    }
  }
}
