using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_kms_alias.
/// </summary>
public partial class AwsKmsAliasDataSource : TerraformDataSource
{
    public AwsKmsAliasDataSource(string name) : base("aws_kms_alias", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Arn { get; }

    /// <summary>
    /// The target_key_arn attribute.
    /// </summary>
    [TerraformProperty("target_key_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetKeyArn { get; }

    /// <summary>
    /// The target_key_id attribute.
    /// </summary>
    [TerraformProperty("target_key_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> TargetKeyId { get; }

}
