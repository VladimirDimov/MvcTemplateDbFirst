var attributeWatcher = (function () {
    // For a list of elements watches the change in the attribute value. Returns an array with objects {name: string, value: object}
    function watchAttribute($elements, valueSelector, callback) {
        var length = length || $elements.length;
        var oldValues;

        if (!oldValues) {
            oldValues = [];
            for (var i = 0; i < length; i++) {
                oldValues[i] = valueSelector($($elements[i]));
            }
        }

        setInterval(function () {
            for (var i = 0; i < length; i++) {
                var $element = $($elements[i]);
                var elementValue = valueSelector($element);
                if (elementValue != oldValues[i]) {
                    oldValues[i] = elementValue;

                    var data = {};
                    for (var j = 0; j < length; j++) {
                        var keyValPair = getKeyValPair($($elements[i]), 'data-search');
                        data[keyValPair.name] = keyValPair.value;
                    }

                    callback(data);
                }
            }
        }, 100);

        function getKeyValPair($elem, nameAttribute) {
            //var name = $elem.attr(nameAttribute);
            var value = valueSelector($elem);

            return { 'name': nameAttribute, 'value': value };
        }
    }

    return {
        watchAttribute: watchAttribute
    }
})();