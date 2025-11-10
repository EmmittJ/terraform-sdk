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
        set => SetProperty("location", value);
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
        set => SetProperty("method", value);
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
        set => SetProperty("version", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        set => SetProperty("good_bad_metric_filter", value);
    }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &amp;quot;{X}s&amp;quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    public TerraformProperty<string>? WindowPeriod
    {
        set => SetProperty("window_period", value);
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
        SetOutput("name");
        SetOutput("calendar_period");
        SetOutput("display_name");
        SetOutput("goal");
        SetOutput("id");
        SetOutput("project");
        SetOutput("rolling_period_days");
        SetOutput("service");
        SetOutput("slo_id");
        SetOutput("user_labels");
    }

    /// <summary>
    /// A calendar period, semantically &amp;quot;since the start of the current
    /// &amp;lt;calendarPeriod&amp;gt;&amp;quot;. Possible values: [&amp;quot;DAY&amp;quot;, &amp;quot;WEEK&amp;quot;, &amp;quot;FORTNIGHT&amp;quot;, &amp;quot;MONTH&amp;quot;]
    /// </summary>
    public TerraformProperty<string> CalendarPeriod
    {
        get => GetRequiredOutput<TerraformProperty<string>>("calendar_period");
        set => SetProperty("calendar_period", value);
    }

    /// <summary>
    /// Name used for UI elements listing this SLO.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &amp;lt; goal &amp;lt;= 0.999
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    public required TerraformProperty<double> Goal
    {
        get => GetRequiredOutput<TerraformProperty<double>>("goal");
        set => SetProperty("goal", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// A rolling time period, semantically &amp;quot;in the past X days&amp;quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    public TerraformProperty<double> RollingPeriodDays
    {
        get => GetRequiredOutput<TerraformProperty<double>>("rolling_period_days");
        set => SetProperty("rolling_period_days", value);
    }

    /// <summary>
    /// ID of the service to which this SLO belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformProperty<string> Service
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service");
        set => SetProperty("service", value);
    }

    /// <summary>
    /// The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.
    /// </summary>
    public TerraformProperty<string> SloId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("slo_id");
        set => SetProperty("slo_id", value);
    }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> UserLabels
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("user_labels");
        set => SetProperty("user_labels", value);
    }

    /// <summary>
    /// Block for basic_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicSli block(s) allowed")]
    public List<GoogleMonitoringSloBasicSliBlock>? BasicSli
    {
        set => SetProperty("basic_sli", value);
    }

    /// <summary>
    /// Block for request_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestBasedSli block(s) allowed")]
    public List<GoogleMonitoringSloRequestBasedSliBlock>? RequestBasedSli
    {
        set => SetProperty("request_based_sli", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleMonitoringSloTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for windows_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsBasedSli block(s) allowed")]
    public List<GoogleMonitoringSloWindowsBasedSliBlock>? WindowsBasedSli
    {
        set => SetProperty("windows_based_sli", value);
    }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    public TerraformExpression Name => this["name"];

}
