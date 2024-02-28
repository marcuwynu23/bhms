$(function () {
  $("#announcements-tab").on("click", function (e) {
    e.preventDefault();
    $(this).tab("show");
  });

  $("#messages-tab").on("click", function (e) {
    e.preventDefault();
    $(this).tab("show");
  });
});
	