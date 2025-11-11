using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpc_ipam_organization_admin_account resource.
/// </summary>
public partial class AwsVpcIpamOrganizationAdminAccount : TerraformResource
{
    public AwsVpcIpamOrganizationAdminAccount(string name) : base("aws_vpc_ipam_organization_admin_account", name)
    {
    }

    /// <summary>
    /// The delegated_admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DelegatedAdminAccountId is required")]
    [TerraformProperty("delegated_admin_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> DelegatedAdminAccountId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The email attribute.
    /// </summary>
    [TerraformProperty("email")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Email { get; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [TerraformProperty("name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Name { get; }

    /// <summary>
    /// The service_principal attribute.
    /// </summary>
    [TerraformProperty("service_principal")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ServicePrincipal { get; }

}
