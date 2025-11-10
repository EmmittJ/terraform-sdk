using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for options in .
/// Nesting mode: list
/// </summary>
public class AwsNetworkmanagerVpcAttachmentOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The appliance_mode_support attribute.
    /// </summary>
    public TerraformProperty<bool>? ApplianceModeSupport
    {
        get => GetProperty<TerraformProperty<bool>>("appliance_mode_support");
        set => WithProperty("appliance_mode_support", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsSupport
    {
        get => GetProperty<TerraformProperty<bool>>("dns_support");
        set => WithProperty("dns_support", value);
    }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformProperty<bool>? Ipv6Support
    {
        get => GetProperty<TerraformProperty<bool>>("ipv6_support");
        set => WithProperty("ipv6_support", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformProperty<bool>? SecurityGroupReferencingSupport
    {
        get => GetProperty<TerraformProperty<bool>>("security_group_referencing_support");
        set => WithProperty("security_group_referencing_support", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsNetworkmanagerVpcAttachmentTimeoutsBlock : TerraformBlock
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

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_vpc_attachment resource.
/// </summary>
public class AwsNetworkmanagerVpcAttachment : TerraformResource
{
    public AwsNetworkmanagerVpcAttachment(string name) : base("aws_networkmanager_vpc_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("attachment_policy_rule_number");
        this.DeclareOutput("attachment_type");
        this.DeclareOutput("core_network_arn");
        this.DeclareOutput("edge_location");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArns is required")]
    public HashSet<TerraformProperty<string>>? SubnetArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_arns");
        set => this.WithProperty("subnet_arns", value);
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
    /// The vpc_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcArn is required")]
    public required TerraformProperty<string> VpcArn
    {
        get => GetProperty<TerraformProperty<string>>("vpc_arn");
        set => this.WithProperty("vpc_arn", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsNetworkmanagerVpcAttachmentOptionsBlock>? Options
    {
        get => GetProperty<List<AwsNetworkmanagerVpcAttachmentOptionsBlock>>("options");
        set => this.WithProperty("options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerVpcAttachmentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsNetworkmanagerVpcAttachmentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
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
    /// The edge_location attribute.
    /// </summary>
    public TerraformExpression EdgeLocation => this["edge_location"];

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
