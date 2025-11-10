using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSccV2OrganizationMuteConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_scc_v2_organization_mute_config resource.
/// </summary>
public class GoogleSccV2OrganizationMuteConfig : TerraformResource
{
    public GoogleSccV2OrganizationMuteConfig(string name) : base("google_scc_v2_organization_mute_config", name)
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
        SetOutput("filter");
        SetOutput("id");
        SetOutput("location");
        SetOutput("mute_config_id");
        SetOutput("organization");
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
    /// location Id is provided by organization. If not provided, Use global as default.
    /// </summary>
    public TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The organization whose Cloud Security Command Center the Mute
    /// Config lives in.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Organization is required")]
    public required TerraformProperty<string> Organization
    {
        get => GetRequiredOutput<TerraformProperty<string>>("organization");
        set => SetProperty("organization", value);
    }

    /// <summary>
    /// The type of the mute config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetRequiredOutput<TerraformProperty<string>>("type");
        set => SetProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSccV2OrganizationMuteConfigTimeoutsBlock? Timeouts
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
    /// organizations/{organization}/locations/global/muteConfigs/{configId},
    /// folders/{folder}/locations/global/muteConfigs/{configId},
    /// or projects/{project}/locations/global/muteConfigs/{configId}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The most recent time at which the mute config was
    /// updated. This field is set by the server and will be ignored if
    /// provided on config creation or update.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
