using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_delegated_administrators.
/// </summary>
public class AwsOrganizationsDelegatedAdministratorsDataSource : TerraformDataSource
{
    public AwsOrganizationsDelegatedAdministratorsDataSource(string name) : base("aws_organizations_delegated_administrators", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformPropertyName("service_principal")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? ServicePrincipal { get; set; }

    /// <summary>
    /// The delegated_administrators attribute.
    /// </summary>
    [TerraformPropertyName("delegated_administrators")]
    // Output-only attribute - read-only reference
    public TerraformProperty<HashSet<TerraformProperty<object>>> DelegatedAdministrators => new TerraformReferenceProperty<HashSet<TerraformProperty<object>>>(ResourceAddress, "delegated_administrators");

}
