using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for per_database_settings in AzurermMssqlElasticpool.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlElasticpoolPerDatabaseSettingsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "per_database_settings";

    /// <summary>
    /// The max_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MaxCapacity is required")]
    public required TerraformValue<double> MaxCapacity
    {
        get => GetArgument<TerraformValue<double>>("max_capacity");
        set => SetArgument("max_capacity", value);
    }

    /// <summary>
    /// The min_capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "MinCapacity is required")]
    public required TerraformValue<double> MinCapacity
    {
        get => GetArgument<TerraformValue<double>>("min_capacity");
        set => SetArgument("min_capacity", value);
    }

}


/// <summary>
/// Block type for sku in AzurermMssqlElasticpool.
/// Nesting mode: list
/// </summary>
public class AzurermMssqlElasticpoolSkuBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "sku";

    /// <summary>
    /// The capacity attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Capacity is required")]
    public required TerraformValue<double> Capacity
    {
        get => GetArgument<TerraformValue<double>>("capacity");
        set => SetArgument("capacity", value);
    }

    /// <summary>
    /// The family attribute.
    /// </summary>
    public TerraformValue<string>? Family
    {
        get => GetArgument<TerraformValue<string>>("family");
        set => SetArgument("family", value);
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
    /// The tier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermMssqlElasticpool.
/// Nesting mode: single
/// </summary>
public class AzurermMssqlElasticpoolTimeoutsBlock : TerraformBlock
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
/// Represents a azurerm_mssql_elasticpool Terraform resource.
/// Manages a azurerm_mssql_elasticpool resource.
/// </summary>
public partial class AzurermMssqlElasticpool(string name) : TerraformResource("azurerm_mssql_elasticpool", name)
{
    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformValue<string>? EnclaveType
    {
        get => GetArgument<TerraformValue<string>>("enclave_type");
        set => SetArgument("enclave_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string>? Id
    {
        get => GetArgument<TerraformValue<string>>("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string>? LicenseType
    {
        get => GetArgument<TerraformValue<string>>("license_type");
        set => SetArgument("license_type", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The maintenance_configuration_name attribute.
    /// </summary>
    public TerraformValue<string>? MaintenanceConfigurationName
    {
        get => GetArgument<TerraformValue<string>>("maintenance_configuration_name");
        set => SetArgument("maintenance_configuration_name", value);
    }

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    public TerraformValue<double>? MaxSizeBytes
    {
        get => GetArgument<TerraformValue<double>>("max_size_bytes");
        set => SetArgument("max_size_bytes", value);
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformValue<double>? MaxSizeGb
    {
        get => GetArgument<TerraformValue<double>>("max_size_gb");
        set => SetArgument("max_size_gb", value);
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
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformValue<string> ServerName
    {
        get => GetArgument<TerraformValue<string>>("server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool>? ZoneRedundant
    {
        get => GetArgument<TerraformValue<bool>>("zone_redundant");
        set => SetArgument("zone_redundant", value);
    }

    /// <summary>
    /// PerDatabaseSettings block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PerDatabaseSettings is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PerDatabaseSettings block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PerDatabaseSettings block(s) allowed")]
    public required TerraformList<AzurermMssqlElasticpoolPerDatabaseSettingsBlock> PerDatabaseSettings
    {
        get => GetRequiredArgument<TerraformList<AzurermMssqlElasticpoolPerDatabaseSettingsBlock>>("per_database_settings");
        set => SetArgument("per_database_settings", value);
    }

    /// <summary>
    /// Sku block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Sku is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Sku block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Sku block(s) allowed")]
    public required TerraformList<AzurermMssqlElasticpoolSkuBlock> Sku
    {
        get => GetRequiredArgument<TerraformList<AzurermMssqlElasticpoolSkuBlock>>("sku");
        set => SetArgument("sku", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlElasticpoolTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlElasticpoolTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
