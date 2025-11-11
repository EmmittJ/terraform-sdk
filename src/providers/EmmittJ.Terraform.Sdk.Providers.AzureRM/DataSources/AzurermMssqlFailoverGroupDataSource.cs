using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlFailoverGroupDataSourceTimeoutsBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformPropertyName("server_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlFailoverGroupDataSourceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    [TerraformPropertyName("databases")]
    // Output-only attribute - read-only reference
    public TerraformSet<string> Databases => new TerraformReference(this, "databases");

    /// <summary>
    /// The partner_server attribute.
    /// </summary>
    [TerraformPropertyName("partner_server")]
    // Output-only attribute - read-only reference
    public TerraformList<object> PartnerServer => new TerraformReference(this, "partner_server");

    /// <summary>
    /// The read_write_endpoint_failover_policy attribute.
    /// </summary>
    [TerraformPropertyName("read_write_endpoint_failover_policy")]
    // Output-only attribute - read-only reference
    public TerraformList<object> ReadWriteEndpointFailoverPolicy => new TerraformReference(this, "read_write_endpoint_failover_policy");

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    [TerraformPropertyName("readonly_endpoint_failover_policy_enabled")]
    // Output-only attribute - read-only reference
    public TerraformValue<bool> ReadonlyEndpointFailoverPolicyEnabled => new TerraformReference(this, "readonly_endpoint_failover_policy_enabled");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> Tags => new TerraformReference(this, "tags");

}
