using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_instance_metadata_defaults resource.
/// </summary>
public class AwsEc2InstanceMetadataDefaults : TerraformResource
{
    public AwsEc2InstanceMetadataDefaults(string name) : base("aws_ec2_instance_metadata_defaults", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("id");
        SetOutput("http_endpoint");
        SetOutput("http_put_response_hop_limit");
        SetOutput("http_tokens");
        SetOutput("instance_metadata_tags");
        SetOutput("region");
    }

    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> HttpEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_endpoint");
        set => SetProperty("http_endpoint", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformProperty<double> HttpPutResponseHopLimit
    {
        get => GetRequiredOutput<TerraformProperty<double>>("http_put_response_hop_limit");
        set => SetProperty("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformProperty<string> HttpTokens
    {
        get => GetRequiredOutput<TerraformProperty<string>>("http_tokens");
        set => SetProperty("http_tokens", value);
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public TerraformProperty<string> InstanceMetadataTags
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_metadata_tags");
        set => SetProperty("instance_metadata_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
