using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_redshift_data_share_authorization resource.
/// </summary>
public class AwsRedshiftDataShareAuthorization : TerraformResource
{
    public AwsRedshiftDataShareAuthorization(string name) : base("aws_redshift_data_share_authorization", name)
    {
    }

    /// <summary>
    /// The allow_writes attribute.
    /// </summary>
    [TerraformPropertyName("allow_writes")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AllowWrites { get; set; }

    /// <summary>
    /// The consumer_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ConsumerIdentifier is required")]
    [TerraformPropertyName("consumer_identifier")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ConsumerIdentifier { get; set; }

    /// <summary>
    /// The data_share_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DataShareArn is required")]
    [TerraformPropertyName("data_share_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> DataShareArn { get; set; }

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
    /// The managed_by attribute.
    /// </summary>
    [TerraformPropertyName("managed_by")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ManagedBy => new TerraformReference(this, "managed_by");

    /// <summary>
    /// The producer_arn attribute.
    /// </summary>
    [TerraformPropertyName("producer_arn")]
    // Output-only attribute - read-only reference
    public TerraformValue<string> ProducerArn => new TerraformReference(this, "producer_arn");

}
