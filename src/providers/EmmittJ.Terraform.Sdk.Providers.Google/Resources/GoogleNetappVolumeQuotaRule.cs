using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleNetappVolumeQuotaRule.
/// Nesting mode: single
/// </summary>
public class GoogleNetappVolumeQuotaRuleTimeoutsBlock : TerraformBlock
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
/// Represents a google_netapp_volume_quota_rule Terraform resource.
/// Manages a google_netapp_volume_quota_rule resource.
/// </summary>
public partial class GoogleNetappVolumeQuotaRule(string name) : TerraformResource("google_netapp_volume_quota_rule", name)
{
    /// <summary>
    /// Description for the quota rule.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The maximum allowed capacity in MiB.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DiskLimitMib is required")]
    public required TerraformValue<double> DiskLimitMib
    {
        get => GetRequiredArgument<TerraformValue<double>>("disk_limit_mib");
        set => SetArgument("disk_limit_mib", value);
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
    /// Labels as key value pairs of the quota rule. Example: &#39;{ &amp;quot;owner&amp;quot;: &amp;quot;Bob&amp;quot;, &amp;quot;department&amp;quot;: &amp;quot;finance&amp;quot;, &amp;quot;purpose&amp;quot;: &amp;quot;testing&amp;quot; }&#39;.
    /// 
    /// 
    /// **Note**: This field is non-authoritative, and will only manage the labels present in your configuration.
    /// Please refer to the field &#39;effective_labels&#39; for all of the labels present on the resource.
    /// </summary>
    public TerraformMap<string>? Labels
    {
        get => GetArgument<TerraformMap<string>>("labels");
        set => SetArgument("labels", value);
    }

    /// <summary>
    /// Loction of the quotaRule. QuotaRules are child resources of volumes and live in the same location.
    /// </summary>
    public TerraformValue<string>? Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The resource name of the quotaRule.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string> Project
    {
        get => GetArgument<TerraformValue<string>>("project") ?? AsReference("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// The quota rule applies to the specified user or group.
    /// Valid targets for volumes with NFS protocol enabled:
    ///   - UNIX UID for individual user quota
    ///   - UNIX GID for individual group quota
    /// Valid targets for volumes with SMB protocol enabled:
    ///   - Windows SID for individual user quota
    /// Leave empty for default quotas
    /// </summary>
    public TerraformValue<string>? Target
    {
        get => GetArgument<TerraformValue<string>>("target");
        set => SetArgument("target", value);
    }

    /// <summary>
    /// Types of Quota Rule. Possible values: [&amp;quot;INDIVIDUAL_USER_QUOTA&amp;quot;, &amp;quot;INDIVIDUAL_GROUP_QUOTA&amp;quot;, &amp;quot;DEFAULT_USER_QUOTA&amp;quot;, &amp;quot;DEFAULT_GROUP_QUOTA&amp;quot;]
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// Name of the volume to create the quotaRule in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VolumeName is required")]
    public required TerraformValue<string> VolumeName
    {
        get => GetRequiredArgument<TerraformValue<string>>("volume_name");
        set => SetArgument("volume_name", value);
    }

    /// <summary>
    /// Create time of the quota rule. A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format. Examples: &amp;quot;2023-06-22T09:13:01.617Z&amp;quot;.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// All of labels (key/value pairs) present on the resource in GCP, including the labels configured through Terraform, other clients and services.
    /// </summary>
    public TerraformMap<string> EffectiveLabels
        => AsReference("effective_labels");

    /// <summary>
    /// The state of the quota rule. Possible Values : [STATE_UNSPECIFIED, CREATING, UPDATING, READY, DELETING, ERROR]
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// State details of the quota rule
    /// </summary>
    public TerraformValue<string> StateDetails
        => AsReference("state_details");

    /// <summary>
    /// The combination of labels configured directly on the resource
    ///  and default labels configured on the provider.
    /// </summary>
    public TerraformMap<string> TerraformLabels
        => AsReference("terraform_labels");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleNetappVolumeQuotaRuleTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleNetappVolumeQuotaRuleTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
