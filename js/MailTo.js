// Source: https://www.msctek.com/blazor-wasm-how-to-send-email-from-a-pwa/

window.blazorExtensions = {
    sendEmail: function (mailto, subject, body) {
        let link = document.createElement('a');

        link.target = "_blank";

        let uri = "mailto:" + mailto + "?";
        if (!isEmpty(subject)) {
            uri = uri + "subject=" + subject;
        }

        if (!isEmpty(body)) {
            if (!isEmpty(subject)) { // We already appended one querystring parameter, add the '&' separator
                uri = uri + "&"
            }

            uri = uri + "body=" + body;
        }

        uri = encodeURI(uri);
        uri = uri.substring(0, 2000); // Avoid exceeding querystring limits.
        console.log('Clicking sendEmail link:', uri);

        link.href = uri;
        document.body.appendChild(link); // Needed for Firefox
        link.click();
        document.body.removeChild(link);
    }
};

function isEmpty(str) {
    return (!str || str.length === 0);
}