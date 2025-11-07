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
        this.DeclareOutput("id");
    }

    /// <summary>
    /// The http_endpoint attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HttpEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_endpoint");
        set => this.WithProperty("http_endpoint", value);
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformLiteralProperty<double>? HttpPutResponseHopLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_put_response_hop_limit");
        set => this.WithProperty("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? HttpTokens
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_tokens");
        set => this.WithProperty("http_tokens", value);
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? InstanceMetadataTags
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_metadata_tags");
        set => this.WithProperty("instance_metadata_tags", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformLiteralProperty<string>? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
