
//Gets List of User Transactions using GET method from UserTransactionsController class
function showUserTransactions() {
    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", "https://localhost:5001/api/usertransactions/" + document.getElementById("transactionID").value, true);
    xhttp.send();

    xhttp.onreadystatechange = function () {
        var tbody = document.getElementById("TransactionTable").querySelector("tbody");
        document.getElementById("TransactionTable").hidden = false;
        tbody.innerHTML = "";
        if (this.readyState == 4 && this.status == 200) {
            JSON.parse(this.responseText).forEach(function (data, index) {
                tbody.innerHTML += "<tr><td>" + data.investmentID + "</td>" + "<td>" + data.investmentName + "</td></tr>";
            });
        }
    };
}
//Gets List of detailed User Transactions using GET method from UserInvestmentDetailsController class
function showUserInvestmentDetails() {
    var xhttp = new XMLHttpRequest();
    xhttp.open("GET", "https://localhost:5001/api/userinvestmentdetails/" + document.getElementById("detailID").value, true);
    xhttp.send();

    xhttp.onreadystatechange = function () {
        var tbody = document.getElementById("DetailsTable").querySelector("tbody");
        document.getElementById("DetailsTable").hidden = false;
        tbody.innerHTML = "";
        if (this.readyState == 4 && this.status == 200) {
            JSON.parse(this.responseText).forEach(function (data, index) {
                tbody.innerHTML += "<tr><td>" + data.costBasis + "</td>" + "<td>" + data.currentValue + "</td>" + "<td>" + data.currentPrice + "</td>" + "<td>" + data.term+ "</td>" + "<td>" + data.totalGainLoss + "</td></tr>";
            });
        }
    };
}
