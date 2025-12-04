using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Represents a aws_ec2_instance_metadata_defaults Terraform resource.
/// Manages a aws_ec2_instance_metadata_defaults resource.
/// </summary>
public partial class AwsEc2InstanceMetadataDefaults(string name) : TerraformResource("aws_ec2_instance_metadata_defaults", name)
{
    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    public TerraformValue<string> HttpEndpoint
    {
        get => GetArgument<TerraformValue<string>>("http_endpoint") ?? AsReference("http_endpoint");
        set => SetArgument("http_endpoint", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformValue<double> HttpPutResponseHopLimit
    {
        get => GetArgument<TerraformValue<double>>("http_put_response_hop_limit") ?? AsReference("http_put_response_hop_limit");
        set => SetArgument("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformValue<string> HttpTokens
    {
        get => GetArgument<TerraformValue<string>>("http_tokens") ?? AsReference("http_tokens");
        set => SetArgument("http_tokens", value);
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public TerraformValue<string> InstanceMetadataTags
    {
        get => GetArgument<TerraformValue<string>>("instance_metadata_tags") ?? AsReference("instance_metadata_tags");
        set => SetArgument("instance_metadata_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
        => AsReference("id");

}
