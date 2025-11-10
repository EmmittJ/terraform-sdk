using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermWebAppHybridConnectionTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

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
        this.WithOutputamespace_name");
        this.WithOutputelay_name");
        this.WithOutputend_key_value");
        this.WithOutputervice_bus_namespace");
        this.WithOutputervice_bus_suffix");
    }

    /// <summary>
    /// The hostname of the endpoint.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Hostname is required")]
    public required TerraformProperty<string> Hostname
    {
        get => GetRequiredProperty<TerraformProperty<string>>("hostname");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Port is required")]
    public required TerraformProperty<double> Port
    {
        get => GetRequiredProperty<TerraformProperty<double>>("port");
        set => this.WithProperty("port", value);
    }

    /// <summary>
    /// The ID of the Relay Hybrid Connection to use.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RelayId is required")]
    public required TerraformProperty<string> RelayId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("relay_id");
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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WebAppId is required")]
    public required TerraformProperty<string> WebAppId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("web_app_id");
        set => this.WithProperty("web_app_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermWebAppHybridConnectionTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermWebAppHybridConnectionTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
