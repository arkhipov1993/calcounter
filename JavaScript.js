var checkFirstName = '';

var checkLastName = '';

var checkEmail = '';

var checkPass = '';

var errorFlag = true;



function validationForm() {

    if (document.forms['SignUpForm']['TextBox1'].value == '') {

        checkFirstName = 'Name field is empty!';

        errorFlag = false;

    } else {

        checkFirstName = '';

    }

    if (document.forms['SignUpForm']['TextBox2'].value == '') {

        checkLastName = 'Name field is empty!';

        errorFlag = false;

    } else {

        checkLastName = '';

    }

    if (document.forms['SignUpForm']['TextBox3'].value == '') {

        checkEmail = 'Email field is empty!';

        errorFlag = false;

    } else {

        checkEmail = '';

        var validEmail = /[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?/;



        if (document.forms['SignUpForm']['TextBox3'].value.match(validEmail)) {

            checkEmail = '';

        } else {

            checkEmail = 'Email address is not valid!';

            errorFlag = false;

        }

    }

    if (document.forms['SignUpForm']['TextBox4'].value == '' || document.forms['SignUpForm']['TextBox5'].value == '') {

        checkPass = 'Password fields are empty!';

        errorFlag = false;

    } else {

        checkPass = '';

        if (document.forms['SignUpForm']['TextBox4'].value !== document.forms['SignUpForm']['TextBox5'].value) {

            checkPass = 'Password and Confirm password fields should be equal.';

            errorFlag = false;

        }

    }

    errorMsg();

    return errorFlag;
    
   

}

function errorMsg() {

    document.getElementById('errorMsgArea').innerHTML = checkFirstName + "<br>" + checkLastName + "<br>" + checkEmail + "<br>" + checkPass;

}

