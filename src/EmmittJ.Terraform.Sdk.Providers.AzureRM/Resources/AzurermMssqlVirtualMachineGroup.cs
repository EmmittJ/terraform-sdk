using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineGroupTimeoutsBlock : TerraformBlock
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
/// Block type for wsfc_domain_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock : TerraformBlock
{
    /// <summary>
    /// The cluster_bootstrap_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterBootstrapAccountName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_bootstrap_account_name");
        set => WithProperty("cluster_bootstrap_account_name", value);
    }

    /// <summary>
    /// The cluster_operator_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterOperatorAccountName
    {
        get => GetProperty<TerraformProperty<string>>("cluster_operator_account_name");
        set => WithProperty("cluster_operator_account_name", value);
    }

    /// <summary>
    /// The cluster_subnet_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterSubnetType is required")]
    public required TerraformProperty<string> ClusterSubnetType
    {
        get => GetProperty<TerraformProperty<string>>("cluster_subnet_type");
        set => WithProperty("cluster_subnet_type", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdn is required")]
    public required TerraformProperty<string> Fqdn
    {
        get => GetProperty<TerraformProperty<string>>("fqdn");
        set => WithProperty("fqdn", value);
    }

    /// <summary>
    /// The organizational_unit_path attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitPath
    {
        get => GetProperty<TerraformProperty<string>>("organizational_unit_path");
        set => WithProperty("organizational_unit_path", value);
    }

    /// <summary>
    /// The sql_service_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? SqlServiceAccountName
    {
        get => GetProperty<TerraformProperty<string>>("sql_service_account_name");
        set => WithProperty("sql_service_account_name", value);
    }

    /// <summary>
    /// The storage_account_primary_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountPrimaryKey
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_primary_key");
        set => WithProperty("storage_account_primary_key", value);
    }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountUrl
    {
        get => GetProperty<TerraformProperty<string>>("storage_account_url");
        set => WithProperty("storage_account_url", value);
    }

}

/// <summary>
/// Manages a azurerm_mssql_virtual_machine_group resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AzurermMssqlVirtualMachineGroup : TerraformResource
{
    public AzurermMssqlVirtualMachineGroup(string name) : base("azurerm_mssql_virtual_machine_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sql_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageOffer is required")]
    public required TerraformProperty<string> SqlImageOffer
    {
        get => GetProperty<TerraformProperty<string>>("sql_image_offer");
        set => this.WithProperty("sql_image_offer", value);
    }

    /// <summary>
    /// The sql_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageSku is required")]
    public required TerraformProperty<string> SqlImageSku
    {
        get => GetProperty<TerraformProperty<string>>("sql_image_sku");
        set => this.WithProperty("sql_image_sku", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlVirtualMachineGroupTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermMssqlVirtualMachineGroupTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// Block for wsfc_domain_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WsfcDomainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainProfile block(s) allowed")]
    public List<AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock>? WsfcDomainProfile
    {
        get => GetProperty<List<AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock>>("wsfc_domain_profile");
        set => this.WithProperty("wsfc_domain_profile", value);
    }

}
