using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_s3control_access_grants_location resource.
/// </summary>
public partial class AwsS3controlAccessGrantsLocation : TerraformResource
{
    public AwsS3controlAccessGrantsLocation(string name) : base("aws_s3control_access_grants_location", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The iam_role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IamRoleArn is required")]
    [TerraformProperty("iam_role_arn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> IamRoleArn { get; set; }

    /// <summary>
    /// The location_scope attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LocationScope is required")]
    [TerraformProperty("location_scope")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> LocationScope { get; set; }

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
    /// The access_grants_location_arn attribute.
    /// </summary>
    [TerraformProperty("access_grants_location_arn")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessGrantsLocationArn { get; }

    /// <summary>
    /// The access_grants_location_id attribute.
    /// </summary>
    [TerraformProperty("access_grants_location_id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> AccessGrantsLocationId { get; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> TagsAll { get; }

}
