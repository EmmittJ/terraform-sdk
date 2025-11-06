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
    public List<string>? Definition
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("definition")?.Value;
        set => this.WithProperty("definition", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
    }

    /// <summary>
    /// Display name for this policy
    /// </summary>
    public string? DisplayName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("display_name")?.Value;
        set => this.WithProperty("display_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

}
