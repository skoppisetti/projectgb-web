import { NgModule } from '@angular/core';
import { MatCardModule } from '@angular/material/card';
import { MatChipsModule } from '@angular/material/chips';
import { MatButtonModule } from '@angular/material/button';
import { MatIconModule } from '@angular/material/icon'

@NgModule({
    exports: [
        MatCardModule,
        MatChipsModule,
        MatButtonModule,
        MatIconModule,
    ]
})
export class MaterialModule {}