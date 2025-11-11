using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for read_write_endpoint_failover_policy in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock : TerraformBlockBase
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
public partial class AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock : TerraformBlockBase
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
/// Manages a azurerm_mssql_managed_instance_failover_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlManagedInstanceFailoverGroup : TerraformResource
{
    public AzurermMssqlManagedInstanceFailoverGroup(string name) : base("azurerm_mssql_managed_instance_failover_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformProperty("managed_instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ManagedInstanceId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The partner_managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PartnerManagedInstanceId is required")]
    [TerraformProperty("partner_managed_instance_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> PartnerManagedInstanceId { get; set; }

    /// <summary>
    /// The readonly_endpoint_failover_policy_enabled attribute.
    /// </summary>
    [TerraformProperty("readonly_endpoint_failover_policy_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ReadonlyEndpointFailoverPolicyEnabled { get; set; }

    /// <summary>
    /// The secondary_type attribute.
    /// </summary>
    [TerraformProperty("secondary_type")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SecondaryType { get; set; }

    /// <summary>
    /// Block for read_write_endpoint_failover_policy.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ReadWriteEndpointFailoverPolicy is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 ReadWriteEndpointFailoverPolicy block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReadWriteEndpointFailoverPolicy block(s) allowed")]
    [TerraformProperty("read_write_endpoint_failover_policy")]
    public partial TerraformList<TerraformBlock<AzurermMssqlManagedInstanceFailoverGroupReadWriteEndpointFailoverPolicyBlock>>? ReadWriteEndpointFailoverPolicy { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlManagedInstanceFailoverGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The partner_region attribute.
    /// </summary>
    [TerraformProperty("partner_region")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformList<object> PartnerRegion { get; }

    /// <summary>
    /// The role attribute.
    /// </summary>
    [TerraformProperty("role")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Role { get; }

}
