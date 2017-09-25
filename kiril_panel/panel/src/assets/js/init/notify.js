if ('undefined' !== typeof module) {
    inNotify = true;
    type = ['','info','success','warning','danger'];
    module.exports = function initNotify(from, align){
        color = Math.floor((Math.random() * 4) + 1);
        if(inNotify){
            $.notify({
            	icon: "notifications",
            	message: localStorage.getItem("lg") == "tr" ? "<b>Markum Panel</b>'e hoşgeldiniz." : (localStorage.getItem("lg") == "en" ? "Velcome to <b>Markum Panel</b>'." : "Zu erwerben <b>Markum Panel</b>'.")

            },{
                type: type[color],
                timer: 3000,
                placement: {
                    from: from,
                    align: align
                }
            });
            inNotify = false;
        }
    }
}

