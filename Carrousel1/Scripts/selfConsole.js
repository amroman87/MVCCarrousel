class SelfConsole {
    static log(message) {
        log(1, message);
    }
    static info(message) {
        log(2, message);
    }
    static error(message) {
        log(3, message);
    }
    static debug(message) {
        log(4, message);
    }
}


function log(level, message) {

    var levelText;
    if (level == 1) {
        levelText = "log";
         
    } else if (level == 2) {
        levelText = "info";
    }
    else if (level == 3) {
        levelText = "error";
    }
    
    else if (level == 4)
    {
        levelText = "debug";
    }    

    var today = new Date();
    

    var table = document.getElementById("dtConsoleLog");
    var row = table.insertRow(table.rows.length);
        
    var cell1 = row.insertCell(0);
    var cell2 = row.insertCell(1);
    var cell3 = row.insertCell(2);
    // Add some text to the new cells:
    cell1.innerHTML = levelText;
    cell2.innerHTML = message;
    cell3.innerHTML = new Date().toLocaleString().replace(",", "").replace(/:.. /, " ");
}       