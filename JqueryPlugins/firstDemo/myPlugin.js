;(function ($, window) {
    $.fn.myPlugin = function () {
        var max = 0;

        this.each(function () {
            max = Math.max(max, $(this).height());
        });

        return max;
    }
}(jQuery, window));

// 一般返回一个jQuery对象
;(function ($) {
    $.fn.greenify = function () {
        this.css("backgroundColor", "green");
        return this;
    }
}(jQuery));

// $.extend 可以为对象拓展属性
// .each 方法
;(function ($, window) {
    $.fn.tooltip = function (options) {
        var settings = $.extend({
            'location': 'top',
            'backgroudColor': 'blue'
        }, options);

        return this.each(function () {
            
        })
    }
}(jQuery, window));

// 侦测环境
if(typeof module == 'object' && typeof module.exports === 'object'){
    console.log("CommonJs版本");
}else{
    console.log("浏览器环境");
};

// 将a元素的href属性添加到网页的插件
;(function ($) {
    $.fn.showLinkLocation = function () {
        return this.filter('a').append(function () {
            return ' ( ' + this.href + ' ) ';
        })
    }
}(jQuery));