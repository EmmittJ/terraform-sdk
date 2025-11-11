using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for parameter in .
/// Nesting mode: list
/// </summary>
public partial class AzureadSynchronizationJobProvisionOnDemandParameterBlock : TerraformBlockBase
{
    /// <summary>
    /// The identifier of the synchronization rule to be applied. This rule ID is defined in the schema for a given synchronization job or template.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RuleId is required")]
    [TerraformProperty("rule_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RuleId { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadSynchronizationJobProvisionOnDemandTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

}

/// <summary>
/// Manages a azuread_synchronization_job_provision_on_demand resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzureadSynchronizationJobProvisionOnDemand : TerraformResource
{
    public AzureadSynchronizationJobProvisionOnDemand(string name) : base("azuread_synchronization_job_provision_on_demand", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The object ID of the service principal for which this synchronization job should be provisioned
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformProperty("service_principal_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ServicePrincipalId { get; set; }

    /// <summary>
    /// The identifier for the synchronization jop.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SynchronizationJobId is required")]
    [TerraformProperty("synchronization_job_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> SynchronizationJobId { get; set; }

    /// <summary>
    /// The triggers attribute.
    /// </summary>
    [TerraformProperty("triggers")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Triggers { get; set; }

    /// <summary>
    /// Block for parameter.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Parameter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Parameter block(s) required")]
    [TerraformProperty("parameter")]
    public TerraformList<TerraformBlock<AzureadSynchronizationJobProvisionOnDemandParameterBlock>>? Parameter { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzureadSynchronizationJobProvisionOnDemandTimeoutsBlock>? Timeouts { get; set; }

}
