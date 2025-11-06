using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_ec2_transit_gateway_multicast_domain resource.
/// </summary>
public class AwsEc2TransitGatewayMulticastDomain : TerraformResource
{
    public AwsEc2TransitGatewayMulticastDomain(string name) : base("aws_ec2_transit_gateway_multicast_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("owner_id");
    }

    /// <summary>
    /// The auto_accept_shared_associations attribute.
    /// </summary>
    public string? AutoAcceptSharedAssociations
    {
        get => GetProperty<TerraformLiteralProperty<string>>("auto_accept_shared_associations")?.Value;
        set => this.WithProperty("auto_accept_shared_associations", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The igmpv2_support attribute.
    /// </summary>
    public string? Igmpv2Support
    {
        get => GetProperty<TerraformLiteralProperty<string>>("igmpv2_support")?.Value;
        set => this.WithProperty("igmpv2_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The static_sources_support attribute.
    /// </summary>
    public string? StaticSourcesSupport
    {
        get => GetProperty<TerraformLiteralProperty<string>>("static_sources_support")?.Value;
        set => this.WithProperty("static_sources_support", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, string>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all")?.Value;
        set => this.WithProperty("tags_all", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public string? TransitGatewayId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_id")?.Value;
        set => this.WithProperty("transit_gateway_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

}
