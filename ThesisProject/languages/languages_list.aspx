﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="languages_list.aspx.cs" Inherits="ThesisProject.languages.languages__list" %>


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
              <form id="form2" runat="server">
                   <h3> Üniversite Listesi</h3>
                     <table class="table table-bordered table-hover">
                      <thead>
                         <tr>
                          <th>Id</th>
                          <th>Language</th>
                          </tr>
                     </thead>
                     <tbody>
                     <asp:Repeater runat="server" ID="languagesList">
                  <ItemTemplate>
                  <tr>
                   <td><%# Eval("LANGUAGE_ID") %></td>
                   <td><%# Eval("LANGUAGE_") %></td>
                   <td>
                       <asp:HyperLink NavigateUrl='<%# "languages_delete.aspx?id=" + Eval("LANGUAGE_ID") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                  </td>
                 </tr>    
               </ItemTemplate>
           </asp:Repeater>
       </tbody>
   </table>

              </form>
                <a href="/languages/languages_add.aspx" role="button" class=" btn btn-success">Add Language</a>
            </div>    
        </div>
        <!-- /#page-content-wrapper -->

    </div>
    <!-- /#wrapper -->

    <!-- Menu Toggle Script -->


     <script src="./index.js"></script>
</body>
</html>




