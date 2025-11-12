using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for partner_server in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlFailoverGroupPartnerServerBlock() : TerraformBlock("partner_server")
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Id is required")]
    [TerraformProperty("id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Id { get; set; }



}

/// <summary>
/// Block type for read_write_endpoint_failover_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlFailoverGroupReadWriteEndpointFailoverPolicyBlock() : TerraformBlock("read_write_endpoint_failover_policy")
{
    /// <summary>
    /// The grace_minutes attribute.
    /// </summary>
    [TerraformProperty("grace_minutes")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? GraceMinutes { get; set; }

    /// <summary>
    /// The mode attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Mode is required")]
    [TerraformProperty("mode")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Mode { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlFailoverGroupTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_failover_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlFailoverGroup : TerraformResource
{
    public AzurermMssqlFailoverGroup(string name) : base("azurerm_mssql_failover_group", name)
    {
    }

    /// <summary>
    /// The databases attribute.
    /// </summary>
    [TerraformProperty("databases")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? Databases { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("readonly_endpoint_failover_policy_enabled")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<bool> ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>
    /// The server_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServerId is required")]
    [TerraformProperty("server_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServerId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for partner_server.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerServer is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PartnerServer block(s) required")]
    [TerraformProperty("partner_server")]
    public required TerraformList<AzurermMssqlFailoverGroupPartnerServerBlock> PartnerServer { get; set; } = new();

    /// <summary>
    /// Block for read_write_endpoint_failover_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadWriteEndpointFailoverPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadWriteEndpointFailoverPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadWriteEndpointFailoverPolicy block(s) allowed")]
    [TerraformProperty("read_write_endpoint_failover_policy")]
    public required TerraformList<AzurermMssqlFailoverGroupReadWriteEndpointFailoverPolicyBlock> ReadWriteEndpointFailoverPolicy { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermMssqlFailoverGroupTimeoutsBlock Timeouts { get; set; } = new();

}
