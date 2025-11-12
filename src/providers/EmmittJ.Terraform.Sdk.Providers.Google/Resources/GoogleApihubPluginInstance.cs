using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApihubPluginInstanceActionsBlock() : TerraformBlock("actions")
{
    /// <summary>
    /// This should map to one of the action id specified
    /// in actions_config in the plugin.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ActionId is required")]
    [TerraformProperty("action_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ActionId { get; set; }


    /// <summary>
    /// The schedule for this plugin instance action. This can only be set if the
    /// plugin supports API_HUB_SCHEDULE_TRIGGER mode for this action.
    /// </summary>
    [TerraformProperty("schedule_cron_expression")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScheduleCronExpression { get; set; }

    /// <summary>
    /// The time zone for the schedule cron expression. If not provided, UTC will
    /// be used.
    /// </summary>
    [TerraformProperty("schedule_time_zone")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ScheduleTimeZone { get; set; }


}

/// <summary>
/// Block type for auth_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApihubPluginInstanceAuthConfigBlock() : TerraformBlock("auth_config")
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
    [TerraformProperty("auth_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AuthType { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApihubPluginInstanceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a google_apihub_plugin_instance resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApihubPluginInstance : TerraformResource
{
    public GoogleApihubPluginInstance(string name) : base("google_apihub_plugin_instance", name)
    {
    }

    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    [TerraformProperty("disable")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? Disable { get; set; }

    /// <summary>
    /// The display name for this plugin instance. Max length is 255 characters.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Plugin is required")]
    [TerraformProperty("plugin")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Plugin { get; set; }

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
    [TerraformProperty("plugin_instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PluginInstanceId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for actions.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("actions")]
    public TerraformList<GoogleApihubPluginInstanceActionsBlock> Actions { get; set; } = new();

    /// <summary>
    /// Block for auth_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfig block(s) allowed")]
    [TerraformProperty("auth_config")]
    public TerraformList<GoogleApihubPluginInstanceAuthConfigBlock> AuthConfig { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApihubPluginInstanceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Timestamp indicating when the plugin instance was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Error message describing the failure, if any, during Create, Delete or
    /// ApplyConfig operation corresponding to the plugin instance.This field will
    /// only be populated if the plugin instance is in the ERROR or FAILED state.
    /// </summary>
    [TerraformProperty("error_message")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ErrorMessage { get; }

    /// <summary>
    /// Identifier. The unique name of the plugin instance resource.
    /// Format:
    /// &#39;projects/{project}/locations/{location}/plugins/{plugin}/instances/{instance}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

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
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Timestamp indicating when the plugin instance was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
