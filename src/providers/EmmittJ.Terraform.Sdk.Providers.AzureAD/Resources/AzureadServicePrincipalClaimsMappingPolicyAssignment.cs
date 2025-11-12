using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock() : TerraformBlock("timeouts")
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

}

/// <summary>
/// Manages a azuread_service_principal_claims_mapping_policy_assignment resource.
/// </summary>
public partial class AzureadServicePrincipalClaimsMappingPolicyAssignment : TerraformResource
{
    public AzureadServicePrincipalClaimsMappingPolicyAssignment(string name) : base("azuread_service_principal_claims_mapping_policy_assignment", name)
    {
    }

    /// <summary>
    /// ID of the claims mapping policy to assign
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimsMappingPolicyId is required")]
    [TerraformProperty("claims_mapping_policy_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClaimsMappingPolicyId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// ID of the service principal for which to assign the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    [TerraformProperty("service_principal_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ServicePrincipalId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock Timeouts { get; set; } = new();

}
