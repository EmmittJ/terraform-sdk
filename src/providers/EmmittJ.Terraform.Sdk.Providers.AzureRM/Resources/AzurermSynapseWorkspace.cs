using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_devops_repo in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseWorkspaceAzureDevopsRepoBlock() : TerraformBlock("azure_devops_repo")
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformProperty("branch_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformProperty("last_commit_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastCommitId { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformProperty("project_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ProjectName { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformProperty("root_folder")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RootFolder { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformProperty("tenant_id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> TenantId { get; set; }

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseWorkspaceCustomerManagedKeyBlock() : TerraformBlock("customer_managed_key")
{
    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformProperty("key_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// The key_versionless_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVersionlessId is required")]
    [TerraformProperty("key_versionless_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> KeyVersionlessId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformProperty("user_assigned_identity_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for github_repo in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseWorkspaceGithubRepoBlock() : TerraformBlock("github_repo")
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformProperty("account_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformProperty("branch_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The git_url attribute.
    /// </summary>
    [TerraformProperty("git_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? GitUrl { get; set; }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformProperty("last_commit_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? LastCommitId { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformProperty("repository_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformProperty("root_folder")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> RootFolder { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public partial class AzurermSynapseWorkspaceIdentityBlock() : TerraformBlock("identity")
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformProperty("identity_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformProperty("type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermSynapseWorkspaceTimeoutsBlock() : TerraformBlock("timeouts")
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_synapse_workspace resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermSynapseWorkspace : TerraformResource
{
    public AzurermSynapseWorkspace(string name) : base("azurerm_synapse_workspace", name)
    {
    }

    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    [TerraformProperty("azuread_authentication_only")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? AzureadAuthenticationOnly { get; set; }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    [TerraformProperty("compute_subnet_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ComputeSubnetId { get; set; }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    [TerraformProperty("data_exfiltration_protection_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    [TerraformProperty("linking_allowed_for_aad_tenant_ids")]
    // Optional argument - source generator will implement get/set
    public partial TerraformList<string>? LinkingAllowedForAadTenantIds { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformProperty("managed_resource_group_name")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> ManagedResourceGroupName { get; set; }

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    [TerraformProperty("managed_virtual_network_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformProperty("public_network_access_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    [TerraformProperty("purview_id")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? PurviewId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sql_administrator_login attribute.
    /// </summary>
    [TerraformProperty("sql_administrator_login")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SqlAdministratorLogin { get; set; }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    [TerraformProperty("sql_administrator_login_password")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SqlAdministratorLoginPassword { get; set; }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    [TerraformProperty("sql_identity_control_enabled")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<bool>? SqlIdentityControlEnabled { get; set; }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageDataLakeGen2FilesystemId is required")]
    [TerraformProperty("storage_data_lake_gen2_filesystem_id")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> StorageDataLakeGen2FilesystemId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for azure_devops_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureDevopsRepo block(s) allowed")]
    [TerraformProperty("azure_devops_repo")]
    public TerraformList<AzurermSynapseWorkspaceAzureDevopsRepoBlock> AzureDevopsRepo { get; set; } = new();

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformProperty("customer_managed_key")]
    public TerraformList<AzurermSynapseWorkspaceCustomerManagedKeyBlock> CustomerManagedKey { get; set; } = new();

    /// <summary>
    /// Block for github_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubRepo block(s) allowed")]
    [TerraformProperty("github_repo")]
    public TerraformList<AzurermSynapseWorkspaceGithubRepoBlock> GithubRepo { get; set; } = new();

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformProperty("identity")]
    public TerraformList<AzurermSynapseWorkspaceIdentityBlock> Identity { get; set; } = new();

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public AzurermSynapseWorkspaceTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    [TerraformProperty("connectivity_endpoints")]
    // Output-only attribute - source generator will implement read-only get
    public partial TerraformMap<string> ConnectivityEndpoints { get; }

}
