using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSccMuteConfigTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a google_scc_mute_config resource.
/// </summary>
public class GoogleSccMuteConfig : TerraformResource
{
    public GoogleSccMuteConfig(string name) : base("google_scc_mute_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("most_recent_editor");
        SetOutput("name");
        SetOutput("update_time");
        SetOutput("description");
        SetOutput("expiry_time");
        SetOutput("filter");
        SetOutput("id");
        SetOutput("mute_config_id");
        SetOutput("parent");
        SetOutput("type");
    }

    /// <summary>
    /// A description of the mute config.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// Optional. The expiry of the mute config. Only applicable for dynamic configs.
    /// If the expiry is set, when the config expires, it is removed from all findings.
    /// 
    /// A timestamp in RFC3339 UTC &amp;quot;Zulu&amp;quot; format, with nanosecond resolution and up to
    /// nine fractional digits. Examples: &amp;quot;2014-10-02T15:01:23Z&amp;quot; and &amp;quot;2014-10-02T15:01:23.045123456Z&amp;quot;.
    /// </summary>
    public TerraformProperty<string> ExpiryTime
    {
        get => GetRequiredOutput<TerraformProperty<string>>("expiry_time");
        set => SetProperty("expiry_time", value);
    }

    /// <summary>
    /// An expression that defines the filter to apply across create/update
    /// events of findings. While creating a filter string, be mindful of
    /// the scope in which the mute configuration is being created. E.g.,
    /// If a filter contains project = X but is created under the
    /// project = Y scope, it might not match any findings.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformProperty<string> Filter
    {
        get => GetRequiredOutput<TerraformProperty<string>>("filter");
        set => SetProperty("filter", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Unique identifier provided by the client within the parent scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MuteConfigId is required")]
    public required TerraformProperty<string> MuteConfigId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("mute_config_id");
        set => SetProperty("mute_config_id", value);
    }

    /// <summary>
    /// Resource name of the new mute configs&#39;s parent. Its format is
    /// &amp;quot;organizations/[organization_id]&amp;quot;, &amp;quot;folders/[folder_id]&amp;quot;, or
    /// &amp;quot;projects/[project_id]&amp;quot;.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parent is required")]
    public required TerraformProperty<string> Parent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("parent");
        set => SetProperty("parent", value);
    }

    /// <summary>
    /// The type of the mute config, which determines what type of mute state the config affects. Default value: &amp;quot;DYNAMIC&amp;quot; Possible values: [&amp;quot;MUTE_CONFIG_TYPE_UNSPECIFIED&amp;quot;, &amp;quot;STATIC&amp;quot;, &amp;quot;DYNAMIC&amp;quot;]
    /// </summary>
    public TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSccMuteConfigTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The time at which the mute config was created. This field is set by
    /// the server and will be ignored if provided on config creation.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Email address of the user who last edited the mute config. This
    /// field is set by the server and will be ignored if provided on
    /// config creation or update.
    /// </summary>
    public TerraformExpression MostRecentEditor => this["most_recent_editor"];

    /// <summary>
    /// Name of the mute config. Its format is
    /// organizations/{organization}/muteConfigs/{configId},
    /// folders/{folder}/muteConfigs/{configId},
    /// or projects/{project}/muteConfigs/{configId}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The most recent time at which the mute config was
    /// updated. This field is set by the server and will be ignored if
    /// provided on config creation or update.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
