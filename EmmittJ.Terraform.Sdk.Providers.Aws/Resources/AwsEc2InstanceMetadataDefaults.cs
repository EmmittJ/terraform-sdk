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
    public string? HttpEndpoint
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_endpoint")?.Value;
        set => this.WithProperty("http_endpoint", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public double? HttpPutResponseHopLimit
    {
        get => GetProperty<TerraformLiteralProperty<double>>("http_put_response_hop_limit")?.Value;
        set => this.WithProperty("http_put_response_hop_limit", value == null ? null : new TerraformLiteralProperty<double>(value.Value));
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public string? HttpTokens
    {
        get => GetProperty<TerraformLiteralProperty<string>>("http_tokens")?.Value;
        set => this.WithProperty("http_tokens", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The instance_metadata_tags attribute.
    /// </summary>
    public string? InstanceMetadataTags
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_metadata_tags")?.Value;
        set => this.WithProperty("instance_metadata_tags", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

}
