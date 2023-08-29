import { HttpErrorResponse } from '@angular/common/http';
import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class ErrorHandlerService {

  constructor() {
  }

  handleError(err: HttpErrorResponse, actionText: string = 'ok') {
  //   if (typeof err.error == 'object' && err.error !== null) {

  //     // const error: CustomException = err.error;

  //     const message: string = (err.error && err.error.Message) || 'Error has occurred';

  //     // const panelClass = ErrorHandlerService.getPanelClass(error.type);
  //     const panelClass = ErrorHandlerService.getPanelClass(err.error.Type);

  //     const snackbarOptions: MatSnackBarConfig = {
  //       // duration: error.duration || 4000,
  //       duration: err.error.Duration || 4000,
  //       panelClass,
  //       politeness: 'polite',
  //     };

  //     return this.snackbar.open(message || 'Error has occurred', actionText, snackbarOptions);
  //   } else {
  //     return this.snackbar.open('Error has occurred', actionText, {
  //       panelClass: 'custom-snackbar-error',
  //       politeness: 'assertive',
  //       duration: 4000
  //     });
  //   }
  // }

  // private static getPanelClass(type: ExceptionTypeEnum | undefined) {
  //   if (type === ExceptionTypeEnum.Error) {
  //     return 'custom-snackbar-error';
  //   } else if (type === ExceptionTypeEnum.Warning) {
  //     return '.custom-snackbar-warning';
  //   }

  //   return ''
  }
}
