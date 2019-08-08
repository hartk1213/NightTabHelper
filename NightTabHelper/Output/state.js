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
          show: true,
          display: "number"
        },
        minutes: {
          show: true,
          display: "number"
        },
        seconds: {
          show: true,
          display: "number"
        },
        separator: {
          show: true
        },
        meridiem: {
          show: true
        },
        hour24: {
          show: true
        },
        size: 0.8
      },
      date: {
        day: {
          show: false,
          display: "word",
          weekStart: "monday",
          length: "short"
        },
        date: {
          show: true,
          display: "number",
          ordinal: true
        },
        month: {
          show: true,
          display: "word",
          length: "short",
          ordinal: true
        },
        year: {
          show: true,
          display: "number"
        },
        separator: {
          show: true
        },
        format: "monthdate",
        size: 1
      },
      search: {
        show: true,
        style: "auto",
        width: 30,
        focus: true,
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
          show: true,
        },
        accent: {
          show: false,
        },
        style: "clear",
        size: 0.6
      },
      shade: {
        show: true,
        style: "scroll",
        opacity: 0.95
      },
      border: {
        top: 0,
        bottom: 0
      },
      greeting: {
        show: true,
        type: "good",
        name: "Kyle",
        size: 1
      },
      transitional: {
        show: false,
        type: "timeanddate",
        size: 1
      },
      radius: false
    },
    link: {
      area: {
        width: 100,
        alignment: "right"
      },
      item: {
        display: {
          show: true,
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
          show: true,
          size: 0.9,
        },
        url: {
          show: false
        },
        line: {
          show: true
        },
        hoverScale: {
          show: true
        },
        order: "displayname",
        size: 1.1,
        newTab: true
      },
      show: true,
      edit: false,
      style: "block",
	  newTab: true
    },
    layout: {
      alignment: "centercenter",
      order: "headerlink",
      padding: 4,
      gutter: 1,
      width: 80,
      scrollPastEnd: false,
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
          active: false,
          style: "any"
        }
      },
      style: "dark",
      radius: 0.8
    },
    background: {
      image: {
        show: false,
        url: "https://www.kylehart1213.com/backgrounds/blackandwhite.jpg",
        blur: 1.5,
        scale: 3,
        opacity: 4,
        grayscale: 2,
        accent: 0.1
      }
    },
    edge: false,
    search: false,
    menu: true,
    modal: false,
    autoSuggest: false,
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
