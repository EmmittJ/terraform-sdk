using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginActionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// The description of the operation performed by the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformProperty<string> Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => WithProperty("display_name", value);
    }

    /// <summary>
    /// The id of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformProperty<string> Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => WithProperty("id", value);
    }

    /// <summary>
    /// The trigger mode supported by the action.
    /// Possible values:
    /// TRIGGER_MODE_UNSPECIFIED
    /// API_HUB_ON_DEMAND_TRIGGER
    /// API_HUB_SCHEDULE_TRIGGER
    /// NON_API_HUB_MANAGED
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerMode is required")]
    public required TerraformProperty<string> TriggerMode
    {
        get => GetProperty<TerraformProperty<string>>("trigger_mode");
        set => WithProperty("trigger_mode", value);
    }

}

/// <summary>
/// Block type for config_template in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlock : TerraformBlock
{
}

/// <summary>
/// Block type for documentation in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginDocumentationBlock : TerraformBlock
{
    /// <summary>
    /// The uri of the externally hosted documentation.
    /// </summary>
    public TerraformProperty<string>? ExternalUri
    {
        get => GetProperty<TerraformProperty<string>>("external_uri");
        set => WithProperty("external_uri", value);
    }

}

/// <summary>
/// Block type for hosting_service in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginHostingServiceBlock : TerraformBlock
{
    /// <summary>
    /// The URI of the service implemented by the plugin developer, used to
    /// invoke the plugin&#39;s functionality. This information is only required for
    /// user defined plugins.
    /// </summary>
    public TerraformProperty<string>? ServiceUri
    {
        get => GetProperty<TerraformProperty<string>>("service_uri");
        set => WithProperty("service_uri", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubPluginTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a google_apihub_plugin resource.
/// </summary>
public class GoogleApihubPlugin : TerraformResource
{
    public GoogleApihubPlugin(string name) : base("google_apihub_plugin", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("create_time");
        this.DeclareOutput("name");
        this.DeclareOutput("ownership_type");
        this.DeclareOutput("state");
        this.DeclareOutput("update_time");
    }

    /// <summary>
    /// The plugin description. Max length is 2000 characters (Unicode code
    /// points).
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name of the plugin. Max length is 50 characters (Unicode code
    /// points).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// Possible values:
    /// PLUGIN_CATEGORY_UNSPECIFIED
    /// API_GATEWAY
    /// API_PRODUCER
    /// </summary>
    public TerraformProperty<string>? PluginCategory
    {
        get => GetProperty<TerraformProperty<string>>("plugin_category");
        set => this.WithProperty("plugin_category", value);
    }

    /// <summary>
    /// The ID to use for the Plugin resource, which will become the final
    /// component of the Plugin&#39;s resource name. This field is optional.
    /// 
    /// * If provided, the same will be used. The service will throw an error if
    /// the specified id is already used by another Plugin resource in the API hub
    /// instance.
    /// * If not provided, a system generated id will be used.
    /// 
    /// This value should be 4-63 characters, overall resource name which will be
    /// of format
    /// &#39;projects/{project}/locations/{location}/plugins/{plugin}&#39;,
    /// its length is limited to 1000 characters and valid characters are
    /// /a-z[0-9]-_/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PluginId is required")]
    public required TerraformProperty<string> PluginId
    {
        get => GetProperty<TerraformProperty<string>>("plugin_id");
        set => this.WithProperty("plugin_id", value);
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
    /// Block for actions_config.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleApihubPluginActionsConfigBlock>? ActionsConfig
    {
        get => GetProperty<List<GoogleApihubPluginActionsConfigBlock>>("actions_config");
        set => this.WithProperty("actions_config", value);
    }

    /// <summary>
    /// Block for config_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigTemplate block(s) allowed")]
    public List<GoogleApihubPluginConfigTemplateBlock>? ConfigTemplate
    {
        get => GetProperty<List<GoogleApihubPluginConfigTemplateBlock>>("config_template");
        set => this.WithProperty("config_template", value);
    }

    /// <summary>
    /// Block for documentation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Documentation block(s) allowed")]
    public List<GoogleApihubPluginDocumentationBlock>? Documentation
    {
        get => GetProperty<List<GoogleApihubPluginDocumentationBlock>>("documentation");
        set => this.WithProperty("documentation", value);
    }

    /// <summary>
    /// Block for hosting_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostingService block(s) allowed")]
    public List<GoogleApihubPluginHostingServiceBlock>? HostingService
    {
        get => GetProperty<List<GoogleApihubPluginHostingServiceBlock>>("hosting_service");
        set => this.WithProperty("hosting_service", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApihubPluginTimeoutsBlock? Timeouts
    {
        get => GetProperty<GoogleApihubPluginTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Timestamp indicating when the plugin was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Identifier. The name of the plugin.
    /// Format: &#39;projects/{project}/locations/{location}/plugins/{plugin}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The type of the plugin, indicating whether it is &#39;SYSTEM_OWNED&#39; or
    /// &#39;USER_OWNED&#39;.
    /// Possible values:
    /// OWNERSHIP_TYPE_UNSPECIFIED
    /// SYSTEM_OWNED
    /// USER_OWNED
    /// </summary>
    public TerraformExpression OwnershipType => this["ownership_type"];

    /// <summary>
    /// Represents the state of the plugin.
    /// Note this field will not be set for plugins developed via plugin
    /// framework as the state will be managed at plugin instance level.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ENABLED
    /// DISABLED
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Timestamp indicating when the plugin was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
