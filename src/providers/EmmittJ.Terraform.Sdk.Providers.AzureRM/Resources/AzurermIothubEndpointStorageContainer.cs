using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubEndpointStorageContainerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("authentication_type");
        SetOutput("batch_frequency_in_seconds");
        SetOutput("connection_string");
        SetOutput("container_name");
        SetOutput("encoding");
        SetOutput("endpoint_uri");
        SetOutput("file_name_format");
        SetOutput("id");
        SetOutput("identity_id");
        SetOutput("iothub_id");
        SetOutput("max_chunk_size_in_bytes");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("subscription_id");
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The batch_frequency_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> BatchFrequencyInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("batch_frequency_in_seconds");
        set => SetProperty("batch_frequency_in_seconds", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformProperty<string> ConnectionString
    {
        get => GetRequiredOutput<TerraformProperty<string>>("connection_string");
        set => SetProperty("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_name");
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformProperty<string> Encoding
    {
        get => GetRequiredOutput<TerraformProperty<string>>("encoding");
        set => SetProperty("encoding", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformProperty<string> EndpointUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_uri");
        set => SetProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The file_name_format attribute.
    /// </summary>
    public TerraformProperty<string> FileNameFormat
    {
        get => GetRequiredOutput<TerraformProperty<string>>("file_name_format");
        set => SetProperty("file_name_format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string> IdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_id");
        set => SetProperty("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformProperty<string> IothubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iothub_id");
        set => SetProperty("iothub_id", value);
    }

    /// <summary>
    /// The max_chunk_size_in_bytes attribute.
    /// </summary>
    public TerraformProperty<double> MaxChunkSizeInBytes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_chunk_size_in_bytes");
        set => SetProperty("max_chunk_size_in_bytes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubEndpointStorageContainerTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
