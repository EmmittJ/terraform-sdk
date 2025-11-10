using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermAppServiceHybridConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
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
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("namespace_name");
        SetOutput("relay_name");
        SetOutput("send_key_value");
        SetOutput("service_bus_namespace");
        SetOutput("service_bus_suffix");
        SetOutput("app_service_name");
        SetOutput("hostname");
        SetOutput("id");
        SetOutput("port");
        SetOutput("relay_id");
        SetOutput("resource_group_name");
        SetOutput("send_key_name");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AppServiceName is required")]
    public required TerraformProperty<string> AppServiceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("app_service_name");
        set => SetProperty("app_service_name", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hostname");
        set => SetProperty("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredOutput<TerraformProperty<double>>("port");
        set => SetProperty("port", value);
    }

    /// <summary>
    /// The relay_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    public required TerraformProperty<string> RelayId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("relay_id");
        set => SetProperty("relay_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The send_key_name attribute.
    /// </summary>
    public TerraformProperty<string> SendKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("send_key_name");
        set => SetProperty("send_key_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermAppServiceHybridConnectionTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The namespace_name attribute.
    /// </summary>
    public TerraformExpression NamespaceName => this["namespace_name"];

    /// <summary>
    /// The relay_name attribute.
    /// </summary>
    public TerraformExpression RelayName => this["relay_name"];

    /// <summary>
    /// The send_key_value attribute.
    /// </summary>
    public TerraformExpression SendKeyValue => this["send_key_value"];

    /// <summary>
    /// The service_bus_namespace attribute.
    /// </summary>
    public TerraformExpression ServiceBusNamespace => this["service_bus_namespace"];

    /// <summary>
    /// The service_bus_suffix attribute.
    /// </summary>
    public TerraformExpression ServiceBusSuffix => this["service_bus_suffix"];

}
