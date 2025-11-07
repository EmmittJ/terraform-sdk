using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
        this.DeclareOutput("namespace_name");
        this.DeclareOutput("relay_name");
        this.DeclareOutput("send_key_value");
        this.DeclareOutput("service_bus_namespace");
        this.DeclareOutput("service_bus_suffix");
    }

    /// <summary>
    /// The app_service_name attribute.
    /// </summary>
    public TerraformProperty<string>? AppServiceName
    {
        get => GetProperty<TerraformProperty<string>>("app_service_name");
        set => this.WithProperty("app_service_name", value);
    }

    /// <summary>
    /// The hostname attribute.
    /// </summary>
    public TerraformProperty<string>? Hostname
    {
        get => GetProperty<TerraformProperty<string>>("hostname");
        set => this.WithProperty("hostname", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The port attribute.
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The relay_id attribute.
    /// </summary>
    public TerraformProperty<string>? RelayId
    {
        get => GetProperty<TerraformProperty<string>>("relay_id");
        set => this.WithProperty("relay_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The send_key_name attribute.
    /// </summary>
    public TerraformProperty<string>? SendKeyName
    {
        get => GetProperty<TerraformProperty<string>>("send_key_name");
        set => this.WithProperty("send_key_name", value);
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
