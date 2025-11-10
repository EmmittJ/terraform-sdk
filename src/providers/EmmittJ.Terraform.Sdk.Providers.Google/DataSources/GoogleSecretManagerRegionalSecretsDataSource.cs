using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Google;

/// <summary>
/// Retrieves information about a google_secret_manager_regional_secrets.
/// </summary>
public class GoogleSecretManagerRegionalSecretsDataSource : TerraformDataSource
{
    public GoogleSecretManagerRegionalSecretsDataSource(string name) : base("google_secret_manager_regional_secrets", name)
    {
    }

    /// <summary>
    /// Filter string, adhering to the rules in List-operation filtering (https://cloud.google.com/secret-manager/docs/filtering).
    /// List only secrets matching the filter. If filter is empty, all regional secrets are listed from the specified location.
    /// </summary>
    [TerraformPropertyName("filter")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Filter { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Location { get; set; }

    /// <summary>
    /// The project attribute.
    /// </summary>
    [TerraformPropertyName("project")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Project { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "project");

    /// <summary>
    /// The secrets attribute.
    /// </summary>
    [TerraformPropertyName("secrets")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Secrets => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "secrets");

}
