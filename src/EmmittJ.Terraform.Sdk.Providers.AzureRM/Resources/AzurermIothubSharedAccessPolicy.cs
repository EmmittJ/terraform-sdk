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
    public TerraformLiteralProperty<bool>? DeviceConnect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("device_connect");
        set => this.WithProperty("device_connect", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The iothub_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IothubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_name");
        set => this.WithProperty("iothub_name", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The registry_read attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RegistryRead
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registry_read");
        set => this.WithProperty("registry_read", value);
    }

    /// <summary>
    /// The registry_write attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? RegistryWrite
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("registry_write");
        set => this.WithProperty("registry_write", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The service_connect attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? ServiceConnect
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("service_connect");
        set => this.WithProperty("service_connect", value);
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
