using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_instance_metadata_defaults resource.
/// </summary>
public class AwsEc2InstanceMetadataDefaults : TerraformResource
{
    public AwsEc2InstanceMetadataDefaults(string name) : base("aws_ec2_instance_metadata_defaults", name)
    {
    }

    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    [TerraformPropertyName("http_endpoint")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpEndpoint { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "http_endpoint");

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    [TerraformPropertyName("http_put_response_hop_limit")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<double>> HttpPutResponseHopLimit { get; set; } = new TerraformReferenceProperty<TerraformProperty<double>>(ResourceAddress, "http_put_response_hop_limit");

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    [TerraformPropertyName("http_tokens")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> HttpTokens { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "http_tokens");

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    [TerraformPropertyName("instance_metadata_tags")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> InstanceMetadataTags { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "instance_metadata_tags");

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    [TerraformPropertyName("region")]
    // Optional+Computed - defaults to reference (Terraform will compute if not set)
    public TerraformProperty<TerraformProperty<string>> Region { get; set; } = new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "region");

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Output-only attribute - read-only reference
    public TerraformProperty<TerraformProperty<string>> Id => new TerraformReferenceProperty<TerraformProperty<string>>(ResourceAddress, "id");

}
