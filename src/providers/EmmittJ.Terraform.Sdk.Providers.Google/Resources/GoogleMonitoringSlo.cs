using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_sli in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMonitoringSloBasicSliBlock : TerraformBlockBase
{
    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&#39;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [TerraformProperty("location")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&#39;s methods. For service types that don&#39;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [TerraformProperty("method")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&#39;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [TerraformProperty("version")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Version { get; set; }

}

/// <summary>
/// Block type for request_based_sli in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMonitoringSloRequestBasedSliBlock : TerraformBlockBase
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleMonitoringSloTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Block type for windows_based_sli in .
/// Nesting mode: list
/// </summary>
public partial class GoogleMonitoringSloWindowsBasedSliBlock : TerraformBlockBase
{
    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of &#39;good_bad_metric_filter&#39;,
    /// &#39;good_total_ratio_threshold&#39;, &#39;metric_mean_in_range&#39;,
    /// &#39;metric_sum_in_range&#39; must be set for &#39;windows_based_sli&#39;.
    /// </summary>
    [TerraformProperty("good_bad_metric_filter")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GoodBadMetricFilter { get; set; }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &amp;quot;{X}s&amp;quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    [TerraformProperty("window_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? WindowPeriod { get; set; }

}

/// <summary>
/// Manages a google_monitoring_slo resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleMonitoringSlo : TerraformResource
{
    public GoogleMonitoringSlo(string name) : base("google_monitoring_slo", name)
    {
    }

    /// <summary>
    /// A calendar period, semantically &amp;quot;since the start of the current
    /// &amp;lt;calendarPeriod&amp;gt;&amp;quot;. Possible values: [&amp;quot;DAY&amp;quot;, &amp;quot;WEEK&amp;quot;, &amp;quot;FORTNIGHT&amp;quot;, &amp;quot;MONTH&amp;quot;]
    /// </summary>
    [TerraformProperty("calendar_period")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CalendarPeriod { get; set; }

    /// <summary>
    /// Name used for UI elements listing this SLO.
    /// </summary>
    [TerraformProperty("display_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DisplayName { get; set; }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &amp;lt; goal &amp;lt;= 0.999
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    [TerraformProperty("goal")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<double> Goal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// A rolling time period, semantically &amp;quot;in the past X days&amp;quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    [TerraformProperty("rolling_period_days")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RollingPeriodDays { get; set; }

    /// <summary>
    /// ID of the service to which this SLO belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformProperty("service")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Service { get; set; }

    /// <summary>
    /// The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.
    /// </summary>
    [TerraformProperty("slo_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> SloId { get; set; }

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [TerraformProperty("user_labels")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? UserLabels { get; set; }

    /// <summary>
    /// Block for basic_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicSli block(s) allowed")]
    [TerraformProperty("basic_sli")]
    public partial TerraformList<TerraformBlock<GoogleMonitoringSloBasicSliBlock>>? BasicSli { get; set; }

    /// <summary>
    /// Block for request_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestBasedSli block(s) allowed")]
    [TerraformProperty("request_based_sli")]
    public partial TerraformList<TerraformBlock<GoogleMonitoringSloRequestBasedSliBlock>>? RequestBasedSli { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<GoogleMonitoringSloTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for windows_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsBasedSli block(s) allowed")]
    [TerraformProperty("windows_based_sli")]
    public partial TerraformList<TerraformBlock<GoogleMonitoringSloWindowsBasedSliBlock>>? WindowsBasedSli { get; set; }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

}
