using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

// Resources, Data Sources, Ephemeral Resources, Blocks: Getter ALWAYS returns a reference
// This is the key to natural Terraform syntax
// When you access rg.Name, you get azurerm_resource_group.rg.name (a reference)
// The value that was SET is only used during serialization

// Providers: Getter returns stored value
// Providers are not referenced in HCL
// Use required getter if property is required or non-nullable

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermMssqlVirtualMachineGroupTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The create attribute.
    /// </summary>
    [TerraformArgument("create")]
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    [TerraformArgument("delete")]
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    [TerraformArgument("read")]
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    [TerraformArgument("update")]
    public TerraformValue<string>? Update
    {
        get => new TerraformReference<string>(this, "update");
        set => SetArgument("update", value);
    }

}

/// <summary>
/// Block type for wsfc_domain_profile in .
/// Nesting mode: list
/// </summary>
public class AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "wsfc_domain_profile";

    /// <summary>
    /// The cluster_bootstrap_account_name attribute.
    /// </summary>
    [TerraformArgument("cluster_bootstrap_account_name")]
    public TerraformValue<string>? ClusterBootstrapAccountName
    {
        get => new TerraformReference<string>(this, "cluster_bootstrap_account_name");
        set => SetArgument("cluster_bootstrap_account_name", value);
    }

    /// <summary>
    /// The cluster_operator_account_name attribute.
    /// </summary>
    [TerraformArgument("cluster_operator_account_name")]
    public TerraformValue<string>? ClusterOperatorAccountName
    {
        get => new TerraformReference<string>(this, "cluster_operator_account_name");
        set => SetArgument("cluster_operator_account_name", value);
    }

    /// <summary>
    /// The cluster_subnet_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterSubnetType is required")]
    [TerraformArgument("cluster_subnet_type")]
    public required TerraformValue<string> ClusterSubnetType
    {
        get => new TerraformReference<string>(this, "cluster_subnet_type");
        set => SetArgument("cluster_subnet_type", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdn is required")]
    [TerraformArgument("fqdn")]
    public required TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
        set => SetArgument("fqdn", value);
    }

    /// <summary>
    /// The organizational_unit_path attribute.
    /// </summary>
    [TerraformArgument("organizational_unit_path")]
    public TerraformValue<string>? OrganizationalUnitPath
    {
        get => new TerraformReference<string>(this, "organizational_unit_path");
        set => SetArgument("organizational_unit_path", value);
    }

    /// <summary>
    /// The sql_service_account_name attribute.
    /// </summary>
    [TerraformArgument("sql_service_account_name")]
    public TerraformValue<string>? SqlServiceAccountName
    {
        get => new TerraformReference<string>(this, "sql_service_account_name");
        set => SetArgument("sql_service_account_name", value);
    }

    /// <summary>
    /// The storage_account_primary_key attribute.
    /// </summary>
    [TerraformArgument("storage_account_primary_key")]
    public TerraformValue<string>? StorageAccountPrimaryKey
    {
        get => new TerraformReference<string>(this, "storage_account_primary_key");
        set => SetArgument("storage_account_primary_key", value);
    }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    [TerraformArgument("storage_account_url")]
    public TerraformValue<string>? StorageAccountUrl
    {
        get => new TerraformReference<string>(this, "storage_account_url");
        set => SetArgument("storage_account_url", value);
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
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    [TerraformArgument("id")]
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    [TerraformArgument("location")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    [TerraformArgument("name")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    [TerraformArgument("resource_group_name")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sql_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageOffer is required")]
    [TerraformArgument("sql_image_offer")]
    public required TerraformValue<string> SqlImageOffer
    {
        get => new TerraformReference<string>(this, "sql_image_offer");
        set => SetArgument("sql_image_offer", value);
    }

    /// <summary>
    /// The sql_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageSku is required")]
    [TerraformArgument("sql_image_sku")]
    public required TerraformValue<string> SqlImageSku
    {
        get => new TerraformReference<string>(this, "sql_image_sku");
        set => SetArgument("sql_image_sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    [TerraformArgument("tags")]
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    [TerraformArgument("timeouts")]
    public AzurermMssqlVirtualMachineGroupTimeoutsBlock Timeouts { get; set; } = new();

    /// <summary>
    /// Block for wsfc_domain_profile.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WsfcDomainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WsfcDomainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainProfile block(s) allowed")]
    [TerraformArgument("wsfc_domain_profile")]
    public required TerraformList<AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock> WsfcDomainProfile { get; set; } = new();

}
