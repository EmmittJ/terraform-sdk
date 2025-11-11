using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_lambda_code_signing_config.
/// </summary>
public class AwsLambdaCodeSigningConfigDataSource : TerraformDataSource
{
    public AwsLambdaCodeSigningConfigDataSource(string name) : base("aws_lambda_code_signing_config", name)
    {
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    [TerraformPropertyName("arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Region { get; set; } = default!;

    /// <summary>
    /// The allowed_publishers attribute.
    /// </summary>
    [TerraformPropertyName("allowed_publishers")]
    // Output-only attribute - read-only reference
    public TerraformList<object> AllowedPublishers => new TerraformReference(this, "allowed_publishers");

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    [TerraformPropertyName("config_id")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ConfigId => new TerraformReference(this, "config_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> Description => new TerraformReference(this, "description");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> LastModified => new TerraformReference(this, "last_modified");

    /// <summary>
    /// The policies attribute.
    /// </summary>
    [TerraformPropertyName("policies")]
    // Output-only attribute - read-only reference
    public TerraformList<object> Policies => new TerraformReference(this, "policies");

}
