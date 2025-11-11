using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineGroupTimeoutsBlock
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
/// Block type for wsfc_domain_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock
{
    /// <summary>
    /// The cluster_bootstrap_account_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_bootstrap_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterBootstrapAccountName { get; set; }

    /// <summary>
    /// The cluster_operator_account_name attribute.
    /// </summary>
    [TerraformPropertyName("cluster_operator_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? ClusterOperatorAccountName { get; set; }

    /// <summary>
    /// The cluster_subnet_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterSubnetType is required")]
    [TerraformPropertyName("cluster_subnet_type")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ClusterSubnetType { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdn is required")]
    [TerraformPropertyName("fqdn")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Fqdn { get; set; }

    /// <summary>
    /// The organizational_unit_path attribute.
    /// </summary>
    [TerraformPropertyName("organizational_unit_path")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? OrganizationalUnitPath { get; set; }

    /// <summary>
    /// The sql_service_account_name attribute.
    /// </summary>
    [TerraformPropertyName("sql_service_account_name")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? SqlServiceAccountName { get; set; }

    /// <summary>
    /// The storage_account_primary_key attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_primary_key")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountPrimaryKey { get; set; }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    [TerraformPropertyName("storage_account_url")]
    // Optional argument - user may or may not set a value
    public TerraformValue<string>? StorageAccountUrl { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_virtual_machine_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlVirtualMachineGroup : TerraformResource
{
    public AzurermMssqlVirtualMachineGroup(string name) : base("azurerm_mssql_virtual_machine_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformPropertyName("id")]
    // Optional+Computed - use setter for literal value, or leave as computed reference
    public TerraformValue<string> Id { get; set; } = default!;

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformPropertyName("location")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformPropertyName("name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformPropertyName("resource_group_name")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sql_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageOffer is required")]
    [TerraformPropertyName("sql_image_offer")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SqlImageOffer { get; set; }

    /// <summary>
    /// The sql_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageSku is required")]
    [TerraformPropertyName("sql_image_sku")]
    // Required argument - user must set a value (no initializer for compile-time enforcement)
    public required TerraformValue<string> SqlImageSku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformPropertyName("tags")]
    // Optional argument - user may or may not set a value
    public TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformPropertyName("timeouts")]
    public TerraformBlock<AzurermMssqlVirtualMachineGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for wsfc_domain_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WsfcDomainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WsfcDomainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainProfile block(s) allowed")]
    [TerraformPropertyName("wsfc_domain_profile")]
    public TerraformList<TerraformBlock<AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock>>? WsfcDomainProfile { get; set; }

}
