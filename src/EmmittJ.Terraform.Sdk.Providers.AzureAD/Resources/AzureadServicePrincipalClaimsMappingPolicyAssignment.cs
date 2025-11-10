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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
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
    }

    /// <summary>
    /// ID of the claims mapping policy to assign
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClaimsMappingPolicyId is required")]
    public required TerraformProperty<string> ClaimsMappingPolicyId
    {
        get => GetProperty<TerraformProperty<string>>("claims_mapping_policy_id");
        set => this.WithProperty("claims_mapping_policy_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// ID of the service principal for which to assign the policy
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ServicePrincipalId is required")]
    public required TerraformProperty<string> ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzureadServicePrincipalClaimsMappingPolicyAssignmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
