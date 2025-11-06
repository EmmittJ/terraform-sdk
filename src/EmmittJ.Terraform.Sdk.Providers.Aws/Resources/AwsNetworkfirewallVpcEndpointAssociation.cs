using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkfirewall_vpc_endpoint_association resource.
/// </summary>
public class AwsNetworkfirewallVpcEndpointAssociation : TerraformResource
{
    public AwsNetworkfirewallVpcEndpointAssociation(string name) : base("aws_networkfirewall_vpc_endpoint_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("tags_all");
        this.DeclareOutput("vpc_endpoint_association_arn");
        this.DeclareOutput("vpc_endpoint_association_id");
        this.DeclareOutput("vpc_endpoint_association_status");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public string? Description
    {
        get => GetProperty<TerraformLiteralProperty<string>>("description")?.Value;
        set => this.WithProperty("description", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    public string? FirewallArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("firewall_arn")?.Value;
        set => this.WithProperty("firewall_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The vpc_id attribute.
    /// </summary>
    public string? VpcId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpc_id")?.Value;
        set => this.WithProperty("vpc_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

    /// <summary>
    /// The vpc_endpoint_association_arn attribute.
    /// </summary>
    public TerraformExpression VpcEndpointAssociationArn => this["vpc_endpoint_association_arn"];

    /// <summary>
    /// The vpc_endpoint_association_id attribute.
    /// </summary>
    public TerraformExpression VpcEndpointAssociationId => this["vpc_endpoint_association_id"];

    /// <summary>
    /// The vpc_endpoint_association_status attribute.
    /// </summary>
    public TerraformExpression VpcEndpointAssociationStatus => this["vpc_endpoint_association_status"];

}
