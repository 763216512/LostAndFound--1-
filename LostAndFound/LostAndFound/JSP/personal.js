$(document).ready(function () {
    loadPublishedInfo();
});


document.write("12312312312312312321");


//读取地域数据
function loadPublishedInfo() {
    
    $.ajax({
        url: "../JSP/personal.ashx",
        type: "get",
        contentType: "application/json",
        dataType: "json",
        data: { Action: "GetPublished","UserID":UserID},
        success: function (msg) {
            $("#published").html("");
         
            $.each(msg.PublishedInf, function (index, Table) {
               
                    //var Tablehtml = '<tr id="' + Table.AreaID + '">' +
                    //    //
                    //                                  '<td style="text-align:center"  >' + Table.AreaID + '</td>' +
                    //                                  '<td style="text-align:center" id="AreaName">' + Table.AreaName + '</td>' +
                    //                                  '<td>' +
                    //                                 ' <div>' +
                    //                                  '<button type="button" onclick="select(this,\'' + Table.AreaName + '\',\'' + Table.AreaID + '\')" class="btn btn-default btn-sm btn-flat"  Value="' + Table.AreaID + '" name="' + Table.AreaID + '"><i class="fa fa-fw fa-search" aria-hidden="true"></i>楼宇信息</button>'
                    //                                  + '&nbsp'
                    //                                  + '<button type="button" onclick="ShowUp(this)" class="btn btn-default btn-sm btn-flat" id="' + Table.AreaID + '"  name="' + Table.AreaName + '"><i class="fa fa-edit" aria-hidden="true"></i>修改</button>'
                    //                                  + '&nbsp'
                    //                                  + '<button type="button" onclick="deleteById(\'' + Table.AreaID + '\')" class="btn btn-danger btn-sm btn-flat" name="' + Table.AreaID + '"><i class="fa fa-trash-o"></i>&nbsp;删除</button>'
                    //' </div>' +
                    // '</td>' +
                // '</tr>';

                        
                var Tablehtml = '<a href="#" id="' + Table.PublishedID + '">'+
                                  ' <div class="weui-form-preview">'+

                                     ' <div class="weui-form-preview__bd">'+
                                        '<div class="weui-form-preview__pic">'+
                                          ' <img src="WeUI/pic/man.png" class="preview__pic" />'+
                                       '</div>'+
                                       '<div class="weui-form-preview__text">'+
                                           '<div class="weui-form-preview__title">'+
                                               + Table.FoundPropertyName +
                                           '</div>'+
                                          ' <div class="weui-form-preview__time">'+
                                               + Table.FoundDate +
                                          ' </div>'+
                                          ' <div class="weui-form-preview__place" id=>'+
                                               + Table.FoundPart +
                                          ' </div>'+
                                      ' </div>'+
                                      ' <a href="append.html">'+
                                     ' <div style="width:30px; height:100px; float:right; background-color:#87CEEB; text-align:center;">'+
                                           ' <h2 style=" color:#FFFFFF">匹配</h2>'+
                                       ' </div>'+
                                           ' </a>'+
                                  ' </div>'+
                              ' </div>'+
                          ' </a>'


                    $("#published").append(Tablehtml);
                
            }
            )
            display();
        }
    })
};