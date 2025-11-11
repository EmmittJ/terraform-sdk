using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_organizations_delegated_services.
/// </summary>
public partial class AwsOrganizationsDelegatedServicesDataSource : TerraformDataSource
{
    public AwsOrganizationsDelegatedServicesDataSource(string name) : base("aws_organizations_delegated_services", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    [TerraformProperty("account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The delegated_services attribute.
    /// </summary>
    [TerraformProperty("delegated_services")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformSet<object> DelegatedServices { get; }

}
