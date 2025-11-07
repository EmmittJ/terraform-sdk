using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_file_upload resource.
/// </summary>
public class AzurermIothubFileUpload : TerraformResource
{
    public AzurermIothubFileUpload(string name) : base("azurerm_iothub_file_upload", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DefaultTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_ttl");
        set => this.WithProperty("default_ttl", value);
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IothubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_id");
        set => this.WithProperty("iothub_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? LockDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_duration");
        set => this.WithProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxDeliveryCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_delivery_count");
        set => this.WithProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    public TerraformLiteralProperty<bool>? NotificationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("notifications_enabled");
        set => this.WithProperty("notifications_enabled", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SasTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sas_ttl");
        set => this.WithProperty("sas_ttl", value);
    }

}
