using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for policy in AwsResiliencehubResiliencyPolicy.
/// Nesting mode: list
/// </summary>
public class AwsResiliencehubResiliencyPolicyPolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "policy";

    /// <summary>
    /// Az block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockAzBlock>? Az
    {
        get => GetArgument<TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockAzBlock>>("az");
        set => SetArgument("az", value);
    }

    /// <summary>
    /// Hardware block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockHardwareBlock>? Hardware
    {
        get => GetArgument<TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockHardwareBlock>>("hardware");
        set => SetArgument("hardware", value);
    }

    /// <summary>
    /// Region block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockRegionBlock>? Region
    {
        get => GetArgument<TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockRegionBlock>>("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// Software block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockSoftwareBlock>? Software
    {
        get => GetArgument<TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlockSoftwareBlock>>("software");
        set => SetArgument("software", value);
    }

}

/// <summary>
/// Block type for az in AwsResiliencehubResiliencyPolicyPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsResiliencehubResiliencyPolicyPolicyBlockAzBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "az";

    /// <summary>
    /// Recovery Point Objective (RPO) as a Go duration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rpo is required")]
    public required TerraformValue<string> Rpo
    {
        get => GetArgument<TerraformValue<string>>("rpo");
        set => SetArgument("rpo", value);
    }

    /// <summary>
    /// Recovery Time Objective (RTO) as a Go duration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rto is required")]
    public required TerraformValue<string> Rto
    {
        get => GetArgument<TerraformValue<string>>("rto");
        set => SetArgument("rto", value);
    }

}

/// <summary>
/// Block type for hardware in AwsResiliencehubResiliencyPolicyPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsResiliencehubResiliencyPolicyPolicyBlockHardwareBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "hardware";

    /// <summary>
    /// Recovery Point Objective (RPO) as a Go duration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rpo is required")]
    public required TerraformValue<string> Rpo
    {
        get => GetArgument<TerraformValue<string>>("rpo");
        set => SetArgument("rpo", value);
    }

    /// <summary>
    /// Recovery Time Objective (RTO) as a Go duration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rto is required")]
    public required TerraformValue<string> Rto
    {
        get => GetArgument<TerraformValue<string>>("rto");
        set => SetArgument("rto", value);
    }

}

/// <summary>
/// Block type for region in AwsResiliencehubResiliencyPolicyPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsResiliencehubResiliencyPolicyPolicyBlockRegionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "region";

    /// <summary>
    /// Recovery Point Objective (RPO) as a Go duration.
    /// </summary>
    public TerraformValue<string>? Rpo
    {
        get => GetArgument<TerraformValue<string>>("rpo");
        set => SetArgument("rpo", value);
    }

    /// <summary>
    /// Recovery Time Objective (RTO) as a Go duration.
    /// </summary>
    public TerraformValue<string>? Rto
    {
        get => GetArgument<TerraformValue<string>>("rto");
        set => SetArgument("rto", value);
    }

}

/// <summary>
/// Block type for software in AwsResiliencehubResiliencyPolicyPolicyBlock.
/// Nesting mode: list
/// </summary>
public class AwsResiliencehubResiliencyPolicyPolicyBlockSoftwareBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "software";

    /// <summary>
    /// Recovery Point Objective (RPO) as a Go duration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rpo is required")]
    public required TerraformValue<string> Rpo
    {
        get => GetArgument<TerraformValue<string>>("rpo");
        set => SetArgument("rpo", value);
    }

    /// <summary>
    /// Recovery Time Objective (RTO) as a Go duration.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rto is required")]
    public required TerraformValue<string> Rto
    {
        get => GetArgument<TerraformValue<string>>("rto");
        set => SetArgument("rto", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsResiliencehubResiliencyPolicy.
/// Nesting mode: single
/// </summary>
public class AwsResiliencehubResiliencyPolicyTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours). Setting a timeout for a Delete operation is only applicable if changes are saved into state before the destroy operation occurs.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// A string that can be [parsed as a duration](https://pkg.go.dev/time#ParseDuration) consisting of numbers and unit suffixes, such as &amp;quot;30s&amp;quot; or &amp;quot;2h45m&amp;quot;. Valid time units are &amp;quot;s&amp;quot; (seconds), &amp;quot;m&amp;quot; (minutes), &amp;quot;h&amp;quot; (hours).
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_resiliencehub_resiliency_policy Terraform resource.
/// Manages a aws_resiliencehub_resiliency_policy resource.
/// </summary>
public partial class AwsResiliencehubResiliencyPolicy(string name) : TerraformResource("aws_resiliencehub_resiliency_policy", name)
{
    /// <summary>
    /// Specifies a high-level geographical location constraint for where resilience policy data can be stored.
    /// </summary>
    public TerraformValue<string>? DataLocationConstraint
    {
        get => GetArgument<TerraformValue<string>>("data_location_constraint");
        set => SetArgument("data_location_constraint", value);
    }

    /// <summary>
    /// The description for the policy.
    /// </summary>
    public TerraformValue<string>? Description
    {
        get => GetArgument<TerraformValue<string>>("description");
        set => SetArgument("description", value);
    }

    /// <summary>
    /// The name of the policy.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string>? Region
    {
        get => GetArgument<TerraformValue<string>>("region");
        set => SetArgument("region", value);
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
    /// The tier for the resiliency policy, ranging from the highest severity (MissionCritical) to lowest (NonCritical).
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Tier is required")]
    public required TerraformValue<string> Tier
    {
        get => GetArgument<TerraformValue<string>>("tier");
        set => SetArgument("tier", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => AsReference("arn");

    /// <summary>
    /// Specifies the estimated cost tier of the resiliency policy.
    /// </summary>
    public TerraformValue<string> EstimatedCostTier
        => AsReference("estimated_cost_tier");

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
        => AsReference("tags_all");

    /// <summary>
    /// Policy block (nesting mode: list).
    /// </summary>
    public TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlock>? Policy
    {
        get => GetArgument<TerraformList<AwsResiliencehubResiliencyPolicyPolicyBlock>>("policy");
        set => SetArgument("policy", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsResiliencehubResiliencyPolicyTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsResiliencehubResiliencyPolicyTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
