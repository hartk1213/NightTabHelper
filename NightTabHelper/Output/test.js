var state = (function() {

  var current = {
    header: {
      area: {
        width: 100,
        alignment: "center"
      },
      item: {
        alignment: "left"
      },
      clock: {
        hours: {
          show: True,
          display: "number"
        },
        minutes: {
          show: True,
          display: "number"
        },
        seconds: {
          show: True,
          display: "number"
        },
        separator: {
          show: True
        },
        meridiem: {
          show: True
        },
        hour24: {
          show: True
        },
        size: 0.8
      },
      date: {
        day: {
          show: False,
          display: "word",
          weekStart: "monday",
          length: "short"
        },
        date: {
          show: True,
          display: "number",
          ordinal: True
        },
        month: {
          show: True,
          display: "word",
          length: "short",
          ordinal: True
        },
        year: {
          show: True,
          display: "number"
        },
        separator: {
          show: True
        },
        format: "monthdate",
        size: 1
      },
      search: {
        show: True,
        style: "auto",
        width: 30,
        focus: True,
        engine: {
          selected: "google",
          google: {
            url: "https://www.google.com/search",
            name: "Google"
          },
          duckduckgo: {
            url: "https://duckduckgo.com/",
            name: "Duck Duck Go"
          },
          youtube: {
            url: "https://www.youtube.com/results?search_query=",
            name: "YouTube"
          },
          giphy: {
            url: "https://giphy.com/search/",
            name: "Giphy"
          },
          bing: {
            url: "https://www.bing.com/search?q=",
            name: "Bing"
          },
          custom: {
            url: "",
            name: ""
          }
        },
        text: {
          alignment: "left"
        },
        size: 1
      },
      button: {
        editAdd: {
          show: True,
        },
        accent: {
          show: False,
        },
        style: "clear",
        size: 0.6
      },
      shade: {
        show: True,
        style: "scroll",
        opacity: 0.95
      },
      border: {
        top: 0,
        bottom: 0
      },
      greeting: {
        show: True,
        type: "good",
        name: "Kyle",
        size: 1
      },
      transitional: {
        show: False,
        type: "timeanddate",
        size: 1
      },
      radius: False
    },
    link: {
      area: {
        width: 100,
        alignment: "right"
      },
      item: {
        display: {
          show: True,
          size: 2,
          alignment: "bottomright",
          letter: {
            size: 2
          },
          icon: {
            size: 3
          }
        },
        name: {
          show: True,
          size: 0.9,
        },
        url: {
          show: False
        },
        line: {
          show: True
        },
        hoverScale: {
          show: True
        },
        order: "displayname",
        size: 1.1,
        newTab: True
      },
      show: True,
      edit: True,
      style: "block",
	  newTab: True
    },
    layout: {
      alignment: "centercenter",
      order: "headerlink",
      padding: 4,
      gutter: 1,
      width: 80,
      scrollPastEnd: False,
      title: "Home Page"
    },
    theme: {
      accent: {
        current: {
          r: 41,
          g: 119,
          b: 244
        },
        random: {
          active: False,
          style: "any"
        }
      },
      style: "dark",
      radius: 0.8
    },
    background: {
      image: {
        show: False,
        url: "https://www.kylehart1213.com/backgrounds/blackAndWhite.jpg",
        blur: 1.5,
        scale: 3,
        opacity: 4,
        grayscale: 2,
        accent: 0.1
      }
    },
    edge: False,
    search: False,
    menu: True,
    modal: False,
    autoSuggest: False,
  };

  var get = function() {
    return current;
  };

  var restore = function(data) {
    if ("state" in data) {
      current = data.state;
    };
  };

  var init = function() {
    if (data.load()) {
      restore(data.load());
    };
  };

  return {
    init: init,
    get: get
  };

})();
