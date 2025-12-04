using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in AzurermOracleExascaleDatabaseStorageVaultDataSource.
/// Nesting mode: single
/// </summary>
public class AzurermOracleExascaleDatabaseStorageVaultDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

}


/// <summary>
/// Represents a azurerm_oracle_exascale_database_storage_vault Terraform data source.
/// Retrieves information about a azurerm_oracle_exascale_database_storage_vault.
/// </summary>
public partial class AzurermOracleExascaleDatabaseStorageVaultDataSource(string name) : TerraformDataSource("azurerm_oracle_exascale_database_storage_vault", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The additional_flash_cache_percentage attribute.
    /// </summary>
    public TerraformValue<double> AdditionalFlashCachePercentage
        => AsReference("additional_flash_cache_percentage");

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformValue<string> Description
        => AsReference("description");

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformValue<string> DisplayName
        => AsReference("display_name");

    /// <summary>
    /// The high_capacity_database_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> HighCapacityDatabaseStorage
        => AsReference("high_capacity_database_storage");

    /// <summary>
    /// The lifecycle_details attribute.
    /// </summary>
    public TerraformValue<string> LifecycleDetails
        => AsReference("lifecycle_details");

    /// <summary>
    /// The lifecycle_state attribute.
    /// </summary>
    public TerraformValue<string> LifecycleState
        => AsReference("lifecycle_state");

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
        => AsReference("location");

    /// <summary>
    /// The oci_url attribute.
    /// </summary>
    public TerraformValue<string> OciUrl
        => AsReference("oci_url");

    /// <summary>
    /// The ocid attribute.
    /// </summary>
    public TerraformValue<string> Ocid
        => AsReference("ocid");

    /// <summary>
    /// The time_zone attribute.
    /// </summary>
    public TerraformValue<string> TimeZone
        => AsReference("time_zone");

    /// <summary>
    /// The virtual_machine_cluster_count attribute.
    /// </summary>
    public TerraformValue<double> VirtualMachineClusterCount
        => AsReference("virtual_machine_cluster_count");

    /// <summary>
    /// The zones attribute.
    /// </summary>
    public TerraformList<string> Zones
        => AsReference("zones");

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermOracleExascaleDatabaseStorageVaultDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermOracleExascaleDatabaseStorageVaultDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
