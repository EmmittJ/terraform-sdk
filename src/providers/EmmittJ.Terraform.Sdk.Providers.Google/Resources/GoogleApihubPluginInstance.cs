using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceActionsBlock : TerraformBlock
{
    /// <summary>
    /// This should map to one of the action id specified
    /// in actions_config in the plugin.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionId is required")]
    public required TerraformProperty<string> ActionId
    {
        set => SetProperty("action_id", value);
    }

    /// <summary>
    /// The execution status for the plugin instance.
    /// </summary>
    public List<TerraformProperty<object>>? HubInstanceAction
    {
        set => SetProperty("hub_instance_action", value);
    }

    /// <summary>
    /// The schedule for this plugin instance action. This can only be set if the
    /// plugin supports API_HUB_SCHEDULE_TRIGGER mode for this action.
    /// </summary>
    public TerraformProperty<string>? ScheduleCronExpression
    {
        set => SetProperty("schedule_cron_expression", value);
    }

    /// <summary>
    /// The time zone for the schedule cron expression. If not provided, UTC will
    /// be used.
    /// </summary>
    public TerraformProperty<string>? ScheduleTimeZone
    {
        set => SetProperty("schedule_time_zone", value);
    }

    /// <summary>
    /// The current state of the plugin action in the plugin instance.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ENABLED
    /// DISABLED
    /// ENABLING
    /// DISABLING
    /// ERROR
    /// </summary>
    public TerraformProperty<string>? State
    {
        set => SetProperty("state", value);
    }

}

/// <summary>
/// Block type for auth_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginInstanceAuthConfigBlock : TerraformBlock
{
    /// <summary>
    /// Possible values:
    /// AUTH_TYPE_UNSPECIFIED
    /// NO_AUTH
    /// GOOGLE_SERVICE_ACCOUNT
    /// USER_PASSWORD
    /// API_KEY
    /// OAUTH2_CLIENT_CREDENTIALS
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AuthType is required")]
    public required TerraformProperty<string> AuthType
    {
        set => SetProperty("auth_type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubPluginInstanceTimeoutsBlock : TerraformBlock
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
/// Manages a google_apihub_plugin_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApihubPluginInstance : TerraformResource
{
    public GoogleApihubPluginInstance(string name) : base("google_apihub_plugin_instance", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("create_time");
        SetOutput("error_message");
        SetOutput("name");
        SetOutput("state");
        SetOutput("update_time");
        SetOutput("disable");
        SetOutput("display_name");
        SetOutput("id");
        SetOutput("location");
        SetOutput("plugin");
        SetOutput("plugin_instance_id");
        SetOutput("project");
    }

    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    public TerraformProperty<bool> Disable
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("disable");
        set => SetProperty("disable", value);
    }

    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
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
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plugin is required")]
    public required TerraformProperty<string> Plugin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plugin");
        set => SetProperty("plugin", value);
    }

    /// <summary>
    /// The ID to use for the plugin instance, which will become the final
    /// component of the plugin instance&#39;s resource name. This field is optional.
    /// 
    /// * If provided, the same will be used. The service will throw an error if
    /// the specified id is already used by another plugin instance in the plugin
    /// resource.
    /// * If not provided, a system generated id will be used.
    /// 
    /// This value should be 4-63 characters, and valid characters
    /// are /a-z[0-9]-_/.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PluginInstanceId is required")]
    public required TerraformProperty<string> PluginInstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("plugin_instance_id");
        set => SetProperty("plugin_instance_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformProperty<string> Project
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project");
        set => SetProperty("project", value);
    }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    public List<GoogleApihubPluginInstanceActionsBlock>? Actions
    {
        set => SetProperty("actions", value);
    }

    /// <summary>
    /// Block for auth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    public List<GoogleApihubPluginInstanceAuthConfigBlock>? AuthConfig
    {
        set => SetProperty("auth_config", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public GoogleApihubPluginInstanceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Timestamp indicating when the plugin instance was created.
    /// </summary>
    public TerraformExpression CreateTime => this["create_time"];

    /// <summary>
    /// Error message describing the failure, if any, during Create, Delete or
    /// ApplyConfig operation corresponding to the plugin instance.This field will
    /// only be populated if the plugin instance is in the ERROR or FAILED state.
    /// </summary>
    public TerraformExpression ErrorMessage => this["error_message"];

    /// <summary>
    /// Identifier. The unique name of the plugin instance resource.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}&#39;
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The current state of the plugin instance (e.g., enabled, disabled,
    /// provisioning).
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// CREATING
    /// ACTIVE
    /// APPLYING_CONFIG
    /// ERROR
    /// FAILED
    /// DELETING
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// Timestamp indicating when the plugin instance was last updated.
    /// </summary>
    public TerraformExpression UpdateTime => this["update_time"];

}
