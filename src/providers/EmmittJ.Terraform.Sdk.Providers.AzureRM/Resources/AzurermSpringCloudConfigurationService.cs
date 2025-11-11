using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for repository in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSpringCloudConfigurationServiceRepositoryBlock : TerraformBlockBase
{
    /// <summary>
    /// The ca_certificate_id attribute.
    /// </summary>
    [TerraformProperty("ca_certificate_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? CaCertificateId { get; set; }

    /// <summary>
    /// The host_key attribute.
    /// </summary>
    [TerraformProperty("host_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostKey { get; set; }

    /// <summary>
    /// The host_key_algorithm attribute.
    /// </summary>
    [TerraformProperty("host_key_algorithm")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? HostKeyAlgorithm { get; set; }

    /// <summary>
    /// The label attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Label is required")]
    [TerraformProperty("label")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Label { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [TerraformProperty("password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Password { get; set; }

    /// <summary>
    /// The patterns attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Patterns is required")]
    [TerraformProperty("patterns")]
    // Required argument - source generator will implement get/set
    public required partial TerraformSet<string> Patterns { get; set; }

    /// <summary>
    /// The private_key attribute.
    /// </summary>
    [TerraformProperty("private_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PrivateKey { get; set; }

    /// <summary>
    /// The search_paths attribute.
    /// </summary>
    [TerraformProperty("search_paths")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? SearchPaths { get; set; }

    /// <summary>
    /// The strict_host_key_checking attribute.
    /// </summary>
    [TerraformProperty("strict_host_key_checking")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? StrictHostKeyChecking { get; set; }

    /// <summary>
    /// The uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Uri is required")]
    [TerraformProperty("uri")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Uri { get; set; }

    /// <summary>
    /// The username attribute.
    /// </summary>
    [TerraformProperty("username")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Username { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSpringCloudConfigurationServiceTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_spring_cloud_configuration_service resource.
/// </summary>
public partial class AzurermSpringCloudConfigurationService : TerraformResource
{
    public AzurermSpringCloudConfigurationService(string name) : base("azurerm_spring_cloud_configuration_service", name)
    {
    }

    /// <summary>
    /// The generation attribute.
    /// </summary>
    [TerraformProperty("generation")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Generation { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The refresh_interval_in_seconds attribute.
    /// </summary>
    [TerraformProperty("refresh_interval_in_seconds")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<double>? RefreshIntervalInSeconds { get; set; }

    /// <summary>
    /// The spring_cloud_service_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SpringCloudServiceId is required")]
    [TerraformProperty("spring_cloud_service_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SpringCloudServiceId { get; set; }

    /// <summary>
    /// Block for repository.
    /// Nesting mode: list
    /// </summary>
    [TerraformProperty("repository")]
    public partial TerraformList<TerraformBlock<AzurermSpringCloudConfigurationServiceRepositoryBlock>>? Repository { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermSpringCloudConfigurationServiceTimeoutsBlock>? Timeouts { get; set; }

}
