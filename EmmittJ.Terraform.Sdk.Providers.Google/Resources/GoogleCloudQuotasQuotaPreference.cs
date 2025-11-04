using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Manages a google_cloud_quotas_quota_preference resource.
/// </summary>
public class GoogleCloudQuotasQuotaPreference : TerraformResource
{
    public GoogleCloudQuotasQuotaPreference(string name) : base("google_cloud_quotas_quota_preference", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("etag");
        this.DeclareOutput("reconciling");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// An email address that can be used for quota related communication between the Google Cloud and the user in case the Google Cloud needs further information to make a decision on whether the user preferred quota can be granted.
    /// 
    /// The Google account for the email address must have quota update permission for the project, folder or organization this quota preference is for.
    /// </summary>
    public string? ContactEmail
    {
        get => GetProperty<TerraformLiteralProperty<string>>("contact_email")?.Value;
        set => this.WithProperty("contact_email", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &amp;quot;region&amp;quot;, &amp;quot;zone&amp;quot;, &amp;quot;network_id&amp;quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// 
    /// NOTE: QuotaPreferences can only be applied across all values of &amp;quot;user&amp;quot; and &amp;quot;resource&amp;quot; dimension. Do not set values for &amp;quot;user&amp;quot; or &amp;quot;resource&amp;quot; in the dimension map.
    /// 
    /// Example: &#39;{&amp;quot;provider&amp;quot;: &amp;quot;Foo Inc&amp;quot;}&#39; where &amp;quot;provider&amp;quot; is a service specific dimension.
    /// </summary>
    public Dictionary<string, string>? Dimensions
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("dimensions")?.Value;
        set => this.WithProperty("dimensions", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The list of quota safety checks to be ignored. Default value: &amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot;, &amp;quot;QUOTA_DECREASE_BELOW_USAGE&amp;quot;, &amp;quot;QUOTA_DECREASE_PERCENTAGE_TOO_HIGH&amp;quot;]
    /// </summary>
    public string? IgnoreSafetyChecks
    {
        get => GetProperty<TerraformLiteralProperty<string>>("ignore_safety_checks")?.Value;
        set => this.WithProperty("ignore_safety_checks", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The reason / justification for this quota preference.
    /// </summary>
    public string? Justification
    {
        get => GetProperty<TerraformLiteralProperty<string>>("justification")?.Value;
        set => this.WithProperty("justification", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource name of the quota preference. Required except in the CREATE requests.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The parent of the quota preference. Allowed parents are &amp;quot;projects/[project-id / number]&amp;quot; or &amp;quot;folders/[folder-id / number]&amp;quot; or &amp;quot;organizations/[org-id / number]&amp;quot;.
    /// </summary>
    public string? Parent
    {
        get => GetProperty<TerraformLiteralProperty<string>>("parent")?.Value;
        set => this.WithProperty("parent", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: &#39;CPUS-per-project-region&#39;.
    /// </summary>
    public string? QuotaId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("quota_id")?.Value;
        set => this.WithProperty("quota_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the service to which the quota preference is applied.
    /// </summary>
    public string? Service
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service")?.Value;
        set => this.WithProperty("service", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Create time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// The current etag of the quota preference. If an etag is provided on update and does not match the current server&#39;s etag of the quota preference, the request will be blocked and an ABORTED error will be returned. See https://google.aip.dev/134#etags for more details on etags.
    /// </summary>
    public TerraformExpression Etag => this["etag"];

    /// <summary>
    /// Is the quota preference pending Google Cloud approval and fulfillment.
    /// </summary>
    public TerraformExpression Reconciling => this["reconciling"];

    /// <summary>
    /// Update time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
