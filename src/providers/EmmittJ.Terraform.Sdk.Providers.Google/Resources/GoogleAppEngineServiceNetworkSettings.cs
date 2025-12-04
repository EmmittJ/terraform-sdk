using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Block type for network_settings in GoogleAppEngineServiceNetworkSettings.
/// Nesting mode: list
/// </summary>
public class GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "network_settings";

    /// <summary>
    /// The ingress settings for version or service. Default value: &amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot; Possible values: [&amp;quot;INGRESS_TRAFFIC_ALLOWED_UNSPECIFIED&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_ALL&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_ONLY&amp;quot;, &amp;quot;INGRESS_TRAFFIC_ALLOWED_INTERNAL_AND_LB&amp;quot;]
    /// </summary>
    public TerraformValue<string>? IngressTrafficAllowed
    {
        get => GetArgument<TerraformValue<string>>("ingress_traffic_allowed");
        set => SetArgument("ingress_traffic_allowed", value);
    }

}


/// <summary>
/// Block type for timeouts in GoogleAppEngineServiceNetworkSettings.
/// Nesting mode: single
/// </summary>
public class GoogleAppEngineServiceNetworkSettingsTimeoutsBlock : TerraformBlock
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
/// Represents a google_app_engine_service_network_settings Terraform resource.
/// Manages a google_app_engine_service_network_settings resource.
/// </summary>
public partial class GoogleAppEngineServiceNetworkSettings(string name) : TerraformResource("google_app_engine_service_network_settings", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
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
    /// The name of the service these settings apply to.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Service is required")]
    public required TerraformValue<string> Service
    {
        get => GetArgument<TerraformValue<string>>("service");
        set => SetArgument("service", value);
    }

    /// <summary>
    /// NetworkSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 NetworkSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NetworkSettings block(s) allowed")]
    public required TerraformList<GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock> NetworkSettings
    {
        get => GetRequiredArgument<TerraformList<GoogleAppEngineServiceNetworkSettingsNetworkSettingsBlock>>("network_settings");
        set => SetArgument("network_settings", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public GoogleAppEngineServiceNetworkSettingsTimeoutsBlock? Timeouts
    {
        get => GetArgument<GoogleAppEngineServiceNetworkSettingsTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
