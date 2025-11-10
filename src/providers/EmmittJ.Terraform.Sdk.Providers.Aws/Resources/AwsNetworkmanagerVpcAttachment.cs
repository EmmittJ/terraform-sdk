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
        set => SetProperty("appliance_mode_support", value);
    }

    /// <summary>
    /// The dns_support attribute.
    /// </summary>
    public TerraformProperty<bool>? DnsSupport
    {
        set => SetProperty("dns_support", value);
    }

    /// <summary>
    /// The ipv6_support attribute.
    /// </summary>
    public TerraformProperty<bool>? Ipv6Support
    {
        set => SetProperty("ipv6_support", value);
    }

    /// <summary>
    /// The security_group_referencing_support attribute.
    /// </summary>
    public TerraformProperty<bool>? SecurityGroupReferencingSupport
    {
        set => SetProperty("security_group_referencing_support", value);
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
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

/// <summary>
/// Manages a aws_networkmanager_vpc_attachment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsNetworkmanagerVpcAttachment : TerraformResource
{
    public AwsNetworkmanagerVpcAttachment(string name) : base("aws_networkmanager_vpc_attachment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("attachment_policy_rule_number");
        SetOutput("attachment_type");
        SetOutput("core_network_arn");
        SetOutput("edge_location");
        SetOutput("owner_account_id");
        SetOutput("resource_arn");
        SetOutput("segment_name");
        SetOutput("state");
        SetOutput("core_network_id");
        SetOutput("id");
        SetOutput("subnet_arns");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_arn");
    }

    /// <summary>
    /// The core_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "CoreNetworkId is required")]
    public required TerraformProperty<string> CoreNetworkId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("core_network_id");
        set => SetProperty("core_network_id", value);
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
    /// The subnet_arns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SubnetArns is required")]
    public HashSet<TerraformProperty<string>> SubnetArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_arns");
        set => SetProperty("subnet_arns", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// The vpc_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "VpcArn is required")]
    public required TerraformProperty<string> VpcArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_arn");
        set => SetProperty("vpc_arn", value);
    }

    /// <summary>
    /// Block for options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Options block(s) allowed")]
    public List<AwsNetworkmanagerVpcAttachmentOptionsBlock>? Options
    {
        set => SetProperty("options", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsNetworkmanagerVpcAttachmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
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
