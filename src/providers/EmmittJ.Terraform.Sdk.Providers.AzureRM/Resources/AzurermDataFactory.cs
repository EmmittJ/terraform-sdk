using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for github_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryGithubConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformProperty("branch_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The git_url attribute.
    /// </summary>
    [TerraformProperty("git_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GitUrl { get; set; }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    [TerraformProperty("publishing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublishingEnabled { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformProperty("root_folder")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RootFolder { get; set; }

}

/// <summary>
/// Block type for global_parameter in .
/// Nesting mode: set
/// </summary>
public partial class AzurermDataFactoryGlobalParameterBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformProperty("value")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermDataFactoryTimeoutsBlock : TerraformBlockBase
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
/// Block type for vsts_configuration in .
/// Nesting mode: list
/// </summary>
public partial class AzurermDataFactoryVstsConfigurationBlock : TerraformBlockBase
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformProperty("branch_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformProperty("project_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectName { get; set; }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    [TerraformProperty("publishing_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublishingEnabled { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformProperty("root_folder")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RootFolder { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformProperty("tenant_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> TenantId { get; set; }

}

/// <summary>
/// Manages a azurerm_data_factory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermDataFactory : TerraformResource
{
    public AzurermDataFactory(string name) : base("azurerm_data_factory", name)
    {
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CustomerManagedKeyId { get; set; }

    /// <summary>
    /// The customer_managed_key_identity_id attribute.
    /// </summary>
    [TerraformProperty("customer_managed_key_identity_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> CustomerManagedKeyIdentityId { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    [TerraformProperty("managed_virtual_network_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkEnabled { get; set; }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    [TerraformProperty("purview_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PurviewId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for github_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfiguration block(s) allowed")]
    [TerraformProperty("github_configuration")]
    public partial TerraformList<TerraformBlock<AzurermDataFactoryGithubConfigurationBlock>>? GithubConfiguration { get; set; }

    /// <summary>
    /// Block for global_parameter.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("global_parameter")]
    public partial TerraformSet<TerraformBlock<AzurermDataFactoryGlobalParameterBlock>>? GlobalParameter { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public partial TerraformList<TerraformBlock<AzurermDataFactoryIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermDataFactoryTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for vsts_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VstsConfiguration block(s) allowed")]
    [TerraformProperty("vsts_configuration")]
    public partial TerraformList<TerraformBlock<AzurermDataFactoryVstsConfigurationBlock>>? VstsConfiguration { get; set; }

}
