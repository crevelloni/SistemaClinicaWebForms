<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="GestionarPaciente.aspx.cs" Inherits="SistemaClinicaWebForms.frmGestionarPaciente" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1 style="text-align: center">Cadastro de pacientes </h1>      
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>RG</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="txtRG" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>NOME</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextNome" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>SOBRENOME PAI</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextPai" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>SOBRENOME MÃE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextMae" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-body">
                        <div class="form-group">
                            <label>SEXO</label>
                        </div>
                        <div class="form-group">
                            <asp:DropDownList ID="ddlSexo" runat="server" CssClass="form-control"></asp:DropDownList>
                        </div>
                        <div class="form-group">
                            <label>IDADE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextIdade" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>TELEFONE</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextTel" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                        <div class="form-group">
                            <label>ENDEREÇO</label>
                        </div>
                        <div class="form-group">
                            <asp:TextBox ID="TextEnder" runat="server" Text="" CssClass="form-control"></asp:TextBox>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div style="text-align: center">
            <table>
                <tr>
                    <td>
                        <asp:Button ID="btnCadastrar" runat="server" CssClass="btn btn-primary" Text="Cadastrar" />
                    </td>
                    <td>&nbsp;&nbsp;&nbsp;&nbsp;</td>
                    <td>
                        <asp:Button ID="btnCancelar" runat="server" CssClass="btn btn-danger" Text="Cancelar" />
                    </td>
                </tr>
            </table>
        </div>
    </section>
</asp:Content>
