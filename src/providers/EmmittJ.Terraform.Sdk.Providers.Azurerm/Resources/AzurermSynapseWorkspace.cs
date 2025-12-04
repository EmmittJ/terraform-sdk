using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for azure_devops_repo in AzurermSynapseWorkspace.
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
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformValue<string>? LastCommitId
    {
        get => GetArgument<TerraformValue<string>>("last_commit_id");
        set => SetArgument("last_commit_id", value);
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
    public TerraformValue<string> TenantId
    {
        get => GetArgument<TerraformValue<string>>("tenant_id") ?? AsReference("tenant_id");
        set => SetArgument("tenant_id", value);
    }

}


/// <summary>
/// Block type for customer_managed_key in AzurermSynapseWorkspace.
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
    public TerraformValue<string>? KeyName
    {
        get => GetArgument<TerraformValue<string>>("key_name");
        set => SetArgument("key_name", value);
    }

    /// <summary>
    /// The key_versionless_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVersionlessId is required")]
    public required TerraformValue<string> KeyVersionlessId
    {
        get => GetRequiredArgument<TerraformValue<string>>("key_versionless_id");
        set => SetArgument("key_versionless_id", value);
    }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    public TerraformValue<string>? UserAssignedIdentityId
    {
        get => GetArgument<TerraformValue<string>>("user_assigned_identity_id");
        set => SetArgument("user_assigned_identity_id", value);
    }

}


/// <summary>
/// Block type for github_repo in AzurermSynapseWorkspace.
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
    /// The last_commit_id attribute.
    /// </summary>
    public TerraformValue<string>? LastCommitId
    {
        get => GetArgument<TerraformValue<string>>("last_commit_id");
        set => SetArgument("last_commit_id", value);
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
/// Block type for identity in AzurermSynapseWorkspace.
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
/// Block type for timeouts in AzurermSynapseWorkspace.
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
/// Represents a azurerm_synapse_workspace Terraform resource.
/// Manages a azurerm_synapse_workspace resource.
/// </summary>
public partial class AzurermSynapseWorkspace(string name) : TerraformResource("azurerm_synapse_workspace", name)
{
    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    public TerraformValue<bool>? AzureadAuthenticationOnly
    {
        get => GetArgument<TerraformValue<bool>>("azuread_authentication_only");
        set => SetArgument("azuread_authentication_only", value);
    }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    public TerraformValue<string>? ComputeSubnetId
    {
        get => GetArgument<TerraformValue<string>>("compute_subnet_id");
        set => SetArgument("compute_subnet_id", value);
    }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? DataExfiltrationProtectionEnabled
    {
        get => GetArgument<TerraformValue<bool>>("data_exfiltration_protection_enabled");
        set => SetArgument("data_exfiltration_protection_enabled", value);
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
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    public TerraformList<string>? LinkingAllowedForAadTenantIds
    {
        get => GetArgument<TerraformList<string>>("linking_allowed_for_aad_tenant_ids");
        set => SetArgument("linking_allowed_for_aad_tenant_ids", value);
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
    /// The managed_resource_group_name attribute.
    /// </summary>
    public TerraformValue<string> ManagedResourceGroupName
    {
        get => GetArgument<TerraformValue<string>>("managed_resource_group_name") ?? AsReference("managed_resource_group_name");
        set => SetArgument("managed_resource_group_name", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? PublicNetworkAccessEnabled
    {
        get => GetArgument<TerraformValue<bool>>("public_network_access_enabled");
        set => SetArgument("public_network_access_enabled", value);
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
    /// The sql_administrator_login attribute.
    /// </summary>
    public TerraformValue<string>? SqlAdministratorLogin
    {
        get => GetArgument<TerraformValue<string>>("sql_administrator_login");
        set => SetArgument("sql_administrator_login", value);
    }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    public TerraformValue<string>? SqlAdministratorLoginPassword
    {
        get => GetArgument<TerraformValue<string>>("sql_administrator_login_password");
        set => SetArgument("sql_administrator_login_password", value);
    }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    public TerraformValue<bool>? SqlIdentityControlEnabled
    {
        get => GetArgument<TerraformValue<bool>>("sql_identity_control_enabled");
        set => SetArgument("sql_identity_control_enabled", value);
    }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageDataLakeGen2FilesystemId is required")]
    public required TerraformValue<string> StorageDataLakeGen2FilesystemId
    {
        get => GetRequiredArgument<TerraformValue<string>>("storage_data_lake_gen2_filesystem_id");
        set => SetArgument("storage_data_lake_gen2_filesystem_id", value);
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
    /// The connectivity_endpoints attribute.
    /// </summary>
    public TerraformMap<string> ConnectivityEndpoints
        => AsReference("connectivity_endpoints");

    /// <summary>
    /// AzureDevopsRepo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureDevopsRepo block(s) allowed")]
    public TerraformList<AzurermSynapseWorkspaceAzureDevopsRepoBlock>? AzureDevopsRepo
    {
        get => GetArgument<TerraformList<AzurermSynapseWorkspaceAzureDevopsRepoBlock>>("azure_devops_repo");
        set => SetArgument("azure_devops_repo", value);
    }

    /// <summary>
    /// CustomerManagedKey block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    public TerraformList<AzurermSynapseWorkspaceCustomerManagedKeyBlock>? CustomerManagedKey
    {
        get => GetArgument<TerraformList<AzurermSynapseWorkspaceCustomerManagedKeyBlock>>("customer_managed_key");
        set => SetArgument("customer_managed_key", value);
    }

    /// <summary>
    /// GithubRepo block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubRepo block(s) allowed")]
    public TerraformList<AzurermSynapseWorkspaceGithubRepoBlock>? GithubRepo
    {
        get => GetArgument<TerraformList<AzurermSynapseWorkspaceGithubRepoBlock>>("github_repo");
        set => SetArgument("github_repo", value);
    }

    /// <summary>
    /// Identity block (nesting mode: list).
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    public TerraformList<AzurermSynapseWorkspaceIdentityBlock>? Identity
    {
        get => GetArgument<TerraformList<AzurermSynapseWorkspaceIdentityBlock>>("identity");
        set => SetArgument("identity", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermSynapseWorkspaceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermSynapseWorkspaceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
