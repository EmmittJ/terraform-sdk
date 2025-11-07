using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_monitoring_slo resource.
/// </summary>
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
    public TerraformProperty<double>? Goal
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
    public TerraformProperty<string>? Service
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
    public TerraformProperty<Dictionary<string, string>>? UserLabels
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("user_labels");
        set => this.WithProperty("user_labels", value);
    }

    /// <summary>
    /// The full resource name for this service. The syntax is:
    /// projects/[PROJECT_ID_OR_NUMBER]/services/[SERVICE_ID]/serviceLevelObjectives/[SLO_NAME]
    /// </summary>
    public TerraformExpression Name => this["name"];

}
