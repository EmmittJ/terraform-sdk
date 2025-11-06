using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_endpoint_storage_container resource.
/// </summary>
public class AzurermIothubEndpointStorageContainer : TerraformResource
{
    public AzurermIothubEndpointStorageContainer(string name) : base("azurerm_iothub_endpoint_storage_container", name)
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
    /// The batch_frequency_in_seconds attribute.
    /// </summary>
    public double? BatchFrequencyInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_frequency_in_seconds")?.Value;
        set => this.WithProperty("batch_frequency_in_seconds", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The encoding attribute.
    /// </summary>
    public string? Encoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding")?.Value;
        set => this.WithProperty("encoding", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public string? EndpointUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_uri")?.Value;
        set => this.WithProperty("endpoint_uri", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The file_name_format attribute.
    /// </summary>
    public string? FileNameFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_name_format")?.Value;
        set => this.WithProperty("file_name_format", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The max_chunk_size_in_bytes attribute.
    /// </summary>
    public double? MaxChunkSizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_chunk_size_in_bytes")?.Value;
        set => this.WithProperty("max_chunk_size_in_bytes", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public string? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id")?.Value;
        set => this.WithProperty("subscription_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
