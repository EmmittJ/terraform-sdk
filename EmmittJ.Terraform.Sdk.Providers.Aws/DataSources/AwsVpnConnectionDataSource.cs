using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

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
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The vpn_connection_id attribute.
    /// </summary>
    public string? VpnConnectionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("vpn_connection_id")?.Value;
        set => this.WithProperty("vpn_connection_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
