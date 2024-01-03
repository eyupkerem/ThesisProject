﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cosupervisor_edit.aspx.cs" Inherits="ThesisProject.Cosupervisor.Cosupervisor_edit" %>




<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="../assets/style.css">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

</head>
<body>

    <div id="wrapper" class="toggled">

        <!-- Sidebar -->
        <div id="sidebar-wrapper" class="sidebarWrapper">
            <ul class="sidebar-nav">
                <li class="sidebar-brand">
                    <a href="#">
                        Start Bootstrap
                    </a>
                </li>
                <li>
                    <a href="#">Dashboard</a>
                </li>
                <li>
                    <a href="#">Shortcuts</a>
                </li>
                <li>
                    <a href="#">Overview</a>
                </li>
                <li>
                    <a href="#">Events</a>
                </li>
                <li>
                    <a href="#">About</a>
                </li>
                <li>
                    <a href="#">Services</a>
                </li>
                <li>
                    <a href="#">Contact</a>
                </li>
            </ul>
        </div>
        <!-- /#sidebar-wrapper -->
        <!-- Page Content -->
        <div class="title">Graduate Thesis System</div>
        <div id="page-content-wrapper">
            <div class="container-fluid">
                   <form id="form1" runat="server">
                       <div class="form-group" >
                        <asp:TextBox runat="server" ID="txtCosupervisorName" CssClass="form-control" placeHolder="Cosupervisor Name" />                       
                        <label for="Cosupervisor LastName"></label>
                        <asp:TextBox runat="server" ID="txtCosupervisorSurname" CssClass="form-control" placeHolder="Cosupervisor Surname" />                      
                        <label for="Cosupervisor Phone Number"></label>
                        <asp:TextBox runat="server" ID="txtCosupervisorPhoneNumber" CssClass="form-control" placeHolder="Cosupervisor Phone Number" />                     
                        <label for="Cosupervisor Email"></label>
                        <asp:TextBox runat="server" ID="txtCosupervisorEmail" CssClass="form-control" placeHolder="Email" />
                       </div>
                        <asp:Button Text="Edit" ID="btnKaydet" runat="server" CssClass="btn btn-success" OnClick="btnKaydet_Click"/>
                        <a href="/Cosupervisor/Cosupervisor_list.aspx" class="btn btn-danger">Cancel</a>

                   </form>
            </div>    
        </div>
        <!-- /#page-content-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- Menu Toggle Script -->


     <script src="./index.js"></script>
</body>
</html>











