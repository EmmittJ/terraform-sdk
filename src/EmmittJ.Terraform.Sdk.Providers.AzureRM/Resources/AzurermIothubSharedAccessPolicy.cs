using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_shared_access_policy resource.
/// </summary>
public class AzurermIothubSharedAccessPolicy : TerraformResource
{
    public AzurermIothubSharedAccessPolicy(string name) : base("azurerm_iothub_shared_access_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("primary_connection_string");
        this.DeclareOutput("primary_key");
        this.DeclareOutput("secondary_connection_string");
        this.DeclareOutput("secondary_key");
    }

    /// <summary>
    /// The device_connect attribute.
    /// </summary>
    public bool? DeviceConnect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("device_connect")?.Value;
        set => this.WithProperty("device_connect", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
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
    /// The iothub_name attribute.
    /// </summary>
    public string? IothubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_name")?.Value;
        set => this.WithProperty("iothub_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The registry_read attribute.
    /// </summary>
    public bool? RegistryRead
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registry_read")?.Value;
        set => this.WithProperty("registry_read", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The registry_write attribute.
    /// </summary>
    public bool? RegistryWrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registry_write")?.Value;
        set => this.WithProperty("registry_write", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The service_connect attribute.
    /// </summary>
    public bool? ServiceConnect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("service_connect")?.Value;
        set => this.WithProperty("service_connect", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The primary_connection_string attribute.
    /// </summary>
    public TerraformExpression PrimaryConnectionString => this["primary_connection_string"];

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformExpression PrimaryKey => this["primary_key"];

    /// <summary>
    /// The secondary_connection_string attribute.
    /// </summary>
    public TerraformExpression SecondaryConnectionString => this["secondary_connection_string"];

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformExpression SecondaryKey => this["secondary_key"];

}
