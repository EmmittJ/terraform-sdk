using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlManagedInstanceActiveDirectoryAdministratorTimeoutsBlock : TerraformBlockBase
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformProperty("create")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Create { get; set; }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformProperty("delete")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Delete { get; set; }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformProperty("read")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Read { get; set; }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformProperty("update")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<string>? Update { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_managed_instance_active_directory_administrator resource.
/// </summary>
public partial class AzurermMssqlManagedInstanceActiveDirectoryAdministrator : TerraformResource
{
    public AzurermMssqlManagedInstanceActiveDirectoryAdministrator(string name) : base("azurerm_mssql_managed_instance_active_directory_administrator", name)
    {
    }

    /// <summary>
    /// The azuread_authentication_only attribute.
    /// </summary>
    [TerraformProperty("azuread_authentication_only")]
    // Optional argument - source generator will implement get/set
    public TerraformValue<bool>? AzureadAuthenticationOnly { get; set; }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The login_username attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "LoginUsername is required")]
    [TerraformProperty("login_username")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> LoginUsername { get; set; }

    /// <summary>
    /// The managed_instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagedInstanceId is required")]
    [TerraformProperty("managed_instance_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ManagedInstanceId { get; set; }

    /// <summary>
    /// The object_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ObjectId is required")]
    [TerraformProperty("object_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> ObjectId { get; set; }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TenantId is required")]
    [TerraformProperty("tenant_id")]
    // Required argument - source generator will implement get/set
    public required TerraformValue<string> TenantId { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public TerraformBlock<AzurermMssqlManagedInstanceActiveDirectoryAdministratorTimeoutsBlock>? Timeouts { get; set; }

}
