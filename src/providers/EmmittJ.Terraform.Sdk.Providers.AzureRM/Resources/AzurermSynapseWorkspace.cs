using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for azure_devops_repo in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceAzureDevopsRepoBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformPropertyName("branch_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformPropertyName("last_commit_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LastCommitId { get; set; }

    /// <summary>
    /// The project_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ProjectName is required")]
    [TerraformPropertyName("project_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ProjectName { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformPropertyName("root_folder")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RootFolder { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [TerraformPropertyName("tenant_id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> TenantId { get; set; } = default!;

}

/// <summary>
/// Block type for customer_managed_key in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceCustomerManagedKeyBlock
{
    /// <summary>
    /// The key_name attribute.
    /// </summary>
    [TerraformPropertyName("key_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? KeyName { get; set; }

    /// <summary>
    /// The key_versionless_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "KeyVersionlessId is required")]
    [TerraformPropertyName("key_versionless_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> KeyVersionlessId { get; set; }

    /// <summary>
    /// The user_assigned_identity_id attribute.
    /// </summary>
    [TerraformPropertyName("user_assigned_identity_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? UserAssignedIdentityId { get; set; }

}

/// <summary>
/// Block type for github_repo in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceGithubRepoBlock
{
    /// <summary>
    /// The account_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountName is required")]
    [TerraformPropertyName("account_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> AccountName { get; set; }

    /// <summary>
    /// The branch_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "BranchName is required")]
    [TerraformPropertyName("branch_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> BranchName { get; set; }

    /// <summary>
    /// The git_url attribute.
    /// </summary>
    [TerraformPropertyName("git_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? GitUrl { get; set; }

    /// <summary>
    /// The last_commit_id attribute.
    /// </summary>
    [TerraformPropertyName("last_commit_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? LastCommitId { get; set; }

    /// <summary>
    /// The repository_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RepositoryName is required")]
    [TerraformPropertyName("repository_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RepositoryName { get; set; }

    /// <summary>
    /// The root_folder attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "RootFolder is required")]
    [TerraformPropertyName("root_folder")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> RootFolder { get; set; }

}

/// <summary>
/// Block type for identity in .
/// Nesting mode: list
/// </summary>
public class AzurermSynapseWorkspaceIdentityBlock
{
    /// <summary>
    /// The identity_ids attribute.
    /// </summary>
    [TerraformPropertyName("identity_ids")]
    // Optional argument - user may or may not set a value
    public TerraformSet<string>? IdentityIds { get; set; }



    /// <summary>
    /// The type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Type is required")]
    [TerraformPropertyName("type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Type { get; set; }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermSynapseWorkspaceTimeoutsBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformPropertyName("create")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformPropertyName("delete")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformPropertyName("read")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformPropertyName("update")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? Update { get; set; }

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
    [TerraformPropertyName("azuread_authentication_only")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? AzureadAuthenticationOnly { get; set; }

    /// <summary>
    /// The compute_subnet_id attribute.
    /// </summary>
    [TerraformPropertyName("compute_subnet_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ComputeSubnetId { get; set; }

    /// <summary>
    /// The data_exfiltration_protection_enabled attribute.
    /// </summary>
    [TerraformPropertyName("data_exfiltration_protection_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? DataExfiltrationProtectionEnabled { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The linking_allowed_for_aad_tenant_ids attribute.
    /// </summary>
    [TerraformPropertyName("linking_allowed_for_aad_tenant_ids")]
    // Optional argument - user may or may not set a value
    public TerraformList<string>? LinkingAllowedForAadTenantIds { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The managed_resource_group_name attribute.
    /// </summary>
    [TerraformPropertyName("managed_resource_group_name")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> ManagedResourceGroupName { get; set; } = default!;

    /// <summary>
    /// The managed_virtual_network_enabled attribute.
    /// </summary>
    [TerraformPropertyName("managed_virtual_network_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? ManagedVirtualNetworkEnabled { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [TerraformPropertyName("public_network_access_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? PublicNetworkAccessEnabled { get; set; }

    /// <summary>
    /// The purview_id attribute.
    /// </summary>
    [TerraformPropertyName("purview_id")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? PurviewId { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sql_administrator_login attribute.
    /// </summary>
    [TerraformPropertyName("sql_administrator_login")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlAdministratorLogin { get; set; }

    /// <summary>
    /// The sql_administrator_login_password attribute.
    /// </summary>
    [TerraformPropertyName("sql_administrator_login_password")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlAdministratorLoginPassword { get; set; }

    /// <summary>
    /// The sql_identity_control_enabled attribute.
    /// </summary>
    [TerraformPropertyName("sql_identity_control_enabled")]
    // Optional argument - user may or may not set a value
    public TerraformValue<bool>? SqlIdentityControlEnabled { get; set; }

    /// <summary>
    /// The storage_data_lake_gen2_filesystem_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "StorageDataLakeGen2FilesystemId is required")]
    [TerraformPropertyName("storage_data_lake_gen2_filesystem_id")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> StorageDataLakeGen2FilesystemId { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for azure_devops_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 AzureDevopsRepo block(s) allowed")]
    [TerraformPropertyName("azure_devops_repo")]
    public TerraformList<TerraformBlock<AzurermSynapseWorkspaceAzureDevopsRepoBlock>>? AzureDevopsRepo { get; set; }

    /// <summary>
    /// Block for customer_managed_key.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 CustomerManagedKey block(s) allowed")]
    [TerraformPropertyName("customer_managed_key")]
    public TerraformList<TerraformBlock<AzurermSynapseWorkspaceCustomerManagedKeyBlock>>? CustomerManagedKey { get; set; }

    /// <summary>
    /// Block for github_repo.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 GithubRepo block(s) allowed")]
    [TerraformPropertyName("github_repo")]
    public TerraformList<TerraformBlock<AzurermSynapseWorkspaceGithubRepoBlock>>? GithubRepo { get; set; }

    /// <summary>
    /// Block for identity.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Identity block(s) allowed")]
    [TerraformPropertyName("identity")]
    public TerraformList<TerraformBlock<AzurermSynapseWorkspaceIdentityBlock>>? Identity { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermSynapseWorkspaceTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// The connectivity_endpoints attribute.
    /// </summary>
    [TerraformPropertyName("connectivity_endpoints")]
    // Output-only attribute - read-only reference
    public TerraformMap<string> ConnectivityEndpoints => new TerraformReference(this, "connectivity_endpoints");

}
