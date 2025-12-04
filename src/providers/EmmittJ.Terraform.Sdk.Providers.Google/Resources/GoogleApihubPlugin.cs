using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for actions_config in GoogleApihubPlugin.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginActionsConfigBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions_config";

    /// <summary>
    /// The description of the operation performed by the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Description is required")]
    public required TerraformValue<string> Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id of the action.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    public required TerraformValue<string> TriggerMode
    {
        get => GetArgument<TerraformValue<string>>("trigger_mode");
        set => SetArgument("trigger_mode", value);
    }

}


/// <summary>
/// Block type for config_template in GoogleApihubPlugin.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "config_template";

    /// <summary>
    /// AdditionalConfigTemplate block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlock>? AdditionalConfigTemplate
    {
        get => GetArgument<TerraformList<GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlock>>("additional_config_template");
        set => SetArgument("additional_config_template", value);
    }

    /// <summary>
    /// AuthConfigTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AuthConfigTemplate block(s) allowed")]
    public TerraformList<GoogleApihubPluginConfigTemplateBlockAuthConfigTemplateBlock>? AuthConfigTemplate
    {
        get => GetArgument<TerraformList<GoogleApihubPluginConfigTemplateBlockAuthConfigTemplateBlock>>("auth_config_template");
        set => SetArgument("auth_config_template", value);
    }

}

/// <summary>
/// Block type for additional_config_template in GoogleApihubPluginConfigTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "additional_config_template";

    /// <summary>
    /// Description.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// ID of the config variable. Must be unique within the configuration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Flag represents that this &#39;ConfigVariable&#39; must be provided for a
    /// PluginInstance.
    /// </summary>
    public TerraformValue<bool>? Required
    {
        get => GetArgument<TerraformValue<bool>>("required");
        set => SetArgument("required", value);
    }

    /// <summary>
    /// Regular expression in RE2 syntax used for validating the &#39;value&#39; of a
    /// &#39;ConfigVariable&#39;.
    /// </summary>
    public TerraformValue<string>? ValidationRegex
    {
        get => GetArgument<TerraformValue<string>>("validation_regex");
        set => SetArgument("validation_regex", value);
    }

    /// <summary>
    /// Type of the parameter: string, int, bool etc.
    /// Possible values:
    /// VALUE_TYPE_UNSPECIFIED
    /// STRING
    /// INT
    /// BOOL
    /// SECRET
    /// ENUM
    /// MULTI_SELECT
    /// MULTI_STRING
    /// MULTI_INT
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ValueType is required")]
    public required TerraformValue<string> ValueType
    {
        get => GetArgument<TerraformValue<string>>("value_type");
        set => SetArgument("value_type", value);
    }

    /// <summary>
    /// EnumOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlockEnumOptionsBlock>? EnumOptions
    {
        get => GetArgument<TerraformList<GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlockEnumOptionsBlock>>("enum_options");
        set => SetArgument("enum_options", value);
    }

    /// <summary>
    /// MultiSelectOptions block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlockMultiSelectOptionsBlock>? MultiSelectOptions
    {
        get => GetArgument<TerraformList<GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlockMultiSelectOptionsBlock>>("multi_select_options");
        set => SetArgument("multi_select_options", value);
    }

}

/// <summary>
/// Block type for enum_options in GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlockEnumOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "enum_options";

    /// <summary>
    /// Description of the option.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Display name of the option.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Id of the option.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for multi_select_options in GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlockAdditionalConfigTemplateBlockMultiSelectOptionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "multi_select_options";

    /// <summary>
    /// Description of the option.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// Display name of the option.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// Id of the option.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    public required TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

}

/// <summary>
/// Block type for auth_config_template in GoogleApihubPluginConfigTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlockAuthConfigTemplateBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "auth_config_template";

    /// <summary>
    /// The list of authentication types supported by the plugin.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SupportedAuthTypes is required")]
    public TerraformList<string>? SupportedAuthTypes
    {
        get => GetArgument<TerraformList<string>>("supported_auth_types");
        set => SetArgument("supported_auth_types", value);
    }

    /// <summary>
    /// ServiceAccount block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ServiceAccount block(s) allowed")]
    public TerraformList<GoogleApihubPluginConfigTemplateBlockAuthConfigTemplateBlockServiceAccountBlock>? ServiceAccount
    {
        get => GetArgument<TerraformList<GoogleApihubPluginConfigTemplateBlockAuthConfigTemplateBlockServiceAccountBlock>>("service_account");
        set => SetArgument("service_account", value);
    }

}

/// <summary>
/// Block type for service_account in GoogleApihubPluginConfigTemplateBlockAuthConfigTemplateBlock.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginConfigTemplateBlockAuthConfigTemplateBlockServiceAccountBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "service_account";

    /// <summary>
    /// The service account to be used for authenticating request.
    /// 
    /// The &#39;iam.serviceAccounts.getAccessToken&#39; permission should be granted on
    /// this service account to the impersonator service account.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServiceAccount is required")]
    public required TerraformValue<string> ServiceAccount
    {
        get => GetArgument<TerraformValue<string>>("service_account");
        set => SetArgument("service_account", value);
    }

}


