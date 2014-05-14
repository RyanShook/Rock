﻿// <copyright>
// Copyright 2013 by the Spark Development Network
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// </copyright>
//
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using Rock.Model;
using Rock.Reporting.Dashboard.Flot;

namespace Rock.Web.UI.Controls
{
    /// <summary>
    /// Abstract class for much of the Flot Charts Logic
    /// Subset of the spec at https://github.com/flot/flot/blob/master/API.md
    /// </summary>
    public abstract class FlotChart : CompositeControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlotChart"/> class.
        /// </summary>
        public FlotChart()
        {
            Options = new ChartOptions();

            // set default options, but ChartStyle or child class can override some of it
            this.Options.xaxis = new AxisOptions { mode = AxisMode.time };
            this.Options.grid = new GridOptions { hoverable = true, clickable = true };
        }

        #region Controls

        private HiddenField _hfMetricId;
        private HiddenFieldWithClass _hfRestUrl;
        private HiddenFieldWithClass _hfRestUrlParams;
        private HiddenFieldWithClass _hfSeriesNameUrl;
        private HiddenFieldWithClass _hfXAxisLabel;
        private HiddenFieldWithClass _hfYAxisLabel;
        private Label _lblDashboardTitle;
        private Label _lblDashboardSubtitle;
        private Panel _pnlChartPlaceholder;
        private HelpBlock _hbChartOptions;

        #endregion

