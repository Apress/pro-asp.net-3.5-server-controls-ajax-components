// Title: Pro ASP.NET 3.5 Server Controls and AJAX Components
//
// Chapter: 11 - Design-Time Support
// File: SimpleTextEditor.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace ControlsBook2Lib.Ch11.Design
{
   public class SimpleTextEditor : UITypeEditor
   {     
      public override UITypeEditorEditStyle GetEditStyle(
         ITypeDescriptorContext context)
      {
         if (null != context)
         {
            return UITypeEditorEditStyle.Modal;
         }
         return base.GetEditStyle(context);
      }

      public override object EditValue(ITypeDescriptorContext context,
         IServiceProvider serviceProvider, object value)
      {
         if ((null  != context) && (null  != serviceProvider))
         {
            IWindowsFormsEditorService editorService =
               (IWindowsFormsEditorService)serviceProvider.GetService(
               typeof(IWindowsFormsEditorService));

            if (null != editorService)
            {
               SimpleTextEditorDialog formEditor = new SimpleTextEditorDialog();
               formEditor.TextValue = (string)value;

               DialogResult DlgResult = editorService.ShowDialog(formEditor);
               if (DialogResult.OK == DlgResult)
               {
                  value = formEditor.TextValue;
               }
            }
         }
         return value;
      }
   }
}