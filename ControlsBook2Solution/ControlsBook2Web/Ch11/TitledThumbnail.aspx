<%@ Page Language="C#" MasterPageFile="~/MasterPage/ControlsBook2MasterPage.Master"
    AutoEventWireup="true" CodeBehind="TitledThumbnail.aspx.cs" Inherits="ControlsBook2Web.Ch11.TitledThumbnail"
    Title="TitledThumbnail Demo" %>

<%@ Register TagPrefix="apress" Namespace="ControlsBook2Lib.Ch11" Assembly="ControlsBook2Lib" %>
<%@ Register Assembly="ControlsBook2Lib" Namespace="ControlsBook2Lib.Ch03" TagPrefix="cc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="HeadSection" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ChapterNumAndTitle" runat="server">
    <asp:Label ID="ChapterNumberLabel" runat="server" Width="14px">11</asp:Label>&nbsp;&nbsp;<asp:Label
        ID="ChapterTitleLabel" runat="server" Width="360px">Design-Time Support</asp:Label>
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="PrimaryContent" runat="server">
    <br />
    <apress:TitledThumbnail ID="TitledThumbnail1" Title="Clear Winter Day" runat="server"
        ImageInfo-PhotographerFullName="Robert Cameron" ImageInfo-ImageLongDescription="Winter outdoor scene in Februrary"
        ImageInfo-ImageDate="2007-02-06" ImageUrl="imgs/Outdoors.jpg" 
        ImageInfo-ImageLocation="31N,123W" Align="left">
    </apress:TitledThumbnail>
    <br />
    <apress:TitledThumbnail ID="Titledthumbnail2" Title="Lizard on the Prowl" runat="server"
        ImageInfo-PhotographerFullName="Rob Cameron" ImageInfo-ImageLongDescription="A lizard on the side of a wooden deck."
        ImageInfo-ImageDate="2007-08-08" ImageUrl="imgs/Lizard.jpg" ImageInfo-ImageLocation="32S,123E">
    </apress:TitledThumbnail>
    <br />
    <br />
</asp:Content>
