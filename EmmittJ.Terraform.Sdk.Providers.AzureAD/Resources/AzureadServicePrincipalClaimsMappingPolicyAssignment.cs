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
    public string? ClaimsMappingPolicyId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("claims_mapping_policy_id")?.Value;
        set => this.WithProperty("claims_mapping_policy_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// ID of the service principal for which to assign the policy
    /// </summary>
    public string? ServicePrincipalId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("service_principal_id")?.Value;
        set => this.WithProperty("service_principal_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
