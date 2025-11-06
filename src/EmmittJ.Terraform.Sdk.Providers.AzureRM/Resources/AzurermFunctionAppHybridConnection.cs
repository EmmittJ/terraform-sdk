using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_function_app_hybrid_connection resource.
/// </summary>
public class AzurermFunctionAppHybridConnection : TerraformResource
{
    public AzurermFunctionAppHybridConnection(string name) : base("azurerm_function_app_hybrid_connection", name)
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
    /// The ID of the Function App for this Hybrid Connection.
    /// </summary>
    public string? FunctionAppId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("function_app_id")?.Value;
        set => this.WithProperty("function_app_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    public string? Hostname
    {
        get => GetProperty<TerraformLiteralProperty<string>>("hostname")?.Value;
        set => this.WithProperty("hostname", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The port to use for the endpoint
    /// </summary>
    public double? Port
    {
        get => GetProperty<TerraformLiteralProperty<double>>("port")?.Value;
        set => this.WithProperty("port", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    public string? RelayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("relay_id")?.Value;
        set => this.WithProperty("relay_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name of the Relay key with `Send` permission to use. Defaults to `RootManageSharedAccessKey`
    /// </summary>
    public string? SendKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("send_key_name")?.Value;
        set => this.WithProperty("send_key_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
