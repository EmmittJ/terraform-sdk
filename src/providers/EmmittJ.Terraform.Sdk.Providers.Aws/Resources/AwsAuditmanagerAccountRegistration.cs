using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_auditmanager_account_registration resource.
/// </summary>
public partial class AwsAuditmanagerAccountRegistration : TerraformResource
{
    public AwsAuditmanagerAccountRegistration(string name) : base("aws_auditmanager_account_registration", name)
    {
    }

    /// <summary>
    /// The delegated_admin_account attribute.
    /// </summary>
    [TerraformProperty("delegated_admin_account")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? DelegatedAdminAccount { get; set; }

    /// <summary>
    /// The deregister_on_destroy attribute.
    /// </summary>
    [TerraformProperty("deregister_on_destroy")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DeregisterOnDestroy { get; set; }

    /// <summary>
    /// The kms_key attribute.
    /// </summary>
    [TerraformProperty("kms_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KmsKey { get; set; }

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
    /// The status attribute.
    /// </summary>
    [TerraformProperty("status")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Status { get; }

}
