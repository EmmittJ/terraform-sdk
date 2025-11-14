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
public class AzurermAppServiceHybridConnectionTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_app_service_hybrid_connection resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public class AzurermAppServiceHybridConnection : TerraformResource
{
    public AzurermAppServiceHybridConnection(string name) : base("azurerm_app_service_hybrid_connection", name)
    {
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    [TerraformArgument("app_service_name")]
    public required TerraformValue<string> AppServiceName
    {
        get => new TerraformReference<string>(this, "app_service_name");
        set => SetArgument("app_service_name", value);
    }

    /// <summary>
    /// The hostname attribute.
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
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    [TerraformArgument("port")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The relay_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    [TerraformArgument("relay_id")]
    public required TerraformValue<string> RelayId
    {
        get => new TerraformReference<string>(this, "relay_id");
        set => SetArgument("relay_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The send_key_name attribute.
    /// </summary>
    [TerraformArgument("send_key_name")]
    public TerraformValue<string>? SendKeyName
    {
        get => new TerraformReference<string>(this, "send_key_name");
        set => SetArgument("send_key_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermAppServiceHybridConnectionTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    [TerraformArgument("namespace_name")]
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
    }

    /// <summary>
    /// The relay_name attribute.
    /// </summary>
    [TerraformArgument("relay_name")]
    public TerraformValue<string> RelayName
    {
        get => new TerraformReference<string>(this, "relay_name");
    }

    /// <summary>
    /// The send_key_value attribute.
    /// </summary>
    [TerraformArgument("send_key_value")]
    public TerraformValue<string> SendKeyValue
    {
        get => new TerraformReference<string>(this, "send_key_value");
    }

    /// <summary>
    /// The service_bus_namespace attribute.
    /// </summary>
    [TerraformArgument("service_bus_namespace")]
    public TerraformValue<string> ServiceBusNamespace
    {
        get => new TerraformReference<string>(this, "service_bus_namespace");
    }

    /// <summary>
    /// The service_bus_suffix attribute.
    /// </summary>
    [TerraformArgument("service_bus_suffix")]
    public TerraformValue<string> ServiceBusSuffix
    {
        get => new TerraformReference<string>(this, "service_bus_suffix");
    }

}
