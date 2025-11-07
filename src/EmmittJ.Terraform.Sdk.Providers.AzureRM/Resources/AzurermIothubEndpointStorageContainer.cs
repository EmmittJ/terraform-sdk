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
    public TerraformLiteralProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The batch_frequency_in_seconds attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? BatchFrequencyInSeconds
    {
        get => GetProperty<TerraformLiteralProperty<double>>("batch_frequency_in_seconds");
        set => this.WithProperty("batch_frequency_in_seconds", value);
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
    /// The encoding attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Encoding
    {
        get => GetProperty<TerraformLiteralProperty<string>>("encoding");
        set => this.WithProperty("encoding", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_uri");
        set => this.WithProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The file_name_format attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? FileNameFormat
    {
        get => GetProperty<TerraformLiteralProperty<string>>("file_name_format");
        set => this.WithProperty("file_name_format", value);
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
    /// The max_chunk_size_in_bytes attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? MaxChunkSizeInBytes
    {
        get => GetProperty<TerraformLiteralProperty<double>>("max_chunk_size_in_bytes");
        set => this.WithProperty("max_chunk_size_in_bytes", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

}
