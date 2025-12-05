using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for rule in AzurermStorageManagementPolicy.
/// Nesting mode: list
/// </summary>
public class AzurermStorageManagementPolicyRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Enabled is required")]
    public required TerraformValue<bool> Enabled
    {
        get => GetRequiredArgument<TerraformValue<bool>>("enabled");
        set => SetArgument("enabled", value);
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
    /// Actions block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Actions is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Actions block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Actions block(s) allowed")]
    public required TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlock> Actions
    {
        get => GetRequiredArgument<TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlock>>("actions");
        set => SetArgument("actions", value);
    }

    /// <summary>
    /// Filters block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filters is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Filters block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Filters block(s) allowed")]
    public required TerraformList<AzurermStorageManagementPolicyRuleBlockFiltersBlock> Filters
    {
        get => GetRequiredArgument<TerraformList<AzurermStorageManagementPolicyRuleBlockFiltersBlock>>("filters");
        set => SetArgument("filters", value);
    }

}

/// <summary>
/// Block type for actions in AzurermStorageManagementPolicyRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageManagementPolicyRuleBlockActionsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "actions";

    /// <summary>
    /// BaseBlob block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BaseBlob block(s) allowed")]
    public TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlockBaseBlobBlock>? BaseBlob
    {
        get => GetArgument<TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlockBaseBlobBlock>>("base_blob");
        set => SetArgument("base_blob", value);
    }

    /// <summary>
    /// Snapshot block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Snapshot block(s) allowed")]
    public TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlockSnapshotBlock>? Snapshot
    {
        get => GetArgument<TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlockSnapshotBlock>>("snapshot");
        set => SetArgument("snapshot", value);
    }

    /// <summary>
    /// Version block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Version block(s) allowed")]
    public TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlockVersionBlock>? Version
    {
        get => GetArgument<TerraformList<AzurermStorageManagementPolicyRuleBlockActionsBlockVersionBlock>>("version");
        set => SetArgument("version", value);
    }

}

/// <summary>
/// Block type for base_blob in AzurermStorageManagementPolicyRuleBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageManagementPolicyRuleBlockActionsBlockBaseBlobBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "base_blob";

    /// <summary>
    /// The auto_tier_to_hot_from_cool_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? AutoTierToHotFromCoolEnabled
    {
        get => GetArgument<TerraformValue<bool>>("auto_tier_to_hot_from_cool_enabled");
        set => SetArgument("auto_tier_to_hot_from_cool_enabled", value);
    }

    /// <summary>
    /// The delete_after_days_since_creation_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? DeleteAfterDaysSinceCreationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("delete_after_days_since_creation_greater_than");
        set => SetArgument("delete_after_days_since_creation_greater_than", value);
    }

    /// <summary>
    /// The delete_after_days_since_last_access_time_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? DeleteAfterDaysSinceLastAccessTimeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("delete_after_days_since_last_access_time_greater_than");
        set => SetArgument("delete_after_days_since_last_access_time_greater_than", value);
    }

    /// <summary>
    /// The delete_after_days_since_modification_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? DeleteAfterDaysSinceModificationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("delete_after_days_since_modification_greater_than");
        set => SetArgument("delete_after_days_since_modification_greater_than", value);
    }

    /// <summary>
    /// The tier_to_archive_after_days_since_creation_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToArchiveAfterDaysSinceCreationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_archive_after_days_since_creation_greater_than");
        set => SetArgument("tier_to_archive_after_days_since_creation_greater_than", value);
    }

    /// <summary>
    /// The tier_to_archive_after_days_since_last_access_time_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToArchiveAfterDaysSinceLastAccessTimeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_archive_after_days_since_last_access_time_greater_than");
        set => SetArgument("tier_to_archive_after_days_since_last_access_time_greater_than", value);
    }

    /// <summary>
    /// The tier_to_archive_after_days_since_last_tier_change_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_archive_after_days_since_last_tier_change_greater_than");
        set => SetArgument("tier_to_archive_after_days_since_last_tier_change_greater_than", value);
    }

    /// <summary>
    /// The tier_to_archive_after_days_since_modification_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToArchiveAfterDaysSinceModificationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_archive_after_days_since_modification_greater_than");
        set => SetArgument("tier_to_archive_after_days_since_modification_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cold_after_days_since_creation_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToColdAfterDaysSinceCreationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cold_after_days_since_creation_greater_than");
        set => SetArgument("tier_to_cold_after_days_since_creation_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cold_after_days_since_last_access_time_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToColdAfterDaysSinceLastAccessTimeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cold_after_days_since_last_access_time_greater_than");
        set => SetArgument("tier_to_cold_after_days_since_last_access_time_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cold_after_days_since_modification_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToColdAfterDaysSinceModificationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cold_after_days_since_modification_greater_than");
        set => SetArgument("tier_to_cold_after_days_since_modification_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cool_after_days_since_creation_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToCoolAfterDaysSinceCreationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cool_after_days_since_creation_greater_than");
        set => SetArgument("tier_to_cool_after_days_since_creation_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cool_after_days_since_last_access_time_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToCoolAfterDaysSinceLastAccessTimeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cool_after_days_since_last_access_time_greater_than");
        set => SetArgument("tier_to_cool_after_days_since_last_access_time_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cool_after_days_since_modification_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToCoolAfterDaysSinceModificationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cool_after_days_since_modification_greater_than");
        set => SetArgument("tier_to_cool_after_days_since_modification_greater_than", value);
    }

}

