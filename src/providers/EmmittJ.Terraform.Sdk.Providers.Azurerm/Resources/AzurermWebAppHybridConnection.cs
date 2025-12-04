using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermWebAppHybridConnection.
/// Nesting mode: single
/// </summary>
public class AzurermWebAppHybridConnectionTimeoutsBlock : TerraformBlock
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
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
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
/// Represents a azurerm_web_app_hybrid_connection Terraform resource.
/// Manages a azurerm_web_app_hybrid_connection resource.
/// </summary>
public partial class AzurermWebAppHybridConnection(string name) : TerraformResource("azurerm_web_app_hybrid_connection", name)
{
    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
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
    /// The port to use for the endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    public required TerraformValue<string> RelayId
    {
        get => GetArgument<TerraformValue<string>>("relay_id");
        set => SetArgument("relay_id", value);
    }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    public TerraformValue<string>? SendKeyName
    {
        get => GetArgument<TerraformValue<string>>("send_key_name");
        set => SetArgument("send_key_name", value);
    }

    /// <summary>
    /// The ID of the Web App for this Hybrid Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    public required TerraformValue<string> WebAppId
    {
        get => GetArgument<TerraformValue<string>>("web_app_id");
        set => SetArgument("web_app_id", value);
    }

    /// <summary>
    /// The name of the Relay Namespace.
    /// </summary>
    public TerraformValue<string> NamespaceName
        => AsReference("namespace_name");

    /// <summary>
    /// The name of the Relay in use.
    /// </summary>
    public TerraformValue<string> RelayName
        => AsReference("relay_name");

    /// <summary>
    /// The Primary Access Key for the `send_key_name`
    /// </summary>
    public TerraformValue<string> SendKeyValue
        => AsReference("send_key_value");

    /// <summary>
    /// The Service Bus Namespace.
    /// </summary>
    public TerraformValue<string> ServiceBusNamespace
        => AsReference("service_bus_namespace");

    /// <summary>
    /// The suffix for the endpoint.
    /// </summary>
    public TerraformValue<string> ServiceBusSuffix
        => AsReference("service_bus_suffix");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermWebAppHybridConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermWebAppHybridConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
