using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_claims_mapping_policy resource.
/// </summary>
public class AzureadClaimsMappingPolicy : TerraformResource
{
    public AzureadClaimsMappingPolicy(string name) : base("azuread_claims_mapping_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// A string collection containing a JSON string that defines the rules and settings for this policy
    /// </summary>
    public TerraformLiteralProperty<List<string>>? Definition
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("definition");
        set => this.WithProperty("definition", value);
    }

    /// <summary>
    /// Display name for this policy
    /// </summary>
    public TerraformLiteralProperty<string>? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
