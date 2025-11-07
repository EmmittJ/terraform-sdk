using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

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
    public TerraformProperty<string>? ClaimsMappingPolicyId
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
    public TerraformProperty<string>? ServicePrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("service_principal_id");
        set => this.WithProperty("service_principal_id", value);
    }

}
