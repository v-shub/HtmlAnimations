document.addEventListener('DOMContentLoaded', function () {
    LottieInteractivity.create({
        player: '#500Lottie',
        mode: 'cursor',
        actions: [
            {
                type: 'click',
                forceFlag: false
            },
        ],
    });
});