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
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
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
        get => GetArgument<TerraformValue<string>>("authentication_type");
        set => SetArgument("authentication_type", value);
    }

    /// <summary>
    /// The batch_frequency_in_seconds attribute.
    /// </summary>
    public TerraformValue<double>? BatchFrequencyInSeconds
    {
        get => GetArgument<TerraformValue<double>>("batch_frequency_in_seconds");
        set => SetArgument("batch_frequency_in_seconds", value);
    }

    /// <summary>
    /// The connection_string attribute.
    /// </summary>
    public TerraformValue<string>? ConnectionString
    {
        get => GetArgument<TerraformValue<string>>("connection_string");
        set => SetArgument("connection_string", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformValue<string> ContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("container_name");
        set => SetArgument("container_name", value);
    }

    /// <summary>
    /// The encoding attribute.
    /// </summary>
    public TerraformValue<string>? Encoding
    {
        get => GetArgument<TerraformValue<string>>("encoding");
        set => SetArgument("encoding", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformValue<string>? EndpointUri
    {
        get => GetArgument<TerraformValue<string>>("endpoint_uri");
        set => SetArgument("endpoint_uri", value);
    }

    /// <summary>
    /// The file_name_format attribute.
    /// </summary>
    public TerraformValue<string>? FileNameFormat
    {
        get => GetArgument<TerraformValue<string>>("file_name_format");
        set => SetArgument("file_name_format", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformValue<string>? IdentityId
    {
        get => GetArgument<TerraformValue<string>>("identity_id");
        set => SetArgument("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformValue<string> IothubId
    {
        get => GetRequiredArgument<TerraformValue<string>>("iothub_id");
        set => SetArgument("iothub_id", value);
    }

    /// <summary>
    /// The max_chunk_size_in_bytes attribute.
    /// </summary>
    public TerraformValue<double>? MaxChunkSizeInBytes
    {
        get => GetArgument<TerraformValue<double>>("max_chunk_size_in_bytes");
        set => SetArgument("max_chunk_size_in_bytes", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformValue<string> SubscriptionId
    {
        get => GetArgument<TerraformValue<string>>("subscription_id") ?? AsReference("subscription_id");
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
