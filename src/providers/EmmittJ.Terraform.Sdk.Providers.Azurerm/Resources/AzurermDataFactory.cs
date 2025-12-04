using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for github_configuration in AzurermDataFactory.
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
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformValue<string> BranchName
    {
        get => GetRequiredArgument<TerraformValue<string>>("branch_name");
        set => SetArgument("branch_name", value);
    }

    /// <summary>
    /// The git_url attribute.
    /// </summary>
    public TerraformValue<string>? GitUrl
    {
        get => GetArgument<TerraformValue<string>>("git_url");
        set => SetArgument("git_url", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublishingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("publishing_enabled");
        set => SetArgument("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformValue<string> RootFolder
    {
        get => GetRequiredArgument<TerraformValue<string>>("root_folder");
        set => SetArgument("root_folder", value);
    }

}


/// <summary>
/// Block type for global_parameter in AzurermDataFactory.
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
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

    /// <summary>
    /// The value attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Value is required")]
    public required TerraformValue<string> Value
    {
        get => GetRequiredArgument<TerraformValue<string>>("value");
        set => SetArgument("value", value);
    }

}


/// <summary>
/// Block type for identity in AzurermDataFactory.
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
    public TerraformSet<string>? IdentityIds
    {
        get => GetArgument<TerraformSet<string>>("identity_ids");
        set => SetArgument("identity_ids", value);
    }

    /// <summary>
    /// The principal_id attribute.
    /// </summary>
    public TerraformValue<string> PrincipalId
        => AsReference("principal_id");

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformValue<string> TenantId
        => AsReference("tenant_id");

    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    public required TerraformValue<string> Type
    {
        get => GetRequiredArgument<TerraformValue<string>>("type");
        set => SetArgument("type", value);
    }

}


/// <summary>
/// Block type for timeouts in AzurermDataFactory.
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
    public TerraformValue<string>? Create
    {
        get => GetArgument<TerraformValue<string>>("create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => GetArgument<TerraformValue<string>>("delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => GetArgument<TerraformValue<string>>("read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformValue<string>? Update
    {
        get => GetArgument<TerraformValue<string>>("update");
        set => SetArgument("update", value);
    }

}


/// <summary>
/// Block type for vsts_configuration in AzurermDataFactory.
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
    public required TerraformValue<string> AccountName
    {
        get => GetRequiredArgument<TerraformValue<string>>("account_name");
        set => SetArgument("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformValue<string> BranchName
    {
        get => GetRequiredArgument<TerraformValue<string>>("branch_name");
        set => SetArgument("branch_name", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformValue<string> ProjectName
    {
        get => GetRequiredArgument<TerraformValue<string>>("project_name");
        set => SetArgument("project_name", value);
    }

    /// <summary>
    /// The publishing_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublishingEnabled
    {
        get => GetArgument<TerraformValue<bool>>("publishing_enabled");
        set => SetArgument("publishing_enabled", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformValue<string> RepositoryName
    {
        get => GetRequiredArgument<TerraformValue<string>>("repository_name");
        set => SetArgument("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformValue<string> RootFolder
    {
        get => GetRequiredArgument<TerraformValue<string>>("root_folder");
        set => SetArgument("root_folder", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    public required TerraformValue<string> TenantId
    {
        get => GetRequiredArgument<TerraformValue<string>>("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Represents a azurerm_data_factory Terraform resource.
/// Manages a azurerm_data_factory resource.
/// </summary>
public partial class AzurermDataFactory(string name) : TerraformResource("azurerm_data_factory", name)
{
    /// <summary>
    /// The customer_managed_key_id attribute.
    /// </summary>
    public TerraformValue<string> CustomerManagedKeyId
    {
        get => GetArgument<TerraformValue<string>>("customer_managed_key_id") ?? AsReference("customer_managed_key_id");
        set => SetArgument("customer_managed_key_id", value);
    }

    /// <summary>
    /// The customer_managed_key_identity_id attribute.
    /// </summary>
    public TerraformValue<string> CustomerManagedKeyIdentityId
    {
        get => GetArgument<TerraformValue<string>>("customer_managed_key_identity_id") ?? AsReference("customer_managed_key_identity_id");
        set => SetArgument("customer_managed_key_identity_id", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => GetArgument<TerraformValue<string>>("id") ?? AsReference("id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => GetRequiredArgument<TerraformValue<string>>("location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? ManagedVirtualNetworkEnabled
    {
        get => GetArgument<TerraformValue<bool>>("managed_virtual_network_enabled");
        set => SetArgument("managed_virtual_network_enabled", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => GetRequiredArgument<TerraformValue<string>>("name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The public_network_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_enabled");
        set => SetArgument("public_network_enabled", value);
    }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    public TerraformValue<string>? PurviewId
    {
        get => GetArgument<TerraformValue<string>>("purview_id");
        set => SetArgument("purview_id", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => GetRequiredArgument<TerraformValue<string>>("resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => GetArgument<TerraformMap<string>>("tags");
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// GithubConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubConfiguration block(s) allowed")]
    public TerraformList<AzurermDataFactoryGithubConfigurationBlock>? GithubConfiguration
    {
        get => GetArgument<TerraformList<AzurermDataFactoryGithubConfigurationBlock>>("github_configuration");
        set => SetArgument("github_configuration", value);
    }

    /// <summary>
    /// GlobalParameter block (nesting mode: set).
    /// </summary>
    public TerraformSet<AzurermDataFactoryGlobalParameterBlock>? GlobalParameter
    {
        get => GetArgument<TerraformSet<AzurermDataFactoryGlobalParameterBlock>>("global_parameter");
        set => SetArgument("global_parameter", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermDataFactoryIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermDataFactoryIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermDataFactoryTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermDataFactoryTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// VstsConfiguration block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 VstsConfiguration block(s) allowed")]
    public TerraformList<AzurermDataFactoryVstsConfigurationBlock>? VstsConfiguration
    {
        get => GetArgument<TerraformList<AzurermDataFactoryVstsConfigurationBlock>>("vsts_configuration");
        set => SetArgument("vsts_configuration", value);
    }

}
