using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
/// Represents a azurerm_app_service_hybrid_connection Terraform resource.
/// Manages a azurerm_app_service_hybrid_connection resource.
/// </summary>
[Obsolete("This resource is deprecated.")]
public partial class AzurermAppServiceHybridConnection(string name) : TerraformResource("azurerm_app_service_hybrid_connection", name)
{
    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformValue<string> AppServiceName
    {
        get => new TerraformReference<string>(this, "app_service_name");
        set => SetArgument("app_service_name", value);
    }

    /// <summary>
    /// The hostname attribute.
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
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformValue<double> Port
    {
        get => new TerraformReference<double>(this, "port");
        set => SetArgument("port", value);
    }

    /// <summary>
    /// The relay_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    public required TerraformValue<string> RelayId
    {
        get => new TerraformReference<string>(this, "relay_id");
        set => SetArgument("relay_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The send_key_name attribute.
    /// </summary>
    public TerraformValue<string>? SendKeyName
    {
        get => new TerraformReference<string>(this, "send_key_name");
        set => SetArgument("send_key_name", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    public TerraformValue<string> NamespaceName
    {
        get => new TerraformReference<string>(this, "namespace_name");
    }

    /// <summary>
    /// The relay_name attribute.
    /// </summary>
    public TerraformValue<string> RelayName
    {
        get => new TerraformReference<string>(this, "relay_name");
    }

    /// <summary>
    /// The send_key_value attribute.
    /// </summary>
    public TerraformValue<string> SendKeyValue
    {
        get => new TerraformReference<string>(this, "send_key_value");
    }

    /// <summary>
    /// The service_bus_namespace attribute.
    /// </summary>
    public TerraformValue<string> ServiceBusNamespace
    {
        get => new TerraformReference<string>(this, "service_bus_namespace");
    }

    /// <summary>
    /// The service_bus_suffix attribute.
    /// </summary>
    public TerraformValue<string> ServiceBusSuffix
    {
        get => new TerraformReference<string>(this, "service_bus_suffix");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermAppServiceHybridConnectionTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermAppServiceHybridConnectionTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
