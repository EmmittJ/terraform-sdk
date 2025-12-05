using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in GoogleSccMuteConfig.
/// Nesting mode: single
/// </summary>
public class GoogleSccMuteConfigTimeoutsBlock : TerraformBlock
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
/// Represents a google_scc_mute_config Terraform resource.
/// Manages a google_scc_mute_config resource.
/// </summary>
public partial class GoogleSccMuteConfig(string name) : TerraformResource("google_scc_mute_config", name)
{
    /// <summary>
    /// A description of the mute config.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Optional. The expiry of the mute config. Only applicable for dynamic configs.
    /// If the expiry is set, when the config expires, it is removed from all findings.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to
    /// nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformValue<string>? ExpiryTime
    {
        get => GetArgument<TerraformValue<string>>("expiry_time");
        set => SetArgument("expiry_time", value);
    }

    /// <summary>
    /// An expression that defines the filter to apply across create/update
    /// events of findings. While creating a filter string, be mindful of
    /// the scope in which the mute configuration is being created. E.g.,
    /// If a filter contains project = X but is created under the
    /// project = Y scope, it might not match any findings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Unique identifier provided by the client within the parent scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MuteConfigId is required")]
    public required TerraformValue<string> MuteConfigId
    {
        get => GetRequiredArgument<TerraformValue<string>>("mute_config_id");
        set => SetArgument("mute_config_id", value);
    }

    /// <summary>
    /// Resource name of the new mute configs&#39;s parent. Its format is
    /// &amp;quot;organizations/[organization_id]&amp;quot;, &amp;quot;folders/[folder_id]&amp;quot;, or
    /// &amp;quot;projects/[project_id]&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformValue<string> Parent
    {
        get => GetRequiredArgument<TerraformValue<string>>("parent");
        set => SetArgument("parent", value);
    }

    /// <summary>
    /// The type of the mute config, which determines what type of mute state the config affects. Default value: &amp;quot;DYNAMIC&amp;quot; Possible values: [&amp;quot;MUTE_CONFIG_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;STATIC&amp;quot;, &amp;quot;DYNAMIC&amp;quot;]
    /// </summary>
    public TerraformValue<string>? Type
    {
        get => GetArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The time at which the mute config was created. This field is set by
    /// the server and will be ignored if provided on config creation.
    /// </summary>
    public TerraformValue<string> CreateTime
        => CreateReference("create_time");

    /// <summary>
    /// Email address of the user who last edited the mute config. This
    /// field is set by the server and will be ignored if provided on
    /// config creation or update.
    /// </summary>
    public TerraformValue<string> MostRecentEditor
        => CreateReference("most_recent_editor");

    /// <summary>
    /// Name of the mute config. Its format is
    /// organizations/{organization}/muteConfigs/{configId},
    /// folders/{folder}/muteConfigs/{configId},
    /// or projects/{project}/muteConfigs/{configId}
    /// </summary>
    public TerraformValue<string> Name
        => CreateReference("name");

    /// <summary>
    /// Output only. The most recent time at which the mute config was
    /// updated. This field is set by the server and will be ignored if
    /// provided on config creation or update.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => CreateReference("update_time");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleSccMuteConfigTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleSccMuteConfigTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
