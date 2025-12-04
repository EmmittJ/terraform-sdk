using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azuread;

/// <summary>
/// Block type for timeouts in AzureadServicePrincipalClaimsMappingPolicyAssignment.
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock : TerraformBlock
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

}


/// <summary>
/// Represents a azuread_service_principal_claims_mapping_policy_assignment Terraform resource.
/// Manages a azuread_service_principal_claims_mapping_policy_assignment resource.
/// </summary>
public partial class AzureadServicePrincipalClaimsMappingPolicyAssignment(string name) : TerraformResource("azuread_service_principal_claims_mapping_policy_assignment", name)
{
    /// <summary>
    /// ID of the claims mapping policy to assign
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimsMappingPolicyId is required")]
    public required TerraformValue<string> ClaimsMappingPolicyId
    {
        get => GetRequiredArgument<TerraformValue<string>>("claims_mapping_policy_id");
        set => SetArgument("claims_mapping_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// ID of the service principal for which to assign the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformValue<string> ServicePrincipalId
    {
        get => GetRequiredArgument<TerraformValue<string>>("service_principal_id");
        set => SetArgument("service_principal_id", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
