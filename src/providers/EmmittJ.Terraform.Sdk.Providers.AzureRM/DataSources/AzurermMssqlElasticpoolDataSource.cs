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
public class AzurermMssqlElasticpoolDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_elasticpool.
/// </summary>
public class AzurermMssqlElasticpoolDataSource : TerraformDataSource
{
    public AzurermMssqlElasticpoolDataSource(string name) : base("azurerm_mssql_elasticpool", name)
    {
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The server_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerName is required")]
    [TerraformArgument("server_name")]
    public required TerraformValue<string> ServerName
    {
        get => new TerraformReference<string>(this, "server_name");
        set => SetArgument("server_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlElasticpoolDataSourceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The enclave_type attribute.
    /// </summary>
    [TerraformArgument("enclave_type")]
    public TerraformValue<string> EnclaveType
    {
        get => new TerraformReference<string>(this, "enclave_type");
    }

    /// <summary>
    /// The license_type attribute.
    /// </summary>
    [TerraformArgument("license_type")]
    public TerraformValue<string> LicenseType
    {
        get => new TerraformReference<string>(this, "license_type");
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [TerraformArgument("location")]
    public TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
    }

    /// <summary>
    /// The max_size_bytes attribute.
    /// </summary>
    [TerraformArgument("max_size_bytes")]
    public TerraformValue<double> MaxSizeBytes
    {
        get => new TerraformReference<double>(this, "max_size_bytes");
    }

    /// <summary>
    /// The max_size_gb attribute.
    /// </summary>
    [TerraformArgument("max_size_gb")]
    public TerraformValue<double> MaxSizeGb
    {
        get => new TerraformReference<double>(this, "max_size_gb");
    }

    /// <summary>
    /// The per_db_max_capacity attribute.
    /// </summary>
    [TerraformArgument("per_db_max_capacity")]
    public TerraformValue<double> PerDbMaxCapacity
    {
        get => new TerraformReference<double>(this, "per_db_max_capacity");
    }

    /// <summary>
    /// The per_db_min_capacity attribute.
    /// </summary>
    [TerraformArgument("per_db_min_capacity")]
    public TerraformValue<double> PerDbMinCapacity
    {
        get => new TerraformReference<double>(this, "per_db_min_capacity");
    }

    /// <summary>
    /// The sku attribute.
    /// </summary>
    [TerraformArgument("sku")]
    public TerraformList<object> Sku
    {
        get => TerraformList<object>.Lazy(ctx => new TerraformReference<TerraformList<object>>(this, "sku").ResolveNodes(ctx));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
    }

    /// <summary>
    /// The zone_redundant attribute.
    /// </summary>
    [TerraformArgument("zone_redundant")]
    public TerraformValue<bool> ZoneRedundant
    {
        get => new TerraformReference<bool>(this, "zone_redundant");
    }

}
