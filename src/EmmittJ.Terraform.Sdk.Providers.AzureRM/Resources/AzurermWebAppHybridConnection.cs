using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_web_app_hybrid_connection resource.
/// </summary>
public class AzurermWebAppHybridConnection : TerraformResource
{
    public AzurermWebAppHybridConnection(string name) : base("azurerm_web_app_hybrid_connection", name)
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
    /// The hostname of the endpoint.
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
    /// The port to use for the endpoint
    /// </summary>
    public TerraformProperty<double>? Port
    {
        get => GetProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    public TerraformProperty<string>? RelayId
    {
        get => GetProperty<TerraformProperty<string>>("relay_id");
        set => this.WithProperty("relay_id", value);
    }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    public TerraformProperty<string>? SendKeyName
    {
        get => GetProperty<TerraformProperty<string>>("send_key_name");
        set => this.WithProperty("send_key_name", value);
    }

    /// <summary>
    /// The ID of the Web App for this Hybrid Connection.
    /// </summary>
    public TerraformProperty<string>? WebAppId
    {
        get => GetProperty<TerraformProperty<string>>("web_app_id");
        set => this.WithProperty("web_app_id", value);
    }

    /// <summary>
    /// The name of the Relay Namespace.
    /// </summary>
    public TerraformExpression NamespaceName => this["namespace_name"];

    /// <summary>
    /// The name of the Relay in use.
    /// </summary>
    public TerraformExpression RelayName => this["relay_name"];

    /// <summary>
    /// The Primary Access Key for the `send_key_name`
    /// </summary>
    public TerraformExpression SendKeyValue => this["send_key_value"];

    /// <summary>
    /// The Service Bus Namespace.
    /// </summary>
    public TerraformExpression ServiceBusNamespace => this["service_bus_namespace"];

    /// <summary>
    /// The suffix for the endpoint.
    /// </summary>
    public TerraformExpression ServiceBusSuffix => this["service_bus_suffix"];

}
