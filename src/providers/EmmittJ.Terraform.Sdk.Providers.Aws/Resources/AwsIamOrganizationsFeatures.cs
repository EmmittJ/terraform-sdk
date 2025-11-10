using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_iam_organizations_features resource.
/// </summary>
public class AwsIamOrganizationsFeatures : TerraformResource
{
    public AwsIamOrganizationsFeatures(string name) : base("aws_iam_organizations_features", name)
    {
    }

    /// <summary>
    /// The enabled_features attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnabledFeatures is required")]
    [TerraformPropertyName("enabled_features")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public TerraformProperty<HashSet<TerraformProperty<string>>>? EnabledFeatures { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
