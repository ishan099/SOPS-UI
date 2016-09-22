<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="completeOrder.aspx.cs" Inherits="OnlineOrderSystem.completeOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <div class="container">
        <div class="row">
            <div class="col-lg-12">
                <div class="order-main-wrapper">
                    <div >
                        <table class="table table-hover">
                            <thead>
                                <tr>
                                    <th>Order Id</th>
                                    <th>Customer Name</th>
                                    <th>Recived Date</th>
                                    <th></th>
                                </tr>
                            </thead>
                            <tbody id="tableComplete_id">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
