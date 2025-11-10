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
    public required TerraformProperty<TerraformProperty<string>> Arn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The allowed_publishers attribute.
    /// </summary>
    [TerraformPropertyName("allowed_publishers")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> AllowedPublishers => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "allowed_publishers");

    /// <summary>
    /// The config_id attribute.
    /// </summary>
    [TerraformPropertyName("config_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> ConfigId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "config_id");

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Description => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "description");

    /// <summary>
    /// The last_modified attribute.
    /// </summary>
    [TerraformPropertyName("last_modified")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> LastModified => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "last_modified");

    /// <summary>
    /// The policies attribute.
    /// </summary>
    [TerraformPropertyName("policies")]
    // Output-only attribute - read-only reference
    public TerraformProperty<List<TerraformProperty<object>>> Policies => new TerraformReferenceProperty<List<TerraformProperty<object>>>(ResourceAddress, "policies");

}
