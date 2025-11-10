using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for git_repository in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// The branch attribute.
    /// </summary>
    public TerraformProperty<string>? Branch
    {
        get => GetProperty<TerraformProperty<string>>("branch");
        set => WithProperty("branch", value);
    }

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificateId
    {
        get => GetProperty<TerraformProperty<string>>("ca_certificate_id");
        set => WithProperty("ca_certificate_id", value);
    }

    /// <summary>
    /// The commit attribute.
    /// </summary>
    public TerraformProperty<string>? Commit
    {
        get => GetProperty<TerraformProperty<string>>("commit");
        set => WithProperty("commit", value);
    }

    /// <summary>
    /// The git_tag attribute.
    /// </summary>
    public TerraformProperty<string>? GitTag
    {
        get => GetProperty<TerraformProperty<string>>("git_tag");
        set => WithProperty("git_tag", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("interval_in_seconds");
        set => WithProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        get => GetProperty<TerraformProperty<string>>("path");
        set => WithProperty("path", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        get => GetProperty<TerraformProperty<string>>("url");
        set => WithProperty("url", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        get => GetProperty<TerraformProperty<string>>("delete");
        set => WithProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        get => GetProperty<TerraformProperty<string>>("update");
        set => WithProperty("update", value);
    }

}

/// <summary>
/// Manages a azurerm_spring_cloud_customized_accelerator resource.
/// </summary>
public class AzurermSpringCloudCustomizedAccelerator : TerraformResource
{
    public AzurermSpringCloudCustomizedAccelerator(string name) : base("azurerm_spring_cloud_customized_accelerator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The accelerator_tags attribute.
    /// </summary>
    public List<TerraformProperty<string>>? AcceleratorTags
    {
        get => GetProperty<List<TerraformProperty<string>>>("accelerator_tags");
        set => this.WithProperty("accelerator_tags", value);
    }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformProperty<string>? AcceleratorType
    {
        get => GetProperty<TerraformProperty<string>>("accelerator_type");
        set => this.WithProperty("accelerator_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string>? DisplayName
    {
        get => GetProperty<TerraformProperty<string>>("display_name");
        set => this.WithProperty("display_name", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public TerraformProperty<string>? IconUrl
    {
        get => GetProperty<TerraformProperty<string>>("icon_url");
        set => this.WithProperty("icon_url", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAcceleratorId is required")]
    public required TerraformProperty<string> SpringCloudAcceleratorId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_accelerator_id");
        set => this.WithProperty("spring_cloud_accelerator_id", value);
    }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    public List<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock>? GitRepository
    {
        get => GetProperty<List<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock>>("git_repository");
        set => this.WithProperty("git_repository", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
