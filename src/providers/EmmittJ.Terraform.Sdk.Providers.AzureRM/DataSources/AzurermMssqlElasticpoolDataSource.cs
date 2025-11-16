using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlElasticpoolDataSourceTimeoutsBlock : TerraformBlock
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
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_mssql_elasticpool Terraform data source.
/// Retrieves information about a azurerm_mssql_elasticpool.
/// </summary>
public partial class AzurermMssqlElasticpoolDataSource(string name) : TerraformDataSource("azurerm_mssql_elasticpool", name)
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
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    public required TerraformValue<string> ServerName
    {
        get => new TerraformReference<string>(this, "server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    public TerraformValue<string> EnclaveType
    {
        get => new TerraformReference<string>(this, "enclave_type");
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeBytes
    {
        get => new TerraformReference<double>(this, "max_size_bytes");
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    public TerraformValue<double> MaxSizeGb
    {
        get => new TerraformReference<double>(this, "max_size_gb");
    }

    /// <summary>
    /// The per_db_max_capacity attribute.
    /// </summary>
    public TerraformValue<double> PerDbMaxCapacity
    {
        get => new TerraformReference<double>(this, "per_db_max_capacity");
    }

    /// <summary>
    /// The per_db_min_capacity attribute.
    /// </summary>
    public TerraformValue<double> PerDbMinCapacity
    {
        get => new TerraformReference<double>(this, "per_db_min_capacity");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Sku
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlElasticpoolDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlElasticpoolDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
