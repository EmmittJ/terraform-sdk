using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_vpclattice_access_log_subscription resource.
/// </summary>
public partial class AwsVpclatticeAccessLogSubscription : TerraformResource
{
    public AwsVpclatticeAccessLogSubscription(string name) : base("aws_vpclattice_access_log_subscription", name)
    {
    }

    /// <summary>
    /// The destination_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DestinationArn is required")]
    [TerraformProperty("destination_arn")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> DestinationArn { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The resource_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceIdentifier is required")]
    [TerraformProperty("resource_identifier")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceIdentifier { get; set; }

    /// <summary>
    /// The service_network_log_type attribute.
    /// </summary>
    [TerraformProperty("service_network_log_type")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> ServiceNetworkLogType { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    [TerraformProperty("tags_all")]
    // Optional+Computed - source generator will implement get/set
    public TerraformMap<string> TagsAll { get; set; }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [TerraformProperty("arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Arn { get; }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    [TerraformProperty("resource_arn")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> ResourceArn { get; }

}
