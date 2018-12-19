<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/Admin_MasterPage.master" AutoEventWireup="true" CodeFile="Add_program.aspx.cs" Inherits="Admin_Add_program" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    
    <div class="container">
      <div class="card card-register mx-auto mt-5">
        <div class="card-header">Add a program</div>
        <div class="card-body">
     <form runat="server">
            
            <div class="form-group">
              <div class="form-label-group">
         <asp:TextBox ID="pgmname"  runat="server" class="form-control" placeholder="Program name" required="required"></asp:TextBox>
                
                
              </div>
            </div>
            <div class="form-group">
              <div class="form-row">
                <div class="col-md-6">
                  <div class="form-label-group">
             <asp:TextBox ID="TextBox1" runat="server" class="form-control"></asp:TextBox>
                    
                   
                  </div>
                </div>
                <div class="col-md-6">
                  <div class="form-label-group">
                    <input type="password" id="confirmPassword" class="form-control" placeholder="Confirm password" required="required">
                    <label for="confirmPassword">Confirm password</label>
                  </div>
                </div>
              </div>
            </div>
            <a class="btn btn-primary btn-block" href="login.html">Register</a>
          </form>
            </div>
          </div>
        </div>
    
</asp:Content>

