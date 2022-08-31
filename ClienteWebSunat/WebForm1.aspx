<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="ClienteWebSunat.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<style>
    #Panel2{
    display: grid;
         height: 35px;
         background-color: coral;
         justify-content: space-between;
       top:10px;
       position:fixed;
       width:737px;
      }
    #Buscar {
            top:160px;
       position:fixed;
       left :720px;
         }
    #TextBuscar {
       top:100px;
       position:fixed;
       left :450px;
        height: 27px;
        width: 654px;
    }
    header{

         height: 30px;
     top: 0;
        left 200px;

    }
    #cbBuscar {
    top:60px;
       position:fixed;
       left :450px;
       }
    #Label2 {
    top:220px;
       position:fixed;
       left :450px;
    
    }
      #lblRUC{
    top:220px;
       position:fixed;
       left :750px;
    }
  #Label3 {
    top:250px;
       position:fixed;
       left :450px;
    
    }
    #lblRazonSocial{
    top:250px;
       position:fixed;
       left :750px;
    }
   #Label4 {
    top:280px;
       position:fixed;
       left :450px;
    }
     #lblTipoContrib{
    top:280px;
       position:fixed;
       left :750px;
    }
     #Label5 {
    top:310px;
       position:fixed;
       left :450px;
    }
       #lblNombreComercial{
    top:310px;
       position:fixed;
       left :750px;
    }
       #Label6{
    top:340px;
       position:fixed;
       left :450px;
    }
         #lblFechaIncripcion{
    top:340px;
       position:fixed;
       left :750px;
    }
        #Label7{
    top:370px;
       position:fixed;
       left :450px;
    }
          #lblFechaInicioAct{
    top:370px;
       position:fixed;
       left :750px;
    }
         #Label8{
    top:400px;
       position:fixed;
       left :450px;
    }
           #lblEstado{
    top:400px;
       position:fixed;
       left :750px;
    }
          #Label9{
    top:430px;
       position:fixed;
       left :450px;
    }
            #lblCondicion{
    top:430px;
       position:fixed;
       left :750px;
    }
             #Label10{
    top:460px;
       position:fixed;
       left :450px;
    }
           #lblDomicilio{
    top:460px;
       position:fixed;
       left :750px;
    }
</style>
<body>
    <header>
        <asp:Label Text="Sunat" runat="server" />
    </header>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:Panel ID="Panel1" runat="server" BackColor="#CCCCFF" Height="483px" style="margin-left: 413px" Width="738px">
            
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Panel ID="Panel2" runat="server" HorizontalAlign="Center">
                <asp:Label ID="Label1" runat="server" Text="Busqueda por Criterio "></asp:Label>
            </asp:Panel>
            <asp:Button ID="Buscar" Text="Buscar " runat="server" Height="37px" Width="120px" OnClick="Buscar_Click" />
                        
            <asp:TextBox ID="TextBuscar" runat="server"></asp:TextBox>
                        
            <asp:DropDownList ID="cbBuscar" runat="server">
                <asp:ListItem>RUC</asp:ListItem>
                <asp:ListItem>Empresa</asp:ListItem>
            </asp:DropDownList>
                        
            <asp:Label ID="Label2" runat="server" Text="Numero de Ruc :"></asp:Label>
                        
            <asp:Label ID="Label3" runat="server" Text="Razon Social :"></asp:Label>

                        
            <asp:Label ID="Label4" runat="server" Text="Tipo de contribuyente :"></asp:Label>

                        
            <asp:Label ID="Label5" runat="server" Text="Nombre Comercial :"></asp:Label>

                        
            <asp:Label ID="Label6" runat="server" Text="Fecha de Incripcion: "></asp:Label>

                        
            <asp:Label ID="Label7" runat="server" Text="Fecha de inicio de actividades"></asp:Label>

                        
            <asp:Label ID="Label8" runat="server" Text="Estado :"></asp:Label>

                        
            <asp:Label ID="Label9" runat="server" Text="Condicion :"></asp:Label>

                        
            <asp:Label ID="Label10" runat="server" Text="Domicilio :"></asp:Label>
                                   
            <asp:Label ID="lblRUC" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblRazonSocial" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblTipoContrib" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblNombreComercial" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblFechaIncripcion" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblFechaInicioAct" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblEstado" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblCondicion" runat="server" Text="Label"></asp:Label>
            <asp:Label ID="lblDomicilio" runat="server" Text="Label"></asp:Label>
                        
            </asp:Panel>

        <asp:GridView ID="gvEmpresa" runat="server" Visible="False"></asp:GridView>
    </form>
</body>
</html>
