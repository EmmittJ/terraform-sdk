using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Manages a azuread_service_principal_claims_mapping_policy_assignment resource.
/// </summary>
public class AzureadServicePrincipalClaimsMappingPolicyAssignment : TerraformResource
{
    public AzureadServicePrincipalClaimsMappingPolicyAssignment(string name) : base("azuread_service_principal_claims_mapping_policy_assignment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("claims_mapping_policy_id");
        SetOutput("id");
        SetOutput("service_principal_id");
    }

    /// <summary>
    /// ID of the claims mapping policy to assign
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimsMappingPolicyId is required")]
    public required TerraformProperty<string> ClaimsMappingPolicyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("claims_mapping_policy_id");
        set => SetProperty("claims_mapping_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// ID of the service principal for which to assign the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("service_principal_id");
        set => SetProperty("service_principal_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
