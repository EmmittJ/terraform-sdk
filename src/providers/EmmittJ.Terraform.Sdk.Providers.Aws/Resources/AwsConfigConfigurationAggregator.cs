using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for account_aggregation_source in AwsConfigConfigurationAggregator.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationAggregatorAccountAggregationSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "account_aggregation_source";

    /// <summary>
    /// The account_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountIds is required")]
    public TerraformList<string>? AccountIds
    {
        get => GetArgument<TerraformList<string>>("account_ids");
        set => SetArgument("account_ids", value);
    }

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformValue<bool>? AllRegions
    {
        get => GetArgument<TerraformValue<bool>>("all_regions");
        set => SetArgument("all_regions", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformList<string>? Regions
    {
        get => GetArgument<TerraformList<string>>("regions");
        set => SetArgument("regions", value);
    }

}


/// <summary>
/// Block type for organization_aggregation_source in AwsConfigConfigurationAggregator.
/// Nesting mode: list
/// </summary>
public class AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "organization_aggregation_source";

    /// <summary>
    /// The all_regions attribute.
    /// </summary>
    public TerraformValue<bool>? AllRegions
    {
        get => GetArgument<TerraformValue<bool>>("all_regions");
        set => SetArgument("all_regions", value);
    }

    /// <summary>
    /// The regions attribute.
    /// </summary>
    public TerraformList<string>? Regions
    {
        get => GetArgument<TerraformList<string>>("regions");
        set => SetArgument("regions", value);
    }

    /// <summary>
    /// The role_arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RoleArn is required")]
    public required TerraformValue<string> RoleArn
    {
        get => GetRequiredArgument<TerraformValue<string>>("role_arn");
        set => SetArgument("role_arn", value);
    }

}


/// <summary>
/// Represents a aws_config_configuration_aggregator Terraform resource.
/// Manages a aws_config_configuration_aggregator resource.
/// </summary>
public partial class AwsConfigConfigurationAggregator(string name) : TerraformResource("aws_config_configuration_aggregator", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? CreateReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? CreateReference("region");
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
    /// The tags_all attribute.
    /// </summary>
    public TerraformMap<string> TagsAll
    {
        get => GetArgument<TerraformMap<string>>("tags_all") ?? CreateReference("tags_all");
        set => SetArgument("tags_all", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformValue<string> Arn
        => CreateReference("arn");

    /// <summary>
    /// AccountAggregationSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AccountAggregationSource block(s) allowed")]
    public TerraformList<AwsConfigConfigurationAggregatorAccountAggregationSourceBlock>? AccountAggregationSource
    {
        get => GetArgument<TerraformList<AwsConfigConfigurationAggregatorAccountAggregationSourceBlock>>("account_aggregation_source");
        set => SetArgument("account_aggregation_source", value);
    }

    /// <summary>
    /// OrganizationAggregationSource block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OrganizationAggregationSource block(s) allowed")]
    public TerraformList<AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock>? OrganizationAggregationSource
    {
        get => GetArgument<TerraformList<AwsConfigConfigurationAggregatorOrganizationAggregationSourceBlock>>("organization_aggregation_source");
        set => SetArgument("organization_aggregation_source", value);
    }

}
