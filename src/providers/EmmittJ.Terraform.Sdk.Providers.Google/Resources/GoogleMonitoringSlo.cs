using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for basic_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloBasicSliBlock : ITerraformBlock
{
    /// <summary>
    /// An optional set of locations to which this SLI is relevant.
    /// Telemetry from other locations will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// locations in which the Service has activity. For service types
    /// that don&#39;t support breaking down by location, setting this
    /// field will result in an error.
    /// </summary>
    [TerraformPropertyName("location")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Location { get; set; }

    /// <summary>
    /// An optional set of RPCs to which this SLI is relevant.
    /// Telemetry from other methods will not be used to calculate
    /// performance for this SLI. If omitted, this SLI applies to all
    /// the Service&#39;s methods. For service types that don&#39;t support
    /// breaking down by method, setting this field will result in an
    /// error.
    /// </summary>
    [TerraformPropertyName("method")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Method { get; set; }

    /// <summary>
    /// The set of API versions to which this SLI is relevant.
    /// Telemetry from other API versions will not be used to
    /// calculate performance for this SLI. If omitted,
    /// this SLI applies to all API versions. For service types
    /// that don&#39;t support breaking down by version, setting this
    /// field will result in an error.
    /// </summary>
    [TerraformPropertyName("version")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<HashSet<TerraformProperty<string>>>? Version { get; set; }

}

/// <summary>
/// Block type for request_based_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloRequestBasedSliBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleMonitoringSloTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Update { get; set; }

}

/// <summary>
/// Block type for windows_based_sli in .
/// Nesting mode: list
/// </summary>
public class GoogleMonitoringSloWindowsBasedSliBlock : ITerraformBlock
{
    /// <summary>
    /// A TimeSeries [monitoring filter](https://cloud.google.com/monitoring/api/v3/filters)
    /// with ValueType = BOOL. The window is good if any true values
    /// appear in the window. One of &#39;good_bad_metric_filter&#39;,
    /// &#39;good_total_ratio_threshold&#39;, &#39;metric_mean_in_range&#39;,
    /// &#39;metric_sum_in_range&#39; must be set for &#39;windows_based_sli&#39;.
    /// </summary>
    [TerraformPropertyName("good_bad_metric_filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? GoodBadMetricFilter { get; set; }

    /// <summary>
    /// Duration over which window quality is evaluated, given as a
    /// duration string &amp;quot;{X}s&amp;quot; representing X seconds. Must be an
    /// integer fraction of a day and at least 60s.
    /// </summary>
    [TerraformPropertyName("window_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? WindowPeriod { get; set; }

}

/// <summary>
/// Manages a google_monitoring_slo resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleMonitoringSlo : TerraformResource
{
    public GoogleMonitoringSlo(string name) : base("google_monitoring_slo", name)
    {
    }

    /// <summary>
    /// A calendar period, semantically &amp;quot;since the start of the current
    /// &amp;lt;calendarPeriod&amp;gt;&amp;quot;. Possible values: [&amp;quot;DAY&amp;quot;, &amp;quot;WEEK&amp;quot;, &amp;quot;FORTNIGHT&amp;quot;, &amp;quot;MONTH&amp;quot;]
    /// </summary>
    [TerraformPropertyName("calendar_period")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? CalendarPeriod { get; set; }

    /// <summary>
    /// Name used for UI elements listing this SLO.
    /// </summary>
    [TerraformPropertyName("display_name")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? DisplayName { get; set; }

    /// <summary>
    /// The fraction of service that must be good in order for this objective
    /// to be met. 0 &amp;lt; goal &amp;lt;= 0.999
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Goal is required")]
    [TerraformPropertyName("goal")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<double>> Goal { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// A rolling time period, semantically &amp;quot;in the past X days&amp;quot;.
    /// Must be between 1 to 30 days, inclusive.
    /// </summary>
    [TerraformPropertyName("rolling_period_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RollingPeriodDays { get; set; }

    /// <summary>
    /// ID of the service to which this SLO belongs.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    [TerraformPropertyName("service")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Service { get; set; }

    /// <summary>
    /// The id to use for this ServiceLevelObjective. If omitted, an id will be generated instead.
    /// </summary>
    [TerraformPropertyName("slo_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> SloId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "slo_id");

    /// <summary>
    /// This field is intended to be used for organizing and identifying the AlertPolicy
    /// objects.The field can contain up to 64 entries. Each key and value is limited
    /// to 63 Unicode characters or 128 bytes, whichever is smaller. Labels and values
    /// can contain only lowercase letters, numerals, underscores, and dashes. Keys
    /// must begin with a letter.
    /// </summary>
    [TerraformPropertyName("user_labels")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? UserLabels { get; set; }

    /// <summary>
    /// Block for basic_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicSli block(s) allowed")]
    [TerraformPropertyName("basic_sli")]
    public TerraformList<TerraformBlock<GoogleMonitoringSloBasicSliBlock>>? BasicSli { get; set; } = new();

    /// <summary>
    /// Block for request_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 RequestBasedSli block(s) allowed")]
    [TerraformPropertyName("request_based_sli")]
    public TerraformList<TerraformBlock<GoogleMonitoringSloRequestBasedSliBlock>>? RequestBasedSli { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleMonitoringSloTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Block for windows_based_sli.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WindowsBasedSli block(s) allowed")]
    [TerraformPropertyName("windows_based_sli")]
    public TerraformList<TerraformBlock<GoogleMonitoringSloWindowsBasedSliBlock>>? WindowsBasedSli { get; set; } = new();

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

}
