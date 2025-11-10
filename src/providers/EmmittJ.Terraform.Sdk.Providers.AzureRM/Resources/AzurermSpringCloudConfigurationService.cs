using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for repository in .
/// Nesting mode: list
/// </summary>
public class AzurermSpringCloudConfigurationServiceRepositoryBlock : TerraformBlock
{
    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    public TerraformProperty<string>? CaCertificateId
    {
        set => SetProperty("ca_certificate_id", value);
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformProperty<string>? HostKey
    {
        set => SetProperty("host_key", value);
    }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? HostKeyAlgorithm
    {
        set => SetProperty("host_key_algorithm", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Label is required")]
    public required TerraformProperty<string> Label
    {
        set => SetProperty("label", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        set => SetProperty("password", value);
    }

    /// <summary>
    /// The patterns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Patterns is required")]
    public HashSet<TerraformProperty<string>>? Patterns
    {
        set => SetProperty("patterns", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKey
    {
        set => SetProperty("private_key", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SearchPaths
    {
        set => SetProperty("search_paths", value);
    }

    /// <summary>
    /// The strict_host_key_checking attribute.
    /// </summary>
    public TerraformProperty<bool>? StrictHostKeyChecking
    {
        set => SetProperty("strict_host_key_checking", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        set => SetProperty("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        set => SetProperty("username", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSpringCloudConfigurationServiceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_spring_cloud_configuration_service resource.
/// </summary>
public class AzurermSpringCloudConfigurationService : TerraformResource
{
    public AzurermSpringCloudConfigurationService(string name) : base("azurerm_spring_cloud_configuration_service", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("generation");
        SetOutput("id");
        SetOutput("name");
        SetOutput("refresh_interval_in_seconds");
        SetOutput("spring_cloud_service_id");
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformProperty<string> Generation
    {
        get => GetRequiredOutput<TerraformProperty<string>>("generation");
        set => SetProperty("generation", value);
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
    /// The refresh_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double> RefreshIntervalInSeconds
    {
        get => GetRequiredOutput<TerraformProperty<double>>("refresh_interval_in_seconds");
        set => SetProperty("refresh_interval_in_seconds", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("spring_cloud_service_id");
        set => SetProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSpringCloudConfigurationServiceRepositoryBlock>? Repository
    {
        set => SetProperty("repository", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudConfigurationServiceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
