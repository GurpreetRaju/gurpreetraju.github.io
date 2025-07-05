export function renderRecaptcha(siteKey, captchaElement) {
    if (typeof grecaptcha === 'undefined') {
        console.error("reCAPTCHA not yet loaded.");
        return;
    }

    return grecaptcha.render(captchaElement, {
        sitekey: siteKey
    });
}

export function getRecaptchaResponse() {
    return grecaptcha.getResponse();
}