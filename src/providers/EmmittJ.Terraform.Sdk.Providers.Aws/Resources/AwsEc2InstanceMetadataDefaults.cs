using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_instance_metadata_defaults resource.
/// </summary>
public partial class AwsEc2InstanceMetadataDefaults : TerraformResource
{
    public AwsEc2InstanceMetadataDefaults(string name) : base("aws_ec2_instance_metadata_defaults", name)
    {
    }

    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformProperty("http_endpoint")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpEndpoint { get; set; }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformProperty("http_put_response_hop_limit")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<double> HttpPutResponseHopLimit { get; set; }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformProperty("http_tokens")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> HttpTokens { get; set; }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    [TerraformProperty("instance_metadata_tags")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> InstanceMetadataTags { get; set; }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformProperty("region")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Region { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> Id { get; }

}
