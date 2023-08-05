<%@ Page Title="" Language="C#" MasterPageFile="~/Sport.Master" AutoEventWireup="true" CodeBehind="football.aspx.cs" Inherits="SportDemo.football" %>
<%--<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
      

     <!-- Required meta tags -->
     <meta charset="UTF-8"/>
        <meta http-equiv="X-UA-Compatible" content="IE=edge"/>
        <meta name="viewport" content="width=device-width, initial-scale=1.0"/>
        <title>PI</title>
     
        <link href="style.css" rel="stylesheet" />

</asp:Content>--%>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
     <div class="col-12 grid-margin stretch-card">
              <div class="card">
                <div class="card-body">
                  <h4 class="card-title">Basic Information(Football)</h4>

                  <form class="forms-sample">
                    <div class="form-group">
                      <label for="exampleInputNamef">Name</label>
                        <asp:TextBox ID="exampleInputNamef" runat="server" CssClass="form-control" placeholder="Name" ></asp:TextBox>
                     
                    </div>
                    <div class="form-group">
                      <label for="exampleInputEmaif">Email address</label>
                         <asp:TextBox ID="exampleInputEmailf" runat="server" CssClass="form-control" placeholder="Email" ></asp:TextBox>
                      </div>
                    <div class="form-group">
                      <label for="exampleInputPasswordf">Password</label>
                        <asp:TextBox ID="exampleInputPasswordf" runat="server" CssClass="form-control" TextMode="Password" placeholder="Password" ></asp:TextBox>
                        
                    </div>
                    <div class="form-group">
                      <label for="exampleSelectGender">Gender</label>
                        <asp:TextBox ID="exampleSelectGenderf" runat="server" CssClass="form-control" placeholder="Gender" ></asp:TextBox>
                        <select class="form-control" id="exampleSelectGender1">
                          <option>Male</option>
                          <option>Female</option>
                            </select>
                      </div>
                      <div class="form-group">
                        <label>Photo upload</label>
                         <asp ID="exampleSelectPhotof" runat="server" CssClass="form-control"></asp>
                        <div class="input-group col-xs-12">
                            <input type="file" class="form-control file-upload-info" placeholder="Upload Image">
                            <span class="input-group-append">
                                <button class="file-upload-browse btn btn-primary" type="button">Upload</button>
                            </span>
                        </div>
                    </div>
                  
                      <div class="form-group">
                      <label for="exampleInputCity">City</label>
                         <asp:TextBox ID="exampleInputCityf" runat="server" CssClass="form-control" placeholder="Location" ></asp:TextBox>
                  
                  <asp:Button ID="btnSubmit" runat="server" Text="Submit" CssClass="btn btn-primary mr-2" OnClick="btnSubmit_Click"/>
 <asp:Button ID="btnReset"  runat="server" Text="Reset" CssClass="btn btn-danger mr-2" OnClick="btnReset_Click"/>
                          </div>
                  </form>
                </div>
              </div>
            </div>
</asp:Content>
