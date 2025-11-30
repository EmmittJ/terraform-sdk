using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for high_capacity_database_storage in AzurermOracleExascaleDatabaseStorageVault.
/// Nesting mode: list
/// </summary>
public class AzurermOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "high_capacity_database_storage";

    /// <summary>
    /// The available_size_in_gb attribute.
    /// </summary>
    public TerraformValue<double> AvailableSizeInGb
    {
        get => new TerraformReference<double>(this, "available_size_in_gb");
    }

    /// <summary>
    /// The total_size_in_gb attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TotalSizeInGb is required")]
    public required TerraformValue<double> TotalSizeInGb
    {
        get => new TerraformReference<double>(this, "total_size_in_gb");
        set => SetArgument("total_size_in_gb", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermOracleExascaleDatabaseStorageVault.
/// Nesting mode: single
/// </summary>
public class AzurermOracleExascaleDatabaseStorageVaultTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_oracle_exascale_database_storage_vault Terraform resource.
/// Manages a azurerm_oracle_exascale_database_storage_vault resource.
/// </summary>
public partial class AzurermOracleExascaleDatabaseStorageVault(string name) : TerraformResource("azurerm_oracle_exascale_database_storage_vault", name)
{
    /// <summary>
    /// The additional_flash_cache_percentage attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdditionalFlashCachePercentage is required")]
    public required TerraformValue<double> AdditionalFlashCachePercentage
    {
        get => new TerraformReference<double>(this, "additional_flash_cache_percentage");
        set => SetArgument("additional_flash_cache_percentage", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
    {
        get => new TerraformReference<string>(this, "description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DisplayName is required")]
    public required TerraformValue<string> DisplayName
    {
        get => new TerraformReference<string>(this, "display_name");
        set => SetArgument("display_name", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
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
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string>? TimeZone
    {
        get => new TerraformReference<string>(this, "time_zone");
        set => SetArgument("time_zone", value);
    }

    /// <summary>
    /// The zones attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Zones is required")]
    public required TerraformSet<string> Zones
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "zones").ResolveNodes(ctx));
        set => SetArgument("zones", value);
    }

    /// <summary>
    /// HighCapacityDatabaseStorage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HighCapacityDatabaseStorage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 HighCapacityDatabaseStorage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 HighCapacityDatabaseStorage block(s) allowed")]
    public required TerraformList<AzurermOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageBlock> HighCapacityDatabaseStorage
    {
        get => GetRequiredArgument<TerraformList<AzurermOracleExascaleDatabaseStorageVaultHighCapacityDatabaseStorageBlock>>("high_capacity_database_storage");
        set => SetArgument("high_capacity_database_storage", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleExascaleDatabaseStorageVaultTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleExascaleDatabaseStorageVaultTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
