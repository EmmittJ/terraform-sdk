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
/// Block type for azure_devops_repo in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceAzureDevopsRepoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "azure_devops_repo";

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
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformArgument("last_commit_id")]
    public TerraformValue<string>? LastCommitId
    {
        get => new TerraformReference<string>(this, "last_commit_id");
        set => SetArgument("last_commit_id", value);
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
    [TerraformArgument("tenant_id")]
    public TerraformValue<string> TenantId
    {
        get => new TerraformReference<string>(this, "tenant_id");
        set => SetArgument("tenant_id", value);
    }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "customer_managed_key";

    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformArgument("key_name")]
    public TerraformValue<string>? KeyName
    {
        get => new TerraformReference<string>(this, "key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The key_versionless_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVersionlessId is required")]
    [TerraformArgument("key_versionless_id")]
    public required TerraformValue<string> KeyVersionlessId
    {
        get => new TerraformReference<string>(this, "key_versionless_id");
        set => SetArgument("key_versionless_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformArgument("user_assigned_identity_id")]
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => new TerraformReference<string>(this, "user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for github_repo in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceGithubRepoBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "github_repo";

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
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformArgument("last_commit_id")]
    public TerraformValue<string>? LastCommitId
    {
        get => new TerraformReference<string>(this, "last_commit_id");
        set => SetArgument("last_commit_id", value);
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
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceIdentityBlock : TerraformBlock
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
public class AzurermSynapseWorkspaceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_synapse_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSynapseWorkspace : TerraformResource
{
    public AzurermSynapseWorkspace(string name) : base("azurerm_synapse_workspace", name)
    {
    }

    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    [TerraformArgument("azuread_authentication_only")]
    public TerraformValue<bool>? AzureadAuthenticationOnly
    {
        get => new TerraformReference<bool>(this, "azuread_authentication_only");
        set => SetArgument("azuread_authentication_only", value);
    }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    [TerraformArgument("compute_subnet_id")]
    public TerraformValue<string>? ComputeSubnetId
    {
        get => new TerraformReference<string>(this, "compute_subnet_id");
        set => SetArgument("compute_subnet_id", value);
    }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    [TerraformArgument("data_exfiltration_protection_enabled")]
    public TerraformValue<bool>? DataExfiltrationProtectionEnabled
    {
        get => new TerraformReference<bool>(this, "data_exfiltration_protection_enabled");
        set => SetArgument("data_exfiltration_protection_enabled", value);
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
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    [TerraformArgument("linking_allowed_for_aad_tenant_ids")]
    public TerraformList<string>? LinkingAllowedForAadTenantIds
    {
        get => TerraformList<string>.Lazy(ctx => new TerraformReference<TerraformList<string>>(this, "linking_allowed_for_aad_tenant_ids").ResolveNodes(ctx));
        set => SetArgument("linking_allowed_for_aad_tenant_ids", value);
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
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformArgument("managed_resource_group_name")]
    public TerraformValue<string> ManagedResourceGroupName
    {
        get => new TerraformReference<string>(this, "managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformArgument("public_network_access_enabled")]
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => new TerraformReference<bool>(this, "public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The sql_administrator_login attribute.
    /// </summary>
    [TerraformArgument("sql_administrator_login")]
    public TerraformValue<string>? SqlAdministratorLogin
    {
        get => new TerraformReference<string>(this, "sql_administrator_login");
        set => SetArgument("sql_administrator_login", value);
    }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    [TerraformArgument("sql_administrator_login_password")]
    public TerraformValue<string>? SqlAdministratorLoginPassword
    {
        get => new TerraformReference<string>(this, "sql_administrator_login_password");
        set => SetArgument("sql_administrator_login_password", value);
    }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    [TerraformArgument("sql_identity_control_enabled")]
    public TerraformValue<bool>? SqlIdentityControlEnabled
    {
        get => new TerraformReference<bool>(this, "sql_identity_control_enabled");
        set => SetArgument("sql_identity_control_enabled", value);
    }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageDataLakeGen2FilesystemId is required")]
    [TerraformArgument("storage_data_lake_gen2_filesystem_id")]
    public required TerraformValue<string> StorageDataLakeGen2FilesystemId
    {
        get => new TerraformReference<string>(this, "storage_data_lake_gen2_filesystem_id");
        set => SetArgument("storage_data_lake_gen2_filesystem_id", value);
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
    /// Block for azure_devops_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureDevopsRepo block(s) allowed")]
    [TerraformArgument("azure_devops_repo")]
    public TerraformList<AzurermSynapseWorkspaceAzureDevopsRepoBlock> AzureDevopsRepo { get; set; } = new();

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformArgument("customer_managed_key")]
    public TerraformList<AzurermSynapseWorkspaceCustomerManagedKeyBlock> CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for github_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubRepo block(s) allowed")]
    [TerraformArgument("github_repo")]
    public TerraformList<AzurermSynapseWorkspaceGithubRepoBlock> GithubRepo { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformArgument("identity")]
    public TerraformList<AzurermSynapseWorkspaceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermSynapseWorkspaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    [TerraformArgument("connectivity_endpoints")]
    public TerraformMap<string> ConnectivityEndpoints
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "connectivity_endpoints").ResolveNodes(ctx));
    }

}
