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
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The firewall_arn attribute.
    /// </summary>
    public TerraformProperty<string>? FirewallArn
    {
        get => GetProperty<TerraformProperty<string>>("firewall_arn");
        set => this.WithProperty("firewall_arn", value);
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
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The vpc_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_id");
        set => this.WithProperty("vpc_id", value);
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
