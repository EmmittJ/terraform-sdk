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
    public TerraformProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string>? ConnectionString
    {
        get => GetProperty<TerraformProperty<string>>("connection_string");
        set => this.WithProperty("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerName
    {
        get => GetProperty<TerraformProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? DefaultTtl
    {
        get => GetProperty<TerraformProperty<string>>("default_ttl");
        set => this.WithProperty("default_ttl", value);
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? IdentityId
    {
        get => GetProperty<TerraformProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    public TerraformProperty<string>? IothubId
    {
        get => GetProperty<TerraformProperty<string>>("iothub_id");
        set => this.WithProperty("iothub_id", value);
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public TerraformProperty<string>? LockDuration
    {
        get => GetProperty<TerraformProperty<string>>("lock_duration");
        set => this.WithProperty("lock_duration", value);
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public TerraformProperty<double>? MaxDeliveryCount
    {
        get => GetProperty<TerraformProperty<double>>("max_delivery_count");
        set => this.WithProperty("max_delivery_count", value);
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? NotificationsEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("notifications_enabled");
        set => this.WithProperty("notifications_enabled", value);
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public TerraformProperty<string>? SasTtl
    {
        get => GetProperty<TerraformProperty<string>>("sas_ttl");
        set => this.WithProperty("sas_ttl", value);
    }

}
