using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for ides in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentIdesBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The runtime attribute.
    /// </summary>
    public TerraformProperty<string>? Runtime
    {
        set => SetProperty("runtime", value);
    }

}

/// <summary>
/// Block type for persistent_storage in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentPersistentStorageBlock : TerraformBlock
{
    /// <summary>
    /// The size attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Size is required")]
    public required TerraformProperty<double> Size
    {
        set => SetProperty("size", value);
    }

}

/// <summary>
/// Block type for repositories in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentRepositoriesBlock : TerraformBlock
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    public TerraformProperty<string>? BranchName
    {
        set => SetProperty("branch_name", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        set => SetProperty("repository_name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsCodecatalystDevEnvironmentTimeoutsBlock : TerraformBlock
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
/// Manages a aws_codecatalyst_dev_environment resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodecatalystDevEnvironment : TerraformResource
{
    public AwsCodecatalystDevEnvironment(string name) : base("aws_codecatalyst_dev_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("alias");
        SetOutput("id");
        SetOutput("inactivity_timeout_minutes");
        SetOutput("instance_type");
        SetOutput("project_name");
        SetOutput("region");
        SetOutput("space_name");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformProperty<string> Alias
    {
        get => GetRequiredOutput<TerraformProperty<string>>("alias");
        set => SetProperty("alias", value);
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
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public TerraformProperty<double> InactivityTimeoutMinutes
    {
        get => GetRequiredOutput<TerraformProperty<double>>("inactivity_timeout_minutes");
        set => SetProperty("inactivity_timeout_minutes", value);
    }

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceType is required")]
    public required TerraformProperty<string> InstanceType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_type");
        set => SetProperty("instance_type", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("project_name");
        set => SetProperty("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    public required TerraformProperty<string> SpaceName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("space_name");
        set => SetProperty("space_name", value);
    }

    /// <summary>
    /// Block for ides.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Ides is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 Ides block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Ides block(s) allowed")]
    public List<AwsCodecatalystDevEnvironmentIdesBlock>? Ides
    {
        set => SetProperty("ides", value);
    }

    /// <summary>
    /// Block for persistent_storage.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PersistentStorage is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 PersistentStorage block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 PersistentStorage block(s) allowed")]
    public List<AwsCodecatalystDevEnvironmentPersistentStorageBlock>? PersistentStorage
    {
        set => SetProperty("persistent_storage", value);
    }

    /// <summary>
    /// Block for repositories.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    public List<AwsCodecatalystDevEnvironmentRepositoriesBlock>? Repositories
    {
        set => SetProperty("repositories", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsCodecatalystDevEnvironmentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
