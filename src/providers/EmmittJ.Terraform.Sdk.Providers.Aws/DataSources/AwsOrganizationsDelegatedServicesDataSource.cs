using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_delegated_services.
/// </summary>
public class AwsOrganizationsDelegatedServicesDataSource : TerraformDataSource
{
    public AwsOrganizationsDelegatedServicesDataSource(string name) : base("aws_organizations_delegated_services", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformPropertyName("account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The delegated_services attribute.
    /// </summary>
    [TerraformPropertyName("delegated_services")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> DelegatedServices => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "delegated_services");

}
