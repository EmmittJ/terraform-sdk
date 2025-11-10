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
        get => GetProperty<TerraformProperty<string>>("container_group_name");
        set => WithProperty("container_group_name", value);
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
        get => GetProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The secure_value attribute.
    /// </summary>
    public TerraformProperty<string>? SecureValue
    {
        get => GetProperty<TerraformProperty<string>>("secure_value");
        set => WithProperty("secure_value", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    public TerraformProperty<string>? Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
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
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
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
        get => GetProperty<TerraformProperty<string>>("key");
        set => WithProperty("key", value);
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
/// Manages a azurerm_resource_deployment_script_azure_cli resource.
/// </summary>
public class AzurermResourceDeploymentScriptAzureCli : TerraformResource
{
    public AzurermResourceDeploymentScriptAzureCli(string name) : base("azurerm_resource_deployment_script_azure_cli", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("outputs");
    }

    /// <summary>
    /// The cleanup_preference attribute.
    /// </summary>
    public TerraformProperty<string>? CleanupPreference
    {
        get => GetProperty<TerraformProperty<string>>("cleanup_preference");
        set => this.WithProperty("cleanup_preference", value);
    }

    /// <summary>
    /// The command_line attribute.
    /// </summary>
    public TerraformProperty<string>? CommandLine
    {
        get => GetProperty<TerraformProperty<string>>("command_line");
        set => this.WithProperty("command_line", value);
    }

    /// <summary>
    /// The force_update_tag attribute.
    /// </summary>
    public TerraformProperty<string>? ForceUpdateTag
    {
        get => GetProperty<TerraformProperty<string>>("force_update_tag");
        set => this.WithProperty("force_update_tag", value);
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
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
    /// The primary_script_uri attribute.
    /// </summary>
    public TerraformProperty<string>? PrimaryScriptUri
    {
        get => GetProperty<TerraformProperty<string>>("primary_script_uri");
        set => this.WithProperty("primary_script_uri", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The retention_interval attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RetentionInterval is required")]
    public required TerraformProperty<string> RetentionInterval
    {
        get => GetProperty<TerraformProperty<string>>("retention_interval");
        set => this.WithProperty("retention_interval", value);
    }

    /// <summary>
    /// The script_content attribute.
    /// </summary>
    public TerraformProperty<string>? ScriptContent
    {
        get => GetProperty<TerraformProperty<string>>("script_content");
        set => this.WithProperty("script_content", value);
    }

    /// <summary>
    /// The supporting_script_uris attribute.
    /// </summary>
    public List<TerraformProperty<string>>? SupportingScriptUris
    {
        get => GetProperty<List<TerraformProperty<string>>>("supporting_script_uris");
        set => this.WithProperty("supporting_script_uris", value);
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
    /// The timeout attribute.
    /// </summary>
    public TerraformProperty<string>? Timeout
    {
        get => GetProperty<TerraformProperty<string>>("timeout");
        set => this.WithProperty("timeout", value);
    }

    /// <summary>
    /// The version attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Version is required")]
    public required TerraformProperty<string> Version
    {
        get => GetProperty<TerraformProperty<string>>("version");
        set => this.WithProperty("version", value);
    }

    /// <summary>
    /// Block for container.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Container block(s) allowed")]
    public List<AzurermResourceDeploymentScriptAzureCliContainerBlock>? Container
    {
        get => GetProperty<List<AzurermResourceDeploymentScriptAzureCliContainerBlock>>("container");
        set => this.WithProperty("container", value);
    }

    /// <summary>
    /// Block for environment_variable.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermResourceDeploymentScriptAzureCliEnvironmentVariableBlock>? EnvironmentVariable
    {
        get => GetProperty<HashSet<AzurermResourceDeploymentScriptAzureCliEnvironmentVariableBlock>>("environment_variable");
        set => this.WithProperty("environment_variable", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermResourceDeploymentScriptAzureCliIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermResourceDeploymentScriptAzureCliIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for storage_account.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 StorageAccount block(s) allowed")]
    public List<AzurermResourceDeploymentScriptAzureCliStorageAccountBlock>? StorageAccount
    {
        get => GetProperty<List<AzurermResourceDeploymentScriptAzureCliStorageAccountBlock>>("storage_account");
        set => this.WithProperty("storage_account", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermResourceDeploymentScriptAzureCliTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermResourceDeploymentScriptAzureCliTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The outputs attribute.
    /// </summary>
    public TerraformExpression Outputs => this["outputs"];

}
