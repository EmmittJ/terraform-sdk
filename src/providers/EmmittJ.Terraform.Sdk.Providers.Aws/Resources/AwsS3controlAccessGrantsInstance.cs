using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_instance resource.
/// </summary>
public partial class AwsS3controlAccessGrantsInstance : TerraformResource
{
    public AwsS3controlAccessGrantsInstance(string name) : base("aws_s3control_access_grants_instance", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The identity_center_arn attribute.
    /// </summary>
    [TerraformProperty("identity_center_arn")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? IdentityCenterArn { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The access_grants_instance_arn attribute.
    /// </summary>
    [TerraformProperty("access_grants_instance_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessGrantsInstanceArn { get; }

    /// <summary>
    /// The access_grants_instance_id attribute.
    /// </summary>
    [TerraformProperty("access_grants_instance_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessGrantsInstanceId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The identity_center_application_arn attribute.
    /// </summary>
    [TerraformProperty("identity_center_application_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> IdentityCenterApplicationArn { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
