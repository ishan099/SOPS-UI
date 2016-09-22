<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="processingOrder.aspx.cs" Inherits="OnlineOrderSystem.processingOrder" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
                            <tbody id="tablePro_id">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>
</asp:Content>
