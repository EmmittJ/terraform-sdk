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
    public HashSet<string>? AllowedCombinations
    {
        get => GetProperty<TerraformLiteralProperty<HashSet<string>>>("allowed_combinations")?.Value;
        set => this.WithProperty("allowed_combinations", value == null ? null : new TerraformLiteralProperty<HashSet<string>>(value));
    }

    /// <summary>
    /// The description for the authentication strength policy
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The display name for the authentication strength policy
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
