using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsVpnConnectionDataSourceFilterBlock : TerraformBlock
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
/// Retrieves information about a aws_vpn_connection.
/// </summary>
public class AwsVpnConnectionDataSource : TerraformDataSource
{
    public AwsVpnConnectionDataSource(string name) : base("aws_vpn_connection", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("category");
        this.DeclareOutput("core_network_arn");
        this.DeclareOutput("core_network_attachment_arn");
        this.DeclareOutput("customer_gateway_configuration");
        this.DeclareOutput("customer_gateway_id");
        this.DeclareOutput("gateway_association_state");
        this.DeclareOutput("pre_shared_key_arn");
        this.DeclareOutput("routes");
        this.DeclareOutput("state");
        this.DeclareOutput("tags");
        this.DeclareOutput("transit_gateway_id");
        this.DeclareOutput("type");
        this.DeclareOutput("vgw_telemetries");
        this.DeclareOutput("vpn_gateway_id");
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
    /// The vpn_connection_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpnConnectionId
    {
        get => GetProperty<TerraformProperty<string>>("vpn_connection_id");
        set => this.WithProperty("vpn_connection_id", value);
    }

    /// <summary>
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsVpnConnectionDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsVpnConnectionDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// The category attribute.
    /// </summary>
    public TerraformExpression Category => this["category"];

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformExpression CoreNetworkArn => this["core_network_arn"];

    /// <summary>
    /// The core_network_attachment_arn attribute.
    /// </summary>
    public TerraformExpression CoreNetworkAttachmentArn => this["core_network_attachment_arn"];

    /// <summary>
    /// The customer_gateway_configuration attribute.
    /// </summary>
    public TerraformExpression CustomerGatewayConfiguration => this["customer_gateway_configuration"];

    /// <summary>
    /// The customer_gateway_id attribute.
    /// </summary>
    public TerraformExpression CustomerGatewayId => this["customer_gateway_id"];

    /// <summary>
    /// The gateway_association_state attribute.
    /// </summary>
    public TerraformExpression GatewayAssociationState => this["gateway_association_state"];

    /// <summary>
    /// The pre_shared_key_arn attribute.
    /// </summary>
    public TerraformExpression PreSharedKeyArn => this["pre_shared_key_arn"];

    /// <summary>
    /// The routes attribute.
    /// </summary>
    public TerraformExpression Routes => this["routes"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The transit_gateway_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayId => this["transit_gateway_id"];

    /// <summary>
    /// The type attribute.
    /// </summary>
    public TerraformExpression Type => this["type"];

    /// <summary>
    /// The vgw_telemetries attribute.
    /// </summary>
    public TerraformExpression VgwTelemetries => this["vgw_telemetries"];

    /// <summary>
    /// The vpn_gateway_id attribute.
    /// </summary>
    public TerraformExpression VpnGatewayId => this["vpn_gateway_id"];

}
