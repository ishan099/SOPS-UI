<%@ Page Title="" Language="C#" MasterPageFile="~/main.Master" AutoEventWireup="true" CodeBehind="pendingOrders.aspx.cs" Inherits="OnlineOrderSystem.pendingOrders" %>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

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
                            <tbody id="table_id">
                            </tbody>
                        </table>
                    </div>
                </div>
            </div>
        </div>

        <!-- view more  pending details -->
        <!-- Modal -->
        <div class="modal fade" id="myModal" tabindex="-1" role="dialog" aria-labelledby="myModalLabel">
            <div class="modal-dialog" role="document">
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                            <span aria-hidden="true">&times;</span></button>
                        <h4 class="modal-title" >Order Details</h4>
                    </div>
                    <div class="modal-body">
                        <div  class="row">
                            <div class="col-lg-12">
                                <div class="col-md-4 text-left">Order Id</div>
                                 <div class="col-md-8 text-left" id="orderId"> </div>

                            </div>
                        </div>

                        <div  class="row">
                            <div class="col-lg-12">
                                <div class="col-md-4 text-left">
                                    Customer Name
                                </div>
                                 <div class="col-md-8 text-left" id="customerName"></div>

                            </div>
                        </div>

                        <div class="row order-details-wrapper">
                            <table class="table table-hover">
                            <thead>
                                <tr>
                                    <th>Item Name</th>
                                    <th>Item Code</th>
                                    <th>Qty</th>
                                    <th>Unit Price</th>
                                    <th>value</th>
                                </tr>
                            </thead>
                            <tbody id="OrderView_id">
                            </tbody>
                        </table>
                        </div>
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-block btn-primary">Send to Process</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
