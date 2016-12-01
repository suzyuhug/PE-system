<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Rework.aspx.cs" Inherits="Rework" MasterPageFile="~/Site.master" %>

<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">
    <div style="height: 676px">
        <h2>维修登记</h2>
            <section id="loginForm">
                <div class="form-horizontal">
                    <h4>登记所有系统信息</h4>
                    <hr />
                    <asp:PlaceHolder runat="server" ID="ErrorMessage" Visible="false">
                        <p class="text-danger">
                            <asp:Literal runat="server" ID="FailureText" />
                        </p>
                    </asp:PlaceHolder>
                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label" ID="Label1">SerialNumber:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="UserName" CssClass="form-control" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="“SerialNumber”字段是必填字段。" ID="RequiredFieldValidator1" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label" ID="Label3">Station:</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="DropDownList1" runat="server" CssClass="table-responsive" Height="35px" Width="1278px">
                            </asp:DropDownList>
                            <br />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="“Station”字段是必选字段。" ID="RequiredFieldValidator3" />
                        </div>
                    </div>


                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="UserName" CssClass="col-md-2 control-label" ID="Label4">Buyoff:</asp:Label>
                        <div class="col-md-10">
                            <asp:DropDownList ID="DropDownList2" runat="server" CssClass="table-responsive" style=" height: 35px" Width="1278px">
                            </asp:DropDownList>
                            <br />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="UserName"
                                CssClass="text-danger" ErrorMessage="“Buyoff”字段是必选字段。" ID="RequiredFieldValidator4" />
                        </div>
                    </div>

                    <div class="form-group">
                        <asp:Label runat="server" AssociatedControlID="Password" CssClass="col-md-2 control-label" ID="Label2">Description:</asp:Label>
                        <div class="col-md-10">
                            <asp:TextBox runat="server" ID="Password" TextMode="MultiLine" CssClass="form-control" Height="86px" />
                            <asp:RequiredFieldValidator runat="server" ControlToValidate="Password" CssClass="text-danger" ErrorMessage="“Description”字段是必填字段。" ID="RequiredFieldValidator2" />
                        </div>
                    </div>
                    <div class="form-group">
                        <div class="col-md-offset-2 col-md-10">
                            <asp:Button ID="Button1" runat="server" Text="保  存" Width="80px" CssClass="btn btn-default" OnClick="Button1_Click" />
                        </div>
                    </div>
                </div>
            </section>
        <p>&nbsp;</p>

    </div>
</asp:Content>


