using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_glacier_vault_lock resource.
/// </summary>
public partial class AwsGlacierVaultLock : TerraformResource
{
    public AwsGlacierVaultLock(string name) : base("aws_glacier_vault_lock", name)
    {
    }

    /// <summary>
    /// The complete_lock attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CompleteLock is required")]
    [TerraformProperty("complete_lock")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<bool> CompleteLock { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The ignore_deletion_error attribute.
    /// </summary>
    [TerraformProperty("ignore_deletion_error")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? IgnoreDeletionError { get; set; }

    /// <summary>
    /// The policy attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Policy is required")]
    [TerraformProperty("policy")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Policy { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The vault_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VaultName is required")]
    [TerraformProperty("vault_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> VaultName { get; set; }

}
