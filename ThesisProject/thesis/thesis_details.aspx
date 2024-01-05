<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="thesis_details.aspx.cs" Inherits="ThesisProject.thesis.thesis_details" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link href="../assets/thesis_details.css" rel="stylesheet" />
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-T3c6CoIi6uLrA9TneNEoa7RxnatzjcDSCmG1MXxSR1GAsXEV/Dwwykc2MPK8M2HN" crossorigin="anonymous">

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
             <div class="buttons">
               <a href="/thesis/thesis_list.aspx" role="button" class="btn btn-success">Back to Thesis List</a>
               <a href="../author/author_list.aspx" role="button" class="btn btn-success">Back to Author List</a>
               <a href="../university/university_list.aspx" role="button" class="btn btn-success">Back to University List</a>
               <a href="../supervisor/supervisor_list.aspx" role="button" class="btn btn-success">Back to Supervisor List</a>
               <a href="../Cosupervisor/Cosupervisor_list.aspx" role="button" class="btn btn-success">Back to Cosupervisor List</a>
               <a href="../languages/languages_list.aspx" role="button" class="btn btn-success">Back to Language List</a>
               <a href="../city/city_list.aspx" role="button" class="btn btn-success">Back to City List</a>
             </div>
            <h2 style="text-align:center">Thesis Detail </h2>

            <asp:Repeater runat="server" ID="thesisList">
                 <ItemTemplate>

                     <table class="table table-borderless">
                         <thead>    
                             <tr>
                                 <th> </th>
                                 <th> </th>
                                 <th> </th>
                             </tr>
                         </thead>
                         <tbody>
                             <tr>
                                 <td> <h4>Thesis number </h4>  </td>
                                 <td> <%# Eval("THESIS_ID") %></td>
                             </tr>
                             <tr>
                                 <td> <h4> Author Name</h4></td>
                                 <td><%# getAuthorName(Convert.ToInt32(Eval("AUTHORID"))) %> </td>
                             </tr>
                             <tr>
                                 <td> <h4>Supervisor Name </h4> </td>
                                 <td> <%#getSupervisorName(Convert.ToInt32(Eval("SUPERVISORID"))) %> </td>
                             </tr>
                             <tr>
                                 <td> <h4>Cosupervisor Name </h4>  </td>
                                 <td> <%#getCoSupervisorName(Convert.ToInt32(Eval("COSUPERVISORID"))) %></td>
                             </tr>
                             <tr>
                                 <td> <h4>University Name </h4> </td>
                                 <td> <%# getUniversityName(Convert.ToInt32(Eval("UNIVERSITYID"))) %></td>
                             </tr>
                             <tr>
                                 <td> <h4>Instutue</h4</td>
                                 <td> <%# getInstutes(Convert.ToInt32(Eval("INSTUTUESID"))) %></td>
                             </tr>
                             <tr>
                                 <td> <h4>Language </h4> </td>
                                 <td>  <%# getLanguage(Convert.ToInt32(Eval("LANGUAGE_ID"))) %> </td>
                             </tr>
                             <tr>
                                 <td> <h4> Type</h4>  </td>
                                 <td> <%# getType(Convert.ToInt32(Eval("TYPES_ID"))) %> </td>
                             </tr>
                             <tr>
                                 <td> <h4> Keyword</h4>  </td>
                                 <td>   <%# getKeyword(Convert.ToInt32(Eval("KEYWORD_ID"))) %></td>
                             </tr>
                             <tr>
                                 <td> <h4>Page Number</h4>  </td>
                                 <td>  <%# Eval("PAGENUM") %> </td>
                             </tr>
                             <tr>
                                 <td> <h4>Abstarct</h4>  </td>
                                 <td>  <%# Eval("ABSTRACT") %> </td>
                             </tr>
                             <tr>
                                 <td> <h4>Year</h4></td>
                                 <td> <%# Eval("YEAR_") %> </td>
                             </tr>
                             <tr>
                                 <td> <h4>Submission Date</h4>  </td>
                                 <td> <%# Eval("SUBDATE") %></td>
                             </tr>

                         </tbody>
                     </table>


  

 
                 </ItemTemplate>
         </asp:Repeater>

        </div>
    </form>
</body>
</html>
