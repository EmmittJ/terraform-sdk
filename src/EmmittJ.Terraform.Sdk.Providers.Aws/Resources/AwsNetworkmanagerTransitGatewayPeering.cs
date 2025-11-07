using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_transit_gateway_peering resource.
/// </summary>
public class AwsNetworkmanagerTransitGatewayPeering : TerraformResource
{
    public AwsNetworkmanagerTransitGatewayPeering(string name) : base("aws_networkmanager_transit_gateway_peering", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("core_network_arn");
        this.DeclareOutput("edge_location");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("peering_type");
        this.DeclareOutput("resource_arn");
        this.DeclareOutput("transit_gateway_peering_attachment_id");
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? CoreNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_id");
        set => this.WithProperty("core_network_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformLiteralProperty<Dictionary<string, string>>? TagsAll
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transit_gateway_arn attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? TransitGatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_arn");
        set => this.WithProperty("transit_gateway_arn", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformExpression CoreNetworkArn => this["core_network_arn"];

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformExpression EdgeLocation => this["edge_location"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The peering_type attribute.
    /// </summary>
    public TerraformExpression PeeringType => this["peering_type"];

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

    /// <summary>
    /// The transit_gateway_peering_attachment_id attribute.
    /// </summary>
    public TerraformExpression TransitGatewayPeeringAttachmentId => this["transit_gateway_peering_attachment_id"];

}
