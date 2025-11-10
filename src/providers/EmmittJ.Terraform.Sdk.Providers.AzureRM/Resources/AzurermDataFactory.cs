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
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        set => SetProperty("branch_name", value);
    }

    /// <summary>
    /// The git_url attribute.
    /// </summary>
    public TerraformProperty<string>? GitUrl
    {
        set => SetProperty("git_url", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishingEnabled
    {
        set => SetProperty("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        set => SetProperty("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformProperty<string> RootFolder
    {
        set => SetProperty("root_folder", value);
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
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformProperty<string> Type
    {
        set => SetProperty("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformProperty<string> Value
    {
        set => SetProperty("value", value);
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
        set => SetProperty("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformProperty<string>? PrincipalId
    {
        set => SetProperty("principal_id", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
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
        set => SetProperty("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        set => SetProperty("branch_name", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        set => SetProperty("project_name", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublishingEnabled
    {
        set => SetProperty("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        set => SetProperty("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformProperty<string> RootFolder
    {
        set => SetProperty("root_folder", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformProperty<string> TenantId
    {
        set => SetProperty("tenant_id", value);
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
        SetOutput("customer_managed_key_id");
        SetOutput("customer_managed_key_identity_id");
        SetOutput("id");
        SetOutput("location");
        SetOutput("managed_virtual_network_enabled");
        SetOutput("name");
        SetOutput("public_network_enabled");
        SetOutput("purview_id");
        SetOutput("resource_group_name");
        SetOutput("tags");
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKeyId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key_id");
        set => SetProperty("customer_managed_key_id", value);
    }

    /// <summary>
    /// The customer_managed_key_identity_id attribute.
    /// </summary>
    public TerraformProperty<string> CustomerManagedKeyIdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("customer_managed_key_identity_id");
        set => SetProperty("customer_managed_key_identity_id", value);
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
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> ManagedVirtualNetworkEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("managed_virtual_network_enabled");
        set => SetProperty("managed_virtual_network_enabled", value);
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
    /// The public_network_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_enabled");
        set => SetProperty("public_network_enabled", value);
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public TerraformProperty<string> PurviewId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("purview_id");
        set => SetProperty("purview_id", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// Block for github_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfiguration block(s) allowed")]
    public List<AzurermDataFactoryGithubConfigurationBlock>? GithubConfiguration
    {
        set => SetProperty("github_configuration", value);
    }

    /// <summary>
    /// Block for global_parameter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AzurermDataFactoryGlobalParameterBlock>? GlobalParameter
    {
        set => SetProperty("global_parameter", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermDataFactoryIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataFactoryTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for vsts_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VstsConfiguration block(s) allowed")]
    public List<AzurermDataFactoryVstsConfigurationBlock>? VstsConfiguration
    {
        set => SetProperty("vsts_configuration", value);
    }

}
