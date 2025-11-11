using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for quota_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock : TerraformBlockBase
{
    /// <summary>
    /// The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations.
    /// 
    /// An object containing a list of &amp;quot;key: value&amp;quot; pairs. Example: &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    [TerraformProperty("annotations")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Annotations { get; set; }


    /// <summary>
    /// The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is &amp;quot;unlimited&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredValue is required")]
    [TerraformProperty("preferred_value")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> PreferredValue { get; set; }




}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleCloudQuotasQuotaPreferenceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_cloud_quotas_quota_preference resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleCloudQuotasQuotaPreference : TerraformResource
{
    public GoogleCloudQuotasQuotaPreference(string name) : base("google_cloud_quotas_quota_preference", name)
    {
    }

    /// <summary>
    /// An email address that can be used for quota related communication between the Google Cloud and the user in case the Google Cloud needs further information to make a decision on whether the user preferred quota can be granted.
    /// 
    /// The Google account for the email address must have quota update permission for the project, folder or organization this quota preference is for.
    /// </summary>
    [TerraformProperty("contact_email")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContactEmail { get; set; }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &amp;quot;region&amp;quot;, &amp;quot;zone&amp;quot;, &amp;quot;network_id&amp;quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// 
    /// NOTE: QuotaPreferences can only be applied across all values of &amp;quot;user&amp;quot; and &amp;quot;resource&amp;quot; dimension. Do not set values for &amp;quot;user&amp;quot; or &amp;quot;resource&amp;quot; in the dimension map.
    /// 
    /// Example: &#39;{&amp;quot;provider&amp;quot;: &amp;quot;Foo Inc&amp;quot;}&#39; where &amp;quot;provider&amp;quot; is a service specific dimension.
    /// </summary>
    [TerraformProperty("dimensions")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> Dimensions { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The list of quota safety checks to be ignored. Default value: &amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot;, &amp;quot;QUOTA_DECREASE_BELOW_USAGE&amp;quot;, &amp;quot;QUOTA_DECREASE_PERCENTAGE_TOO_HIGH&amp;quot;]
    /// </summary>
    [TerraformProperty("ignore_safety_checks")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? IgnoreSafetyChecks { get; set; }

    /// <summary>
    /// The reason / justification for this quota preference.
    /// </summary>
    [TerraformProperty("justification")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Justification { get; set; }

    /// <summary>
    /// The resource name of the quota preference. Required except in the CREATE requests.
    /// </summary>
    [TerraformProperty("name")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The parent of the quota preference. Allowed parents are &amp;quot;projects/[project-id / number]&amp;quot; or &amp;quot;folders/[folder-id / number]&amp;quot; or &amp;quot;organizations/[org-id / number]&amp;quot;.
    /// </summary>
    [TerraformProperty("parent")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Parent { get; set; }

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: &#39;CPUS-per-project-region&#39;.
    /// </summary>
    [TerraformProperty("quota_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> QuotaId { get; set; }

    /// <summary>
    /// The name of the service to which the quota preference is applied.
    /// </summary>
    [TerraformProperty("service")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Service { get; set; }

    /// <summary>
    /// Block for quota_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QuotaConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaConfig block(s) allowed")]
    [TerraformProperty("quota_config")]
    public TerraformList<TerraformBlock<GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock>>? QuotaConfig { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<GoogleCloudQuotasQuotaPreferenceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Create time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// The current etag of the quota preference. If an etag is provided on update and does not match the current server&#39;s etag of the quota preference, the request will be blocked and an ABORTED error will be returned. See https://google.aip.dev/134#etags for more details on etags.
    /// </summary>
    [TerraformProperty("etag")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Etag { get; }

    /// <summary>
    /// Is the quota preference pending Google Cloud approval and fulfillment.
    /// </summary>
    [TerraformProperty("reconciling")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<bool> Reconciling { get; }

    /// <summary>
    /// Update time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> UpdateTime { get; }

}
