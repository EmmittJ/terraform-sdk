using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for rule in AwsEcrRegistryScanningConfiguration.
/// Nesting mode: set
/// </summary>
public class AwsEcrRegistryScanningConfigurationRuleBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "rule";

    /// <summary>
    /// The scan_frequency attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanFrequency is required")]
    public required TerraformValue<string> ScanFrequency
    {
        get => GetRequiredArgument<TerraformValue<string>>("scan_frequency");
        set => SetArgument("scan_frequency", value);
    }

    /// <summary>
    /// RepositoryFilter block (nesting mode: set).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryFilter is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 RepositoryFilter block(s) required")]
    public required TerraformSet<AwsEcrRegistryScanningConfigurationRuleBlockRepositoryFilterBlock> RepositoryFilter
    {
        get => GetRequiredArgument<TerraformSet<AwsEcrRegistryScanningConfigurationRuleBlockRepositoryFilterBlock>>("repository_filter");
        set => SetArgument("repository_filter", value);
    }

}

/// <summary>
/// Block type for repository_filter in AwsEcrRegistryScanningConfigurationRuleBlock.
/// Nesting mode: set
/// </summary>
public class AwsEcrRegistryScanningConfigurationRuleBlockRepositoryFilterBlock : TerraformBlock
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
        get => GetRequiredArgument<TerraformValue<string>>("filter");
        set => SetArgument("filter", value);
    }

    /// <summary>
    /// The filter_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "FilterType is required")]
    public required TerraformValue<string> FilterType
    {
        get => GetRequiredArgument<TerraformValue<string>>("filter_type");
        set => SetArgument("filter_type", value);
    }

}


/// <summary>
/// Represents a aws_ecr_registry_scanning_configuration Terraform resource.
/// Manages a aws_ecr_registry_scanning_configuration resource.
/// </summary>
public partial class AwsEcrRegistryScanningConfiguration(string name) : TerraformResource("aws_ecr_registry_scanning_configuration", name)
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformValue<string> Region
    {
        get => GetArgument<TerraformValue<string>>("region") ?? AsReference("region");
        set => SetArgument("region", value);
    }

    /// <summary>
    /// The scan_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ScanType is required")]
    public required TerraformValue<string> ScanType
    {
        get => GetRequiredArgument<TerraformValue<string>>("scan_type");
        set => SetArgument("scan_type", value);
    }

    /// <summary>
    /// The registry_id attribute.
    /// </summary>
    public TerraformValue<string> RegistryId
        => AsReference("registry_id");

    /// <summary>
    /// Rule block (nesting mode: set).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Rule block(s) allowed")]
    public TerraformSet<AwsEcrRegistryScanningConfigurationRuleBlock>? Rule
    {
        get => GetArgument<TerraformSet<AwsEcrRegistryScanningConfigurationRuleBlock>>("rule");
        set => SetArgument("rule", value);
    }

}
