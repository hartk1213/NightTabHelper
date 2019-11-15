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
        ""+
        "  var all = [{0}];\n" +
        "  var get = function(data) {\n" +
        "    var _singleBookmark = function() {\n" +
        "      var found = false;\n" +
        "      for (var i = 0; i < all.length; i++) {\n" +
        "        if (all[i].timeStamp === data.timeStamp) {\n" +
        "          found = all[i];\n" +
        "        };\n" +
        "      };\n" +
        "      return found;\n" +
        "    };\n" +
        "    if (data && typeof data.timeStamp == \"number\") {\n" +
        "      return _singleBookmark();\n" +
        "    } else {\n" +
        "      return all;\n" +
        "    };\n" +
        "  };\n" +
        "  var restore = function(data) {\n" +
        "    if (\"bookmarks\" in data) {\n" +
        "      all = data.bookmarks;\n" +
        "    };\n" +
        "  };\n" +
        "  var add = function(data) {\n" +
        "    all.push(data);\n" +
        "  };\n" +
        "  var edit = function(data) {\n" +
        "    for (var i = 0; i < all.length; i++) {\n" +
        "      if (all[i].timeStamp === data.timeStamp) {\n" +
        "        all[i] = data;\n" +
        "      };\n" +
        "    };\n" +
        "  };\n" +
        "  var remove = function(data) {\n" +
        "    for (var i = 0; i < all.length; i++) {\n" +
        "      if (all[i].timeStamp === data.timeStamp) {\n" +
        "        all.splice(all.indexOf(all[i]), 1);\n" +
        "      };\n" +
        "    };\n" +
        "  };\n" +
        "  var sort = function(by) {\n" +
        "    var action = {\n" +
        "      name: function(array) {\n" +
        "        return helper.sortObject(array, \"name\");\n" +
        "      },\n" +
        "      letter: function(array) {\n" +
        "        return helper.sortObject(array, \"letter\");\n" +
        "      },\n" +
        "      icon: function(array) {\n" +
        "        return helper.sortObject(array, \"icon.name\");\n" +
        "      }\n" +
        "    };\n" +
        "    all = action[by](all);\n" +
        "  };\n" +
        "  var move = function(origin, destination) {\n" +
        "    all = helper.moveArrayItem(all, origin, destination);\n" +
        "  };\n" +
        "  var init = function() {\n" +
        "    if (data.load()) {\n" +
        "      restore(data.load());\n" +
        "    };\n" +
        "  };\n" +
        "  // exposed methods\n" +
        "  return {\n" +
        "    all: all,\n" +
        "    init: init,\n" +
        "    get: get,\n" +
        "    add: add,\n" +
        "    edit: edit,\n" +
        "    sort: sort,\n" +
        "    move: move,\n" +
        "    remove: remove,\n" +
        "    restore: restore\n" +
        "  };\n" +
        "})();";


        public string oldStatejs = "var state = (function() ¿\n" +
        "  var current = ¿\n" +
        "    header: ¿\n" +
        "      area: ¿\n" +
        "        width: {0},\n" +
        "        alignment: \"{1}\"\n" +
        "      ╡,\n" +
        "      item: ¿\n" +
        "        alignment: \"{2}\"\n" +
        "      ╡,\n" +
        "      clock: ¿\n" +
        "        hours: ¿\n" +
        "          show: {3},\n" +
        "          display: \"{4}\"\n" +
        "        ╡,\n" +
        "        minutes: ¿\n" +
        "          show: {5},\n" +
        "          display: \"{6}\"\n" +
        "        ╡,\n" +
        "        seconds: ¿\n" +
        "          show: {7},\n" +
        "          display: \"{8}\"\n" +
        "        ╡,\n" +
        "        separator: ¿\n" +
        "          show: {9}\n" +
        "        ╡,\n" +
        "        meridiem: ¿\n" +
        "          show: {10}\n" +
        "        ╡,\n" +
        "        hour24: ¿\n" +
        "          show: {11}\n" +
        "        ╡,\n" +
        "        size: {12}\n" +
        "      ╡,\n" +
        "      date: ¿\n" +
        "        day: ¿\n" +
        "          show: {13},\n" +
        "          display: \"{14}\",\n" +
        "          weekStart: \"{15}\",\n" +
        "          length: \"{16}\"\n" +
        "        ╡,\n" +
        "        date: ¿\n" +
        "          show: {17},\n" +
        "          display: \"{18}\",\n" +
        "          ordinal: {19}\n" +
        "        ╡,\n" +
        "        month: ¿\n" +
        "          show: {20},\n" +
        "          display: \"{21}\",\n" +
        "          length: \"{22}\",\n" +
        "          ordinal: {23}\n" +
        "        ╡,\n" +
        "        year: ¿\n" +
        "          show: {24},\n" +
        "          display: \"{25}\"\n" +
        "        ╡,\n" +
        "        separator: ¿\n" +
        "          show: {26}\n" +
        "        ╡,\n" +
        "        format: \"{27}\",\n" +
        "        size: {28}\n" +
        "      ╡,\n" +
        "      search: ¿\n" +
        "        show: {29},\n" +
        "        style: \"{30}\",\n" +
        "        width: {31},\n" +
        "        focus: {32},\n" +
        "        engine: ¿\n" +
        "          selected: \"{33}\",\n" +
        "          google: ¿\n" +
        "            url: \"https://www.google.com/search\",\n" +
        "            name: \"Google\"\n" +
        "          ╡,\n" +
        "          duckduckgo: ¿\n" +
        "            url: \"https://duckduckgo.com/\",\n" +
        "            name: \"Duck Duck Go\"\n" +
        "          ╡,\n" +
        "          youtube: ¿\n" +
        "            url: \"https://www.youtube.com/results?search_query=\",\n" +
        "            name: \"YouTube\"\n" +
        "          ╡,\n" +
        "          giphy: ¿\n" +
        "            url: \"https://giphy.com/search/\",\n" +
        "            name: \"Giphy\"\n" +
        "          ╡,\n" +
        "          bing: ¿\n" +
        "            url: \"https://www.bing.com/search?q=\",\n" +
        "            name: \"Bing\"\n" +
        "          ╡,\n" +
        "          custom: ¿\n" +
        "            url: \"{34}\",\n" +
        "            name: \"{35}\"\n" +
        "          ╡\n" +
        "        ╡,\n" +
        "        text: ¿\n" +
        "          alignment: \"{36}\"\n" +
        "        ╡,\n" +
        "        size: {37}\n" +
        "      ╡,\n" +
        "      button: ¿\n" +
        "        editAdd: ¿\n" +
        "          show: {38},\n" +
        "        ╡,\n" +
        "        accent: ¿\n" +
        "          show: {39},\n" +
        "        ╡,\n" +
        "        style: \"{40}\",\n" +
        "        size: {41}\n" +
        "      ╡,\n" +
        "      shade: ¿\n" +
        "        show: {42},\n" +
        "        style: \"{43}\",\n" +
        "        opacity: {44}\n" +
        "      ╡,\n" +
        "      border: ¿\n" +
        "        top: {45},\n" +
        "        bottom: {46}\n" +
        "      ╡,\n" +
        "      greeting: ¿\n" +
        "        show: {47},\n" +
        "        type: \"{48}\",\n" +
        "        name: \"{49}\",\n" +
        "        size: {50}\n" +
        "      ╡,\n" +
        "      transitional: ¿\n" +
        "        show: {51},\n" +
        "        type: \"{52}\",\n" +
        "        size: {53}\n" +
        "      ╡,\n" +
        "      radius: {54}\n" +
        "    ╡,\n" +
        "    link: ¿\n" +
        "      area: ¿\n" +
        "        width: {55},\n" +
        "        alignment: \"{56}\"\n" +
        "      ╡,\n" +
        "      item: ¿\n" +
        "        display: ¿\n" +
        "          show: {57},\n" +
        "          size: {58},\n" +
        "          alignment: \"{59}\",\n" +
        "          letter: ¿\n" +
        "            size: {60}\n" +
        "          ╡,\n" +
        "          icon: ¿\n" +
        "            size: {61}\n" +
        "          ╡\n" +
        "        ╡,\n" +
        "        name: ¿\n" +
        "          show: {62},\n" +
        "          size: {63},\n" +
        "        ╡,\n" +
        "        url: ¿\n" +
        "          show: {64}\n" +
        "        ╡,\n" +
        "        line: ¿\n" +
        "          show: {65}\n" +
        "        ╡,\n" +
        "        hoverScale: ¿\n" +
        "          show: {66}\n" +
        "        ╡,\n" +
        "        order: \"{67}\",\n" +
        "        size: {68},\n" +
        "        newTab: {69}\n" +
        "      ╡,\n" +
        "      show: {70},\n" +
        "      edit: {71},\n" +
        "      style: \"{72}\",\n" +
        "	  newTab: {73}\n" +
        "    ╡,\n" +
        "    layout: ¿\n" +
        "      alignment: \"{74}\",\n" +
        "      order: \"{75}\",\n" +
        "      padding: {76},\n" +
        "      gutter: {77},\n" +
        "      width: {78},\n" +
        "      scrollPastEnd: {79},\n" +
        "      title: \"{80}\"\n" +
        "    ╡,\n" +
        "    theme: ¿\n" +
        "      accent: ¿\n" +
        "        current: ¿\n" +
        "          r: {81},\n" +
        "          g: {82},\n" +
        "          b: {83}\n" +
        "        ╡,\n" +
        "        random: ¿\n" +
        "          active: {84},\n" +
        "          style: \"{85}\"\n" +
        "        ╡\n" +
        "      ╡,\n" +
        "      style: \"{86}\",\n" +
        "      radius: {87}\n" +
        "    ╡,\n" +
        "    background: ¿\n" +
        "      image: ¿\n" +
        "        show: {88},\n" +
        "        url: \"{89}\",\n" +
        "        blur: {90},\n" +
        "        scale: {91},\n" +
        "        opacity: {92},\n" +
        "        grayscale: {93},\n" +
        "        accent: {94}\n" +
        "      ╡\n" +
        "    ╡,\n" +
        "    edge: {95},\n" +
        "    search: {96},\n" +
        "    menu: {97},\n" +
        "    modal: {98},\n" +
        "    autoSuggest: {99},\n" +
        "  ╡;\n" +
        "  var get = function() ¿\n" +
        "    return current;\n" +
        "  ╡;\n" +
        "  var restore = function(data) ¿\n" +
        "    if (\"state\" in data) ¿\n" +
        "      current = data.state;\n" +
        "    ╡;\n" +
        "  ╡;\n" +
        "  var init = function() ¿\n" +
        "    if (data.load()) ¿\n" +
        "      restore(data.load());\n" +
        "    ╡;\n" +
        "  ╡;\n" +
        "  return ¿\n" +
        "    init: init,\n" +
        "    get: get\n" +
        "  ╡;\n" +
        "╡)();";


    }
}
