using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rules in AzurermStorageBlobInventoryPolicy.
/// Nesting mode: set
/// </summary>
public class AzurermStorageBlobInventoryPolicyRulesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rules";

    /// <summary>
    /// The format attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Format is required")]
    public required TerraformValue<string> Format
    {
        get => new TerraformReference<string>(this, "format");
        set => SetArgument("format", value);
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
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => new TerraformReference<string>(this, "schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The schema_fields attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaFields is required")]
    public TerraformList<string>? SchemaFields
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "schema_fields").ResolveNodes(ctx));
        set => SetArgument("schema_fields", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => new TerraformReference<string>(this, "scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    public required TerraformValue<string> StorageContainerName
    {
        get => new TerraformReference<string>(this, "storage_container_name");
        set => SetArgument("storage_container_name", value);
    }

    /// <summary>
    /// Filter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filter block(s) allowed")]
    public TerraformList<AzurermStorageBlobInventoryPolicyRulesBlockFilterBlock>? Filter
    {
        get => GetArgument<TerraformList<AzurermStorageBlobInventoryPolicyRulesBlockFilterBlock>>("filter");
        set => SetArgument("filter", value);
    }

}

/// <summary>
/// Block type for filter in AzurermStorageBlobInventoryPolicyRulesBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageBlobInventoryPolicyRulesBlockFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filter";

    /// <summary>
    /// The blob_types attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BlobTypes is required")]
    public required TerraformSet<string> BlobTypes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "blob_types").ResolveNodes(ctx));
        set => SetArgument("blob_types", value);
    }

    /// <summary>
    /// The exclude_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? ExcludePrefixes
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "exclude_prefixes").ResolveNodes(ctx));
        set => SetArgument("exclude_prefixes", value);
    }

    /// <summary>
    /// The include_blob_versions attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeBlobVersions
    {
        get => new TerraformReference<bool>(this, "include_blob_versions");
        set => SetArgument("include_blob_versions", value);
    }

    /// <summary>
    /// The include_deleted attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDeleted
    {
        get => new TerraformReference<bool>(this, "include_deleted");
        set => SetArgument("include_deleted", value);
    }

    /// <summary>
    /// The include_snapshots attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSnapshots
    {
        get => new TerraformReference<bool>(this, "include_snapshots");
        set => SetArgument("include_snapshots", value);
    }

    /// <summary>
    /// The prefix_match attribute.
    /// </summary>
    public TerraformSet<string>? PrefixMatch
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "prefix_match").ResolveNodes(ctx));
        set => SetArgument("prefix_match", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageBlobInventoryPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermStorageBlobInventoryPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_blob_inventory_policy Terraform resource.
/// Manages a azurerm_storage_blob_inventory_policy resource.
/// </summary>
public partial class AzurermStorageBlobInventoryPolicy(string name) : TerraformResource("azurerm_storage_blob_inventory_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => new TerraformReference<string>(this, "storage_account_id");
        set => SetArgument("storage_account_id", value);
    }

    /// <summary>
    /// Rules block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rules is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rules block(s) required")]
    public required TerraformSet<AzurermStorageBlobInventoryPolicyRulesBlock> Rules
    {
        get => GetRequiredArgument<TerraformSet<AzurermStorageBlobInventoryPolicyRulesBlock>>("rules");
        set => SetArgument("rules", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageBlobInventoryPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageBlobInventoryPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
