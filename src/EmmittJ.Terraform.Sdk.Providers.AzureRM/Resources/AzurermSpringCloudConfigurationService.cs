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
        get => GetProperty<TerraformProperty<string>>("ca_certificate_id");
        set => WithProperty("ca_certificate_id", value);
    }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    public TerraformProperty<string>? HostKey
    {
        get => GetProperty<TerraformProperty<string>>("host_key");
        set => WithProperty("host_key", value);
    }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    public TerraformProperty<string>? HostKeyAlgorithm
    {
        get => GetProperty<TerraformProperty<string>>("host_key_algorithm");
        set => WithProperty("host_key_algorithm", value);
    }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Label is required")]
    public required TerraformProperty<string> Label
    {
        get => GetProperty<TerraformProperty<string>>("label");
        set => WithProperty("label", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The password attribute.
    /// </summary>
    public TerraformProperty<string>? Password
    {
        get => GetProperty<TerraformProperty<string>>("password");
        set => WithProperty("password", value);
    }

    /// <summary>
    /// The patterns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Patterns is required")]
    public HashSet<TerraformProperty<string>>? Patterns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("patterns");
        set => WithProperty("patterns", value);
    }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateKey
    {
        get => GetProperty<TerraformProperty<string>>("private_key");
        set => WithProperty("private_key", value);
    }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SearchPaths
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("search_paths");
        set => WithProperty("search_paths", value);
    }

    /// <summary>
    /// The strict_host_key_checking attribute.
    /// </summary>
    public TerraformProperty<bool>? StrictHostKeyChecking
    {
        get => GetProperty<TerraformProperty<bool>>("strict_host_key_checking");
        set => WithProperty("strict_host_key_checking", value);
    }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    public required TerraformProperty<string> Uri
    {
        get => GetProperty<TerraformProperty<string>>("uri");
        set => WithProperty("uri", value);
    }

    /// <summary>
    /// The username attribute.
    /// </summary>
    public TerraformProperty<string>? Username
    {
        get => GetProperty<TerraformProperty<string>>("username");
        set => WithProperty("username", value);
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
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    public TerraformProperty<string>? Generation
    {
        get => GetProperty<TerraformProperty<string>>("generation");
        set => this.WithProperty("generation", value);
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
    /// The refresh_interval_in_seconds attribute.
    /// </summary>
    public TerraformProperty<double>? RefreshIntervalInSeconds
    {
        get => GetProperty<TerraformProperty<double>>("refresh_interval_in_seconds");
        set => this.WithProperty("refresh_interval_in_seconds", value);
    }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    public required TerraformProperty<string> SpringCloudServiceId
    {
        get => GetProperty<TerraformProperty<string>>("spring_cloud_service_id");
        set => this.WithProperty("spring_cloud_service_id", value);
    }

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    public List<AzurermSpringCloudConfigurationServiceRepositoryBlock>? Repository
    {
        get => GetProperty<List<AzurermSpringCloudConfigurationServiceRepositoryBlock>>("repository");
        set => this.WithProperty("repository", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSpringCloudConfigurationServiceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSpringCloudConfigurationServiceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

}
