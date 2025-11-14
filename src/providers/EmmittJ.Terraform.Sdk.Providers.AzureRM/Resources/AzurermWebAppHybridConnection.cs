using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
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
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_web_app_hybrid_connection resource.
/// </summary>
public class AzurermWebAppHybridConnection : TerraformResource
{
    public AzurermWebAppHybridConnection(string name) : base("azurerm_web_app_hybrid_connection", name)
    {
    }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    [TerraformArgument("hostname")]
    public required TerraformValue<string> Hostname
    {
        get => new TerraformReference<string>(this, "hostname");
        set => SetArgument("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The port to use for the endpoint
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformArgument("port")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    [TerraformArgument("relay_id")]
    public required TerraformValue<string> RelayId
    {
        get => new TerraformReference<string>(this, "relay_id");
        set => SetArgument("relay_id", value);
    }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    [TerraformArgument("send_key_name")]
    public TerraformValue<string>? SendKeyName
    {
        get => new TerraformReference<string>(this, "send_key_name");
        set => SetArgument("send_key_name", value);
    }

    /// <summary>
    /// The ID of the Web App for this Hybrid Connection.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    [TerraformArgument("web_app_id")]
    public required TerraformValue<string> WebAppId
    {
        get => new TerraformReference<string>(this, "web_app_id");
        set => SetArgument("web_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermWebAppHybridConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The name of the Relay Namespace.
    /// </summary>
    [TerraformArgument("namespace_name")]
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
    }

    /// <summary>
    /// The name of the Relay in use.
    /// </summary>
    [TerraformArgument("relay_name")]
    public TerraformValue<string> RelayName
    {
        get => new TerraformReference<string>(this, "relay_name");
    }

    /// <summary>
    /// The Primary Access Key for the `send_key_name`
    /// </summary>
    [TerraformArgument("send_key_value")]
    public TerraformValue<string> SendKeyValue
    {
        get => new TerraformReference<string>(this, "send_key_value");
    }

    /// <summary>
    /// The Service Bus Namespace.
    /// </summary>
    [TerraformArgument("service_bus_namespace")]
    public TerraformValue<string> ServiceBusNamespace
    {
        get => new TerraformReference<string>(this, "service_bus_namespace");
    }

    /// <summary>
    /// The suffix for the endpoint.
    /// </summary>
    [TerraformArgument("service_bus_suffix")]
    public TerraformValue<string> ServiceBusSuffix
    {
        get => new TerraformReference<string>(this, "service_bus_suffix");
    }

}
