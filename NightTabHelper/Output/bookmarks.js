var bookmarks = (function() {

  var all = [{
display: "letter", 
letter: "Am", 
icon: {
 name: "amazon",
 prefix: "fab",
 label: "Amazon"
},
  name: "Amazon",
  url: "https://smile.amazon.com/",
accent: {
override: true,
color: { 
r: 243, 
g: 168, 
b: 71
}
}, 
 timeStamp: 1546453100455
},{
display: "letter", 
letter: "Aw", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Awesomer",
  url: "https://theawesomer.com/",
accent: {
override: true,
color: { 
r: 142, 
g: 142, 
b: 142
}
}, 
 timeStamp: 1543453100455
},{
display: "letter", 
letter: "C", 
icon: {
 name: "calendar",
 prefix: "fas",
 label: "Calendar"
},
  name: "Calendar",
  url: "https://www.google.com/calendar/",
accent: {
override: true,
color: { 
r: 15, 
g: 242, 
b: 197
}
}, 
 timeStamp: 1546453110885
},{
display: "letter", 
letter: "De", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Deluge",
  url: "https://deluge.kylehart1213.com/",
accent: {
override: true,
color: { 
r: 123, 
g: 163, 
b: 206
}
}, 
 timeStamp: 1546453121953
},{
display: "letter", 
letter: "Dev", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "DevOps",
  url: "https://devops.pathguide.com",
accent: {
override: true,
color: { 
r: 16, 
g: 110, 
b: 190
}
}, 
 timeStamp: 1546453113950
},{
display: "letter", 
letter: "Dr", 
icon: {
 name: "google-drive",
 prefix: "fab",
 label: "Google Drive"
},
  name: "Google Drive",
  url: "https://drive.google.com/drive/",
accent: {
override: true,
color: { 
r: 163, 
g: 14, 
b: 243
}
}, 
 timeStamp: 1546853111953
},{
display: "letter", 
letter: "Eb", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Ebay",
  url: "https://www.ebay.com",
accent: {
override: true,
color: { 
r: 255, 
g: 0, 
b: 0
}
}, 
 timeStamp: 1563223778377
},{
display: "letter", 
letter: "Ex", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Expense Form",
  url: "budget",
accent: {
override: true,
color: { 
r: 103, 
g: 58, 
b: 183
}
}, 
 timeStamp: 1564502206875
},{
display: "letter", 
letter: "Gi", 
icon: {
 name: "github",
 prefix: "fab",
 label: "GitHub"
},
  name: "GitHub",
  url: "https://github.com/",
accent: {
override: true,
color: { 
r: 243, 
g: 79, 
b: 41
}
}, 
 timeStamp: 1546453108926
},{
display: "letter", 
letter: "Gm", 
icon: {
 name: "envelope",
 prefix: "fas",
 label: "Envelope"
},
  name: "GMail",
  url: "https://mail.google.com/",
accent: {
override: true,
color: { 
r: 178, 
g: 49, 
b: 33
}
}, 
 timeStamp: 1546453110265
},{
display: "letter", 
letter: "Gs", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Google Sheets",
  url: "https://sheets.google.com",
accent: {
override: true,
color: { 
r: 24, 
g: 128, 
b: 56
}
}, 
 timeStamp: 1563301685660
},{
display: "letter", 
letter: "I", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "IpTorrents",
  url: "https://www.iptorrents.com/",
accent: {
override: true,
color: { 
r: 101, 
g: 112, 
b: 184
}
}, 
 timeStamp: 1546453110205
},{
display: "letter", 
letter: "J", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Jackett",
  url: "https://jackett.kylehart1213.com/",
accent: {
override: true,
color: { 
r: 82, 
g: 203, 
b: 197
}
}, 
 timeStamp: 1546412131953
},{
display: "letter", 
letter: "N", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Netflix",
  url: "https://www.netflix.com/",
accent: {
override: true,
color: { 
r: 229, 
g: 9, 
b: 20
}
}, 
 timeStamp: 1546453104460
},{
display: "letter", 
letter: "Om", 
icon: {
 name: "film",
 prefix: "fas",
 label: "Film"
},
  name: "Ombi",
  url: "https://ombi.kylehart1213.com/",
accent: {
override: true,
color: { 
r: 227, 
g: 114, 
b: 0
}
}, 
 timeStamp: 1546453111153
},{
display: "letter", 
letter: "Op", 
icon: {
 name: "cube",
 prefix: "fas",
 label: "Cube"
},
  name: "Octoprint",
  url: "https://www.dsk3dprinting.com",
accent: {
override: true,
color: { 
r: 17, 
g: 193, 
b: 0
}
}, 
 timeStamp: 1546453111155
},{
display: "letter", 
letter: "Pa", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Pandora",
  url: "https://www.pandora.com/",
accent: {
override: true,
color: { 
r: 13, 
g: 150, 
b: 241
}
}, 
 timeStamp: 1564501530696
},{
display: "letter", 
letter: "Ph", 
icon: {
 name: "images",
 prefix: "fas",
 label: "Images"
},
  name: "Photos",
  url: "https://photos.google.com/",
accent: {
override: true,
color: { 
r: 80, 
g: 96, 
b: 205
}
}, 
 timeStamp: 1546453104910
},{
display: "letter", 
letter: "Pl", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Plex",
  url: "https://plex.kylehart1213.com/",
accent: {
override: true,
color: { 
r: 204, 
g: 123, 
b: 25
}
}, 
 timeStamp: 1546453111353
},{
display: "letter", 
letter: "Po", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Posters",
  url: "PlexPosters",
accent: {
override: true,
color: { 
r: 223, 
g: 174, 
b: 62
}
}, 
 timeStamp: 1564681857992
},{
display: "letter", 
letter: "Ra", 
icon: {
 name: "registered",
 prefix: "fas",
 label: "Registered Trademark"
},
  name: "Radarr",
  url: "https://radarr.kylehart1213.com/",
accent: {
override: true,
color: { 
r: 255, 
g: 194, 
b: 48
}
}, 
 timeStamp: 1546453181953
},{
display: "letter", 
letter: "Re", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Reddit",
  url: "https://www.reddit.com/",
accent: {
override: true,
color: { 
r: 255, 
g: 67, 
b: 1
}
}, 
 timeStamp: 1546453111491
},{
display: "letter", 
letter: "So", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Sonarr",
  url: "https://sonarr.kylehart1213.com/",
accent: {
override: true,
color: { 
r: 54, 
g: 198, 
b: 244
}
}, 
 timeStamp: 1546453191953
},{
display: "letter", 
letter: "Sp", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Speed",
  url: "https://www.speed.cd",
accent: {
override: true,
color: { 
r: 74, 
g: 210, 
b: 81
}
}, 
 timeStamp: 1546453191958
},{
display: "letter", 
letter: "Ta", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Tatulli",
  url: "https://stats.kylehart1213.com/",
accent: {
override: true,
color: { 
r: 229, 
g: 160, 
b: 12
}
}, 
 timeStamp: 1546453113953
},{
display: "letter", 
letter: "Th", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "Thingiverse",
  url: "https://www.thingiverse.com",
accent: {
override: true,
color: { 
r: 36, 
g: 139, 
b: 251
}
}, 
 timeStamp: 1546103113953
},{
display: "letter", 
letter: "Ts", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "TorrentSeeds",
  url: "https://torrentseeds.org/",
accent: {
override: true,
color: { 
r: 160, 
g: 160, 
b: 160
}
}, 
 timeStamp: 1146103113953
},{
display: "letter", 
letter: "U", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "UnRaid",
  url: "http://192.168.1.149/Main",
accent: {
override: false,
color: { 
r: 41, 
g: 119, 
b: 244
}
}, 
 timeStamp: 9866453113953
},{
display: "letter", 
letter: "X", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "XKCD",
  url: "https://xkcd.com/",
accent: {
override: true,
color: { 
r: 255, 
g: 255, 
b: 255
}
}, 
 timeStamp: 1563380613258
},{
display: "letter", 
letter: "Y", 
icon: {
 name: "",
 prefix: "",
 label: ""
},
  name: "YouTube",
  url: "https://www.youtube.com/",
accent: {
override: true,
color: { 
r: 255, 
g: 0, 
b: 0
}
}, 
 timeStamp: 1546453108071
}];

  var get = function(data) {
    var _singleBookmark = function() {
      var found = false;
      for (var i = 0; i < all.length; i++) {
        if (all[i].timeStamp === data.timeStamp) {
          found = all[i];
        };
      };
      return found;
    };
    if (data && typeof data.timeStamp == "number") {
      return _singleBookmark();
    } else {
      return all;
    };
  };

  var restore = function(data) {
    if ("bookmarks" in data) {
      all = data.bookmarks;
    };
  };

  var add = function(data) {
    all.push(data);
  };

  var edit = function(data) {
    for (var i = 0; i < all.length; i++) {
      if (all[i].timeStamp === data.timeStamp) {
        all[i] = data;
      };
    };
  };

  var remove = function(data) {
    for (var i = 0; i < all.length; i++) {
      if (all[i].timeStamp === data.timeStamp) {
        all.splice(all.indexOf(all[i]), 1);
      };
    };
  };

  var sort = function(by) {
    var action = {
      name: function(array) {
        return helper.sortObject(array, "name");
      },
      letter: function(array) {
        return helper.sortObject(array, "letter");
      },
      icon: function(array) {
        return helper.sortObject(array, "icon.name");
      }
    };
    all = action[by](all);
  };

  var move = function(origin, destination) {
    all = helper.moveArrayItem(all, origin, destination);
  };

  var init = function() {
    if (data.load()) {
      restore(data.load());
    };
  };

  // exposed methods
  return {
    all: all,
    init: init,
    get: get,
    add: add,
    edit: edit,
    sort: sort,
    move: move,
    remove: remove,
    restore: restore
  };

})();
