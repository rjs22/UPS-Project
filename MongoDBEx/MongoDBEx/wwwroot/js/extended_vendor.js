function collectFF() {
    var text = document.getElementById("ven6");
    text.value += '{'+
                    '"navigator":' +
                      '{' +
                            '"appCodeName":"Mozilla","app_Name":"Netscape","appversion":"5.0 (Windows; en-US)",' +
                            '"language": "en-US","platform":"Win32","oscpu":"Windows NT 6.0","vendor":"",' +
                            '"product":"Gecko","securityPolicy":"","userAgent":"(Windows; U; Windows NT 6.0; en-US;' +
                            'rv: 1.9.O.1) Gecko / 2008070208 Firefox / 3.O.1","cookieEnabled":true,"onLine":true,"build_ID":"' +
                            '2008070208"' +
                       '},' +
                        '"plugins":' +

                        '[' +
                            '{ "name":"Adobe Acrobat Plugin","version":""},' +
                            '{ "name":"QuickTime Plug-in","version":"7.5"},' +
                            '{ "name":"Windows Media Player Plug-in Dynamic Link Library","version":""},' +
                            '{ "name":"Macromedia Shockwave Flash","version":"9.0"},' +
                            '{ "name":"Java Virtual Machine","version":"1.6.0"}' +
                         ']' +
                         ',"screen":{"availHeight":770,"availWidth":1280,"colorDepth":32,"height":800,"pixelDepth":32,"width":1280},' +
                         '"extra":{"javascript_ver":"2.0","timezone":300}' +
                    '}';
    
}
collectFF();