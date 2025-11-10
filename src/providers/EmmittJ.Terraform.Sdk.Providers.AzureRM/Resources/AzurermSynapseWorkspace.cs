using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_devops_repo in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceAzureDevopsRepoBlock : TerraformBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_name");
        set => WithProperty("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("branch_name");
        set => WithProperty("branch_name", value);
    }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformProperty<string>? LastCommitId
    {
        get => GetProperty<TerraformProperty<string>>("last_commit_id");
        set => WithProperty("last_commit_id", value);
    }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    public required TerraformProperty<string> ProjectName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("project_name");
        set => WithProperty("project_name", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository_name");
        set => WithProperty("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformProperty<string> RootFolder
    {
        get => GetRequiredProperty<TerraformProperty<string>>("root_folder");
        set => WithProperty("root_folder", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformProperty<string>? TenantId
    {
        get => GetProperty<TerraformProperty<string>>("tenant_id");
        set => WithProperty("tenant_id", value);
    }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceCustomerManagedKeyBlock : TerraformBlock
{
    /// <summary>
    /// The key_name attribute.
    /// </summary>
    public TerraformProperty<string>? KeyName
    {
        get => GetProperty<TerraformProperty<string>>("key_name");
        set => WithProperty("key_name", value);
    }

    /// <summary>
    /// The key_versionless_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVersionlessId is required")]
    public required TerraformProperty<string> KeyVersionlessId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("key_versionless_id");
        set => WithProperty("key_versionless_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        get => GetProperty<TerraformProperty<string>>("user_assigned_identity_id");
        set => WithProperty("user_assigned_identity_id", value);
    }

}

/// <summary>
/// Block type for github_repo in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceGithubRepoBlock : TerraformBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    public required TerraformProperty<string> AccountName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("account_name");
        set => WithProperty("account_name", value);
    }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    public required TerraformProperty<string> BranchName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("branch_name");
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
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformProperty<string>? LastCommitId
    {
        get => GetProperty<TerraformProperty<string>>("last_commit_id");
        set => WithProperty("last_commit_id", value);
    }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    public required TerraformProperty<string> RepositoryName
    {
        get => GetRequiredProperty<TerraformProperty<string>>("repository_name");
        set => WithProperty("repository_name", value);
    }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    public required TerraformProperty<string> RootFolder
    {
        get => GetRequiredProperty<TerraformProperty<string>>("root_folder");
        set => WithProperty("root_folder", value);
    }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceIdentityBlock : TerraformBlock
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
        get => GetRequiredProperty<TerraformProperty<string>>("type");
        set => WithProperty("type", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseWorkspaceTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_synapse_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermSynapseWorkspace : TerraformResource
{
    public AzurermSynapseWorkspace(string name) : base("azurerm_synapse_workspace", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("connectivity_endpoints");
    }

    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    public TerraformProperty<bool>? AzureadAuthenticationOnly
    {
        get => GetProperty<TerraformProperty<bool>>("azuread_authentication_only");
        set => this.WithProperty("azuread_authentication_only", value);
    }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? ComputeSubnetId
    {
        get => GetProperty<TerraformProperty<string>>("compute_subnet_id");
        set => this.WithProperty("compute_subnet_id", value);
    }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? DataExfiltrationProtectionEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("data_exfiltration_protection_enabled");
        set => this.WithProperty("data_exfiltration_protection_enabled", value);
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
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>>? LinkingAllowedForAadTenantIds
    {
        get => GetProperty<List<TerraformProperty<string>>>("linking_allowed_for_aad_tenant_ids");
        set => this.WithProperty("linking_allowed_for_aad_tenant_ids", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ManagedResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("managed_resource_group_name");
        set => this.WithProperty("managed_resource_group_name", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
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
        get => GetRequiredProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sql_administrator_login attribute.
    /// </summary>
    public TerraformProperty<string>? SqlAdministratorLogin
    {
        get => GetProperty<TerraformProperty<string>>("sql_administrator_login");
        set => this.WithProperty("sql_administrator_login", value);
    }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string>? SqlAdministratorLoginPassword
    {
        get => GetProperty<TerraformProperty<string>>("sql_administrator_login_password");
        set => this.WithProperty("sql_administrator_login_password", value);
    }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? SqlIdentityControlEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("sql_identity_control_enabled");
        set => this.WithProperty("sql_identity_control_enabled", value);
    }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageDataLakeGen2FilesystemId is required")]
    public required TerraformProperty<string> StorageDataLakeGen2FilesystemId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("storage_data_lake_gen2_filesystem_id");
        set => this.WithProperty("storage_data_lake_gen2_filesystem_id", value);
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
    /// Block for azure_devops_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureDevopsRepo block(s) allowed")]
    public List<AzurermSynapseWorkspaceAzureDevopsRepoBlock>? AzureDevopsRepo
    {
        get => GetProperty<List<AzurermSynapseWorkspaceAzureDevopsRepoBlock>>("azure_devops_repo");
        set => this.WithProperty("azure_devops_repo", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermSynapseWorkspaceCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetProperty<List<AzurermSynapseWorkspaceCustomerManagedKeyBlock>>("customer_managed_key");
        set => this.WithProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for github_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubRepo block(s) allowed")]
    public List<AzurermSynapseWorkspaceGithubRepoBlock>? GithubRepo
    {
        get => GetProperty<List<AzurermSynapseWorkspaceGithubRepoBlock>>("github_repo");
        set => this.WithProperty("github_repo", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermSynapseWorkspaceIdentityBlock>? Identity
    {
        get => GetProperty<List<AzurermSynapseWorkspaceIdentityBlock>>("identity");
        set => this.WithProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermSynapseWorkspaceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    public TerraformExpression ConnectivityEndpoints => this["connectivity_endpoints"];

}
