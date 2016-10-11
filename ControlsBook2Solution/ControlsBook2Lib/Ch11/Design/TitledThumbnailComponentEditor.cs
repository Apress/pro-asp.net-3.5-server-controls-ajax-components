// Title: Building ASP.NET Server Controls
//
// Chapter: 11 - Design-Time Support
// File: TitledThumbnailComponentEditor.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright � 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControlsBook2Lib.Ch11.Design
{
   public class TitledThumbnailComponentEditor : WindowsFormsComponentEditor 
   {
      public override bool EditComponent(ITypeDescriptorContext context, object component, IWin32Window parent) 
      {  
         if ( !(component is TitledThumbnail) )
         {
            throw new ArgumentException("Must be a TitledThumbnail component", "component");
         }

         IServiceProvider serviceProviderSite =  ((TitledThumbnail)component).Site;
         IComponentChangeService changeSrvc = null;

         DesignerTransaction trans = null;
         bool changed = false;

         try 
         {
            if (null != serviceProviderSite) 
            {
               IDesignerHost designerHost = (IDesignerHost)serviceProviderSite.GetService(typeof(IDesignerHost));
               trans = designerHost.CreateTransaction("Property Builder");

               changeSrvc = (IComponentChangeService)serviceProviderSite.GetService(typeof(IComponentChangeService));
               if (null  != changeSrvc) 
               {
                  try 
                  {
                     changeSrvc.OnComponentChanging( (TitledThumbnail)component, null);
                  }
                  catch (CheckoutException err) 
                  {
                     if (err == CheckoutException.Canceled)
                        return false;
                     throw err;
                  }
               }
            }

            try 
            {
               TitledThumbnailComponentEditorDlg propertyBuilderForm = 
                           new TitledThumbnailComponentEditorDlg( (TitledThumbnail)component);
               if (propertyBuilderForm.ShowDialog(parent) == DialogResult.OK) 
               {
                  changed = true;
               }
            }
            finally 
            {
               if (changed && (null != changeSrvc)) 
               {
                  changeSrvc.OnComponentChanged( (TitledThumbnail)component, null, null, null);
               }
            }
         }
         finally 
         {
            if (trans != null) 
            {
               if (changed) 
               {
                  trans.Commit();
               }
               else 
               {
                  trans.Cancel();
               }
            }
         }
         return changed;
      }
   }
}