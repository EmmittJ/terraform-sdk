using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ides in AwsCodecatalystDevEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentIdesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "ides";

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformValue<string>? Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformValue<string>? Runtime
    {
        get => new TerraformReference<string>(this, "runtime");
        set => SetArgument("runtime", value);
    }

}


/// <summary>
/// Block type for persistent_storage in AwsCodecatalystDevEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentPersistentStorageBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "persistent_storage";

    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformValue<double> Size
    {
        get => new TerraformReference<double>(this, "size");
        set => SetArgument("size", value);
    }

}


/// <summary>
/// Block type for repositories in AwsCodecatalystDevEnvironment.
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentRepositoriesBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "repositories";

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    public TerraformValue<string>? BranchName
    {
        get => new TerraformReference<string>(this, "branch_name");
        set => SetArgument("branch_name", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

}


/// <summary>
/// Block type for timeouts in AwsCodecatalystDevEnvironment.
/// Nesting mode: single
/// </summary>
public class AwsCodecatalystDevEnvironmentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Represents a aws_codecatalyst_dev_environment Terraform resource.
/// Manages a aws_codecatalyst_dev_environment resource.
/// </summary>
public partial class AwsCodecatalystDevEnvironment(string name) : TerraformResource("aws_codecatalyst_dev_environment", name)
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
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public TerraformValue<double>? InactivityTimeoutMinutes
    {
        get => new TerraformReference<double>(this, "inactivity_timeout_minutes");
        set => SetArgument("inactivity_timeout_minutes", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformValue<string> InstanceType
    {
        get => new TerraformReference<string>(this, "instance_type");
        set => SetArgument("instance_type", value);
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
    /// Ides block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ides is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ides block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ides block(s) allowed")]
    public required TerraformList<AwsCodecatalystDevEnvironmentIdesBlock> Ides
    {
        get => GetRequiredArgument<TerraformList<AwsCodecatalystDevEnvironmentIdesBlock>>("ides");
        set => SetArgument("ides", value);
    }

    /// <summary>
    /// PersistentStorage block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentStorage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PersistentStorage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentStorage block(s) allowed")]
    public required TerraformList<AwsCodecatalystDevEnvironmentPersistentStorageBlock> PersistentStorage
    {
        get => GetRequiredArgument<TerraformList<AwsCodecatalystDevEnvironmentPersistentStorageBlock>>("persistent_storage");
        set => SetArgument("persistent_storage", value);
    }

    /// <summary>
    /// Repositories block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    public TerraformList<AwsCodecatalystDevEnvironmentRepositoriesBlock>? Repositories
    {
        get => GetArgument<TerraformList<AwsCodecatalystDevEnvironmentRepositoriesBlock>>("repositories");
        set => SetArgument("repositories", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AwsCodecatalystDevEnvironmentTimeoutsBlock? Timeouts
    {
        get => GetArgument<AwsCodecatalystDevEnvironmentTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
