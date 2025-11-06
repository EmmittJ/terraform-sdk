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
    public string? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type")?.Value;
        set => this.WithProperty("authentication_type", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public string? ConnectionString
    {
        get => GetProperty<TerraformLiteralProperty<string>>("connection_string")?.Value;
        set => this.WithProperty("connection_string", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public string? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name")?.Value;
        set => this.WithProperty("container_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The default_ttl attribute.
    /// </summary>
    public string? DefaultTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("default_ttl")?.Value;
        set => this.WithProperty("default_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The identity_id attribute.
    /// </summary>
    public string? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id")?.Value;
        set => this.WithProperty("identity_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    public string? IothubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_id")?.Value;
        set => this.WithProperty("iothub_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The lock_duration attribute.
    /// </summary>
    public string? LockDuration
    {
        get => GetProperty<TerraformLiteralProperty<string>>("lock_duration")?.Value;
        set => this.WithProperty("lock_duration", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The max_delivery_count attribute.
    /// </summary>
    public double? MaxDeliveryCount
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_delivery_count")?.Value;
        set => this.WithProperty("max_delivery_count", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The notifications_enabled attribute.
    /// </summary>
    public bool? NotificationsEnabled
    {
        get => GetProperty<TerraformLiteralProperty<bool>>("notifications_enabled")?.Value;
        set => this.WithProperty("notifications_enabled", value == null ? null : new TerraformLiteralProperty<bool>(value.Value));
    }

    /// <summary>
    /// The sas_ttl attribute.
    /// </summary>
    public string? SasTtl
    {
        get => GetProperty<TerraformLiteralProperty<string>>("sas_ttl")?.Value;
        set => this.WithProperty("sas_ttl", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
