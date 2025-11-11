using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_account_registration resource.
/// </summary>
public class AwsAuditmanagerAccountRegistration : TerraformResource
{
    public AwsAuditmanagerAccountRegistration(string name) : base("aws_auditmanager_account_registration", name)
    {
    }

    /// <summary>
    /// The delegated_admin_account attribute.
    /// </summary>
    [TerraformPropertyName("delegated_admin_account")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? DelegatedAdminAccount { get; set; }

    /// <summary>
    /// The deregister_on_destroy attribute.
    /// </summary>
    [TerraformPropertyName("deregister_on_destroy")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DeregisterOnDestroy { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformPropertyName("kms_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KmsKey { get; set; }

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
    /// The status attribute.
    /// </summary>
    [TerraformPropertyName("status")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Status => new TerraformReference(this, "status");

}
