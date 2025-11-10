using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloBasicSliBlock : TerraformBlock
{
    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&#39;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Location
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("location");
        set => WithProperty("location", value);
    }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&#39;s methods. For service types that don&#39;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Method
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("method");
        set => WithProperty("method", value);
    }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&#39;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    public HashSet<TerraformProperty<string>>? Version
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("version");
        set => WithProperty("version", value);
    }

}

/// <summary>
/// Block type for request_based_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloRequestBasedSliBlock : TerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringSloTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Block type for windows_based_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlock : TerraformBlock
{
    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of &#39;good_bad_metric_filter&#39;,
    /// &#39;good_total_ratio_threshold&#39;, &#39;metric_mean_in_range&#39;,
    /// &#39;metric_sum_in_range&#39; must be set for &#39;windows_based_sli&#39;.
    /// </summary>
    public TerraformProperty<string>? GoodBadMetricFilter
    {
        get => GetProperty<TerraformProperty<string>>("good_bad_metric_filter");
        set => WithProperty("good_bad_metric_filter", value);
    }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &amp;quot;{X}s&amp;quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    public TerraformProperty<string>? WindowPeriod
    {
        get => GetProperty<TerraformProperty<string>>("window_period");
        set => WithProperty("window_period", value);
    }

}

/// <summary>
/// Manages a google_monitoring_slo resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMonitoringSlo : TerraformResource
{
    public GoogleMonitoringSlo(string name) : base("google_monitoring_slo", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("name");
    }

    /// <summary>
    /// A calendar period, semantically &amp;quot;since the start of the current
    /// &amp;lt;calendarPeriod&amp;gt;&amp;quot;. Possible values: [&amp;quot;DAY&amp;quot;, &amp;quot;WEEK&amp;quot;, &amp;quot;FORTNIGHT&amp;quot;, &amp;quot;MONTH&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? CalendarPeriod
    {
        get => GetProperty<TerraformProperty<string>>("calendar_period");
        set => this.WithProperty("calendar_period", value);
    }

    /// <summary>
    /// Name used for UI elements listing this SLO.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &amp;lt; goal &amp;lt;= 0.999
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    public required TerraformProperty<double> Goal
    {
        get => GetProperty<TerraformProperty<double>>("goal");
        set => this.WithProperty("goal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string>? Project
    {
        get => GetProperty<TerraformProperty<string>>("project");
        set => this.WithProperty("project", value);
    }

    /// <summary>
    /// A rolling time period, semantically &amp;quot;in the past X days&amp;quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    public TerraformProperty<double>? RollingPeriodDays
    {
        get => GetProperty<TerraformProperty<double>>("rolling_period_days");
        set => this.WithProperty("rolling_period_days", value);
    }

    /// <summary>
    /// ID of the service to which this SLO belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.
    /// </summary>
    public TerraformProperty<string>? SloId
    {
        get => GetProperty<TerraformProperty<string>>("slo_id");
        set => this.WithProperty("slo_id", value);
    }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? UserLabels
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("user_labels");
        set => this.WithProperty("user_labels", value);
    }

    /// <summary>
    /// Block for basic_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicSli block(s) allowed")]
    public List<GoogleMonitoringSloBasicSliBlock>? BasicSli
    {
        get => GetProperty<List<GoogleMonitoringSloBasicSliBlock>>("basic_sli");
        set => this.WithProperty("basic_sli", value);
    }

    /// <summary>
    /// Block for request_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestBasedSli block(s) allowed")]
    public List<GoogleMonitoringSloRequestBasedSliBlock>? RequestBasedSli
    {
        get => GetProperty<List<GoogleMonitoringSloRequestBasedSliBlock>>("request_based_sli");
        set => this.WithProperty("request_based_sli", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringSloTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleMonitoringSloTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for windows_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsBasedSli block(s) allowed")]
    public List<GoogleMonitoringSloWindowsBasedSliBlock>? WindowsBasedSli
    {
        get => GetProperty<List<GoogleMonitoringSloWindowsBasedSliBlock>>("windows_based_sli");
        set => this.WithProperty("windows_based_sli", value);
    }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    public TerraformExpression Name => this["name"];

}