/// <summary>
/// Block type for documentation in GoogleApihubPlugin.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginDocumentationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "documentation";

    /// <summary>
    /// The uri of the externally hosted documentation.
    /// </summary>
    public TerraformValue<string>? ExternalUri
    {
        get => GetArgument<TerraformValue<string>>("external_uri");
        set => SetArgument("external_uri", value);
    }

}


/// <summary>
/// Block type for hosting_service in GoogleApihubPlugin.
/// Nesting mode: list
/// </summary>
public class GoogleApihubPluginHostingServiceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hosting_service";

    /// <summary>
    /// The URI of the service implemented by the plugin developer, used to
    /// invoke the plugin&#39;s functionality. This information is only required for
    /// user defined plugins.
    /// </summary>
    public TerraformValue<string>? ServiceUri
    {
        get => GetArgument<TerraformValue<string>>("service_uri");
        set => SetArgument("service_uri", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleApihubPlugin.
/// Nesting mode: single
/// </summary>
public class GoogleApihubPluginTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a google_apihub_plugin Terraform resource.
/// Manages a google_apihub_plugin resource.
/// </summary>
public partial class GoogleApihubPlugin(string name) : TerraformResource("google_apihub_plugin", name)
{
    /// <summary>
    /// The plugin description. Max length is 2000 characters (Unicode code
    /// points).
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display name of the plugin. Max length is 50 characters (Unicode code
    /// points).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => GetArgument<TerraformValue<string>>("display_name");
        set => SetArgument("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// Resource ID segment making up resource &#39;name&#39;. It identifies the resource within its parent collection as described in https://google.aip.dev/122.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// Possible values:
    /// PLUGIN_CATEGORY_UNSPECIFIED
    /// API_GATEWAY
    /// API_PRODUCER
    /// </summary>
    public TerraformValue<string>? PluginCategory
    {
        get => GetArgument<TerraformValue<string>>("plugin_category");
        set => SetArgument("plugin_category", value);
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
    public required TerraformValue<string> PluginId
    {
        get => GetArgument<TerraformValue<string>>("plugin_id");
        set => SetArgument("plugin_id", value);
    }

    /// <summary>
    /// The project attribute.
    /// </summary>
    public TerraformValue<string>? Project
    {
        get => GetArgument<TerraformValue<string>>("project");
        set => SetArgument("project", value);
    }

    /// <summary>
    /// Timestamp indicating when the plugin was created.
    /// </summary>
    public TerraformValue<string> CreateTime
        => AsReference("create_time");

    /// <summary>
    /// Identifier. The name of the plugin.
    /// Format: &#39;projects/{project}/locations/{location}/plugins/{plugin}&#39;
    /// </summary>
    public TerraformValue<string> Name
        => AsReference("name");

    /// <summary>
    /// The type of the plugin, indicating whether it is &#39;SYSTEM_OWNED&#39; or
    /// &#39;USER_OWNED&#39;.
    /// Possible values:
    /// OWNERSHIP_TYPE_UNSPECIFIED
    /// SYSTEM_OWNED
    /// USER_OWNED
    /// </summary>
    public TerraformValue<string> OwnershipType
        => AsReference("ownership_type");

    /// <summary>
    /// Represents the state of the plugin.
    /// Note this field will not be set for plugins developed via plugin
    /// framework as the state will be managed at plugin instance level.
    /// Possible values:
    /// STATE_UNSPECIFIED
    /// ENABLED
    /// DISABLED
    /// </summary>
    public TerraformValue<string> State
        => AsReference("state");

    /// <summary>
    /// Timestamp indicating when the plugin was last updated.
    /// </summary>
    public TerraformValue<string> UpdateTime
        => AsReference("update_time");

    /// <summary>
    /// ActionsConfig block (nesting mode: list).
    /// </summary>
    public TerraformList<GoogleApihubPluginActionsConfigBlock>? ActionsConfig
    {
        get => GetArgument<TerraformList<GoogleApihubPluginActionsConfigBlock>>("actions_config");
        set => SetArgument("actions_config", value);
    }

    /// <summary>
    /// ConfigTemplate block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ConfigTemplate block(s) allowed")]
    public TerraformList<GoogleApihubPluginConfigTemplateBlock>? ConfigTemplate
    {
        get => GetArgument<TerraformList<GoogleApihubPluginConfigTemplateBlock>>("config_template");
        set => SetArgument("config_template", value);
    }

    /// <summary>
    /// Documentation block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Documentation block(s) allowed")]
    public TerraformList<GoogleApihubPluginDocumentationBlock>? Documentation
    {
        get => GetArgument<TerraformList<GoogleApihubPluginDocumentationBlock>>("documentation");
        set => SetArgument("documentation", value);
    }

    /// <summary>
    /// HostingService block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HostingService block(s) allowed")]
    public TerraformList<GoogleApihubPluginHostingServiceBlock>? HostingService
    {
        get => GetArgument<TerraformList<GoogleApihubPluginHostingServiceBlock>>("hosting_service");
        set => SetArgument("hosting_service", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleApihubPluginTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleApihubPluginTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
