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
        set => SetProperty("cluster_bootstrap_account_name", value);
    }

    /// <summary>
    /// The cluster_operator_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? ClusterOperatorAccountName
    {
        set => SetProperty("cluster_operator_account_name", value);
    }

    /// <summary>
    /// The cluster_subnet_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterSubnetType is required")]
    public required TerraformProperty<string> ClusterSubnetType
    {
        set => SetProperty("cluster_subnet_type", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdn is required")]
    public required TerraformProperty<string> Fqdn
    {
        set => SetProperty("fqdn", value);
    }

    /// <summary>
    /// The organizational_unit_path attribute.
    /// </summary>
    public TerraformProperty<string>? OrganizationalUnitPath
    {
        set => SetProperty("organizational_unit_path", value);
    }

    /// <summary>
    /// The sql_service_account_name attribute.
    /// </summary>
    public TerraformProperty<string>? SqlServiceAccountName
    {
        set => SetProperty("sql_service_account_name", value);
    }

    /// <summary>
    /// The storage_account_primary_key attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountPrimaryKey
    {
        set => SetProperty("storage_account_primary_key", value);
    }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    public TerraformProperty<string>? StorageAccountUrl
    {
        set => SetProperty("storage_account_url", value);
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
        SetOutput("id");
        SetOutput("location");
        SetOutput("name");
        SetOutput("resource_group_name");
        SetOutput("sql_image_offer");
        SetOutput("sql_image_sku");
        SetOutput("tags");
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
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformProperty<string> Location
    {
        get => GetRequiredOutput<TerraformProperty<string>>("location");
        set => SetProperty("location", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// The sql_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageOffer is required")]
    public required TerraformProperty<string> SqlImageOffer
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_image_offer");
        set => SetProperty("sql_image_offer", value);
    }

    /// <summary>
    /// The sql_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageSku is required")]
    public required TerraformProperty<string> SqlImageSku
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sql_image_sku");
        set => SetProperty("sql_image_sku", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermMssqlVirtualMachineGroupTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// Block for wsfc_domain_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WsfcDomainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WsfcDomainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainProfile block(s) allowed")]
    public List<AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock>? WsfcDomainProfile
    {
        set => SetProperty("wsfc_domain_profile", value);
    }

}
