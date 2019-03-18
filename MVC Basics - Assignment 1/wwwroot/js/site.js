

function showDate() {

    var today = new Date()
    var year = today.getYear()

    if (year < 1000)
        year += 1900

    var day = today.getDay()
    var month = today.getMonth()
    var daym = today.getDate()


    if (month < 10)
        month = "0" + month

    if (daym < 10)
        daym = "0" + daym

    var dayarray = new Array("Sunday", "Monday", "Tuesday", "Wedensday", "Thusrday",
        "Friday", "Saturday")
    var montharray = new Array("Januari", "Februari", "Mars", "April", "Maj", "Juni",
        "Juli", "Augusti", "September", "Oktober", "November", "December")

    //console.log(dayarray[day] + ", " + year + "-" + month + "-" + daym);
    //document.getElementById('date').innerHTML = dayarray[day] + ", " + year + "-" + month + "-" + daym
    document.getElementById('footerText').innerHTML = "Copyright &copy; " + year + "-" + month + "-" + daym + " Nisse Nilson"

}