/// <summary>
/// Block type for snapshot in AzurermStorageManagementPolicyRuleBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageManagementPolicyRuleBlockActionsBlockSnapshotBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "snapshot";

    /// <summary>
    /// The change_tier_to_archive_after_days_since_creation attribute.
    /// </summary>
    public TerraformValue<double>? ChangeTierToArchiveAfterDaysSinceCreation
    {
        get => GetArgument<TerraformValue<double>>("change_tier_to_archive_after_days_since_creation");
        set => SetArgument("change_tier_to_archive_after_days_since_creation", value);
    }

    /// <summary>
    /// The change_tier_to_cool_after_days_since_creation attribute.
    /// </summary>
    public TerraformValue<double>? ChangeTierToCoolAfterDaysSinceCreation
    {
        get => GetArgument<TerraformValue<double>>("change_tier_to_cool_after_days_since_creation");
        set => SetArgument("change_tier_to_cool_after_days_since_creation", value);
    }

    /// <summary>
    /// The delete_after_days_since_creation_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? DeleteAfterDaysSinceCreationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("delete_after_days_since_creation_greater_than");
        set => SetArgument("delete_after_days_since_creation_greater_than", value);
    }

    /// <summary>
    /// The tier_to_archive_after_days_since_last_tier_change_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_archive_after_days_since_last_tier_change_greater_than");
        set => SetArgument("tier_to_archive_after_days_since_last_tier_change_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cold_after_days_since_creation_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToColdAfterDaysSinceCreationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cold_after_days_since_creation_greater_than");
        set => SetArgument("tier_to_cold_after_days_since_creation_greater_than", value);
    }

}

/// <summary>
/// Block type for version in AzurermStorageManagementPolicyRuleBlockActionsBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageManagementPolicyRuleBlockActionsBlockVersionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "version";

    /// <summary>
    /// The change_tier_to_archive_after_days_since_creation attribute.
    /// </summary>
    public TerraformValue<double>? ChangeTierToArchiveAfterDaysSinceCreation
    {
        get => GetArgument<TerraformValue<double>>("change_tier_to_archive_after_days_since_creation");
        set => SetArgument("change_tier_to_archive_after_days_since_creation", value);
    }

    /// <summary>
    /// The change_tier_to_cool_after_days_since_creation attribute.
    /// </summary>
    public TerraformValue<double>? ChangeTierToCoolAfterDaysSinceCreation
    {
        get => GetArgument<TerraformValue<double>>("change_tier_to_cool_after_days_since_creation");
        set => SetArgument("change_tier_to_cool_after_days_since_creation", value);
    }

    /// <summary>
    /// The delete_after_days_since_creation attribute.
    /// </summary>
    public TerraformValue<double>? DeleteAfterDaysSinceCreation
    {
        get => GetArgument<TerraformValue<double>>("delete_after_days_since_creation");
        set => SetArgument("delete_after_days_since_creation", value);
    }

    /// <summary>
    /// The tier_to_archive_after_days_since_last_tier_change_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToArchiveAfterDaysSinceLastTierChangeGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_archive_after_days_since_last_tier_change_greater_than");
        set => SetArgument("tier_to_archive_after_days_since_last_tier_change_greater_than", value);
    }

    /// <summary>
    /// The tier_to_cold_after_days_since_creation_greater_than attribute.
    /// </summary>
    public TerraformValue<double>? TierToColdAfterDaysSinceCreationGreaterThan
    {
        get => GetArgument<TerraformValue<double>>("tier_to_cold_after_days_since_creation_greater_than");
        set => SetArgument("tier_to_cold_after_days_since_creation_greater_than", value);
    }

}

/// <summary>
/// Block type for filters in AzurermStorageManagementPolicyRuleBlock.
/// Nesting mode: list
/// </summary>
public class AzurermStorageManagementPolicyRuleBlockFiltersBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "filters";

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
    /// The prefix_match attribute.
    /// </summary>
    public TerraformSet<string>? PrefixMatch
    {
        get => GetArgument<TerraformSet<string>>("prefix_match");
        set => SetArgument("prefix_match", value);
    }

    /// <summary>
    /// MatchBlobIndexTag block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermStorageManagementPolicyRuleBlockFiltersBlockMatchBlobIndexTagBlock>? MatchBlobIndexTag
    {
        get => GetArgument<TerraformSet<AzurermStorageManagementPolicyRuleBlockFiltersBlockMatchBlobIndexTagBlock>>("match_blob_index_tag");
        set => SetArgument("match_blob_index_tag", value);
    }

}

/// <summary>
/// Block type for match_blob_index_tag in AzurermStorageManagementPolicyRuleBlockFiltersBlock.
/// Nesting mode: set
/// </summary>
public class AzurermStorageManagementPolicyRuleBlockFiltersBlockMatchBlobIndexTagBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "match_blob_index_tag";

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
    /// The operation attribute.
    /// </summary>
    public TerraformValue<string>? Operation
    {
        get => GetArgument<TerraformValue<string>>("operation");
        set => SetArgument("operation", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermStorageManagementPolicy.
/// Nesting mode: single
/// </summary>
public class AzurermStorageManagementPolicyTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_storage_management_policy Terraform resource.
/// Manages a azurerm_storage_management_policy resource.
/// </summary>
public partial class AzurermStorageManagementPolicy(string name) : TerraformResource("azurerm_storage_management_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
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
    /// Rule block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermStorageManagementPolicyRuleBlock>? Rule
    {
        get => GetArgument<TerraformList<AzurermStorageManagementPolicyRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermStorageManagementPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermStorageManagementPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
