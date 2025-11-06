using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_dx_gateway_attachment resource.
/// </summary>
public class AwsNetworkmanagerDxGatewayAttachment : TerraformResource
{
    public AwsNetworkmanagerDxGatewayAttachment(string name) : base("aws_networkmanager_dx_gateway_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("attachment_policy_rule_number");
        this.DeclareOutput("attachment_type");
        this.DeclareOutput("core_network_arn");
        this.DeclareOutput("id");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("segment_name");
        this.DeclareOutput("state");
        this.DeclareOutput("tags_all");
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
    /// The direct_connect_gateway_arn attribute.
    /// </summary>
    public string? DirectConnectGatewayArn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("direct_connect_gateway_arn")?.Value;
        set => this.WithProperty("direct_connect_gateway_arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    public List<string>? EdgeLocations
    {
        get => GetProperty<TerraformLiteralProperty<List<string>>>("edge_locations")?.Value;
        set => this.WithProperty("edge_locations", value == null ? null : new TerraformLiteralProperty<List<string>>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    public TerraformExpression AttachmentPolicyRuleNumber => this["attachment_policy_rule_number"];

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public TerraformExpression AttachmentType => this["attachment_type"];

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformExpression CoreNetworkArn => this["core_network_arn"];

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformExpression Id => this["id"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    public TerraformExpression SegmentName => this["segment_name"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformExpression TagsAll => this["tags_all"];

}
