using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for github_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryGithubConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_configuration";

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformArgument("branch_name")]
    public required TerraformValue<string> BranchName
    {
        get => new TerraformReference<string>(this, "branch_name");
        set => SetArgument("branch_name", value);
    }

    /// <summary>
    /// The git_url attribute.
    /// </summary>
    [TerraformArgument("git_url")]
    public TerraformValue<string>? GitUrl
    {
        get => new TerraformReference<string>(this, "git_url");
        set => SetArgument("git_url", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    [TerraformArgument("publishing_enabled")]
    public TerraformValue<bool>? PublishingEnabled
    {
        get => new TerraformReference<bool>(this, "publishing_enabled");
        set => SetArgument("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformArgument("repository_name")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformArgument("root_folder")]
    public required TerraformValue<string> RootFolder
    {
        get => new TerraformReference<string>(this, "root_folder");
        set => SetArgument("root_folder", value);
    }

}

/// <summary>
/// Block type for global_parameter in .
/// Nesting mode: set
/// </summary>
public class AzurermDataFactoryGlobalParameterBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "global_parameter";

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    [TerraformArgument("value")]
    public required TerraformValue<string> Value
    {
        get => new TerraformReference<string>(this, "value");
        set => SetArgument("value", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryIdentityBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "identity";

    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformArgument("identity_ids")]
    public TerraformSet<string>? IdentityIds
    {
        get => TerraformSet<string>.Lazy(ctx => new TerraformReference<TerraformSet<string>>(this, "identity_ids").ResolveNodes(ctx));
        set => SetArgument("identity_ids", value);
    }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformArgument("type")]
    public required TerraformValue<string> Type
    {
        get => new TerraformReference<string>(this, "type");
        set => SetArgument("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataFactoryTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for vsts_configuration in .
/// Nesting mode: list
/// </summary>
public class AzurermDataFactoryVstsConfigurationBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "vsts_configuration";

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformArgument("account_name")]
    public required TerraformValue<string> AccountName
    {
        get => new TerraformReference<string>(this, "account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformArgument("branch_name")]
    public required TerraformValue<string> BranchName
    {
        get => new TerraformReference<string>(this, "branch_name");
        set => SetArgument("branch_name", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformArgument("project_name")]
    public required TerraformValue<string> ProjectName
    {
        get => new TerraformReference<string>(this, "project_name");
        set => SetArgument("project_name", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    [TerraformArgument("publishing_enabled")]
    public TerraformValue<bool>? PublishingEnabled
    {
        get => new TerraformReference<bool>(this, "publishing_enabled");
        set => SetArgument("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformArgument("repository_name")]
    public required TerraformValue<string> RepositoryName
    {
        get => new TerraformReference<string>(this, "repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformArgument("root_folder")]
    public required TerraformValue<string> RootFolder
    {
        get => new TerraformReference<string>(this, "root_folder");
        set => SetArgument("root_folder", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformArgument("tenant_id")]
    public required TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
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
    }

    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    [TerraformArgument("customer_managed_key_id")]
    public TerraformValue<string> CustomerManagedKeyId
    {
        get => new TerraformReference<string>(this, "customer_managed_key_id");
        set => SetArgument("customer_managed_key_id", value);
    }

    /// <summary>
    /// The customer_managed_key_identity_id attribute.
    /// </summary>
    [TerraformArgument("customer_managed_key_identity_id")]
    public TerraformValue<string> CustomerManagedKeyIdentityId
    {
        get => new TerraformReference<string>(this, "customer_managed_key_identity_id");
        set => SetArgument("customer_managed_key_identity_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    [TerraformArgument("managed_virtual_network_enabled")]
    public TerraformValue<bool>? ManagedVirtualNetworkEnabled
    {
        get => new TerraformReference<bool>(this, "managed_virtual_network_enabled");
        set => SetArgument("managed_virtual_network_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_enabled")]
    public TerraformValue<bool>? PublicNetworkEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_enabled");
        set => SetArgument("public_network_enabled", value);
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    [TerraformArgument("purview_id")]
    public TerraformValue<string>? PurviewId
    {
        get => new TerraformReference<string>(this, "purview_id");
        set => SetArgument("purview_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for github_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfiguration block(s) allowed")]
    [TerraformArgument("github_configuration")]
    public TerraformList<AzurermDataFactoryGithubConfigurationBlock> GithubConfiguration { get; set; } = new();

    /// <summary>
    /// Block for global_parameter.
    /// Nesting mode: set
    /// </summary>
    [TerraformArgument("global_parameter")]
    public TerraformSet<AzurermDataFactoryGlobalParameterBlock> GlobalParameter { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermDataFactoryIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermDataFactoryTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for vsts_configuration.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VstsConfiguration block(s) allowed")]
    [TerraformArgument("vsts_configuration")]
    public TerraformList<AzurermDataFactoryVstsConfigurationBlock> VstsConfiguration { get; set; } = new();

}
