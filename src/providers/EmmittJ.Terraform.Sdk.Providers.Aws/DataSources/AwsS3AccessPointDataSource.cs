using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_s3_access_point.
/// </summary>
public partial class AwsS3AccessPointDataSource : TerraformDataSource
{
    public AwsS3AccessPointDataSource(string name) : base("aws_s3_access_point", name)
    {
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [TerraformProperty("account_id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> AccountId { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    [TerraformProperty("alias")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Alias { get; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The bucket attribute.
    /// </summary>
    [TerraformProperty("bucket")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Bucket { get; }

    /// <summary>
    /// The bucket_account_id attribute.
    /// </summary>
    [TerraformProperty("bucket_account_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> BucketAccountId { get; }

    /// <summary>
    /// The data_source_id attribute.
    /// </summary>
    [TerraformProperty("data_source_id")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DataSourceId { get; }

    /// <summary>
    /// The data_source_type attribute.
    /// </summary>
    [TerraformProperty("data_source_type")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> DataSourceType { get; }

    /// <summary>
    /// The endpoints attribute.
    /// </summary>
    [TerraformProperty("endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Endpoints { get; }

    /// <summary>
    /// The network_origin attribute.
    /// </summary>
    [TerraformProperty("network_origin")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> NetworkOrigin { get; }

    /// <summary>
    /// The public_access_block_configuration attribute.
    /// </summary>
    [TerraformProperty("public_access_block_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> PublicAccessBlockConfiguration { get; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformMap<string> Tags { get; }

    /// <summary>
    /// The vpc_configuration attribute.
    /// </summary>
    [TerraformProperty("vpc_configuration")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformList<object> VpcConfiguration { get; }

}
