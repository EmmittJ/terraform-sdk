using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for repositories in .
/// Nesting mode: list
/// </summary>
public class AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock : TerraformBlock
{
    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    public TerraformProperty<string>? BranchName
    {
        get => GetProperty<TerraformProperty<string>>("branch_name");
        set => WithProperty("branch_name", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    public TerraformProperty<string>? RepositoryName
    {
        get => GetProperty<TerraformProperty<string>>("repository_name");
        set => WithProperty("repository_name", value);
    }

}

/// <summary>
/// Retrieves information about a aws_codecatalyst_dev_environment.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsCodecatalystDevEnvironmentDataSource : TerraformDataSource
{
    public AwsCodecatalystDevEnvironmentDataSource(string name) : base("aws_codecatalyst_dev_environment", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("ides");
        this.DeclareOutput("inactivity_timeout_minutes");
        this.DeclareOutput("instance_type");
        this.DeclareOutput("last_updated_time");
        this.DeclareOutput("persistent_storage");
        this.DeclareOutput("status");
        this.DeclareOutput("status_reason");
    }

    /// <summary>
    /// The alias attribute.
    /// </summary>
    public TerraformProperty<string>? Alias
    {
        get => GetProperty<TerraformProperty<string>>("alias");
        set => this.WithProperty("alias", value);
    }

    /// <summary>
    /// The creator_id attribute.
    /// </summary>
    public TerraformProperty<string>? CreatorId
    {
        get => GetProperty<TerraformProperty<string>>("creator_id");
        set => this.WithProperty("creator_id", value);
    }

    /// <summary>
    /// The env_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EnvId is required")]
    public required TerraformProperty<string> EnvId
    {
        get => GetProperty<TerraformProperty<string>>("env_id");
        set => this.WithProperty("env_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetProperty<TerraformProperty<string>>("project_name");
        set => this.WithProperty("project_name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The space_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpaceName is required")]
    public required TerraformProperty<string> SpaceName
    {
        get => GetProperty<TerraformProperty<string>>("space_name");
        set => this.WithProperty("space_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for repositories.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(100, ErrorMessage = "Maximum 100 Repositories block(s) allowed")]
    public List<AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock>? Repositories
    {
        get => GetProperty<List<AwsCodecatalystDevEnvironmentDataSourceRepositoriesBlock>>("repositories");
        set => this.WithProperty("repositories", value);
    }

    /// <summary>
    /// The ides attribute.
    /// </summary>
    public TerraformExpression Ides => this["ides"];

    /// <summary>
    /// The inactivity_timeout_minutes attribute.
    /// </summary>
    public TerraformExpression InactivityTimeoutMinutes => this["inactivity_timeout_minutes"];

    /// <summary>
    /// The instance_type attribute.
    /// </summary>
    public TerraformExpression InstanceType => this["instance_type"];

    /// <summary>
    /// The last_updated_time attribute.
    /// </summary>
    public TerraformExpression LastUpdatedTime => this["last_updated_time"];

    /// <summary>
    /// The persistent_storage attribute.
    /// </summary>
    public TerraformExpression PersistentStorage => this["persistent_storage"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

    /// <summary>
    /// The status_reason attribute.
    /// </summary>
    public TerraformExpression StatusReason => this["status_reason"];

}
