using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermFunctionAppHybridConnection.
/// Nesting mode: single
/// </summary>
public class AzurermFunctionAppHybridConnectionTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_function_app_hybrid_connection Terraform resource.
/// Manages a azurerm_function_app_hybrid_connection resource.
/// </summary>
public partial class AzurermFunctionAppHybridConnection(string name) : TerraformResource("azurerm_function_app_hybrid_connection", name)
{
    /// <summary>
    /// The ID of the Function App for this Hybrid Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FunctionAppId is required")]
    public required TerraformValue<string> FunctionAppId
    {
        get => new TerraformReference<string>(this, "function_app_id");
        set => SetArgument("function_app_id", value);
    }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The port to use for the endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    public required TerraformValue<string> RelayId
    {
        get => new TerraformReference<string>(this, "relay_id");
        set => SetArgument("relay_id", value);
    }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    public TerraformValue<string>? SendKeyName
    {
        get => new TerraformReference<string>(this, "send_key_name");
        set => SetArgument("send_key_name", value);
    }

    /// <summary>
    /// The name of the Relay Namespace.
    /// </summary>
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
    }

    /// <summary>
    /// The name of the Relay in use.
    /// </summary>
    public TerraformValue<string> RelayName
    {
        get => new TerraformReference<string>(this, "relay_name");
    }

    /// <summary>
    /// The Primary Access Key for the `send_key_name`
    /// </summary>
    public TerraformValue<string> SendKeyValue
    {
        get => new TerraformReference<string>(this, "send_key_value");
    }

    /// <summary>
    /// The Service Bus Namespace.
    /// </summary>
    public TerraformValue<string> ServiceBusNamespace
    {
        get => new TerraformReference<string>(this, "service_bus_namespace");
    }

    /// <summary>
    /// The suffix for the endpoint.
    /// </summary>
    public TerraformValue<string> ServiceBusSuffix
    {
        get => new TerraformReference<string>(this, "service_bus_suffix");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermFunctionAppHybridConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFunctionAppHybridConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
