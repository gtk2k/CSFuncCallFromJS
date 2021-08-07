mergeInto(LibraryManager.library, {
    init: function(btnClickCallback) {
        document.getElementById('btn_id').onclick = () => {
            dynCall_vi(btnClickCallback, 3);
        };
    }
});

