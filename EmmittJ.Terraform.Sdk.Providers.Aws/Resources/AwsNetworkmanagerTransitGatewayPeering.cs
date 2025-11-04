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
    public string? CoreNetworkId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("core_network_id")?.Value;
        set => this.WithProperty("core_network_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The transit_gateway_arn attribute.
    /// </summary>
    public string? TransitGatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("transit_gateway_arn")?.Value;
        set => this.WithProperty("transit_gateway_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
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
