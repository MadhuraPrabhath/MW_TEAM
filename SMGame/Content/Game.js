document.getElementById('MainContent_timer').innerHTML = 01 + ":" + 00;

function CloseModel4() {
    document.getElementById('id04').style.display = 'none'
}

function OpenModel4() {
    document.getElementById('id04').style.display = 'block'
}

function OpenModel2() {
    document.getElementById('id02').style.display = 'block'
}

function OpenModel() {
    document.getElementById('id01').style.display = 'block'
}

function OpenModel3() {
    document.getElementById('id03').style.display = 'block'
}


// startTimer();

function EnableGrid() {
    var Grid = document.getElementById('<%=DataGrid1.ClientID%>');//DataGrid1.ClientID
    Grid.Disable = false;
    var Grid = document.getElementById('<%=DataGrid2.ClientID%>');//DataGrid1.ClientID
    Grid.Disable = false;
    var Grid = document.getElementById('<%=DataGrid3.ClientID%>');//DataGrid1.ClientID
    Grid.disable = false;
    //var NoOfColumns = 3 // Set No. of Columns in GridView
    //for (var i = 0; i < NoOfColumns; i++) {
    //    Grid.rows[1].cells[i].children[0].disabled = true;
    //}
    return false;
}

function DisableGrid() {
    var Grid = document.getElementById('<%=DataGrid1.ClientID%>');//DataGrid1.ClientID
    Grid.Disable = true;
    var Grid = document.getElementById('<%=DataGrid2.ClientID%>');//DataGrid1.ClientID
    Grid.Disable = true;
    var Grid = document.getElementById('<%=DataGrid3.ClientID%>');//DataGrid1.ClientID
    Grid.disable = true;
    //var NoOfColumns = 3 // Set No. of Columns in GridView
    //for (var i = 0; i < NoOfColumns; i++) {
    //    Grid.rows[1].cells[i].children[0].disabled = true;
    //}
    return false;
}

function play() {
    document.getElementById('MainContent_timer').innerHTML = 01 + ":" + 00;
    var varroundNumber = document.getElementById('MainContent_lblGame_Round').innerHTML;


    if (parseInt(varroundNumber) == 10){
        document.getElementById('MainContent_lblGame_Round').innerHTML = 1;

    }
    else {
        document.getElementById('MainContent_lblGame_Round').innerHTML = parseInt(varroundNumber)+1;

    }
    //MainContent_btnStartGame
    //document.getElementById('MainContent_btnStartGame').disable = true;
    CloseModel4();
    startTimer();
   // return false;
}


function startTimer() {

    // EnableGrid();
    var presentTime = document.getElementById('MainContent_timer').innerHTML;
    var timeArray = presentTime.split(/[:]+/);
    var m = timeArray[0];
    var s = checkSecond((timeArray[1] - 1));
    if (s == 59) { m = m - 1 }
    if (m < 0) {
        // DisableGrid();
        OpenModel4();
        //retr
    } else {
        document.getElementById('MainContent_timer').innerHTML = m + ":" + s;
        setTimeout(startTimer, 1000);
    }
    return false;
}

function checkSecond(sec) {
    if (sec < 10 && sec >= 0) { sec = "0" + sec }; // add zero in front of numbers < 10
    if (sec < 0) { sec = "59" };
    return sec;
}
// countdown();