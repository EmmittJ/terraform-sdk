using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public partial class AzurermMssqlVirtualMachineGroupTimeoutsBlock : TerraformBlockBase
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
/// Block type for wsfc_domain_profile in .
/// Nesting mode: list
/// </summary>
public partial class AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock : TerraformBlockBase
{
    /// <summary>
    /// The cluster_bootstrap_account_name attribute.
    /// </summary>
    [TerraformProperty("cluster_bootstrap_account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterBootstrapAccountName { get; set; }

    /// <summary>
    /// The cluster_operator_account_name attribute.
    /// </summary>
    [TerraformProperty("cluster_operator_account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? ClusterOperatorAccountName { get; set; }

    /// <summary>
    /// The cluster_subnet_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterSubnetType is required")]
    [TerraformProperty("cluster_subnet_type")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ClusterSubnetType { get; set; }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdn is required")]
    [TerraformProperty("fqdn")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Fqdn { get; set; }

    /// <summary>
    /// The organizational_unit_path attribute.
    /// </summary>
    [TerraformProperty("organizational_unit_path")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? OrganizationalUnitPath { get; set; }

    /// <summary>
    /// The sql_service_account_name attribute.
    /// </summary>
    [TerraformProperty("sql_service_account_name")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? SqlServiceAccountName { get; set; }

    /// <summary>
    /// The storage_account_primary_key attribute.
    /// </summary>
    [TerraformProperty("storage_account_primary_key")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountPrimaryKey { get; set; }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    [TerraformProperty("storage_account_url")]
    // Optional argument - source generator will implement get/set
    public partial TerraformValue<string>? StorageAccountUrl { get; set; }

}

/// <summary>
/// Manages a azurerm_mssql_virtual_machine_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public partial class AzurermMssqlVirtualMachineGroup : TerraformResource
{
    public AzurermMssqlVirtualMachineGroup(string name) : base("azurerm_mssql_virtual_machine_group", name)
    {
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformProperty("id")]
    // Optional+Computed - source generator will implement get/set
    public partial TerraformValue<string> Id { get; set; }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformProperty("location")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Location { get; set; }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformProperty("name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> Name { get; set; }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformProperty("resource_group_name")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> ResourceGroupName { get; set; }

    /// <summary>
    /// The sql_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageOffer is required")]
    [TerraformProperty("sql_image_offer")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlImageOffer { get; set; }

    /// <summary>
    /// The sql_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageSku is required")]
    [TerraformProperty("sql_image_sku")]
    // Required argument - source generator will implement get/set
    public required partial TerraformValue<string> SqlImageSku { get; set; }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformProperty("tags")]
    // Optional argument - source generator will implement get/set
    public partial TerraformMap<string>? Tags { get; set; }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformProperty("timeouts")]
    public partial TerraformBlock<AzurermMssqlVirtualMachineGroupTimeoutsBlock>? Timeouts { get; set; }

    /// <summary>
    /// Block for wsfc_domain_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WsfcDomainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WsfcDomainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainProfile block(s) allowed")]
    [TerraformProperty("wsfc_domain_profile")]
    public partial TerraformList<TerraformBlock<AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock>>? WsfcDomainProfile { get; set; }

}
