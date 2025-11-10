using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_cloudwatch_event_archive resource.
/// </summary>
public class AwsCloudwatchEventArchive : TerraformResource
{
    public AwsCloudwatchEventArchive(string name) : base("aws_cloudwatch_event_archive", name)
    {
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    [TerraformPropertyName("description")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? Description { get; set; }

    /// <summary>
    /// The event_pattern attribute.
    /// </summary>
    [TerraformPropertyName("event_pattern")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? EventPattern { get; set; }

    /// <summary>
    /// The event_source_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EventSourceArn is required")]
    [TerraformPropertyName("event_source_arn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> EventSourceArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Id { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The kms_key_identifier attribute.
    /// </summary>
    [TerraformPropertyName("kms_key_identifier")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? KmsKeyIdentifier { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformProperty<TerraformProperty<string>> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The retention_days attribute.
    /// </summary>
    [TerraformPropertyName("retention_days")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<double>>? RetentionDays { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformPropertyName("arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Arn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "arn");

}
