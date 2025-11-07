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
    public TerraformProperty<HashSet<string>>? AllowedCombinations
    {
        get => GetProperty<TerraformProperty<HashSet<string>>>("allowed_combinations");
        set => this.WithProperty("allowed_combinations", value);
    }

    /// <summary>
    /// The description for the authentication strength policy
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display name for the authentication strength policy
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

}
