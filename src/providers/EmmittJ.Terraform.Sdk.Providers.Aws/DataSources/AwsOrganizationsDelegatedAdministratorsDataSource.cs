using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_delegated_administrators.
/// </summary>
public partial class AwsOrganizationsDelegatedAdministratorsDataSource : TerraformDataSource
{
    public AwsOrganizationsDelegatedAdministratorsDataSource(string name) : base("aws_organizations_delegated_administrators", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformProperty("service_principal")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ServicePrincipal { get; set; }

    /// <summary>
    /// The delegated_administrators attribute.
    /// </summary>
    [TerraformProperty("delegated_administrators")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformSet<object> DelegatedAdministrators { get; }

}
