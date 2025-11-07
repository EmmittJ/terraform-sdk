using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureAD;

/// <summary>
/// Manages a azuread_authentication_strength_policy resource.
/// </summary>
public class AzureadAuthenticationStrengthPolicy : TerraformResource
{
    public AzureadAuthenticationStrengthPolicy(string name) : base("azuread_authentication_strength_policy", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The allowed MFA methods for this policy
    /// </summary>
    public TerraformLiteralProperty<HashSet<string>>? AllowedCombinations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_combinations");
        set => this.WithProperty("allowed_combinations", value);
    }

    /// <summary>
    /// The description for the authentication strength policy
    /// </summary>
    public TerraformLiteralProperty<string>? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name for the authentication strength policy
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
