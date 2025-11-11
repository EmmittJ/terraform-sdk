using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceDeploymentScriptAzurePowerShellContainerBlock : TerraformBlockBase
{
    /// <summary>
    /// The container_group_name attribute.
    /// </summary>
    [TerraformProperty("container_group_name")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ContainerGroupName { get; set; }

}

/// <summary>
/// Block type for environment_variable in .
/// Nesting mode: set
/// </summary>
public partial class AzurermResourceDeploymentScriptAzurePowerShellEnvironmentVariableBlock : TerraformBlockBase
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The secure_value attribute.
    /// </summary>
    [TerraformProperty("secure_value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? SecureValue { get; set; }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [TerraformProperty("value")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Value { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceDeploymentScriptAzurePowerShellIdentityBlock : TerraformBlockBase
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    [TerraformProperty("identity_ids")]
    // Required argument - source generator will implement get/set
    public required TerraformSet<string> IdentityIds { get; set; }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: list
/// </summary>
public partial class AzurermResourceDeploymentScriptAzurePowerShellStorageAccountBlock : TerraformBlockBase
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    [TerraformProperty("key")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Key { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermResourceDeploymentScriptAzurePowerShellTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_resource_deployment_script_azure_power_shell resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermResourceDeploymentScriptAzurePowerShell : TerraformResource
{
    public AzurermResourceDeploymentScriptAzurePowerShell(string name) : base("azurerm_resource_deployment_script_azure_power_shell", name)
    {
    }

    /// <summary>
    /// The cleanup_preference attribute.
    /// </summary>
    [TerraformProperty("cleanup_preference")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CleanupPreference { get; set; }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    [TerraformProperty("command_line")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? CommandLine { get; set; }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    [TerraformProperty("force_update_tag")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ForceUpdateTag { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The primary_script_uri attribute.
    /// </summary>
    [TerraformProperty("primary_script_uri")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? PrimaryScriptUri { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInterval is required")]
    [TerraformProperty("retention_interval")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> RetentionInterval { get; set; }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    [TerraformProperty("script_content")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? ScriptContent { get; set; }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    [TerraformProperty("supporting_script_uris")]
    // Optional argument - source generator will implement get/set
    public TerraformList<string>? SupportingScriptUris { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    [TerraformProperty("timeout")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Timeout { get; set; }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    [TerraformProperty("version")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> Version { get; set; }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Container block(s) allowed")]
    [TerraformProperty("container")]
    public TerraformList<TerraformBlock<AzurermResourceDeploymentScriptAzurePowerShellContainerBlock>>? Container { get; set; }

    /// <summary>
    /// Block for environment_variable.
    /// Nesting mode: set
    /// </summary>
    [TerraformProperty("environment_variable")]
    public TerraformSet<TerraformBlock<AzurermResourceDeploymentScriptAzurePowerShellEnvironmentVariableBlock>>? EnvironmentVariable { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<TerraformBlock<AzurermResourceDeploymentScriptAzurePowerShellIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccount block(s) allowed")]
    [TerraformProperty("storage_account")]
    public TerraformList<TerraformBlock<AzurermResourceDeploymentScriptAzurePowerShellStorageAccountBlock>>? StorageAccount { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermResourceDeploymentScriptAzurePowerShellTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    [TerraformProperty("outputs")]
    // Output-only attribute - source generator will implement read-only get
    public TerraformValue<string> Outputs { get; }

}
