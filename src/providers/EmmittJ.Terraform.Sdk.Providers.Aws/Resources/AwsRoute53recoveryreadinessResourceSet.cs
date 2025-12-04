using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for resources in AwsRoute53recoveryreadinessResourceSet.
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetResourcesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "resources";

    /// <summary>
    /// The component_id attribute.
    /// </summary>
    public TerraformValue<string> ComponentId
        => AsReference("component_id");

    /// <summary>
    /// The readiness_scopes attribute.
    /// </summary>
    public TerraformList<string>? ReadinessScopes
    {
        get => GetArgument<TerraformList<string>>("readiness_scopes");
        set => SetArgument("readiness_scopes", value);
    }

    /// <summary>
    /// The resource_arn attribute.
    /// </summary>
    public TerraformValue<string>? ResourceArn
    {
        get => GetArgument<TerraformValue<string>>("resource_arn");
        set => SetArgument("resource_arn", value);
    }

    /// <summary>
    /// DnsTargetResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 DnsTargetResource block(s) allowed")]
    public TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlock>? DnsTargetResource
    {
        get => GetArgument<TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlock>>("dns_target_resource");
        set => SetArgument("dns_target_resource", value);
    }

}

/// <summary>
/// Block type for dns_target_resource in AwsRoute53recoveryreadinessResourceSetResourcesBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "dns_target_resource";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DomainName is required")]
    public required TerraformValue<string> DomainName
    {
        get => GetRequiredArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The hosted_zone_arn attribute.
    /// </summary>
    public TerraformValue<string>? HostedZoneArn
    {
        get => GetArgument<TerraformValue<string>>("hosted_zone_arn");
        set => SetArgument("hosted_zone_arn", value);
    }

    /// <summary>
    /// The record_set_id attribute.
    /// </summary>
    public TerraformValue<string>? RecordSetId
    {
        get => GetArgument<TerraformValue<string>>("record_set_id");
        set => SetArgument("record_set_id", value);
    }

    /// <summary>
    /// The record_type attribute.
    /// </summary>
    public TerraformValue<string>? RecordType
    {
        get => GetArgument<TerraformValue<string>>("record_type");
        set => SetArgument("record_type", value);
    }

    /// <summary>
    /// TargetResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 TargetResource block(s) allowed")]
    public TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlock>? TargetResource
    {
        get => GetArgument<TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlock>>("target_resource");
        set => SetArgument("target_resource", value);
    }

}

/// <summary>
/// Block type for target_resource in AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "target_resource";

    /// <summary>
    /// NlbResource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 NlbResource block(s) allowed")]
    public TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlockNlbResourceBlock>? NlbResource
    {
        get => GetArgument<TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlockNlbResourceBlock>>("nlb_resource");
        set => SetArgument("nlb_resource", value);
    }

    /// <summary>
    /// R53Resource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 R53Resource block(s) allowed")]
    public TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlockR53ResourceBlock>? R53Resource
    {
        get => GetArgument<TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlockR53ResourceBlock>>("r53_resource");
        set => SetArgument("r53_resource", value);
    }

}

/// <summary>
/// Block type for nlb_resource in AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlockNlbResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "nlb_resource";

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string>? Arn
    {
        get => GetArgument<TerraformValue<string>>("arn");
        set => SetArgument("arn", value);
    }

}

/// <summary>
/// Block type for r53_resource in AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlock.
/// Nesting mode: list
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetResourcesBlockDnsTargetResourceBlockTargetResourceBlockR53ResourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "r53_resource";

    /// <summary>
    /// The domain_name attribute.
    /// </summary>
    public TerraformValue<string>? DomainName
    {
        get => GetArgument<TerraformValue<string>>("domain_name");
        set => SetArgument("domain_name", value);
    }

    /// <summary>
    /// The record_set_id attribute.
    /// </summary>
    public TerraformValue<string>? RecordSetId
    {
        get => GetArgument<TerraformValue<string>>("record_set_id");
        set => SetArgument("record_set_id", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsRoute53recoveryreadinessResourceSet.
/// Nesting mode: single
/// </summary>
public class AwsRoute53recoveryreadinessResourceSetTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

}


/// <summary>
/// Represents a aws_route53recoveryreadiness_resource_set Terraform resource.
/// Manages a aws_route53recoveryreadiness_resource_set resource.
/// </summary>
public partial class AwsRoute53recoveryreadinessResourceSet(string name) : TerraformResource("aws_route53recoveryreadiness_resource_set", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The resource_set_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetName is required")]
    public required TerraformValue<string> ResourceSetName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_set_name");
        set => SetArgument("resource_set_name", value);
    }

    /// <summary>
    /// The resource_set_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceSetType is required")]
    public required TerraformValue<string> ResourceSetType
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_set_type");
        set => SetArgument("resource_set_type", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? AsReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Resources block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Resources is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Resources block(s) required")]
    public required TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlock> Resources
    {
        get => GetRequiredArgument<TerraformList<AwsRoute53recoveryreadinessResourceSetResourcesBlock>>("resources");
        set => SetArgument("resources", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsRoute53recoveryreadinessResourceSetTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsRoute53recoveryreadinessResourceSetTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
