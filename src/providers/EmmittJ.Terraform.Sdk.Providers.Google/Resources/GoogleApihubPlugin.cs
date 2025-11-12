using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions_config in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApihubPluginActionsConfigBlock() : TerraformBlock("actions_config")
{
    /// <summary>
    /// The description of the operation performed by the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformProperty("description")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Description { get; set; }

    /// <summary>
    /// The display name of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformProperty("display_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DisplayName { get; set; }

    /// <summary>
    /// The id of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The trigger mode supported by the action.
    /// Possible values:
    /// TRIGGER_MODE_UNSPECIFIED
    /// API_HUB_ON_DEMAND_TRIGGER
    /// API_HUB_SCHEDULE_TRIGGER
    /// NON_API_HUB_MANAGED
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerMode is required")]
    [TerraformProperty("trigger_mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TriggerMode { get; set; }

}

/// <summary>
/// Block type for config_template in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApihubPluginConfigTemplateBlock() : TerraformBlock("config_template")
{
}

/// <summary>
/// Block type for documentation in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApihubPluginDocumentationBlock() : TerraformBlock("documentation")
{
    /// <summary>
    /// The uri of the externally hosted documentation.
    /// </summary>
    [TerraformProperty("external_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ExternalUri { get; set; }

}

/// <summary>
/// Block type for hosting_service in .
/// Nesting mode: list
/// </summary>
public partial class GoogleApihubPluginHostingServiceBlock() : TerraformBlock("hosting_service")
{
    /// <summary>
    /// The URI of the service implemented by the plugin developer, used to
    /// invoke the plugin&#39;s functionality. This information is only required for
    /// user defined plugins.
    /// </summary>
    [TerraformProperty("service_uri")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ServiceUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class GoogleApihubPluginTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a google_apihub_plugin resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class GoogleApihubPlugin : TerraformResource
{
    public GoogleApihubPlugin(string name) : base("google_apihub_plugin", name)
    {
    }

    /// <summary>
    /// The plugin description. Max length is 2000 characters (Unicode code
    /// points).
    /// </summary>
    [TerraformProperty("description")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Description { get; set; }

    /// <summary>
    /// The display name of the plugin. Max length is 50 characters (Unicode code
    /// points).
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
    /// Possible values:
    /// PLUGIN_CATEGORY_UNSPECIFIED
    /// API_GATEWAY
    /// API_PRODUCER
    /// </summary>
    [TerraformProperty("plugin_category")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PluginCategory { get; set; }

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
    [TerraformProperty("plugin_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PluginId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformProperty("project")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Project { get; set; }

    /// <summary>
    /// Block for actions_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("actions_config")]
    public TerraformList<GoogleApihubPluginActionsConfigBlock> ActionsConfig { get; set; } = new();

    /// <summary>
    /// Block for config_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigTemplate block(s) allowed")]
    [TerraformProperty("config_template")]
    public TerraformList<GoogleApihubPluginConfigTemplateBlock> ConfigTemplate { get; set; } = new();

    /// <summary>
    /// Block for documentation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Documentation block(s) allowed")]
    [TerraformProperty("documentation")]
    public TerraformList<GoogleApihubPluginDocumentationBlock> Documentation { get; set; } = new();

    /// <summary>
    /// Block for hosting_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostingService block(s) allowed")]
    [TerraformProperty("hosting_service")]
    public TerraformList<GoogleApihubPluginHostingServiceBlock> HostingService { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public GoogleApihubPluginTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Timestamp indicating when the plugin was created.
    /// </summary>
    [TerraformProperty("create_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> CreateTime { get; }

    /// <summary>
    /// Identifier. The name of the plugin.
    /// Format: &#39;projects/{project}/locations/{location}/plugins/{plugin}&#39;
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The type of the plugin, indicating whether it is &#39;SYSTEM_OWNED&#39; or
    /// &#39;USER_OWNED&#39;.
    /// Possible values:
    /// OWNERSHIP_TYPE_UNSPECIFIED
    /// SYSTEM_OWNED
    /// USER_OWNED
    /// </summary>
    [TerraformProperty("ownership_type")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OwnershipType { get; }

    /// <summary>
    /// Represents the state of the plugin.
    /// Note this field will not be set for plugins developed via plugin
    /// framework as the state will be managed at plugin instance level.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ENABLED
    /// DISABLED
    /// </summary>
    [TerraformProperty("state")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> State { get; }

    /// <summary>
    /// Timestamp indicating when the plugin was last updated.
    /// </summary>
    [TerraformProperty("update_time")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> UpdateTime { get; }

}
