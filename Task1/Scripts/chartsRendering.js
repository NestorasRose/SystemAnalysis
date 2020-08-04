AOS.init();
var data = [];
var iterationData = [];
var storyNames = [];
var iterationNum = [];
$.ajax({
    type: "GET",
    url: "/Story/IndexJson",
    success: function (response) {
        if (response != null) {
            for (var item of response) {
                data.push(item["taskTotalHours"]);
                storyNames.push(jQuery(item["name"]).text());
                if (iterationData[item["iteration"]])
                    iterationData[item["iteration"]] = iterationData[item["iteration"]] + item["taskTotalHours"];
                else
                    iterationData[item["iteration"]] = item["taskTotalHours"];
            }

            for (let i = 0; i <= iterationData.length; i++)
                iterationNum.push(i);

            iterationData = Array.from(iterationData, item => item || null);
            renderCharts();
        } else {
            alert("Something went wrong");
        }
    },
    failure: function (response) {
        alert(response.responseText);
    },
    error: function (response) {
        alert(response.responseText);
    }
});


function renderCharts() {

    var optionsStoryXhoursY = {
        chart: {
            type: 'line'
        },
        series: [{
            name: 'Hours',
            data: data
        }],
        xaxis: {
            categories: storyNames
        }
    }

    var options2 = {
        chart: {
            type: 'candlestick'
        },
        series: [{
            data: [{
                x: new Date(2016, 01, 01),
                y: [51.98, 56.29, 51.59, 53.85]
            },
            {
                x: new Date(2016, 02, 01),
                y: [53.66, 54.99, 51.35, 52.95]
            },
            {
                x: new Date(2016, 08, 01),
                y: [52.76, 57.35, 52.15, 57.03]
            }]
        }],
        plotOptions: {
            candlestick: {
                colors: {
                    upward: '#3C90EB',
                    downward: '#DF7D46'
                }
            }
        }

    }

    var optionsIterationXhoursY = {
        chart: {
            type: 'bar'
        },
        series: [{
            name: 'Hours',
            data: iterationData
        }],
        xaxis: {
            categories: iterationNum
        }
    }



    var chart = new ApexCharts(document.querySelector("#chart"), optionsStoryXhoursY);
    var chart2 = new ApexCharts(document.querySelector("#chart2"), options2);
    var chart3 = new ApexCharts(document.querySelector("#chart3"), optionsIterationXhoursY);
    var chart4 = new ApexCharts(document.querySelector("#chart4"), optionsStoryXhoursY);

    chart.render();
    chart2.render();
    chart3.render();
    chart4.render();
    AOS.refresh();
}
