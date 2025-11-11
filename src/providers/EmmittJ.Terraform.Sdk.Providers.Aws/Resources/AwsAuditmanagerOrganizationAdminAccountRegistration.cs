using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_organization_admin_account_registration resource.
/// </summary>
public partial class AwsAuditmanagerOrganizationAdminAccountRegistration : TerraformResource
{
    public AwsAuditmanagerOrganizationAdminAccountRegistration(string name) : base("aws_auditmanager_organization_admin_account_registration", name)
    {
    }

    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccountId is required")]
    [TerraformProperty("admin_account_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AdminAccountId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [TerraformProperty("organization_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> OrganizationId { get; }

}
