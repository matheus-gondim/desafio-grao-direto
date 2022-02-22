import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { SignIn } from 'src/app/models/sign-in';
import { AuthService } from 'src/app/services/auth.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.page.html',
  styleUrls: ['./login.page.scss'],
})
export class LoginPage implements OnInit {
  validPasswordRegex = /(?=.*\d)(?=.*\W+)(?![.\n])(?=.*[A-Z])(?=.*[a-z]).*$/;
  isActiveToggleTextPassword: Boolean = true;
  form: FormGroup
  signIn: SignIn
  
  constructor(
    private readonly router: Router,
    private readonly formBuilder: FormBuilder,
    private readonly authService: AuthService,
  ) { }

  ngOnInit() {
    this.form = this.createForm()
  }

  async login() {
    this.signIn = {
      email: this.form.get('email').value,
      password: this.form.get('password').value
    }
    this.authService.signIn(this.signIn)
    .subscribe(
      (value) => {
        this.authService.showMessage(value.message);
        this.router.navigate(['/home']);
      },
      ({error}) => {
        this.authService.showMessage(error.Messages[0]);
      }
    )
  }

  showPassword(): any {
    this.isActiveToggleTextPassword = !this.isActiveToggleTextPassword
  }

  public getType() {
    return this.isActiveToggleTextPassword ? 'password' : 'text';
  }

  createForm(): FormGroup {
    return this.formBuilder.group({
        email:['', [Validators.required, Validators.email]],
        password: ['', [Validators.required, Validators.pattern(this.validPasswordRegex)]],
    })
  }
}
