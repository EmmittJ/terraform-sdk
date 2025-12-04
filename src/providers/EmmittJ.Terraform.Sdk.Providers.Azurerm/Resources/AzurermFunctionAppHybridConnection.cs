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
        get => GetRequiredArgument<TerraformValue<string>>("function_app_id");
        set => SetArgument("function_app_id", value);
    }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformValue<string> Hostname
    {
        get => GetRequiredArgument<TerraformValue<string>>("hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The port to use for the endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => GetRequiredArgument<TerraformValue<double>>("port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    public required TerraformValue<string> RelayId
    {
        get => GetRequiredArgument<TerraformValue<string>>("relay_id");
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
    public AzurermFunctionAppHybridConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermFunctionAppHybridConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
