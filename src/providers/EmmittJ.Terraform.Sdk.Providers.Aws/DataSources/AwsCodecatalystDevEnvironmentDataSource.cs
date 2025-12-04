using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for repositories in AwsCodecatalystDevEnvironmentDataSource.
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repositories";

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    public TerraformValue<string> BranchName
        => AsReference("branch_name");

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    public TerraformValue<string> RepositoryName
        => AsReference("repository_name");

}


/// <summary>
/// Represents a aws_codecatalyst_dev_environment Terraform data source.
/// Retrieves information about a aws_codecatalyst_dev_environment.
/// </summary>
public partial class AwsCodecatalystDevEnvironmentDataSource(string name) : TerraformDataSource("aws_codecatalyst_dev_environment", name)
{
    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformValue<string>? Alias
    {
        get => GetArgument<TerraformValue<string>>("alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// The creator_id attribute.
    /// </summary>
    public TerraformValue<string>? CreatorId
    {
        get => GetArgument<TerraformValue<string>>("creator_id");
        set => SetArgument("creator_id", value);
    }

    /// <summary>
    /// The env_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformValue<string> EnvId
    {
        get => GetRequiredArgument<TerraformValue<string>>("env_id");
        set => SetArgument("env_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformValue<string> ProjectName
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_name");
        set => SetArgument("project_name", value);
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
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    public required TerraformValue<string> SpaceName
    {
        get => GetRequiredArgument<TerraformValue<string>>("space_name");
        set => SetArgument("space_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => GetArgument<TerraformMap<string>>("tags") ?? AsReference("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ides attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ides
        => AsReference("ides");

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double> InactivityTimeoutMinutes
        => AsReference("inactivity_timeout_minutes");

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
        => AsReference("instance_type");

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
        => AsReference("last_updated_time");

    /// <summary>
    /// The persistent_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PersistentStorage
        => AsReference("persistent_storage");

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
        => AsReference("status");

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
        => AsReference("status_reason");

    /// <summary>
    /// Repositories block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    public TerraformList<AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock>? Repositories
    {
        get => GetArgument<TerraformList<AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock>>("repositories");
        set => SetArgument("repositories", value);
    }

}
