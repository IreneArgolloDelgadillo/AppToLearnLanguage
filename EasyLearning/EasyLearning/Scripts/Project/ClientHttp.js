/**
 * It represents a client HTTP to make requests to the service.
 * @class
 */
var restClient = (function () {

    var rootURL = 'http://localhost:1893';

    function getAll(uri) {
        var response;
        $.ajax({
            type: 'GET',
            url: rootURL + '/' + uri,
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (data, status, jqXHR) {
                if (data != null) {
                    response = data;
                }
            }
        });

        return response;
    }

    function getById(uri, id) {
        var response;
        $.ajax({
            type: 'GET',
            url: rootURL + '/' + uri + '/' + id,
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (data, status, jqXHR) {
                if (data != null) {
                    response = data;
                }
            }
        });

        return response;
    }

    function getBy(uri, searchKey) {
        var response;
        $.ajax({
            type: 'GET',
            url: rootURL + '/' + uri,
            data: searchKey,
            dataType: 'json',
            contentType: 'application/json; charset=utf-8',
            success: function (data, status, jqXHR) {
                if (data != null) {
                    response = data;
                }
            }
        });

        return response;
    }

    function post(uri, item) {
        var response;
        $.ajax({
            type: 'POST',
            url: rootURL + '/' + uri,
            data: item.toJsonString(),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data, status, jqXHR) {
                if (data != null) {
                    response = data;
                }
            }
        });

        return response;
    }

    function update(uri, item) {
        var response;
        $.ajax({
            type: 'PUT',
            url: rootURL + '/' + uri,
            data: item.toJsonString(),
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data, textStatus, jqXHR) {
                if (data != null) {
                    response = data;
                }
            }
        });

        return response;
    }

    function deleteItem(id) {
        var response;
        $.ajax({
            type: 'DELETE',
            url: rootURL + '/' + uri + '/' + id,
            contentType: 'application/json; charset=utf-8',
            dataType: 'json',
            success: function (data, textStatus, jqXHR) {
                if (data != null) {
                    response = data;
                }
            }
        });

        return response;
    }

    return {
        getAll: getAll,
        getById: getById,
        getBy: getBy,
        post: post,
        update: update,
        deleteItem: deleteItem
    };
})();


