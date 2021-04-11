import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { DigitalAssetListComponent } from './digital-asset-list/digital-asset-list.component';
import { DigitalAssetDetailComponent } from './digital-asset-detail/digital-asset-detail.component';
import { DigitalAssetEditorComponent } from './digital-asset-editor/digital-asset-editor.component';
import { SharedModule } from '@shared/shared.module';
import { FormsModule, ReactiveFormsModule } from '@angular/forms';
import { HttpClientModule } from '@angular/common/http';
import { DigitalAssetUploadModule } from './digital-asset-upload/digital-asset-upload.module';



@NgModule({
  declarations: [DigitalAssetListComponent, DigitalAssetDetailComponent, DigitalAssetEditorComponent],
  exports: [DigitalAssetListComponent],
  imports: [
    CommonModule,
    SharedModule,
    ReactiveFormsModule,
    FormsModule,
    HttpClientModule,
    DigitalAssetUploadModule
  ]
})
export class DigitalAssetsModule { }
