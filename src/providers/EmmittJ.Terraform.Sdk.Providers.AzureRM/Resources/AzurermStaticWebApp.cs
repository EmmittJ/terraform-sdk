using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for basic_auth in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStaticWebAppBasicAuthBlock() : TerraformBlock("basic_auth")
{
    /// <summary>
    /// The environments attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Environments is required")]
    [TerraformProperty("environments")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Environments { get; set; }

    /// <summary>
    /// The password attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Password is required")]
    [TerraformProperty("password")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Password { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermStaticWebAppIdentityBlock() : TerraformBlock("identity")
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
public partial class AzurermStaticWebAppTimeoutsBlock() : TerraformBlock("timeouts")
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
/// Manages a azurerm_static_web_app resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermStaticWebApp : TerraformResource
{
    public AzurermStaticWebApp(string name) : base("azurerm_static_web_app", name)
    {
    }

    /// <summary>
    /// The app_settings attribute.
    /// </summary>
    [TerraformProperty("app_settings")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? AppSettings { get; set; }

    /// <summary>
    /// The configuration_file_changes_enabled attribute.
    /// </summary>
    [TerraformProperty("configuration_file_changes_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ConfigurationFileChangesEnabled { get; set; }

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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The preview_environments_enabled attribute.
    /// </summary>
    [TerraformProperty("preview_environments_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PreviewEnvironmentsEnabled { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The repository_branch attribute.
    /// </summary>
    [TerraformProperty("repository_branch")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RepositoryBranch { get; set; }

    /// <summary>
    /// The repository_token attribute.
    /// </summary>
    [TerraformProperty("repository_token")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RepositoryToken { get; set; }

    /// <summary>
    /// The repository_url attribute.
    /// </summary>
    [TerraformProperty("repository_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? RepositoryUrl { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sku_size attribute.
    /// </summary>
    [TerraformProperty("sku_size")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuSize { get; set; }

    /// <summary>
    /// The sku_tier attribute.
    /// </summary>
    [TerraformProperty("sku_tier")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SkuTier { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for basic_auth.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 BasicAuth block(s) allowed")]
    [TerraformProperty("basic_auth")]
    public TerraformList<AzurermStaticWebAppBasicAuthBlock> BasicAuth { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermStaticWebAppIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermStaticWebAppTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The api_key attribute.
    /// </summary>
    [TerraformProperty("api_key")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> ApiKey { get; }

    /// <summary>
    /// The default_host_name attribute.
    /// </summary>
    [TerraformProperty("default_host_name")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformValue<string> DefaultHostName { get; }

}
