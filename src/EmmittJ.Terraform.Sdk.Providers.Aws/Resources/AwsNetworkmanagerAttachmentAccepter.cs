using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerAttachmentAccepterTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

}

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
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentId is required")]
    public required TerraformProperty<string> AttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("attachment_id");
        set => this.WithProperty("attachment_id", value);
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    public required TerraformProperty<string> AttachmentType
    {
        get => GetProperty<TerraformProperty<string>>("attachment_type");
        set => this.WithProperty("attachment_type", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerAttachmentAccepterTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerAttachmentAccepterTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
