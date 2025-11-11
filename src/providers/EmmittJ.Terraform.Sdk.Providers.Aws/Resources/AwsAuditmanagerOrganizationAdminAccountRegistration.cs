using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_organization_admin_account_registration resource.
/// </summary>
public class AwsAuditmanagerOrganizationAdminAccountRegistration : TerraformResource
{
    public AwsAuditmanagerOrganizationAdminAccountRegistration(string name) : base("aws_auditmanager_organization_admin_account_registration", name)
    {
    }

    /// <summary>
    /// The admin_account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AdminAccountId is required")]
    [TerraformPropertyName("admin_account_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AdminAccountId { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Id => new TerraformReference(this, "id");

    /// <summary>
    /// The organization_id attribute.
    /// </summary>
    [TerraformPropertyName("organization_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> OrganizationId => new TerraformReference(this, "organization_id");

}
