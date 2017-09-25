<%@ Page Title="" Language="C#" MasterPageFile="~/design.Master" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="panel._default" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <base href='/'>
        <my-app>
		    <div class="loader">
			    <svg class="circular" viewBox="25 25 50 50">
				    <circle class="path" cx="50" cy="50" r="20" fill="none" stroke-width="2" stroke-miterlimit="10"/>
			    </svg>
		    </div>
	    </my-app>


    <!--   Core JS Files   -->
    <script src="./src/assets/js/core/jquery-3.1.1.min.js" type="text/javascript"></script>
    <script src="./src/assets/js/core/jquery-ui.min.js" type="text/javascript"></script>
    <script src="./src/assets/js/core/bootstrap.min.js" type="text/javascript"></script>
    <script src="./src/assets/js/core/arrive.js" type="text/javascript"></script>
    <script src="./src/assets/js/core/material.min.js" type="text/javascript"></script>
    <script src="./src/assets/js/core/perfect-scrollbar.jquery.min.js" type="text/javascript"></script>
    <!-- Forms Validations Plugin -->
    <script src="./src/assets/js/core/jquery.validate.min.js"></script>
    <!--  Plugin for Date Time Picker and Full Calendar Plugin-->
    <script src="./src/assets/js/plugins/moment.min.js"></script>
    <!--  Charts Plugin -->
    <script src="./src/assets/js/plugins/chartist.min.js"></script>
    <!--  Plugin for the Wizard -->
    <script src="./src/assets/js/plugins/jquery.bootstrap-wizard.js"></script>
    <!--  Notifications Plugin    -->
    <script src="./src/assets/js/plugins/bootstrap-notify.js"></script>
    <!-- DateTimePicker Plugin -->
    <script src="./src/assets/js/plugins/bootstrap-datetimepicker.js"></script>
    <!-- Vector Map plugin -->
    <script src="./src/assets/js/plugins/jquery-jvectormap.js"></script>
    <!-- Sliders Plugin -->
    <script src="./src/assets/js/plugins/nouislider.min.js"></script>
    <!--  Google Maps Plugin    -->
    <script src="https://maps.googleapis.com/maps/api/js"></script>
    <!-- Select Plugin -->
    <script src="./src/assets/js/plugins/jquery.select-bootstrap.js"></script>
    <!--  DataTables.net Plugin    -->
    <script src="./src/assets/js/plugins/jquery.datatables.js"></script>
    <!-- Sweet Alert 2 plugin -->
    <script src="./src/assets/js/plugins/sweetalert2.min.js"></script>
    <!--	Plugin for Fileupload  -->
    <script src="./src/assets/js/plugins/jasny-bootstrap.min.js"></script>
    <!--  Full Calendar Plugin    -->
    <script src="./src/assets/js/plugins/fullcalendar.min.js"></script>
    <!-- TagsInput Plugin -->
    <script src="./src/assets/js/plugins/jquery.tagsinput.js"></script>
    <!-- Material Dashboard javascript methods -->
    <script src="./src/assets/js/material-dashboard-angular.js"></script>
    <!-- Material Dashboard DEMO methods, don't include it in your project! -->
    <script src="./src/assets/js/demo.js"></script>
</asp:Content>
