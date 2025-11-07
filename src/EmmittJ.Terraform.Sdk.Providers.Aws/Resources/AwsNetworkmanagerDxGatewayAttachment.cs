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
    public TerraformProperty<string>? CoreNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("core_network_id");
        set => this.WithProperty("core_network_id", value);
    }

    /// <summary>
    /// The direct_connect_gateway_arn attribute.
    /// </summary>
    public TerraformProperty<string>? DirectConnectGatewayArn
    {
        get => GetProperty<TerraformProperty<string>>("direct_connect_gateway_arn");
        set => this.WithProperty("direct_connect_gateway_arn", value);
    }

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    public TerraformProperty<List<string>>? EdgeLocations
    {
        get => GetProperty<TerraformProperty<List<string>>>("edge_locations");
        set => this.WithProperty("edge_locations", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
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
