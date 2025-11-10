using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerConnectAttachmentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The protocol attribute.
    /// </summary>
    public TerraformProperty<string>? Protocol
    {
        get => GetProperty<TerraformProperty<string>>("protocol");
        set => WithProperty("protocol", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerConnectAttachmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_connect_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerConnectAttachment : TerraformResource
{
    public AwsNetworkmanagerConnectAttachment(string name) : base("aws_networkmanager_connect_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("attachment_id");
        this.DeclareOutput("attachment_policy_rule_number");
        this.DeclareOutput("attachment_type");
        this.DeclareOutput("core_network_arn");
        this.DeclareOutput("owner_account_id");
        this.DeclareOutput("resource_arn");
        this.DeclareOutput("segment_name");
        this.DeclareOutput("state");
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    public required TerraformProperty<string> CoreNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("core_network_id");
        set => this.WithProperty("core_network_id", value);
    }

    /// <summary>
    /// The edge_location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EdgeLocation is required")]
    public required TerraformProperty<string> EdgeLocation
    {
        get => GetProperty<TerraformProperty<string>>("edge_location");
        set => this.WithProperty("edge_location", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// The transport_attachment_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TransportAttachmentId is required")]
    public required TerraformProperty<string> TransportAttachmentId
    {
        get => GetProperty<TerraformProperty<string>>("transport_attachment_id");
        set => this.WithProperty("transport_attachment_id", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Options block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsNetworkmanagerConnectAttachmentOptionsBlock>? Options
    {
        get => GetProperty<List<AwsNetworkmanagerConnectAttachmentOptionsBlock>>("options");
        set => this.WithProperty("options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerConnectAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerConnectAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The attachment_id attribute.
    /// </summary>
    public TerraformExpression AttachmentId => this["attachment_id"];

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
