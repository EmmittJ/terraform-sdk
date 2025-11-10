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
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformProperty<string>? LastCommitId
    {
        set => SetProperty("last_commit_id", value);
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
    public TerraformProperty<string>? TenantId
    {
        set => SetProperty("tenant_id", value);
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
        set => SetProperty("key_name", value);
    }

    /// <summary>
    /// The key_versionless_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVersionlessId is required")]
    public required TerraformProperty<string> KeyVersionlessId
    {
        set => SetProperty("key_versionless_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformProperty<string>? UserAssignedIdentityId
    {
        set => SetProperty("user_assigned_identity_id", value);
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
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformProperty<string>? LastCommitId
    {
        set => SetProperty("last_commit_id", value);
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
public class AzurermSynapseWorkspaceTimeoutsBlock : TerraformBlock
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
        SetOutput("connectivity_endpoints");
        SetOutput("azuread_authentication_only");
        SetOutput("compute_subnet_id");
        SetOutput("data_exfiltration_protection_enabled");
        SetOutput("id");
        SetOutput("linking_allowed_for_aad_tenant_ids");
        SetOutput("location");
        SetOutput("managed_resource_group_name");
        SetOutput("managed_virtual_network_enabled");
        SetOutput("name");
        SetOutput("public_network_access_enabled");
        SetOutput("purview_id");
        SetOutput("resource_group_name");
        SetOutput("sql_administrator_login");
        SetOutput("sql_administrator_login_password");
        SetOutput("sql_identity_control_enabled");
        SetOutput("storage_data_lake_gen2_filesystem_id");
        SetOutput("tags");
    }

    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    public TerraformProperty<bool> AzureadAuthenticationOnly
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("azuread_authentication_only");
        set => SetProperty("azuread_authentication_only", value);
    }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> ComputeSubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("compute_subnet_id");
        set => SetProperty("compute_subnet_id", value);
    }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> DataExfiltrationProtectionEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("data_exfiltration_protection_enabled");
        set => SetProperty("data_exfiltration_protection_enabled", value);
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
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    public List<TerraformProperty<string>> LinkingAllowedForAadTenantIds
    {
        get => GetRequiredOutput<List<TerraformProperty<string>>>("linking_allowed_for_aad_tenant_ids");
        set => SetProperty("linking_allowed_for_aad_tenant_ids", value);
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
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string> ManagedResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("managed_resource_group_name");
        set => SetProperty("managed_resource_group_name", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("public_network_access_enabled");
        set => SetProperty("public_network_access_enabled", value);
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
    /// The sql_administrator_login attribute.
    /// </summary>
    public TerraformProperty<string> SqlAdministratorLogin
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_administrator_login");
        set => SetProperty("sql_administrator_login", value);
    }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    public TerraformProperty<string> SqlAdministratorLoginPassword
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_administrator_login_password");
        set => SetProperty("sql_administrator_login_password", value);
    }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    public TerraformProperty<bool> SqlIdentityControlEnabled
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("sql_identity_control_enabled");
        set => SetProperty("sql_identity_control_enabled", value);
    }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageDataLakeGen2FilesystemId is required")]
    public required TerraformProperty<string> StorageDataLakeGen2FilesystemId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("storage_data_lake_gen2_filesystem_id");
        set => SetProperty("storage_data_lake_gen2_filesystem_id", value);
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
    /// Block for azure_devops_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureDevopsRepo block(s) allowed")]
    public List<AzurermSynapseWorkspaceAzureDevopsRepoBlock>? AzureDevopsRepo
    {
        set => SetProperty("azure_devops_repo", value);
    }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public List<AzurermSynapseWorkspaceCustomerManagedKeyBlock>? CustomerManagedKey
    {
        set => SetProperty("customer_managed_key", value);
    }

    /// <summary>
    /// Block for github_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubRepo block(s) allowed")]
    public List<AzurermSynapseWorkspaceGithubRepoBlock>? GithubRepo
    {
        set => SetProperty("github_repo", value);
    }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public List<AzurermSynapseWorkspaceIdentityBlock>? Identity
    {
        set => SetProperty("identity", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermSynapseWorkspaceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    public TerraformExpression ConnectivityEndpoints => this["connectivity_endpoints"];

}
