using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for container in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliContainerBlock : TerraformBlock
{
    /// <summary>
    /// The container_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ContainerGroupName
    {
        set => SetProperty("container_group_name", value);
    }

}

/// <summary>
/// Block type for environment_variable in .
/// Nesting mode: set
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliEnvironmentVariableBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The secure_value attribute.
    /// </summary>
    public TerraformProperty<string>? SecureValue
    {
        set => SetProperty("secure_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        set => SetProperty("value", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IdentityIds is required")]
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

}

/// <summary>
/// Block type for storage_account in .
/// Nesting mode: list
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliStorageAccountBlock : TerraformBlock
{
    /// <summary>
    /// The key attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Key is required")]
    public required TerraformProperty<string> Key
    {
        set => SetProperty("key", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        set => SetProperty("name", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceDeploymentScriptAzureCliTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_resource_deployment_script_azure_cli resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermResourceDeploymentScriptAzureCli : TerraformResource
{
    public AzurermResourceDeploymentScriptAzureCli(string name) : base("azurerm_resource_deployment_script_azure_cli", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("outputs");
        SetOutput("cleanup_preference");
        SetOutput("command_line");
        SetOutput("force_update_tag");
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("primary_script_uri");
        SetOutput("resource_group_name");
        SetOutput("retention_interval");
        SetOutput("script_content");
        SetOutput("supporting_script_uris");
        SetOutput("tags");
        SetOutput("timeout");
        SetOutput("version");
    }

    /// <summary>
    /// The cleanup_preference attribute.
    /// </summary>
    public TerraformProperty<string> CleanupPreference
    {
        get => GetRequiredOutput<TerraformProperty<string>>("cleanup_preference");
        set => SetProperty("cleanup_preference", value);
    }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    public TerraformProperty<string> CommandLine
    {
        get => GetRequiredOutput<TerraformProperty<string>>("command_line");
        set => SetProperty("command_line", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformProperty<string> ForceUpdateTag
    {
        get => GetRequiredOutput<TerraformProperty<string>>("force_update_tag");
        set => SetProperty("force_update_tag", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The primary_script_uri attribute.
    /// </summary>
    public TerraformProperty<string> PrimaryScriptUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_script_uri");
        set => SetProperty("primary_script_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInterval is required")]
    public required TerraformProperty<string> RetentionInterval
    {
        get => GetRequiredOutput<TerraformProperty<string>>("retention_interval");
        set => SetProperty("retention_interval", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformProperty<string> ScriptContent
    {
        get => GetRequiredOutput<TerraformProperty<string>>("script_content");
        set => SetProperty("script_content", value);
    }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    public List<TerraformProperty<string>> SupportingScriptUris
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("supporting_script_uris");
        set => SetProperty("supporting_script_uris", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string> Timeout
    {
        get => GetRequiredOutput<TerraformProperty<string>>("timeout");
        set => SetProperty("timeout", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetRequiredOutput<TerraformProperty<string>>("version");
        set => SetProperty("version", value);
    }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Container block(s) allowed")]
    public List<AzurermResourceDeploymentScriptAzureCliContainerBlock>? Container
    {
        set => SetProperty("container", value);
    }

    /// <summary>
    /// Block for environment_variable.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermResourceDeploymentScriptAzureCliEnvironmentVariableBlock>? EnvironmentVariable
    {
        set => SetProperty("environment_variable", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermResourceDeploymentScriptAzureCliIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccount block(s) allowed")]
    public List<AzurermResourceDeploymentScriptAzureCliStorageAccountBlock>? StorageAccount
    {
        set => SetProperty("storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermResourceDeploymentScriptAzureCliTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
