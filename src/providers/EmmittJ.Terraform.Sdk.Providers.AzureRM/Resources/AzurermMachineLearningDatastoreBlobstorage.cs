using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningDatastoreBlobstorageTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_machine_learning_datastore_blobstorage Terraform resource.
/// Manages a azurerm_machine_learning_datastore_blobstorage resource.
/// </summary>
public partial class AzurermMachineLearningDatastoreBlobstorage(string name) : TerraformResource("azurerm_machine_learning_datastore_blobstorage", name)
{
    /// <summary>
    /// The account_key attribute.
    /// </summary>
    public TerraformValue<string>? AccountKey
    {
        get => new TerraformReference<string>(this, "account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
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
    /// The is_default attribute.
    /// </summary>
    public TerraformValue<bool>? IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
        set => SetArgument("is_default", value);
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
    /// The service_data_auth_identity attribute.
    /// </summary>
    public TerraformValue<string>? ServiceDataAuthIdentity
    {
        get => new TerraformReference<string>(this, "service_data_auth_identity");
        set => SetArgument("service_data_auth_identity", value);
    }

    /// <summary>
    /// The shared_access_signature attribute.
    /// </summary>
    public TerraformValue<string>? SharedAccessSignature
    {
        get => new TerraformReference<string>(this, "shared_access_signature");
        set => SetArgument("shared_access_signature", value);
    }

    /// <summary>
    /// The storage_container_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerId is required")]
    public required TerraformValue<string> StorageContainerId
    {
        get => new TerraformReference<string>(this, "storage_container_id");
        set => SetArgument("storage_container_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMachineLearningDatastoreBlobstorageTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMachineLearningDatastoreBlobstorageTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
