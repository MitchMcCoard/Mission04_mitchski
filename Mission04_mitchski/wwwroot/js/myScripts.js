$('#calculate').click(function () {

    //Pull in the values
    var assgn = $('#assgn').val() * .5
    var group = $('#group').val() * .1
    var quiz = $('#quiz').val() * .1
    var midterm = $('#midterm').val() * .1
    var final = $('#final').val() * .1
    var intex = $('#intex').val() * .1

    var ioutput = assgn + group + quiz + midterm + final + intex
    var letter = 'E'

    //Determine what grade letter this is
    if (ioutput >= 94) {
        letter = 'A'
    } else if (ioutput <= 90) {
        letter = 'A-'
    } else if (ioutput <= 87) {
        letter = 'B+'
    } else if (ioutput <= 84) {
        letter = 'B'
    } else if (ioutput <= 80) {
        letter = 'B-'
    } else if (ioutput <= 77) {
        letter = 'C+'
    } else if (ioutput <= 74) {
        letter = 'C'
    } else if (ioutput <= 70) {
        letter = 'C-'
    } else if (ioutput <= 67) {
        letter = 'D+'
    } else if (ioutput <= 64) {
        letter = 'D'
    } else if (ioutput <= 60) {
        letter = 'D-'
    }
    
    //This writes the output to the input field
    $('#output').val("You're grade could be an " + letter + " with " + Math.round( ioutput.toString() ) + '% ')
})

