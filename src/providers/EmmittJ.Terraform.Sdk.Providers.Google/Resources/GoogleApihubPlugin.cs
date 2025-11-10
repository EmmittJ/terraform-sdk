using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions_config in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginActionsConfigBlock : ITerraformBlock
{
    /// <summary>
    /// The description of the operation performed by the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    [TerraformPropertyName("description")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Description { get; set; }

    /// <summary>
    /// The display name of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformPropertyName("id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Id { get; set; }

    /// <summary>
    /// The trigger mode supported by the action.
    /// Possible values:
    /// TRIGGER_MODE_UNSPECIFIED
    /// API_HUB_ON_DEMAND_TRIGGER
    /// API_HUB_SCHEDULE_TRIGGER
    /// NON_API_HUB_MANAGED
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TriggerMode is required")]
    [TerraformPropertyName("trigger_mode")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> TriggerMode { get; set; }

}

/// <summary>
/// Block type for config_template in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlock : ITerraformBlock
{
}

/// <summary>
/// Block type for documentation in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginDocumentationBlock : ITerraformBlock
{
    /// <summary>
    /// The uri of the externally hosted documentation.
    /// </summary>
    [TerraformPropertyName("external_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ExternalUri { get; set; }

}

/// <summary>
/// Block type for hosting_service in .
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginHostingServiceBlock : ITerraformBlock
{
    /// <summary>
    /// The URI of the service implemented by the plugin developer, used to
    /// invoke the plugin&#39;s functionality. This information is only required for
    /// user defined plugins.
    /// </summary>
    [TerraformPropertyName("service_uri")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServiceUri { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class GoogleApihubPluginTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Delete { get; set; }

}

/// <summary>
/// Manages a google_apihub_plugin resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class GoogleApihubPlugin : TerraformResource
{
    public GoogleApihubPlugin(string name) : base("google_apihub_plugin", name)
    {
    }

    /// <summary>
    /// The plugin description. Max length is 2000 characters (Unicode code
    /// points).
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The display name of the plugin. Max length is 50 characters (Unicode code
    /// points).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    [TerraformPropertyName("display_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> DisplayName { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// Possible values:
    /// PLUGIN_CATEGORY_UNSPECIFIED
    /// API_GATEWAY
    /// API_PRODUCER
    /// </summary>
    [TerraformPropertyName("plugin_category")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? PluginCategory { get; set; }

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
    [TerraformPropertyName("plugin_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> PluginId { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// Block for actions_config.
    /// Nesting mode: list
    /// </summary>
    [TerraformPropertyName("actions_config")]
    public TerraformList<TerraformBlock<GoogleApihubPluginActionsConfigBlock>>? ActionsConfig { get; set; } = new();

    /// <summary>
    /// Block for config_template.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigTemplate block(s) allowed")]
    [TerraformPropertyName("config_template")]
    public TerraformList<TerraformBlock<GoogleApihubPluginConfigTemplateBlock>>? ConfigTemplate { get; set; } = new();

    /// <summary>
    /// Block for documentation.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Documentation block(s) allowed")]
    [TerraformPropertyName("documentation")]
    public TerraformList<TerraformBlock<GoogleApihubPluginDocumentationBlock>>? Documentation { get; set; } = new();

    /// <summary>
    /// Block for hosting_service.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostingService block(s) allowed")]
    [TerraformPropertyName("hosting_service")]
    public TerraformList<TerraformBlock<GoogleApihubPluginHostingServiceBlock>>? HostingService { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<GoogleApihubPluginTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// Timestamp indicating when the plugin was created.
    /// </summary>
    [TerraformPropertyName("create_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> CreateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "create_time");

    /// <summary>
    /// Identifier. The name of the plugin.
    /// Format: &#39;projects/{project}/locations/{location}/plugins/{plugin}&#39;
    /// </summary>
    [TerraformPropertyName("name")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Name => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "name");

    /// <summary>
    /// The type of the plugin, indicating whether it is &#39;SYSTEM_OWNED&#39; or
    /// &#39;USER_OWNED&#39;.
    /// Possible values:
    /// OWNERSHIP_TYPE_UNSPECIFIED
    /// SYSTEM_OWNED
    /// USER_OWNED
    /// </summary>
    [TerraformPropertyName("ownership_type")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> OwnershipType => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "ownership_type");

    /// <summary>
    /// Represents the state of the plugin.
    /// Note this field will not be set for plugins developed via plugin
    /// framework as the state will be managed at plugin instance level.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ENABLED
    /// DISABLED
    /// </summary>
    [TerraformPropertyName("state")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> State => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "state");

    /// <summary>
    /// Timestamp indicating when the plugin was last updated.
    /// </summary>
    [TerraformPropertyName("update_time")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> UpdateTime => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "update_time");

}
