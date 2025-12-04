using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for quota_config in GoogleCloudQuotasQuotaPreference.
/// Nesting mode: list
/// </summary>
public class GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "quota_config";

    /// <summary>
    /// The annotations map for clients to store small amounts of arbitrary data. Do not put PII or other sensitive information here. See https://google.aip.dev/128#annotations.
    /// 
    /// An object containing a list of &amp;quot;key: value&amp;quot; pairs. Example: &#39;{ &amp;quot;name&amp;quot;: &amp;quot;wrench&amp;quot;, &amp;quot;mass&amp;quot;: &amp;quot;1.3kg&amp;quot;, &amp;quot;count&amp;quot;: &amp;quot;3&amp;quot; }&#39;.
    /// </summary>
    public TerraformMap<string>? Annotations
    {
        get => GetArgument<TerraformMap<string>>("annotations");
        set => SetArgument("annotations", value);
    }

    /// <summary>
    /// Granted quota value.
    /// </summary>
    public TerraformValue<string> GrantedValue
        => AsReference("granted_value");

    /// <summary>
    /// The preferred value. Must be greater than or equal to -1. If set to -1, it means the value is &amp;quot;unlimited&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PreferredValue is required")]
    public required TerraformValue<string> PreferredValue
    {
        get => GetRequiredArgument<TerraformValue<string>>("preferred_value");
        set => SetArgument("preferred_value", value);
    }

    /// <summary>
    /// The origin of the quota preference request.
    /// </summary>
    public TerraformValue<string> RequestOrigin
        => AsReference("request_origin");

    /// <summary>
    /// Optional details about the state of this quota preference.
    /// </summary>
    public TerraformValue<string> StateDetail
        => AsReference("state_detail");

    /// <summary>
    /// The trace id that the Google Cloud uses to provision the requested quota. This trace id may be used by the client to contact Cloud support to track the state of a quota preference request. The trace id is only produced for increase requests and is unique for each request. The quota decrease requests do not have a trace id.
    /// </summary>
    public TerraformValue<string> TraceId
        => AsReference("trace_id");

}


/// <summary>
/// Block type for timeouts in GoogleCloudQuotasQuotaPreference.
/// Nesting mode: single
/// </summary>
public class GoogleCloudQuotasQuotaPreferenceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a google_cloud_quotas_quota_preference Terraform resource.
/// Manages a google_cloud_quotas_quota_preference resource.
/// </summary>
public partial class GoogleCloudQuotasQuotaPreference(string name) : TerraformResource("google_cloud_quotas_quota_preference", name)
{
    /// <summary>
    /// An email address that can be used for quota related communication between the Google Cloud and the user in case the Google Cloud needs further information to make a decision on whether the user preferred quota can be granted.
    /// 
    /// The Google account for the email address must have quota update permission for the project, folder or organization this quota preference is for.
    /// </summary>
    public TerraformValue<string>? ContactEmail
    {
        get => GetArgument<TerraformValue<string>>("contact_email");
        set => SetArgument("contact_email", value);
    }

    /// <summary>
    /// The dimensions that this quota preference applies to. The key of the map entry is the name of a dimension, such as &amp;quot;region&amp;quot;, &amp;quot;zone&amp;quot;, &amp;quot;network_id&amp;quot;, and the value of the map entry is the dimension value. If a dimension is missing from the map of dimensions, the quota preference applies to all the dimension values except for those that have other quota preferences configured for the specific value.
    /// 
    /// NOTE: QuotaPreferences can only be applied across all values of &amp;quot;user&amp;quot; and &amp;quot;resource&amp;quot; dimension. Do not set values for &amp;quot;user&amp;quot; or &amp;quot;resource&amp;quot; in the dimension map.
    /// 
    /// Example: &#39;{&amp;quot;provider&amp;quot;: &amp;quot;Foo Inc&amp;quot;}&#39; where &amp;quot;provider&amp;quot; is a service specific dimension.
    /// </summary>
    public TerraformMap<string> Dimensions
    {
        get => GetArgument<TerraformMap<string>>("dimensions") ?? AsReference("dimensions");
        set => SetArgument("dimensions", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The list of quota safety checks to be ignored. Default value: &amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;QUOTA_SAFETY_CHECK_UNSPECIFIED&amp;quot;, &amp;quot;QUOTA_DECREASE_BELOW_USAGE&amp;quot;, &amp;quot;QUOTA_DECREASE_PERCENTAGE_TOO_HIGH&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IgnoreSafetyChecks
    {
        get => GetArgument<TerraformValue<string>>("ignore_safety_checks");
        set => SetArgument("ignore_safety_checks", value);
    }

    /// <summary>
    /// The reason / justification for this quota preference.
    /// </summary>
    public TerraformValue<string>? Justification
    {
        get => GetArgument<TerraformValue<string>>("justification");
        set => SetArgument("justification", value);
    }

    /// <summary>
    /// The resource name of the quota preference. Required except in the CREATE requests.
    /// </summary>
    public TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name") ?? AsReference("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The parent of the quota preference. Allowed parents are &amp;quot;projects/[project-id / number]&amp;quot; or &amp;quot;folders/[folder-id / number]&amp;quot; or &amp;quot;organizations/[org-id / number]&amp;quot;.
    /// </summary>
    public TerraformValue<string> Parent
    {
        get => GetArgument<TerraformValue<string>>("parent") ?? AsReference("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The id of the quota to which the quota preference is applied. A quota id is unique in the service.
    /// Example: &#39;CPUS-per-project-region&#39;.
    /// </summary>
    public TerraformValue<string> QuotaId
    {
        get => GetArgument<TerraformValue<string>>("quota_id") ?? AsReference("quota_id");
        set => SetArgument("quota_id", value);
    }

    /// <summary>
    /// The name of the service to which the quota preference is applied.
    /// </summary>
    public TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service") ?? AsReference("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// Create time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// The current etag of the quota preference. If an etag is provided on update and does not match the current server&#39;s etag of the quota preference, the request will be blocked and an ABORTED error will be returned. See https://google.aip.dev/134#etags for more details on etags.
    /// </summary>
    public TerraformValue<string> Etag
        => AsReference("etag");

    /// <summary>
    /// Is the quota preference pending Google Cloud approval and fulfillment.
    /// </summary>
    public TerraformValue<bool> Reconciling
        => AsReference("reconciling");

    /// <summary>
    /// Update time stamp.
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to nine fractional digits. Examples: &#39;2014-10-02T15:01:23Z&#39; and &#39;2014-10-02T15:01:23.045123456Z&#39;.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// QuotaConfig block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "QuotaConfig is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 QuotaConfig block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 QuotaConfig block(s) allowed")]
    public required TerraformList<GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock> QuotaConfig
    {
        get => GetRequiredArgument<TerraformList<GoogleCloudQuotasQuotaPreferenceQuotaConfigBlock>>("quota_config");
        set => SetArgument("quota_config", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleCloudQuotasQuotaPreferenceTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleCloudQuotasQuotaPreferenceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
