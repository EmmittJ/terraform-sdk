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
        set => SetProperty("create", value);
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
        SetOutput("attachment_policy_rule_number");
        SetOutput("core_network_arn");
        SetOutput("core_network_id");
        SetOutput("edge_location");
        SetOutput("edge_locations");
        SetOutput("owner_account_id");
        SetOutput("resource_arn");
        SetOutput("segment_name");
        SetOutput("state");
        SetOutput("attachment_id");
        SetOutput("attachment_type");
        SetOutput("id");
    }

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentId is required")]
    public required TerraformProperty<string> AttachmentId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("attachment_id");
        set => SetProperty("attachment_id", value);
    }

    /// <summary>
    /// The attachment_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AttachmentType is required")]
    public required TerraformProperty<string> AttachmentType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("attachment_type");
        set => SetProperty("attachment_type", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerAttachmentAccepterTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
