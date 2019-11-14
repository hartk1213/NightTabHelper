using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NightTabHelper.Classes.TemplateClasses
{
    public class TemplateClass
    {

        public string olbookmarksjs = "var bookmarks = (function() {" +
        "  var all = [{0}];" +
        "  var get = function(data) {" +
        "    var _singleBookmark = function() {" +
        "      var found = false;" +
        "      for (var i = 0; i < all.length; i++) {" +
        "        if (all[i].timeStamp === data.timeStamp) {" +
        "          found = all[i];" +
        "        };" +
        "      };" +
        "      return found;" +
        "    };" +
        "    if (data && typeof data.timeStamp == \"number\") {" +
        "      return _singleBookmark();" +
        "    } else {" +
        "      return all;" +
        "    };" +
        "  };" +
        "  var restore = function(data) {" +
        "    if (\"bookmarks\" in data) {" +
        "      all = data.bookmarks;" +
        "    };" +
        "  };" +
        "  var add = function(data) {" +
        "    all.push(data);" +
        "  };" +
        "  var edit = function(data) {" +
        "    for (var i = 0; i < all.length; i++) {" +
        "      if (all[i].timeStamp === data.timeStamp) {" +
        "        all[i] = data;" +
        "      };" +
        "    };" +
        "  };" +
        "  var remove = function(data) {" +
        "    for (var i = 0; i < all.length; i++) {" +
        "      if (all[i].timeStamp === data.timeStamp) {" +
        "        all.splice(all.indexOf(all[i]), 1);" +
        "      };" +
        "    };" +
        "  };" +
        "  var sort = function(by) {" +
        "    var action = {" +
        "      name: function(array) {" +
        "        return helper.sortObject(array, \"name\");" +
        "      }," +
        "      letter: function(array) {" +
        "        return helper.sortObject(array, \"letter\");" +
        "      }," +
        "      icon: function(array) {" +
        "        return helper.sortObject(array, \"icon.name\");" +
        "      }" +
        "    };" +
        "    all = action[by](all);" +
        "  };" +
        "  var move = function(origin, destination) {" +
        "    all = helper.moveArrayItem(all, origin, destination);" +
        "  };" +
        "  var init = function() {" +
        "    if (data.load()) {" +
        "      restore(data.load());" +
        "    };" +
        "  };" +
        "  // exposed methods" +
        "  return {" +
        "    all: all," +
        "    init: init," +
        "    get: get," +
        "    add: add," +
        "    edit: edit," +
        "    sort: sort," +
        "    move: move," +
        "    remove: remove," +
        "    restore: restore" +
        "  };" +
        "})();";


        public string oldStatejs = "var state = (function() ¿" +
        "  var current = ¿" +
        "    header: ¿" +
        "      area: ¿" +
        "        width: {0}," +
        "        alignment: \"{1}\"" +
        "      ╡," +
        "      item: ¿" +
        "        alignment: \"{2}\"" +
        "      ╡," +
        "      clock: ¿" +
        "        hours: ¿" +
        "          show: {3}," +
        "          display: \"{4}\"" +
        "        ╡," +
        "        minutes: ¿" +
        "          show: {5}," +
        "          display: \"{6}\"" +
        "        ╡," +
        "        seconds: ¿" +
        "          show: {7}," +
        "          display: \"{8}\"" +
        "        ╡," +
        "        separator: ¿" +
        "          show: {9}" +
        "        ╡," +
        "        meridiem: ¿" +
        "          show: {10}" +
        "        ╡," +
        "        hour24: ¿" +
        "          show: {11}" +
        "        ╡," +
        "        size: {12}" +
        "      ╡," +
        "      date: ¿" +
        "        day: ¿" +
        "          show: {13}," +
        "          display: \"{14}\"," +
        "          weekStart: \"{15}\"," +
        "          length: \"{16}\"" +
        "        ╡," +
        "        date: ¿" +
        "          show: {17}," +
        "          display: \"{18}\"," +
        "          ordinal: {19}" +
        "        ╡," +
        "        month: ¿" +
        "          show: {20}," +
        "          display: \"{21}\"," +
        "          length: \"{22}\"," +
        "          ordinal: {23}" +
        "        ╡," +
        "        year: ¿" +
        "          show: {24}," +
        "          display: \"{25}\"" +
        "        ╡," +
        "        separator: ¿" +
        "          show: {26}" +
        "        ╡," +
        "        format: \"{27}\"," +
        "        size: {28}" +
        "      ╡," +
        "      search: ¿" +
        "        show: {29}," +
        "        style: \"{30}\"," +
        "        width: {31}," +
        "        focus: {32}," +
        "        engine: ¿" +
        "          selected: \"{33}\"," +
        "          google: ¿" +
        "            url: \"https://www.google.com/search\"," +
        "            name: \"Google\"" +
        "          ╡," +
        "          duckduckgo: ¿" +
        "            url: \"https://duckduckgo.com/\"," +
        "            name: \"Duck Duck Go\"" +
        "          ╡," +
        "          youtube: ¿" +
        "            url: \"https://www.youtube.com/results?search_query=\"," +
        "            name: \"YouTube\"" +
        "          ╡," +
        "          giphy: ¿" +
        "            url: \"https://giphy.com/search/\"," +
        "            name: \"Giphy\"" +
        "          ╡," +
        "          bing: ¿" +
        "            url: \"https://www.bing.com/search?q=\"," +
        "            name: \"Bing\"" +
        "          ╡," +
        "          custom: ¿" +
        "            url: \"{34}\"," +
        "            name: \"{35}\"" +
        "          ╡" +
        "        ╡," +
        "        text: ¿" +
        "          alignment: \"{36}\"" +
        "        ╡," +
        "        size: {37}" +
        "      ╡," +
        "      button: ¿" +
        "        editAdd: ¿" +
        "          show: {38}," +
        "        ╡," +
        "        accent: ¿" +
        "          show: {39}," +
        "        ╡," +
        "        style: \"{40}\"," +
        "        size: {41}" +
        "      ╡," +
        "      shade: ¿" +
        "        show: {42}," +
        "        style: \"{43}\"," +
        "        opacity: {44}" +
        "      ╡," +
        "      border: ¿" +
        "        top: {45}," +
        "        bottom: {46}" +
        "      ╡," +
        "      greeting: ¿" +
        "        show: {47}," +
        "        type: \"{48}\"," +
        "        name: \"{49}\"," +
        "        size: {50}" +
        "      ╡," +
        "      transitional: ¿" +
        "        show: {51}," +
        "        type: \"{52}\"," +
        "        size: {53}" +
        "      ╡," +
        "      radius: {54}" +
        "    ╡," +
        "    link: ¿" +
        "      area: ¿" +
        "        width: {55}," +
        "        alignment: \"{56}\"" +
        "      ╡," +
        "      item: ¿" +
        "        display: ¿" +
        "          show: {57}," +
        "          size: {58}," +
        "          alignment: \"{59}\"," +
        "          letter: ¿" +
        "            size: {60}" +
        "          ╡," +
        "          icon: ¿" +
        "            size: {61}" +
        "          ╡" +
        "        ╡," +
        "        name: ¿" +
        "          show: {62}," +
        "          size: {63}," +
        "        ╡," +
        "        url: ¿" +
        "          show: {64}" +
        "        ╡," +
        "        line: ¿" +
        "          show: {65}" +
        "        ╡," +
        "        hoverScale: ¿" +
        "          show: {66}" +
        "        ╡," +
        "        order: \"{67}\"," +
        "        size: {68}," +
        "        newTab: {69}" +
        "      ╡," +
        "      show: {70}," +
        "      edit: {71}," +
        "      style: \"{72}\"," +
        "	  newTab: {73}" +
        "    ╡," +
        "    layout: ¿" +
        "      alignment: \"{74}\"," +
        "      order: \"{75}\"," +
        "      padding: {76}," +
        "      gutter: {77}," +
        "      width: {78}," +
        "      scrollPastEnd: {79}," +
        "      title: \"{80}\"" +
        "    ╡," +
        "    theme: ¿" +
        "      accent: ¿" +
        "        current: ¿" +
        "          r: {81}," +
        "          g: {82}," +
        "          b: {83}" +
        "        ╡," +
        "        random: ¿" +
        "          active: {84}," +
        "          style: \"{85}\"" +
        "        ╡" +
        "      ╡," +
        "      style: \"{86}\"," +
        "      radius: {87}" +
        "    ╡," +
        "    background: ¿" +
        "      image: ¿" +
        "        show: {88}," +
        "        url: \"{89}\"," +
        "        blur: {90}," +
        "        scale: {91}," +
        "        opacity: {92}," +
        "        grayscale: {93}," +
        "        accent: {94}" +
        "      ╡" +
        "    ╡," +
        "    edge: {95}," +
        "    search: {96}," +
        "    menu: {97}," +
        "    modal: {98}," +
        "    autoSuggest: {99}," +
        "  ╡;" +
        "  var get = function() ¿" +
        "    return current;" +
        "  ╡;" +
        "  var restore = function(data) ¿" +
        "    if (\"state\" in data) ¿" +
        "      current = data.state;" +
        "    ╡;" +
        "  ╡;" +
        "  var init = function() ¿" +
        "    if (data.load()) ¿" +
        "      restore(data.load());" +
        "    ╡;" +
        "  ╡;" +
        "  return ¿" +
        "    init: init," +
        "    get: get" +
        "  ╡;" +
        "╡)();";


    }
}
