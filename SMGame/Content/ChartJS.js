window.onload = function () {

    var chart = new CanvasJS.Chart("chartContainer", {
        animationEnabled: true,
        theme: "light2",
        title: {
            text: "Stock Market History Chart"
        },

        axisX: {
            title: "Round"
        },


        axisY: {
            title: "Share Price",
            includeZero: false
        },
        toolTip: {
            shared: true
        },
        data: [{
            type: "spline",
            name: "Virtusa",
            showInLegend: true,
            dataPoints: [
               { y: 10 },
               { y: 15 },
               { y: 18 },
               { y: 20 },
               { y: 22 },
               { y: 25 },
               { y: 30 },
               { y: 35 },
               { y: 40 },
               { y: 42 },
               { y: 48 },
               { y: 50 }
            ]




        }, {
            type: "spline",
            name: "MIT",
            showInLegend: true,
            dataPoints: [
               { y: 12 },
               { y: 15 },
               { y: 18 },
               { y: 20 },
               { y: 25 },
               { y: 30 },
               { y: 32 },
               { y: 35 },
               { y: 40 },
               { y: 42 },
               { y: 48 },
               { y: 55 }
            ]


        }, {
            type: "spline",
            name: "WSO2",
            showInLegend: true,
            dataPoints: [
               { y: 12 },
               { y: 16 },
               { y: 20 },
               { y: 22 },
               { y: 30 },
               { y: 32 },
               { y: 34 },
               { y: 38 },
               { y: 40 },
               { y: 42 },
               { y: 45 },
               { y: 55 }
            ]


        }, {
            type: "spline",
            name: "Sampath Bank",
            showInLegend: true,
            dataPoints: [
               { y: 10 },
               { y: 14 },
               { y: 16 },
               { y: 20 },
               { y: 22 },
               { y: 25 },
               { y: 26 },
               { y: 28 },
               { y: 29 },
               { y: 30 },
               { y: 32 },
               { y: 40 }
            ]


        },
        {
            type: "spline",
            name: "HNB",
            showInLegend: true,
            dataPoints: [
               { y: 14 },
               { y: 15 },
               { y: 16 },
               { y: 18 },
               { y: 20 },
               { y: 22 },
               { y: 25 },
               { y: 28 },
               { y: 30 },
               { y: 32 },
               { y: 35 },
               { y: 40 }
            ]
        },

        {
            type: "spline",
            name: "Bank Of Cylon",
            showInLegend: true,
            dataPoints: [
               { y: 15 },
               { y: 18 },
               { y: 20 },
               { y: 22 },
               { y: 24 },
               { y: 26 },
               { y: 28 },
               { y: 30 },
               { y: 32 },
               { y: 34 },
               { y: 36 },
               { y: 40 }
            ]
        },

        {
            type: "spline",
            name: "Marina",
            showInLegend: true,
            dataPoints: [
               { y: 14 },
               { y: 16 },
               { y: 17 },
               { y: 18 },
               { y: 20 },
               { y: 22 },
               { y: 25 },
               { y: 26 },
               { y: 28 },
               { y: 30 },
               { y: 35 },
               { y: 40 }
            ]
        },

        {
            type: "spline",
            name: "LUX",
            showInLegend: true,
            dataPoints: [
               { y: 15 },
               { y: 18 },
               { y: 22 },
               { y: 26 },
               { y: 29 },
               { y: 32 },
               { y: 40 },
               { y: 46 },
               { y: 48 },
               { y: 50 },
               { y: 55 },
               { y: 58 }
            ]
        },

        {
            type: "spline",
            name: "Nature Secret",
            showInLegend: true,
            dataPoints: [
               { y: 8 },
               { y: 10 },
               { y: 12 },
               { y: 14 },
               { y: 16 },
               { y: 17 },
               { y: 18 },
               { y: 19 },
               { y: 20 },
               { y: 22 },
               { y: 24 },
               { y: 25 }
            ]
        },

        {
            type: "spline",
            name: "Damro",
            showInLegend: true,
            dataPoints: [
               { y: 16 },
               { y: 20 },
               { y: 25 },
               { y: 28 },
               { y: 30 },
               { y: 32 },
               { y: 35 },
               { y: 38 },
               { y: 40 },
               { y: 45 },
               { y: 50 },
               { y: 60 }
            ]
        },

        {
            type: "spline",
            name: "MAS Holdings",
            showInLegend: true,
            dataPoints: [
               { y: 14 },
               { y: 16 },
               { y: 20 },
               { y: 22 },
               { y: 25 },
               { y: 28 },
               { y: 30 },
               { y: 35 },
               { y: 38 },
               { y: 40 },
               { y: 45 },
               { y: 50 }
            ]
        },



        {
            type: "spline",
            name: "Singer",
            showInLegend: true,
            dataPoints: [
               { y: 12 },
               { y: 14 },
               { y: 16 },
               { y: 18 },
               { y: 20 },
               { y: 22 },
               { y: 26 },
               { y: 28 },
               { y: 30 },
               { y: 39 },
               { y: 48 },
               { y: 60 }
            ]


        }]
    });
    chart.render();

}
