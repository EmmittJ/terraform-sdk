using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleSccV2ProjectMuteConfigTimeoutsBlock : TerraformBlock
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
/// Manages a google_scc_v2_project_mute_config resource.
/// </summary>
public class GoogleSccV2ProjectMuteConfig : TerraformResource
{
    public GoogleSccV2ProjectMuteConfig(string name) : base("google_scc_v2_project_mute_config", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("most_recent_editor");
        this.DeclareOutput("name");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// A description of the mute config.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
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
        get => GetProperty<TerraformProperty<string>>("filter");
        set => this.WithProperty("filter", value);
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
    /// location Id is provided by project. If not provided, Use global as default.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Unique identifier provided by the client within the parent scope.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MuteConfigId is required")]
    public required TerraformProperty<string> MuteConfigId
    {
        get => GetProperty<TerraformProperty<string>>("mute_config_id");
        set => this.WithProperty("mute_config_id", value);
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
    /// The type of the mute config.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => this.WithProperty("type", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleSccV2ProjectMuteConfigTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleSccV2ProjectMuteConfigTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// projects/{project}/locations/global/muteConfigs/{configId},
    /// folders/{folder}/locations/global/muteConfigs/{configId},
    /// or organizations/{organization}/locations/global/muteConfigs/{configId}
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// Output only. The most recent time at which the mute config was
    /// updated. This field is set by the server and will be ignored if
    /// provided on config creation or update.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
