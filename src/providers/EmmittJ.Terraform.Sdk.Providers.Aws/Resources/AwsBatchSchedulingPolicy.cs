using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for fair_share_policy in AwsBatchSchedulingPolicy.
/// Nesting mode: list
/// </summary>
public class AwsBatchSchedulingPolicyFairSharePolicyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "fair_share_policy";

    /// <summary>
    /// The compute_reservation attribute.
    /// </summary>
    public TerraformValue<double>? ComputeReservation
    {
        get => new TerraformReference<double>(this, "compute_reservation");
        set => SetArgument("compute_reservation", value);
    }

    /// <summary>
    /// The share_decay_seconds attribute.
    /// </summary>
    public TerraformValue<double>? ShareDecaySeconds
    {
        get => new TerraformReference<double>(this, "share_decay_seconds");
        set => SetArgument("share_decay_seconds", value);
    }

    /// <summary>
    /// ShareDistribution block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(500, ErrorMessage = "Maximum 500 ShareDistribution block(s) allowed")]
    public TerraformSet<AwsBatchSchedulingPolicyFairSharePolicyBlockShareDistributionBlock>? ShareDistribution
    {
        get => GetArgument<TerraformSet<AwsBatchSchedulingPolicyFairSharePolicyBlockShareDistributionBlock>>("share_distribution");
        set => SetArgument("share_distribution", value);
    }

}

/// <summary>
/// Block type for share_distribution in AwsBatchSchedulingPolicyFairSharePolicyBlock.
/// Nesting mode: set
/// </summary>
public class AwsBatchSchedulingPolicyFairSharePolicyBlockShareDistributionBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "share_distribution";

    /// <summary>
    /// The share_identifier attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ShareIdentifier is required")]
    public required TerraformValue<string> ShareIdentifier
    {
        get => new TerraformReference<string>(this, "share_identifier");
        set => SetArgument("share_identifier", value);
    }

    /// <summary>
    /// The weight_factor attribute.
    /// </summary>
    public TerraformValue<double>? WeightFactor
    {
        get => new TerraformReference<double>(this, "weight_factor");
        set => SetArgument("weight_factor", value);
    }

}


/// <summary>
/// Represents a aws_batch_scheduling_policy Terraform resource.
/// Manages a aws_batch_scheduling_policy resource.
/// </summary>
public partial class AwsBatchSchedulingPolicy(string name) : TerraformResource("aws_batch_scheduling_policy", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags_all").ResolveNodes(ctx));
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
    {
        get => new TerraformReference<string>(this, "arn");
    }

    /// <summary>
    /// FairSharePolicy block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 FairSharePolicy block(s) allowed")]
    public TerraformList<AwsBatchSchedulingPolicyFairSharePolicyBlock>? FairSharePolicy
    {
        get => GetArgument<TerraformList<AwsBatchSchedulingPolicyFairSharePolicyBlock>>("fair_share_policy");
        set => SetArgument("fair_share_policy", value);
    }

}
