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
    {
        get => new TerraformReference<string>(this, "branch_name");
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    public TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
    }

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
        get => new TerraformReference<string>(this, "alias");
        set => SetArgument("alias", value);
    }

    /// <summary>
    /// The creator_id attribute.
    /// </summary>
    public TerraformValue<string>? CreatorId
    {
        get => new TerraformReference<string>(this, "creator_id");
        set => SetArgument("creator_id", value);
    }

    /// <summary>
    /// The env_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformValue<string> EnvId
    {
        get => new TerraformReference<string>(this, "env_id");
        set => SetArgument("env_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformValue<string> ProjectName
    {
        get => new TerraformReference<string>(this, "project_name");
        set => SetArgument("project_name", value);
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
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    public required TerraformValue<string> SpaceName
    {
        get => new TerraformReference<string>(this, "space_name");
        set => SetArgument("space_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string> Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// The ides attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> Ides
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "ides").ResolveNodes(ctx));
    }

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double> InactivityTimeoutMinutes
    {
        get => new TerraformReference<double>(this, "inactivity_timeout_minutes");
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
    }

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformValue<string> LastUpdatedTime
    {
        get => new TerraformReference<string>(this, "last_updated_time");
    }

    /// <summary>
    /// The persistent_storage attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> PersistentStorage
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "persistent_storage").ResolveNodes(ctx));
    }

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformValue<string> Status
    {
        get => new TerraformReference<string>(this, "status");
    }

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformValue<string> StatusReason
    {
        get => new TerraformReference<string>(this, "status_reason");
    }

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
