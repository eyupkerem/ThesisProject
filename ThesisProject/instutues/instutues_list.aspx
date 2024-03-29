﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="instutues_list.aspx.cs" Inherits="ThesisProject.instutues.instutues_list" %>

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
                       Thesis 
                    </a>
                </li>
                <li>
                    <a href="../author/author_list.aspx">Authors</a>
                </li>
                <li>
                    <a href="../city/city_list.aspx">Cities</a>
                </li>
                <li>
                    <a href="../Cosupervisor/Cosupervisor_list.aspx">Cosupervisors</a>
                </li>
                <li>
                    <a href="../instutues/instutues_list.aspx">Instutues</a>
                </li>
                <li>
                    <a href="../keywords/keywords_list.aspx">Keywords</a>
                </li>
                <li>
                    <a href="../languages/languages_list.aspx">Languages</a>
                </li>
                <li>
                    <a href="../supervisor/supervisor_list.aspx">Supervisors</a>
                </li> 
                <li>
                    <a href="../thesis/thesis_list.aspx">Thesis</a>
                </li>  
                <li>
                    <a href="../types/types_list.aspx">Types</a>
                </li>   
                <li>
                    <a href="/university/university_list">Universities</a>
                </li>
            </ul>
        </div>
        <!-- /#sidebar-wrapper -->
        <!-- Page Content -->
        <div class="title">Graduate Thesis System</div>
        <div id="page-content-wrapper">
            <div class="container-fluid">
                    <form id="form2" runat="server">
                        <table class="table table-bordered table-hover">
                          <thead>
         <tr>
             <td>Instutues ID</td>
             <td>Instutues Name</td>
             <td>Operations</td>
         </tr>
     </thead>
     <tbody>
         <asp:Repeater runat="server" ID="instutuesList">
          <ItemTemplate>
              <tr>
                  <td><%# Eval("INSTUTUESID")%></td>
                  <td><%# Eval("INSTUTUES_NAME")%></td>
                  <td>
                     <asp:HyperLink NavigateUrl='<%# "instutues_delete.aspx?id=" + Eval("INSTUTUESID") %>' runat="server" CssClass="btn btn-danger">Delete</asp:HyperLink>
                     <asp:HyperLink NavigateUrl='<%# "instutues_edit.aspx?id=" + Eval("INSTUTUESID") %>' runat="server" CssClass="btn btn-success">Edit</asp:HyperLink>
                  </td>
              </tr>
          </ItemTemplate>
         </asp:Repeater>
     </tbody>
 </table>
                        <a href="instutues_add.aspx" role="button" class="btn btn-success">Add Instutes</a>
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







