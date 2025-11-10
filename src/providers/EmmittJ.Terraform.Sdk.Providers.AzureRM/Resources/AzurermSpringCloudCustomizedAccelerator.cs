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
        set => SetProperty("branch", value);
    }

    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificateId
    {
        set => SetProperty("ca_certificate_id", value);
    }

    /// <summary>
    /// The commit attribute.
    /// </summary>
    public TerraformProperty<string>? Commit
    {
        set => SetProperty("commit", value);
    }

    /// <summary>
    /// The git_tag attribute.
    /// </summary>
    public TerraformProperty<string>? GitTag
    {
        set => SetProperty("git_tag", value);
    }

    /// <summary>
    /// The interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? IntervalInSeconds
    {
        set => SetProperty("interval_in_seconds", value);
    }

    /// <summary>
    /// The path attribute.
    /// </summary>
    public TerraformProperty<string>? Path
    {
        set => SetProperty("path", value);
    }

    /// <summary>
    /// The url attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Url is required")]
    public required TerraformProperty<string> Url
    {
        set => SetProperty("url", value);
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
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
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
/// Manages a azurerm_spring_cloud_customized_accelerator resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSpringCloudCustomizedAccelerator : TerraformResource
{
    public AzurermSpringCloudCustomizedAccelerator(string name) : base("azurerm_spring_cloud_customized_accelerator", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("accelerator_tags");
        SetOutput("accelerator_type");
        SetOutput("description");
        SetOutput("display_name");
        SetOutput("icon_url");
        SetOutput("id");
        SetOutput("name");
        SetOutput("spring_cloud_accelerator_id");
    }

    /// <summary>
    /// The accelerator_tags attribute.
    /// </summary>
    public List<TerraformProperty<string>> AcceleratorTags
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("accelerator_tags");
        set => SetProperty("accelerator_tags", value);
    }

    /// <summary>
    /// The accelerator_type attribute.
    /// </summary>
    public TerraformProperty<string> AcceleratorType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("accelerator_type");
        set => SetProperty("accelerator_type", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The display_name attribute.
    /// </summary>
    public TerraformProperty<string> DisplayName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("display_name");
        set => SetProperty("display_name", value);
    }

    /// <summary>
    /// The icon_url attribute.
    /// </summary>
    public TerraformProperty<string> IconUrl
    {
        get => GetRequiredOutput<TerraformProperty<string>>("icon_url");
        set => SetProperty("icon_url", value);
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The spring_cloud_accelerator_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudAcceleratorId is required")]
    public required TerraformProperty<string> SpringCloudAcceleratorId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_accelerator_id");
        set => SetProperty("spring_cloud_accelerator_id", value);
    }

    /// <summary>
    /// Block for git_repository.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "GitRepository is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 GitRepository block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GitRepository block(s) allowed")]
    public List<AzurermSpringCloudCustomizedAcceleratorGitRepositoryBlock>? GitRepository
    {
        set => SetProperty("git_repository", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudCustomizedAcceleratorTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
