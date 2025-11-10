using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_instance resource.
/// </summary>
public class AwsS3controlAccessGrantsInstance : TerraformResource
{
    public AwsS3controlAccessGrantsInstance(string name) : base("aws_s3control_access_grants_instance", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformPropertyName("account_id")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> AccountId { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "account_id");

    /// <summary>
    /// The identity_center_arn attribute.
    /// </summary>
    [TerraformPropertyName("identity_center_arn")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<TerraformProperty<string>>? IdentityCenterArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>>? Tags { get; set; }

    /// <summary>
    /// The access_grants_instance_arn attribute.
    /// </summary>
    [TerraformPropertyName("access_grants_instance_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessGrantsInstanceArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_grants_instance_arn");

    /// <summary>
    /// The access_grants_instance_id attribute.
    /// </summary>
    [TerraformPropertyName("access_grants_instance_id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> AccessGrantsInstanceId => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "access_grants_instance_id");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    [TerraformPropertyName("identity_center_application_arn")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> IdentityCenterApplicationArn => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "identity_center_application_arn");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformPropertyName("tags_all")]
    // Output-only attribute - read-only reference
    public TerraformProperty<Dictionary<string, TerraformProperty<string>>> TagsAll => new TerraformReferenceProperty<Dictionary<string, TerraformProperty<string>>>(ResourceAddress, "tags_all");

}
