<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ShoesStore.Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
   <!-- Section: Contact v.2 -->
<section class="my-5">

  <!-- Section heading -->
  <h2 class="h1-responsive font-weight-bold text-center my-5">Liên hệ chúng tôi</h2>
  <!-- Section description -->
  

  <!-- Grid row -->
  <div class="row">

    <!-- Grid column -->
    <div class="col-md-9 mb-md-0 mb-5">

      <form>

        <!-- Grid row -->
        <div class="row">

          <!-- Grid column -->
          <div class="col-md-6">
            <div class="md-form mb-0">
               <label for="contact-name" class="">Tên</label>
              <input type="text" id="contact-name" class="form-control">
              
            </div>
          </div>
          <!-- Grid column -->

          <!-- Grid column -->
          <div class="col-md-6">
            <div class="md-form mb-0">
                <label for="contact-email" class="">Email</label>
              <input type="text" id="contact-email" class="form-control">
              
            </div>
          </div>
          <!-- Grid column -->

        </div>
        <!-- Grid row -->

        <!-- Grid row -->
        <div class="row">

          <!-- Grid column -->
          <div class="col-md-12">
            <div class="md-form mb-0">
                <label for="contact-Subject" class="">Chủ đề</label>
              <input type="text" id="contact-Subject" class="form-control">
            </div>
          </div>
          <!-- Grid column -->

        </div>
        <!-- Grid row -->

        <!-- Grid row -->
        <div class="row">

          <!-- Grid column -->
          <div class="col-md-12">
            <div class="md-form">
                <label for="contact-message">Nội dung</label>
              <textarea id="contact-message" class="form-control md-textarea" rows="3"></textarea>
              
            </div>
          </div>
          <!-- Grid column -->

        </div>
        <!-- Grid row -->

      </form>

      <div class="text-center text-md-left">
        <a class="btn btn-primary btn-md">Gửi</a>
      </div>

    </div>
    <!-- Grid column -->

    <!-- Grid column -->
    <div class="col-md-3 text-center">
      <ul class="list-unstyled mb-0">
        <li>
          <i class="fas fa-map-marker-alt fa-2x blue-text"></i>
          <p>Dã Tượng, Nha Trang</p>
        </li>
        <li>
          <i class="fas fa-phone fa-2x mt-4 blue-text"></i>
          <p>0990 123 456</p>
        </li>
        <li>
          <i class="fas fa-envelope fa-2x mt-4 blue-text"></i>
          <p class="mb-0">giayhoanganh@gmail.com</p>
        </li>
      </ul>
    </div>
    <!-- Grid column -->

  </div>
  <!-- Grid row -->

</section>
<!-- Section: Contact v.2 -->
</asp:Content>