        /// <summary>
        /// Gets or sets the metric identifier.
        /// </summary>
        /// <value>
        /// The metric identifier.
        /// </value>
        public int? MetricId
        {
            get
            {
                EnsureChildControls();
                return _hfMetricId.Value.AsInteger( false );
            }

            set
            {
                EnsureChildControls();
                _hfMetricId.Value = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the MetricValueType (Goal or Measure)
        /// Leave null for both
        /// </summary>
        /// <value>
        /// The type of the metric value.
        /// </value>
        public MetricValueType? MetricValueType
        {
            get
            {
                return ViewState["MetricValueType"] as MetricValueType?;
            }

            set
            {
                ViewState["MetricValueType"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the start date.
        /// </summary>
        /// <value>
        /// The start date.
        /// </value>
        public DateTime? StartDate
        {
            get
            {
                return ViewState["StartDate"] as DateTime?;
            }

            set
            {
                ViewState["StartDate"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the end date.
        /// </summary>
        /// <value>
        /// The end date.
        /// </value>
        public DateTime? EndDate
        {
            get
            {
                return ViewState["EndDate"] as DateTime?;
            }

            set
            {
                ViewState["EndDate"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the entity identifier.
        /// </summary>
        /// <value>
        /// The entity identifier.
        /// </value>
        public int? EntityId
        {
            get
            {
                return ViewState["EntityId"] as int?;
            }

            set
            {
                ViewState["EntityId"] = value;
            }
        }

        /// <summary>
        /// Gets a value indicating whether to combine values with different EntityId values into one series vs. showing each in it's own series
        /// </summary>
        /// <value>
        ///   <c>true</c> if [combine values]; otherwise, <c>false</c>.
        /// </value>
        public bool CombineValues
        {
            get
            {
                return ViewState["CombineValues"] as bool? ?? false;
            }

            set
            {
                ViewState["CombineValues"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            get
            {
                EnsureChildControls();
                return _lblDashboardTitle.Text;
            }

            set
            {
                EnsureChildControls();
                _lblDashboardTitle.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the subtitle.
        /// </summary>
        /// <value>
        /// The subtitle.
        /// </value>
        public string Subtitle
        {
            get
            {
                EnsureChildControls();
                return _lblDashboardSubtitle.Text;
            }

            set
            {
                EnsureChildControls();
                _lblDashboardSubtitle.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the x axis label.
        /// </summary>
        /// <value>
        /// The x axis label.
        /// </value>
        public string XAxisLabel
        {
            get
            {
                EnsureChildControls();
                return _hfXAxisLabel.Value;
            }

            set
            {
                EnsureChildControls();
                _hfXAxisLabel.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the y axis label.
        /// </summary>
        /// <value>
        /// The y axis label.
        /// </value>
        public string YAxisLabel
        {
            get
            {
                EnsureChildControls();
                return _hfYAxisLabel.Value;
            }

            set
            {
                EnsureChildControls();
                _hfYAxisLabel.Value = value;
            }
        }

        /// <summary>
        /// Gets or sets the height of the chart.
        /// </summary>
        /// <value>
        /// The height of the chart.
        /// </value>
        public Unit ChartHeight
        {
            get
            {
                return ViewState["ChartHeight"] as Unit? ?? new Unit( 170 );
            }

            set
            {
                ViewState["ChartHeight"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the width of the chart.
        /// </summary>
        /// <value>
        /// The width of the chart.
        /// </value>
        public Unit ChartWidth
        {
            get
            {
                return ViewState["ChartWidth"] as Unit? ?? new Unit( "100%" );
            }

            set
            {
                ViewState["ChartWidth"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the options.
        /// Defaults to a default set of options
        /// </summary>
        /// <value>
        /// The options.
        /// </value>
        public ChartOptions Options { get; set; }

        /// <summary>
        /// Gets or sets the data source URL.
        /// Defaults to "~/api/MetricValues/GetByMetricId/"
        /// </summary>
        /// <value>
        /// The data source URL.
        /// </value>
        public string DataSourceUrl
        {
            get
            {
                return ViewState["DataSourceUrl"] as string ?? "~/api/MetricValues/GetByMetricId/";
            }

            set
            {
                ViewState["DataSourceUrl"] = value;
            }
        }

        /// <summary>
        /// Gets or sets the series name URL.
        /// </summary>
        /// <value>
        /// The series name URL.
        /// </value>
        public string SeriesNameUrl
        {
            get
            {
                return ViewState["SeriesNameUrl"] as string ?? "~/api/MetricValues/GetSeriesName/";
            }

            set
            {
                ViewState["SeriesNameUrl"] = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show tooltip].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show tooltip]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowTooltip
        {
            get
            {
                return ViewState["ShowTooltip"] as bool? ?? true;
            }

            set
            {
                ViewState["ShowTooltip"] = value;
            }
        }

        /// <summary>
        /// Gets or sets a value indicating whether [show debug].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [show debug]; otherwise, <c>false</c>.
        /// </value>
        public bool ShowDebug
        {
            get
            {
                return ViewState["ShowDebug"] as bool? ?? false;
            }

            set
            {
                ViewState["ShowDebug"] = value;
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public class ChartClickArgs : EventArgs
        {
            /// <summary>
            /// Gets or sets the date time value.
            /// </summary>
            /// <value>
            /// The date time value.
            /// </value>
            public DateTime DateTimeValue { get; set; }

            /// <summary>
            /// Gets or sets the y value.
            /// </summary>
            /// <value>
            /// The y value.
            /// </value>
            public decimal? YValue { get; set; }

            /// <summary>
            /// Gets or sets the series identifier.
            /// </summary>
            /// <value>
            /// The series identifier.
            /// </value>
            public string SeriesId { get; set; }
        }

        /// <summary>
        /// Occurs when [chart click].
        /// </summary>
        public event EventHandler<ChartClickArgs> ChartClick;

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Init" /> event.
        /// </summary>
        /// <param name="e">An <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnInit( EventArgs e )
        {
            base.OnInit( e );

            RockPage.AddScriptLink( this.Page, "~/Scripts/flot/jquery.flot.js" );
            RockPage.AddScriptLink( this.Page, "~/Scripts/flot/jquery.flot.time.js" );
            RockPage.AddScriptLink( this.Page, "~/Scripts/flot/jquery.flot.resize.js" );
            RockPage.AddScriptLink( this.Page, "~/Scripts/flot/jquery.flot.pie.js" );

            EnsureChildControls();
        }

        /// <summary>
        /// Raises the <see cref="E:System.Web.UI.Control.Load" /> event.
        /// </summary>
        /// <param name="e">The <see cref="T:System.EventArgs" /> object that contains the event data.</param>
        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad( e );

            if ( this.Page.IsPostBack )
            {
                EnsureChildControls();
                if ( this.Page.Request.Params["__EVENTTARGET"] == _pnlChartPlaceholder.UniqueID )
                {
                    HandleChartClick();
                }
            }
        }

        /// <summary>
        /// Handles the chart click.
        /// </summary>
        private void HandleChartClick()
        {
            var eventArgs = this.Page.Request.Params["__EVENTARGUMENT"].Split( ';' );
            ChartClickArgs chartClickArgs = new ChartClickArgs();
            foreach ( var parts in eventArgs )
            {
                var param = parts.Split( '=' );
                if ( param[0] == "DateStamp" )
                {
                    long dateStamp = long.Parse( param[1] );
                    chartClickArgs.DateTimeValue = new DateTime( 1970, 1, 1 ).AddMilliseconds( dateStamp );
                }
                else if ( param[0] == "YValue" )
                {
                    chartClickArgs.YValue = param[1].AsInteger() ?? 0;
                }
                else if ( param[0] == "SeriesId" )
                {
                    chartClickArgs.SeriesId = param[1];
                }
            }

            if ( ChartClick != null )
            {
                ChartClick( this, chartClickArgs );
            }
        }

        /// <summary>
        /// Registers the java script.
        /// </summary>
        protected virtual void RegisterJavaScript()
        {
            var metric = new Rock.Model.MetricService( new Rock.Data.RockContext() ).Get( this.MetricId ?? 0 );
            if ( string.IsNullOrWhiteSpace( this.XAxisLabel ) && metric != null )
            {
                // if XAxisLabel hasn't been set, and this is a metric, automatically set it to the metric.XAxisLabel
                this.XAxisLabel = metric.XAxisLabel;
            }

            if ( string.IsNullOrWhiteSpace( this.YAxisLabel ) && metric != null )
            {
                // if YAxisLabel hasn't been set, and this is a metric, automatically set it to the metric.YAxisLabel
                this.YAxisLabel = metric.YAxisLabel;
            }

            // setup Rest URL parameters
            if ( this.MetricId.HasValue )
            {
                _hfRestUrlParams.Value = string.Format( "{0}", this.MetricId );

                List<string> filterParams = new List<string>();
                List<string> qryParams = new List<string>();
                if ( this.StartDate.HasValue )
                {
                    filterParams.Add( string.Format( "MetricValueDateTime ge DateTime'{0}'", this.StartDate.Value.ToString( "o" ) ) );
                }

                if ( this.EndDate.HasValue )
                {
                    filterParams.Add( string.Format( "MetricValueDateTime lt DateTime'{0}'", this.EndDate.Value.ToString( "o" ) ) );
                }

                if ( this.MetricValueType.HasValue )
                {
                    // MetricValueType is an enum, which isn't quite supported for $filters as of Web Api 2.1, so pass it as a regular rest param instead of as part of the odata $filter
                    qryParams.Add( string.Format( "metricValueType={0}", this.MetricValueType ) );
                }

                if ( this.EntityId.HasValue )
                {
                    filterParams.Add( string.Format( "EntityId eq {0}", this.EntityId ) );
                }

                if ( filterParams.Count > 0 )
                {
                    qryParams.Add( "$filter=" + filterParams.AsDelimited( " and " ) );
                }

                _hfRestUrlParams.Value += "?" + qryParams.AsDelimited( "&" );
            }
            else
            {
                _hfRestUrlParams.Value = string.Empty;
            }

            string scriptFormat =
@"
            var restUrl_{0} = $('#{0} .js-rest-url').val() + $('#{0} .js-rest-url-params').val();

            $.ajax({{
                url: restUrl_{0},
                dataType: 'json',
                contentType: 'application/json'
            }})
            .done( function (chartData) {{

                var chartOptions = {1}; 
                var plotSelector = '#{0} .js-chart-placeholder';
                var xaxisLabelText = $('#{0} .js-xaxis-value').val();
                var getSeriesUrl = $('#{0} .js-seriesname-url').val();
                var combineValues = {4};
";

            if ( this.GetType() == typeof( PieChart ) )
            {
                scriptFormat += @"
                Rock.controls.charts.plotPieChartData(chartData, chartOptions, plotSelector);
                
";
            }
            else
            {
                scriptFormat += @"
                Rock.controls.charts.plotChartData(chartData, chartOptions, plotSelector, xaxisLabelText, getSeriesUrl, combineValues);
";
            }

            scriptFormat += @"
                // plothover script (tooltip script) 
                {2}

                // plotclick script
                {3}
            }})
            .fail(function (jqXHR, textStatus, errorThrown) {{
                //debugger
            }});
";

            string chartOptionsJson = JsonConvert.SerializeObject( this.Options, Formatting.Indented, new JsonSerializerSettings() { ReferenceLoopHandling = ReferenceLoopHandling.Ignore, NullValueHandling = NullValueHandling.Ignore } );

            _hbChartOptions.Text = "<div style='white-space: pre; max-height: 120px; overflow-y:scroll' Font-Names='Consolas' Font-Size='8'><br />" + chartOptionsJson + "</div>";

            string restUrl = this.ResolveUrl( this.DataSourceUrl );
            _hfRestUrl.Value = restUrl;

            string getSeriesNameUrl = null;
            if ( !string.IsNullOrWhiteSpace( this.SeriesNameUrl ) )
            {
                getSeriesNameUrl = this.ResolveUrl( this.SeriesNameUrl.EnsureTrailingForwardslash() + this.MetricId + "/" );
            }

            _hfSeriesNameUrl.Value = getSeriesNameUrl;

            string tooltipScript = ShowTooltip ? string.Format( "Rock.controls.charts.bindTooltip('{0}')", this.ClientID ) : null;
            string chartClickScript = GetChartClickScript();

            string script = string.Format(
                scriptFormat,
                this.ClientID,      // {0}
                chartOptionsJson,   // {1}
                tooltipScript,      // {2}
                chartClickScript,   // {3}
                this.CombineValues.ToTrueFalse().ToLower() );  // {4}

            ScriptManager.RegisterStartupScript( this, this.GetType(), "flot-chart-script_" + this.ClientID, script, true );
        }

        /// <summary>
        /// Gets the chart click script.
        /// </summary>
        /// <returns></returns>
        private string GetChartClickScript()
        {
            string chartClickScript = null;
            if ( ChartClick != null )
            {
                string chartClickScriptFormat = @"
                $('#{0}').find('.js-chart-placeholder').bind('plotclick', function (event, pos, item) {{
                    
                    if (item) {{
                        debugger
                        __doPostBack('{1}', 'DateStamp=' + item.series.chartData[item.dataIndex].DateTimeStamp + ';YValue=' + item.series.chartData[item.dataIndex].YValue + ';SeriesId=' + item.series.chartData[item.dataIndex].SeriesId);
                    }}
                    else
                    {{
                        // no point was clicked
                    }}
                }});
";

                chartClickScript = string.Format( chartClickScriptFormat, this.ClientID, _pnlChartPlaceholder.UniqueID );
            }

            return chartClickScript;
        }

        /// <summary>
        /// Called by the ASP.NET page framework to notify server controls that use composition-based implementation to create any child controls they contain in preparation for posting back or rendering.
        /// </summary>
        protected override void CreateChildControls()
        {
            base.CreateChildControls();

            Controls.Clear();

            _hfMetricId = new HiddenField();
            _hfMetricId.ID = string.Format( "hfMetricId_{0}", this.ID );

            _hfXAxisLabel = new HiddenFieldWithClass();
            _hfXAxisLabel.ID = string.Format( "hfXAxisLabel_{0}", this.ID );
            _hfXAxisLabel.CssClass = "js-xaxis-value";

            _hfYAxisLabel = new HiddenFieldWithClass();
            _hfYAxisLabel.ID = string.Format( "hfYAxisLabel_{0}", this.ID );
            _hfYAxisLabel.CssClass = "js-yaxis-value";

            _hfRestUrlParams = new HiddenFieldWithClass();
            _hfRestUrlParams.ID = string.Format( "hfRestUrlParams_{0}", this.ID );
            _hfRestUrlParams.CssClass = "js-rest-url-params";

            _hfRestUrl = new HiddenFieldWithClass();
            _hfRestUrl.ID = string.Format( "hfRestUrl_{0}", this.ID );
            _hfRestUrl.CssClass = "js-rest-url";

            _hfSeriesNameUrl = new HiddenFieldWithClass();
            _hfSeriesNameUrl.ID = string.Format( "hfSeriesNameUrl_{0}", this.ID );
            _hfSeriesNameUrl.CssClass = "js-seriesname-url";

            _lblDashboardTitle = new Label();
            _lblDashboardTitle.CssClass = "dashboard-title";
            _lblDashboardTitle.ID = string.Format( "lblDashboardTitle_{0}", this.ID );

            _lblDashboardSubtitle = new Label();
            _lblDashboardSubtitle.CssClass = "dashboard-subtitle";
            _lblDashboardSubtitle.ID = string.Format( "lblDashboardSubtitle_{0}", this.ID );

            _pnlChartPlaceholder = new Panel();
            _pnlChartPlaceholder.CssClass = "dashboard-chart-placeholder js-chart-placeholder";
            _pnlChartPlaceholder.ID = string.Format( "pnlChartPlaceholder_{0}", this.ID );

            _hbChartOptions = new HelpBlock();
            _hbChartOptions.ID = string.Format( "hbChartOptions_{0}", this.ID );

            Controls.Add( _hfMetricId );
            Controls.Add( _hfXAxisLabel );
            Controls.Add( _hfYAxisLabel );
            Controls.Add( _hfRestUrlParams );
            Controls.Add( _hfRestUrl );
            Controls.Add( _hfSeriesNameUrl );
            Controls.Add( _lblDashboardTitle );
            Controls.Add( _lblDashboardSubtitle );
            Controls.Add( _pnlChartPlaceholder );
            Controls.Add( _hbChartOptions );
        }

        /// <summary>
        /// Outputs server control content to a provided <see cref="T:System.Web.UI.HtmlTextWriter" /> object and stores tracing information about the control if tracing is enabled.
        /// </summary>
        /// <param name="writer">The <see cref="T:System.Web.UI.HtmlTextWriter" /> object that receives the control content.</param>
        public override void RenderControl( HtmlTextWriter writer )
        {
            RegisterJavaScript();

            _pnlChartPlaceholder.Width = this.ChartWidth;
            _pnlChartPlaceholder.Height = this.ChartHeight;

            writer.AddAttribute( "id", this.ClientID );
            writer.AddAttribute( "class", this.GetType().Name.SplitCase().ToLower().Replace( " ", "-" ) );
            writer.RenderBeginTag( HtmlTextWriterTag.Div );

            _hfMetricId.RenderControl( writer );
            _hfRestUrlParams.RenderControl( writer );
            _hfRestUrl.RenderControl( writer );
            _hfSeriesNameUrl.RenderControl( writer );
            _hfXAxisLabel.RenderControl( writer );
            _hfYAxisLabel.RenderControl( writer );

            writer.AddAttribute( "class", "dashboard-title" );
            if ( this.Options.customSettings != null && this.Options.customSettings.titleAlign != null )
            {
                writer.AddStyleAttribute( HtmlTextWriterStyle.TextAlign, this.Options.customSettings.titleAlign );
            }

            if ( this.Options.customSettings != null && this.Options.customSettings.titleFont != null )
            {
                if ( !string.IsNullOrWhiteSpace( this.Options.customSettings.titleFont.color ) )
                {
                    _lblDashboardTitle.ForeColor = ColorTranslator.FromHtml( this.Options.customSettings.titleFont.color );
                }

                if ( !string.IsNullOrWhiteSpace( this.Options.customSettings.titleFont.family ) )
                {
                    _lblDashboardTitle.Font.Name = this.Options.customSettings.titleFont.family;
                }

                if ( this.Options.customSettings.titleFont.size.HasValue )
                {
                    _lblDashboardTitle.Font.Size = new FontUnit( this.Options.customSettings.titleFont.size.Value );
                }
            }

            writer.RenderBeginTag( HtmlTextWriterTag.Div );
            _lblDashboardTitle.RenderControl( writer );
            writer.RenderEndTag();

            writer.AddAttribute( "class", "dashboard-subtitle" );
            if ( this.Options.customSettings != null && this.Options.customSettings.subtitleAlign != null )
            {
                writer.AddStyleAttribute( HtmlTextWriterStyle.TextAlign, this.Options.customSettings.subtitleAlign );
            }

            if ( this.Options.customSettings != null && this.Options.customSettings.subtitleFont != null )
            {
                if ( !string.IsNullOrWhiteSpace( this.Options.customSettings.subtitleFont.color ) )
                {
                    _lblDashboardSubtitle.ForeColor = ColorTranslator.FromHtml( this.Options.customSettings.subtitleFont.color );
                }

                if ( !string.IsNullOrWhiteSpace( this.Options.customSettings.subtitleFont.family ) )
                {
                    _lblDashboardSubtitle.Font.Name = this.Options.customSettings.subtitleFont.family;
                }

                if ( this.Options.customSettings.subtitleFont.size.HasValue )
                {
                    _lblDashboardSubtitle.Font.Size = new FontUnit( this.Options.customSettings.subtitleFont.size.Value );
                }
            }

            writer.RenderBeginTag( HtmlTextWriterTag.Div );
            _lblDashboardSubtitle.RenderControl( writer );
            writer.RenderEndTag();

            if ( this.ShowDebug )
            {
                _hbChartOptions.RenderControl( writer );
            }

            _pnlChartPlaceholder.RenderControl( writer );

            writer.RenderEndTag();
        }
    }
}
