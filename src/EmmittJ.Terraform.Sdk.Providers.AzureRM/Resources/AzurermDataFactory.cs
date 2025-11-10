using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for github_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryGithubConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => WithProperty("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        get => GetProperty<TerraformProperty<string>>("branch_name");
        set => WithProperty("branch_name", value);
    }

    /// <summary>
    /// The git_url attribute.
    /// </summary>
    public TerraformProperty<string>? GitUrl
    {
        get => GetProperty<TerraformProperty<string>>("git_url");
        set => WithProperty("git_url", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("publishing_enabled");
        set => WithProperty("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetProperty<TerraformProperty<string>>("repository_name");
        set => WithProperty("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformProperty<string> RootFolder
    {
        get => GetProperty<TerraformProperty<string>>("root_folder");
        set => WithProperty("root_folder", value);
    }

}

/// <summary>
/// Block type for global_parameter in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryGlobalParameterBlock : TerraformBlock
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
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        get => GetProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        get => GetProperty<TerraformProperty<string>>("value");
        set => WithProperty("value", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIdentityBlock : TerraformBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? IdentityIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("identity_ids");
        set => WithProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        get => GetProperty<TerraformProperty<string>>("principal_id");
        set => WithProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
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
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTimeoutsBlock : TerraformBlock
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
/// Block type for vsts_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryVstsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetProperty<TerraformProperty<string>>("account_name");
        set => WithProperty("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        get => GetProperty<TerraformProperty<string>>("branch_name");
        set => WithProperty("branch_name", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetProperty<TerraformProperty<string>>("project_name");
        set => WithProperty("project_name", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishingEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("publishing_enabled");
        set => WithProperty("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetProperty<TerraformProperty<string>>("repository_name");
        set => WithProperty("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformProperty<string> RootFolder
    {
        get => GetProperty<TerraformProperty<string>>("root_folder");
        set => WithProperty("root_folder", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Manages a azurerm_data_factory resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermDataFactory : TerraformResource
{
    public AzurermDataFactory(string name) : base("azurerm_data_factory", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKeyId
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key_id");
        set => this.WithProperty("customer_managed_key_id", value);
    }

    /// <summary>
    /// The customer_managed_key_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? CustomerManagedKeyIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("customer_managed_key_identity_id");
        set => this.WithProperty("customer_managed_key_identity_id", value);
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
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? ManagedVirtualNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("managed_virtual_network_enabled");
        set => this.WithProperty("managed_virtual_network_enabled", value);
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
    /// The public_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_enabled");
        set => this.WithProperty("public_network_enabled", value);
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public TerraformProperty<string>? PurviewId
    {
        get => GetProperty<TerraformProperty<string>>("purview_id");
        set => this.WithProperty("purview_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// Block for github_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfiguration block(s) allowed")]
    public List<AzurermDataFactoryGithubConfigurationBlock>? GithubConfiguration
    {
        get => GetProperty<List<AzurermDataFactoryGithubConfigurationBlock>>("github_configuration");
        set => this.WithProperty("github_configuration", value);
    }

    /// <summary>
    /// Block for global_parameter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermDataFactoryGlobalParameterBlock>? GlobalParameter
    {
        get => GetProperty<HashSet<AzurermDataFactoryGlobalParameterBlock>>("global_parameter");
        set => this.WithProperty("global_parameter", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermDataFactoryIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermDataFactoryIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataFactoryTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vsts_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VstsConfiguration block(s) allowed")]
    public List<AzurermDataFactoryVstsConfigurationBlock>? VstsConfiguration
    {
        get => GetProperty<List<AzurermDataFactoryVstsConfigurationBlock>>("vsts_configuration");
        set => this.WithProperty("vsts_configuration", value);
    }

}
