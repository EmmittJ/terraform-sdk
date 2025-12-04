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
        get => GetRequiredArgument<TerraformValue<string>>("format");
        set => SetArgument("format", value);
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
    /// The schedule attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Schedule is required")]
    public required TerraformValue<string> Schedule
    {
        get => GetRequiredArgument<TerraformValue<string>>("schedule");
        set => SetArgument("schedule", value);
    }

    /// <summary>
    /// The schema_fields attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SchemaFields is required")]
    public TerraformList<string>? SchemaFields
    {
        get => GetArgument<TerraformList<string>>("schema_fields");
        set => SetArgument("schema_fields", value);
    }

    /// <summary>
    /// The scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Scope is required")]
    public required TerraformValue<string> Scope
    {
        get => GetRequiredArgument<TerraformValue<string>>("scope");
        set => SetArgument("scope", value);
    }

    /// <summary>
    /// The storage_container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageContainerName is required")]
    public required TerraformValue<string> StorageContainerName
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_container_name");
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
        get => GetRequiredArgument<TerraformSet<string>>("blob_types");
        set => SetArgument("blob_types", value);
    }

    /// <summary>
    /// The exclude_prefixes attribute.
    /// </summary>
    public TerraformSet<string>? ExcludePrefixes
    {
        get => GetArgument<TerraformSet<string>>("exclude_prefixes");
        set => SetArgument("exclude_prefixes", value);
    }

    /// <summary>
    /// The include_blob_versions attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeBlobVersions
    {
        get => GetArgument<TerraformValue<bool>>("include_blob_versions");
        set => SetArgument("include_blob_versions", value);
    }

    /// <summary>
    /// The include_deleted attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeDeleted
    {
        get => GetArgument<TerraformValue<bool>>("include_deleted");
        set => SetArgument("include_deleted", value);
    }

    /// <summary>
    /// The include_snapshots attribute.
    /// </summary>
    public TerraformValue<bool>? IncludeSnapshots
    {
        get => GetArgument<TerraformValue<bool>>("include_snapshots");
        set => SetArgument("include_snapshots", value);
    }

    /// <summary>
    /// The prefix_match attribute.
    /// </summary>
    public TerraformSet<string>? PrefixMatch
    {
        get => GetArgument<TerraformSet<string>>("prefix_match");
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
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The storage_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageAccountId is required")]
    public required TerraformValue<string> StorageAccountId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_account_id");
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
