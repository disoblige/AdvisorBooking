<%@ Page Title="" Language="C#" MasterPageFile="~/AdvisorBookingServiceMasterPage.master" AutoEventWireup="true" CodeFile="Confirm.aspx.cs" Inherits="Default2" %>
    <asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <form id="form1" runat="server">
            <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
            <div class="post" id="post-5">
                <div class="post-title">
                    <center>
                         <h2>
                    Book An Appointment</h2>
                         <p>
                             &nbsp;</p>

                    </center>
                </div>
                <div class="post-entry">
                    <div class="post-entry-top">
                        <div class="post-entry-bottom">
                        
                            <br />
                            <div style="margin:0 auto; text-align:left; Width:253px">
                
                                <asp:Label ID="Label3" runat="server" ForeColor="#CCCCCC" Text="Student Name"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Label ID="Label8" runat="server" ForeColor="#CCCCCC" 
                                    Text="Ronaldo Magrare"></asp:Label>
                                <br />
                                    <asp:Label ID="Label4" runat="server" ForeColor="#CCCCCC" Text="Advisor Name"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                    <asp:Label ID="Label7" runat="server" ForeColor="#CCCCCC" 
                                    Text="Advisor Name"></asp:Label>
                                <br />
                                <asp:Label ID="Label1" runat="server" ForeColor="#CCCCCC" Text="Date"></asp:Label>
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:TextBox ID="txtDate" Runat="server" Width="113px" 
                                    onclick="popupCalendar()" ReadOnly="True" />
                                <%-- <img onclick="popupCalendar()" src="cal.png" />--%>
                                <div id="dateField" style="display:none;position:Fixed;text-align:right">
                                    <%@ Register TagPrefix="uc1" TagName="ctlCalendar" Src="ctlCalendar.ascx" %>
                                        <uc1:ctlCalendar id="ctlCalendar1" runat="server"></uc1:ctlCalendar>
                                </div>
                                <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                                    <ContentTemplate>
                                        <asp:Label ID="Label2" runat="server" ForeColor="#CCCCCC" Text="Time"></asp:Label>
                                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
                                        <asp:DropDownList ID="DropDownList1" runat="server" onselectedindexchanged="DropDownList1_SelectedIndexChanged" BackColor="White" ForeColor="Black" style="border-style: none; border-color: inherit; border-width: 0px; line-height: 8px; font-size: 9px; margin-bottom: 0px;"
                                        Height="18px" Width="122px"></asp:DropDownList>
                                    </ContentTemplate>
                                </asp:UpdatePanel>
                                <br />
                                <asp:Label ID="Label6" runat="server" ForeColor="#CCCCCC" Text="Additional comments or questions:
"></asp:Label>
                                &nbsp;&nbsp;&nbsp;
                                <br />
                                <textarea id="TextArea1" name="S1" style="height: 78px; width: 226px" 
                                    runat="server"></textarea>&nbsp;&nbsp;&nbsp;&nbsp;
                                <br />
                                <br />
                                &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                                <asp:Button ID="Submit" runat="server" Text="Submit" onclick="Button1_Click" 
                                    Visible="False" />
                                </p>
                                <p></p>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
            <script type="text/javascript">
                function popupCalendar() {
                    var dateField = document.getElementById('dateField'); // toggle the div 
                    if (dateField.style.display == 'none') dateField.style.display = 'block';
                    else dateField.style.display = 'none';
                }
            </script>
        </form>
    </asp:Content>