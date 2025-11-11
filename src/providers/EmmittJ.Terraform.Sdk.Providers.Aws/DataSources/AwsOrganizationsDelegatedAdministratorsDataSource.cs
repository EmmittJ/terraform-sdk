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
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformPropertyName("service_principal")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ServicePrincipal { get; set; }

    /// <summary>
    /// The delegated_administrators attribute.
    /// </summary>
    [TerraformPropertyName("delegated_administrators")]
    // Output-only attribute - read-only reference
    public TerraformSet<object> DelegatedAdministrators => new TerraformReference(this, "delegated_administrators");

}
