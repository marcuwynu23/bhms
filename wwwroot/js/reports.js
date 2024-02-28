// Sample sales data
var salesData = {
  labels: ["January", "February", "March", "April", "May", "June"],
  datasets: [
    {
      label: "Sales",
      backgroundColor: "rgba(54, 162, 235, 0.2)",
      borderColor: "rgba(54, 162, 235, 1)",
      borderWidth: 1,
      data: [1000, 1500, 1200, 1800, 2000, 1700],
    },
  ],
};

// Get the canvas element
var ctx = document.getElementById("salesChart").getContext("2d");

// Create the chart
var salesChart = new Chart(ctx, {
  type: "line",
  data: salesData,
  options: {
    scales: {
      yAxes: [
        {
          ticks: {
            beginAtZero: true,
          },
        },
      ],
    },
  },
});
