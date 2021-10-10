using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using XCharts;

public class ChartManager : MonoBehaviour
{
    public GameObject LineChart;

    private LineChart linechart;

    // Start is called before the first frame update
    void Start()
    {
        linechart = LineChart.GetComponent<LineChart>();
        linechart.RemoveData();
        linechart.AddSerie(SerieType.Line);
        linechart.yAxes[0].type = Axis.AxisType.Value;
        linechart.yAxes[0].minMaxType = Axis.AxisMinMaxType.Custom;
        linechart.yAxes[0].min = -1;
        linechart.yAxes[0].max = 1;
        linechart.yAxes[0].splitNumber = 10;

        HttpRequestManager.Instance.GetSummary();
        ChartInit();
    }
    public async void ChartInit()
    {
        while (HttpRequestManager.Instance.IsGetting)
        {
            await Task.Delay(10);
        }

        var data = HttpRequestManager.Instance.SummaryListJson.data;

        foreach (var summary in HttpRequestManager.Instance.SummaryListJson.data)
        {
            linechart.AddYAxisData(summary.date);
            linechart.AddData(0, (double)summary.score, summary.date);
        }
    }

        // Update is called once per frame
        void Update()
    {
        
    }
}
