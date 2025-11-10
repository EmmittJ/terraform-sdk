using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlFailoverGroupDataSourceTimeoutsBlock : ITerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Read { get; set; }

}

/// <summary>
/// Retrieves information about a azurerm_mssql_failover_group.
/// </summary>
public class AzurermMssqlFailoverGroupDataSource : TerraformDataSource
{
    public AzurermMssqlFailoverGroupDataSource(string name) : base("azurerm_mssql_failover_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> ServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlFailoverGroupDataSourceTimeoutsBlock>? Timeouts { get; set; } = new();

    /// <summary>
    /// The databases attribute.
    /// </summary>
    [TerraformPropertyName("databases")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<string>>> Databases => new TerraformReferenceProperty<HashSet<TerraformProperty<string>>>(ResourceAddress, "databases");

    /// <summary>
    /// The partner_server attribute.
    /// </summary>
    [TerraformPropertyName("partner_server")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> PartnerServer => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "partner_server");

    /// <summary>
    /// The read_write_endpoint_failover_policy attribute.
    /// </summary>
    [TerraformPropertyName("read_write_endpoint_failover_policy")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> ReadWriteEndpointFailoverPolicy => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "read_write_endpoint_failover_policy");

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("readonly_endpoint_failover_policy_enabled")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<bool>> ReadonlyEndpointFailoverPolicyEnabled => new TerraformReferenceProperty<TerraformProperty<bool>>(ResourceAddress, "readonly_endpoint_failover_policy_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> Tags => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags");

}
