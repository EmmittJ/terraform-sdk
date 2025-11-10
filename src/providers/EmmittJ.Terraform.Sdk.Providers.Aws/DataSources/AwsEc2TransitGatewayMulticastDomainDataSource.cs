using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The transit_gateway_multicast_domain_id attribute.
    /// </summary>
    public TerraformProperty<string>? TransitGatewayMulticastDomainId
    {
        get => GetProperty<TerraformProperty<string>>("transit_gateway_multicast_domain_id");
        set => this.WithProperty("transit_gateway_multicast_domain_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsEc2TransitGatewayMulticastDomainDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsEc2TransitGatewayMulticastDomainDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
