using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Manages a aws_networkmanager_attachment_accepter resource.
/// </summary>
public class AwsNetworkmanagerAttachmentAccepter : TerraformResource
{
    public AwsNetworkmanagerAttachmentAccepter(string name) : base("aws_networkmanager_attachment_accepter", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("attachment_policy_rule_number");
        this.DeclareOutput("core_network_arn");
        this.DeclareOutput("core_network_id");
        this.DeclareOutput("edge_location");
        this.DeclareOutput("edge_locations");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("resource_arn");
        this.DeclareOutput("segment_name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    public string? AttachmentId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attachment_id")?.Value;
        set => this.WithProperty("attachment_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    public string? AttachmentType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("attachment_type")?.Value;
        set => this.WithProperty("attachment_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The attachment_policy_rule_number attribute.
    /// </summary>
    public TerraformExpression AttachmentPolicyRuleNumber => this["attachment_policy_rule_number"];

    /// <summary>
    /// The core_network_arn attribute.
    /// </summary>
    public TerraformExpression CoreNetworkArn => this["core_network_arn"];

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    public TerraformExpression CoreNetworkId => this["core_network_id"];

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    public TerraformExpression EdgeLocation => this["edge_location"];

    /// <summary>
    /// The edge_locations attribute.
    /// </summary>
    public TerraformExpression EdgeLocations => this["edge_locations"];

    /// <summary>
    /// The owner_account_id attribute.
    /// </summary>
    public TerraformExpression OwnerAccountId => this["owner_account_id"];

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformExpression ResourceArn => this["resource_arn"];

    /// <summary>
    /// The segment_name attribute.
    /// </summary>
    public TerraformExpression SegmentName => this["segment_name"];

    /// <summary>
    /// The state attribute.
    /// </summary>
    public TerraformExpression State => this["state"];

}
