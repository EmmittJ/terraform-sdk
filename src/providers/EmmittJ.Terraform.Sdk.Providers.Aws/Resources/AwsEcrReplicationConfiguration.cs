using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for replication_configuration in AwsEcrReplicationConfiguration.
/// Nesting mode: list
/// </summary>
public class AwsEcrReplicationConfigurationReplicationConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "replication_configuration";

    /// <summary>
    /// Rule block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Rule is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Rule block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(10, ErrorMessage = "Maximum 10 Rule block(s) allowed")]
    public required TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlock> Rule
    {
        get => GetRequiredArgument<TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}

/// <summary>
/// Block type for rule in AwsEcrReplicationConfigurationReplicationConfigurationBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// Destination block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Destination is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Destination block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(25, ErrorMessage = "Maximum 25 Destination block(s) allowed")]
    public required TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlockDestinationBlock> Destination
    {
        get => GetRequiredArgument<TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlockDestinationBlock>>("destination");
        set => SetArgument("destination", value);
    }

    /// <summary>
    /// RepositoryFilter block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 RepositoryFilter block(s) allowed")]
    public TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlockRepositoryFilterBlock>? RepositoryFilter
    {
        get => GetArgument<TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlockRepositoryFilterBlock>>("repository_filter");
        set => SetArgument("repository_filter", value);
    }

}

/// <summary>
/// Block type for destination in AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlockDestinationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "destination";

    /// <summary>
    /// The region attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Region is required")]
    public required TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RegistryId is required")]
    public required TerraformValue<string> RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
        set => SetArgument("registry_id", value);
    }

}

/// <summary>
/// Block type for repository_filter in AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlock.
/// Nesting mode: list
/// </summary>
public class AwsEcrReplicationConfigurationReplicationConfigurationBlockRuleBlockRepositoryFilterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repository_filter";

    /// <summary>
    /// The filter attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Filter is required")]
    public required TerraformValue<string> Filter
    {
        get => new TerraformReference<string>(this, "filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformValue<string> FilterType
    {
        get => new TerraformReference<string>(this, "filter_type");
        set => SetArgument("filter_type", value);
    }

}


/// <summary>
/// Represents a aws_ecr_replication_configuration Terraform resource.
/// Manages a aws_ecr_replication_configuration resource.
/// </summary>
public partial class AwsEcrReplicationConfiguration(string name) : TerraformResource("aws_ecr_replication_configuration", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => new TerraformReference<string>(this, "region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
    {
        get => new TerraformReference<string>(this, "registry_id");
    }

    /// <summary>
    /// ReplicationConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 ReplicationConfiguration block(s) allowed")]
    public TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlock>? ReplicationConfiguration
    {
        get => GetArgument<TerraformList<AwsEcrReplicationConfigurationReplicationConfigurationBlock>>("replication_configuration");
        set => SetArgument("replication_configuration", value);
    }

}
