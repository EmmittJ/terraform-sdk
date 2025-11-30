using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermIothubEndpointStorageContainer.
/// Nesting mode: single
/// </summary>
public class AzurermIothubEndpointStorageContainerTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a azurerm_iothub_endpoint_storage_container Terraform resource.
/// Manages a azurerm_iothub_endpoint_storage_container resource.
/// </summary>
public partial class AzurermIothubEndpointStorageContainer(string name) : TerraformResource("azurerm_iothub_endpoint_storage_container", name)
{
    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformValue<string>? AuthenticationType
    {
        get => new TerraformReference<string>(this, "authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The batch_frequency_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? BatchFrequencyInSeconds
    {
        get => new TerraformReference<double>(this, "batch_frequency_in_seconds");
        set => SetArgument("batch_frequency_in_seconds", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionString
    {
        get => new TerraformReference<string>(this, "connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => new TerraformReference<string>(this, "container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => new TerraformReference<string>(this, "encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformValue<string>? EndpointUri
    {
        get => new TerraformReference<string>(this, "endpoint_uri");
        set => SetArgument("endpoint_uri", value);
    }

    /// <summary>
    /// The file_name_format attribute.
    /// </summary>
    public TerraformValue<string>? FileNameFormat
    {
        get => new TerraformReference<string>(this, "file_name_format");
        set => SetArgument("file_name_format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityId
    {
        get => new TerraformReference<string>(this, "identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformValue<string> IothubId
    {
        get => new TerraformReference<string>(this, "iothub_id");
        set => SetArgument("iothub_id", value);
    }

    /// <summary>
    /// The max_chunk_size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? MaxChunkSizeInBytes
    {
        get => new TerraformReference<double>(this, "max_chunk_size_in_bytes");
        set => SetArgument("max_chunk_size_in_bytes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformValue<string> SubscriptionId
    {
        get => new TerraformReference<string>(this, "subscription_id");
        set => SetArgument("subscription_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermIothubEndpointStorageContainerTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermIothubEndpointStorageContainerTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
