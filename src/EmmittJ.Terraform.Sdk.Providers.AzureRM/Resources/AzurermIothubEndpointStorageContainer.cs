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
    public TerraformProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The batch_frequency_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? BatchFrequencyInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("batch_frequency_in_seconds");
        set => this.WithProperty("batch_frequency_in_seconds", value);
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
    /// The encoding attribute.
    /// </summary>
    public TerraformProperty<string>? Encoding
    {
        get => GetProperty<TerraformProperty<string>>("encoding");
        set => this.WithProperty("encoding", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformProperty<string>? EndpointUri
    {
        get => GetProperty<TerraformProperty<string>>("endpoint_uri");
        set => this.WithProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The file_name_format attribute.
    /// </summary>
    public TerraformProperty<string>? FileNameFormat
    {
        get => GetProperty<TerraformProperty<string>>("file_name_format");
        set => this.WithProperty("file_name_format", value);
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
    /// The max_chunk_size_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double>? MaxChunkSizeInBytes
    {
        get => GetProperty<TerraformProperty<double>>("max_chunk_size_in_bytes");
        set => this.WithProperty("max_chunk_size_in_bytes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

}
