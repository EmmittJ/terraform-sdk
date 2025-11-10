using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for quota_config in .
/// Nesting mode: list
/// </summary>
public class GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations.
    /// 
    /// An object containing a list of &amp;quot;key: value&amp;quot; pairs. Example: &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    [TerraformPropertyName("annotations")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Annotations { get; set; }

    /// <summary>
    /// Granted quota value.
    /// </summary>
    [TerraformPropertyName("granted_value")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> GrantedValue => new TerraformReferenceProperty<TerraformProperty<string>>("", "granted_value");

    /// <summary>
    /// The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is &amp;quot;unlimited&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredValue is required")]
    [TerraformPropertyName("preferred_value")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PreferredValue { get; set; }

    /// <summary>
    /// The origin of the quota preference request.
    /// </summary>
    [TerraformPropertyName("request_origin")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> RequestOrigin => new TerraformReferenceProperty<TerraformProperty<string>>("", "request_origin");

    /// <summary>
    /// Optional details about the state of this quota preference.
    /// </summary>
    [TerraformPropertyName("state_detail")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> StateDetail => new TerraformReferenceProperty<TerraformProperty<string>>("", "state_detail");

    /// <summary>
    /// The trace id that the Google Cloud uses to provision the requested quota. This trace id may be used by the client to contact Cloud support to track the state of a quota preference request. The trace id is only produced for increase requests and is unique for each request. The quota decrease requests do not have a trace id.
    /// </summary>
    [TerraformPropertyName("trace_id")]
    // Computed attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> TraceId => new TerraformReferenceProperty<TerraformProperty<string>>("", "trace_id");

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleCloudQuotasQuotaPreferenceTimeoutsBlock : ITerraformBlock
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
/// Manages a google_cloud_quotas_quota_preference resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleCloudQuotasQuotaPreference : TerraformResource
{
    public GoogleCloudQuotasQuotaPreference(string name) : base("google_cloud_quotas_quota_preference", name)
    {
    }

    /// <summary>
    /// An email address that can be used for quota related communication between the Google Cloud and the user in case the Google Cloud needs further information to make a decision on whether the user preferred quota can be granted.
    /// 
    /// The Google account for the email address must have quota update permission for the project, folder or organization this quota preference is for.
    /// </summary>
    [TerraformPropertyName("contact_email")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ContactEmail { get; set; }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &amp;quot;region&amp;quot;, &amp;quot;zone&amp;quot;, &amp;quot;network_id&amp;quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// 
    /// NOTE: QuotaPreferences can only be applied across all values of &amp;quot;user&amp;quot; and &amp;quot;resource&amp;quot; dimension. Do not set values for &amp;quot;user&amp;quot; or &amp;quot;resource&amp;quot; in the dimension map.
    /// 
    /// Example: &#39;{&amp;quot;provider&amp;quot;: &amp;quot;Foo Inc&amp;quot;}&#39; where &amp;quot;provider&amp;quot; is a service specific dimension.
    /// </summary>
    [TerraformPropertyName("dimensions")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Dimensions { get; set; } = new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "dimensions");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The list of quota safety checks to be ignored. Default value: &amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot;, &amp;quot;QUOTA_DECREASE_BELOW_USAGE&amp;quot;, &amp;quot;QUOTA_DECREASE_PERCENTAGE_TOO_HIGH&amp;quot;]
    /// </summary>
    [TerraformPropertyName("ignore_safety_checks")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IgnoreSafetyChecks { get; set; }

    /// <summary>
    /// The reason / justification for this quota preference.
    /// </summary>
    [TerraformPropertyName("justification")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Justification { get; set; }

    /// <summary>
    /// The resource name of the quota preference. Required except in the CREATE requests.
    /// </summary>
    [TerraformPropertyName("name")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Name { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The parent of the quota preference. Allowed parents are &amp;quot;projects/[project-id / number]&amp;quot; or &amp;quot;folders/[folder-id / number]&amp;quot; or &amp;quot;organizations/[org-id / number]&amp;quot;.
    /// </summary>
    [TerraformPropertyName("parent")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Parent { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "parent");

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: &#39;CPUS-per-project-region&#39;.
    /// </summary>
    [TerraformPropertyName("quota_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> QuotaId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "quota_id");

    /// <summary>
    /// The name of the service to which the quota preference is applied.
    /// </summary>
    [TerraformPropertyName("service")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Service { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "service");

    /// <summary>
    /// Block for quota_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QuotaConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaConfig block(s) allowed")]
    [TerraformPropertyName("quota_config")]
    public TerraformList<TerraformBlock<GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock>>? QuotaConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleCloudQuotasQuotaPreferenceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Create time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// The current etag of the quota preference. If an etag is provided on update and does not match the current server&#39;s etag of the quota preference, the request will be blocked and an ABORTED error will be returned. See https://google.aip.dev/134#etags for more details on etags.
    /// </summary>
    [TerraformPropertyName("etag")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Etag => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "etag");

    /// <summary>
    /// Is the quota preference pending Google Cloud approval and fulfillment.
    /// </summary>
    [TerraformPropertyName("reconciling")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> Reconciling => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "reconciling");

    /// <summary>
    /// Update time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
