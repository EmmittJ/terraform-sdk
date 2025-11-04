using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_ec2_transit_gateway_multicast_domain.
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSource : TerraformDataSource
{
    public AwsEc2TransitGatewayMulticastDomainDataSource(string name) : base("aws_ec2_transit_gateway_multicast_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("associations");
        this.DeclareOutput("auto_accept_shared_associations");
        this.DeclareOutput("igmpv2_support");
        this.DeclareOutput("members");
        this.DeclareOutput("owner_id");
        this.DeclareOutput("sources");
        this.DeclareOutput("state");
        this.DeclareOutput("static_sources_support");
        this.DeclareOutput("transit_gateway_attachment_id");
        this.DeclareOutput("transit_gateway_id");
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    public string? TransitGatewayMulticastDomainId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_multicast_domain_id")?.Value;
        set => this.WithProperty("transit_gateway_multicast_domain_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The associations attribute.
    /// </summary>
    public TerraformExpression Associations => this["associations"];

    /// <summary>
    /// The auto_accept_shared_associations attribute.
    /// </summary>
    public TerraformExpression AutoAcceptSharedAssociations => this["auto_accept_shared_associations"];

    /// <summary>
    /// The igmpv2_support attribute.
    /// </summary>
    public TerraformExpression Igmpv2Support => this["igmpv2_support"];

    /// <summary>
    /// The members attribute.
    /// </summary>
    public TerraformExpression Members => this["members"];

    /// <summary>
    /// The owner_id attribute.
    /// </summary>
    public TerraformExpression OwnerId => this["owner_id"];

    /// <summary>
    /// The sources attribute.
    /// </summary>
    public TerraformExpression Sources => this["sources"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The static_sources_support attribute.
    /// </summary>
    public TerraformExpression StaticSourcesSupport => this["static_sources_support"];

    /// <summary>
    /// The transit_gateway_attachment_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayAttachmentId => this["transit_gateway_attachment_id"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

}
