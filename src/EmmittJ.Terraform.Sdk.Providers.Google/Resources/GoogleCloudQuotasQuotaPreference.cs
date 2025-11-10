using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for quota_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock : TerraformBlock
{
    /// <summary>
    /// The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations.
    /// 
    /// An object containing a list of &amp;quot;key: value&amp;quot; pairs. Example: &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Annotations
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("annotations");
        set => WithProperty("annotations", value);
    }

    /// <summary>
    /// Granted quota value.
    /// </summary>
    public TerraformProperty<string>? GrantedValue
    {
        get => GetProperty<TerraformProperty<string>>("granted_value");
        set => WithProperty("granted_value", value);
    }

    /// <summary>
    /// The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is &amp;quot;unlimited&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredValue is required")]
    public required TerraformProperty<string> PreferredValue
    {
        get => GetProperty<TerraformProperty<string>>("preferred_value");
        set => WithProperty("preferred_value", value);
    }

    /// <summary>
    /// The origin of the quota preference request.
    /// </summary>
    public TerraformProperty<string>? RequestOrigin
    {
        get => GetProperty<TerraformProperty<string>>("request_origin");
        set => WithProperty("request_origin", value);
    }

    /// <summary>
    /// Optional details about the state of this quota preference.
    /// </summary>
    public TerraformProperty<string>? StateDetail
    {
        get => GetProperty<TerraformProperty<string>>("state_detail");
        set => WithProperty("state_detail", value);
    }

    /// <summary>
    /// The trace id that the Google Cloud uses to provision the requested quota. This trace id may be used by the client to contact Cloud support to track the state of a quota preference request. The trace id is only produced for increase requests and is unique for each request. The quota decrease requests do not have a trace id.
    /// </summary>
    public TerraformProperty<string>? TraceId
    {
        get => GetProperty<TerraformProperty<string>>("trace_id");
        set => WithProperty("trace_id", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudQuotasQuotaPreferenceTimeoutsBlock : TerraformBlock
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
/// Manages a google_cloud_quotas_quota_preference resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
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
    public TerraformProperty<string>? ContactEmail
    {
        get => GetProperty<TerraformProperty<string>>("contact_email");
        set => this.WithProperty("contact_email", value);
    }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &amp;quot;region&amp;quot;, &amp;quot;zone&amp;quot;, &amp;quot;network_id&amp;quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// 
    /// NOTE: QuotaPreferences can only be applied across all values of &amp;quot;user&amp;quot; and &amp;quot;resource&amp;quot; dimension. Do not set values for &amp;quot;user&amp;quot; or &amp;quot;resource&amp;quot; in the dimension map.
    /// 
    /// Example: &#39;{&amp;quot;provider&amp;quot;: &amp;quot;Foo Inc&amp;quot;}&#39; where &amp;quot;provider&amp;quot; is a service specific dimension.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Dimensions
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("dimensions");
        set => this.WithProperty("dimensions", value);
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
    /// The list of quota safety checks to be ignored. Default value: &amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot;, &amp;quot;QUOTA_DECREASE_BELOW_USAGE&amp;quot;, &amp;quot;QUOTA_DECREASE_PERCENTAGE_TOO_HIGH&amp;quot;]
    /// </summary>
    public TerraformProperty<string>? IgnoreSafetyChecks
    {
        get => GetProperty<TerraformProperty<string>>("ignore_safety_checks");
        set => this.WithProperty("ignore_safety_checks", value);
    }

    /// <summary>
    /// The reason / justification for this quota preference.
    /// </summary>
    public TerraformProperty<string>? Justification
    {
        get => GetProperty<TerraformProperty<string>>("justification");
        set => this.WithProperty("justification", value);
    }

    /// <summary>
    /// The resource name of the quota preference. Required except in the CREATE requests.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The parent of the quota preference. Allowed parents are &amp;quot;projects/[project-id / number]&amp;quot; or &amp;quot;folders/[folder-id / number]&amp;quot; or &amp;quot;organizations/[org-id / number]&amp;quot;.
    /// </summary>
    public TerraformProperty<string>? Parent
    {
        get => GetProperty<TerraformProperty<string>>("parent");
        set => this.WithProperty("parent", value);
    }

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: &#39;CPUS-per-project-region&#39;.
    /// </summary>
    public TerraformProperty<string>? QuotaId
    {
        get => GetProperty<TerraformProperty<string>>("quota_id");
        set => this.WithProperty("quota_id", value);
    }

    /// <summary>
    /// The name of the service to which the quota preference is applied.
    /// </summary>
    public TerraformProperty<string>? Service
    {
        get => GetProperty<TerraformProperty<string>>("service");
        set => this.WithProperty("service", value);
    }

    /// <summary>
    /// Block for quota_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QuotaConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaConfig block(s) allowed")]
    public List<GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock>? QuotaConfig
    {
        get => GetProperty<List<GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock>>("quota_config");
        set => this.WithProperty("quota_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleCloudQuotasQuotaPreferenceTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleCloudQuotasQuotaPreferenceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
