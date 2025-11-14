using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMachineLearningDatastoreFileshareTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Manages a azurerm_machine_learning_datastore_fileshare resource.
/// </summary>
public class AzurermMachineLearningDatastoreFileshare : TerraformResource
{
    public AzurermMachineLearningDatastoreFileshare(string name) : base("azurerm_machine_learning_datastore_fileshare", name)
    {
    }

    /// <summary>
    /// The account_key attribute.
    /// </summary>
    [TerraformArgument("account_key")]
    public TerraformValue<string>? AccountKey
    {
        get => new TerraformReference<string>(this, "account_key");
        set => SetArgument("account_key", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformArgument("description")]
    public TerraformValue<string>? Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The service_data_identity attribute.
    /// </summary>
    [TerraformArgument("service_data_identity")]
    public TerraformValue<string>? ServiceDataIdentity
    {
        get => new TerraformReference<string>(this, "service_data_identity");
        set => SetArgument("service_data_identity", value);
    }

    /// <summary>
    /// The shared_access_signature attribute.
    /// </summary>
    [TerraformArgument("shared_access_signature")]
    public TerraformValue<string>? SharedAccessSignature
    {
        get => new TerraformReference<string>(this, "shared_access_signature");
        set => SetArgument("shared_access_signature", value);
    }

    /// <summary>
    /// The storage_fileshare_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageFileshareId is required")]
    [TerraformArgument("storage_fileshare_id")]
    public required TerraformValue<string> StorageFileshareId
    {
        get => new TerraformReference<string>(this, "storage_fileshare_id");
        set => SetArgument("storage_fileshare_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The workspace_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WorkspaceId is required")]
    [TerraformArgument("workspace_id")]
    public required TerraformValue<string> WorkspaceId
    {
        get => new TerraformReference<string>(this, "workspace_id");
        set => SetArgument("workspace_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMachineLearningDatastoreFileshareTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The is_default attribute.
    /// </summary>
    [TerraformArgument("is_default")]
    public TerraformValue<bool> IsDefault
    {
        get => new TerraformReference<bool>(this, "is_default");
    }

}
