// Title: Building ASP.NET Server Controls
//
// Chapter: 11 - Design-Time Support
// File: TitledThmbnailComponentEditorDlg.cs
// Written by: Rob Cameron and Dale Michalk
//
// Copyright © 2007, Apress L.P.
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace ControlsBook2Lib.Ch11.Design
{
  public partial class TitledThumbnailComponentEditorDlg : Form
  {
    private TitledThumbnail titledThumbnail;

    public TitledThumbnailComponentEditorDlg()
    {
      InitializeComponent();
    }

    public TitledThumbnailComponentEditorDlg(TitledThumbnail component)
    {
      InitializeComponent();

      titledThumbnail = component;

      PopulateAlignment();

      cboAlignment.Text = Enum.GetName(typeof(TitleAlignment), titledThumbnail.Align);
      textImageTitle.Text = titledThumbnail.Title;
      textLocation.Text = titledThumbnail.ImageInfo.ImageLocation.ToString();
      textPhotographerFullName.Text = titledThumbnail.ImageInfo.PhotographerFullName;
      dtpImageTaken.Value = titledThumbnail.ImageInfo.ImageDate;
      textLongImageDesc.Text = titledThumbnail.ImageInfo.ImageLongDescription;
    }

    private void PopulateAlignment()
    {
      foreach (object Align in Enum.GetValues(typeof(TitleAlignment)))
      {
        cboAlignment.Items.Add(Align);
      }
    }

    private void buttonOK_Click(object sender, System.EventArgs e)
    {
      PropertyDescriptorCollection properties =
         TypeDescriptor.GetProperties(titledThumbnail);

      PropertyDescriptor Title = properties["Title"];
      if (Title != null)
      {
        try
        {
          Title.SetValue(titledThumbnail, textImageTitle.Text);
        }
        catch (Exception err)
        {
          MessageBox.Show(this,
             "Problem setting title property: Source:" +
             err.Source + " Message: " + err.Message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }

      PropertyDescriptor alignment = properties["Align"];
      if (alignment != null)
      {
        try
        {
          alignment.SetValue(titledThumbnail, Enum.Parse(typeof(TitleAlignment), cboAlignment.Text));
        }
        catch (Exception err)
        {
          MessageBox.Show(this, "Problem setting align property: Source:" +
             err.Source + " Message: " + err.Message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }

      PropertyDescriptorCollection imageInfoProps =
         TypeDescriptor.GetProperties(titledThumbnail.ImageInfo);

      PropertyDescriptor imageDescription = imageInfoProps["ImageLongDescription"];
      if (imageDescription != null)
      {
        try
        {
          imageDescription.SetValue(titledThumbnail.ImageInfo, textLongImageDesc.Text);
        }
        catch (Exception err)
        {
          MessageBox.Show(this,
             "Problem setting image Long Description property: Source:" +
             err.Source + " Message: " + err.Message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }

      PropertyDescriptor imageDate = imageInfoProps["ImageDate"];
      if (imageDate != null)
      {
        try
        {
          imageDate.SetValue(titledThumbnail.ImageInfo, dtpImageTaken.Value);
        }
        catch (Exception err)
        {
          MessageBox.Show(this,
             "Problem setting image date property: Source:" + err.Source + " Message: "
             + err.Message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }

      PropertyDescriptor photographerFullName = imageInfoProps["PhotographerFullName"];
      if (photographerFullName != null)
      {
        try
        {
          photographerFullName.SetValue(titledThumbnail.ImageInfo, textPhotographerFullName.Text);
        }
        catch (Exception err)
        {
          MessageBox.Show(this,
             "Problem setting photographer's full name property: Source:" +
             err.Source + " Message: " + err.Message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }

      PropertyDescriptor imageLocation = imageInfoProps["ImageLocation"];
      if (imageLocation != null)
      {
        try
        {
          imageLocation.SetValue(titledThumbnail.ImageInfo, imageLocation.Converter.ConvertFrom(null, Application.CurrentCulture, textLocation.Text));
        }
        catch (Exception err)
        {
          MessageBox.Show(this,
             "Problem setting image location property: Source:" +
             err.Source + " Message: " + err.Message, "Error",
             MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
      }
    }
  }
}
