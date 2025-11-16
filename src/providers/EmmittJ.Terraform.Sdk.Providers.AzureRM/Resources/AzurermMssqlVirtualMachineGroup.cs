using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

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
    public TerraformValue<string>? Create
    {
        get => new TerraformReference<string>(this, "create");
        set => SetArgument("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformValue<string>? Delete
    {
        get => new TerraformReference<string>(this, "delete");
        set => SetArgument("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
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
    public TerraformValue<string>? ClusterBootstrapAccountName
    {
        get => new TerraformReference<string>(this, "cluster_bootstrap_account_name");
        set => SetArgument("cluster_bootstrap_account_name", value);
    }

    /// <summary>
    /// The cluster_operator_account_name attribute.
    /// </summary>
    public TerraformValue<string>? ClusterOperatorAccountName
    {
        get => new TerraformReference<string>(this, "cluster_operator_account_name");
        set => SetArgument("cluster_operator_account_name", value);
    }

    /// <summary>
    /// The cluster_subnet_type attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ClusterSubnetType is required")]
    public required TerraformValue<string> ClusterSubnetType
    {
        get => new TerraformReference<string>(this, "cluster_subnet_type");
        set => SetArgument("cluster_subnet_type", value);
    }

    /// <summary>
    /// The fqdn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Fqdn is required")]
    public required TerraformValue<string> Fqdn
    {
        get => new TerraformReference<string>(this, "fqdn");
        set => SetArgument("fqdn", value);
    }

    /// <summary>
    /// The organizational_unit_path attribute.
    /// </summary>
    public TerraformValue<string>? OrganizationalUnitPath
    {
        get => new TerraformReference<string>(this, "organizational_unit_path");
        set => SetArgument("organizational_unit_path", value);
    }

    /// <summary>
    /// The sql_service_account_name attribute.
    /// </summary>
    public TerraformValue<string>? SqlServiceAccountName
    {
        get => new TerraformReference<string>(this, "sql_service_account_name");
        set => SetArgument("sql_service_account_name", value);
    }

    /// <summary>
    /// The storage_account_primary_key attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountPrimaryKey
    {
        get => new TerraformReference<string>(this, "storage_account_primary_key");
        set => SetArgument("storage_account_primary_key", value);
    }

    /// <summary>
    /// The storage_account_url attribute.
    /// </summary>
    public TerraformValue<string>? StorageAccountUrl
    {
        get => new TerraformReference<string>(this, "storage_account_url");
        set => SetArgument("storage_account_url", value);
    }

}

/// <summary>
/// Represents a azurerm_mssql_virtual_machine_group Terraform resource.
/// Manages a azurerm_mssql_virtual_machine_group resource.
/// </summary>
public partial class AzurermMssqlVirtualMachineGroup(string name) : TerraformResource("azurerm_mssql_virtual_machine_group", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Location is required")]
    public required TerraformValue<string> Location
    {
        get => new TerraformReference<string>(this, "location");
        set => SetArgument("location", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// The sql_image_offer attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageOffer is required")]
    public required TerraformValue<string> SqlImageOffer
    {
        get => new TerraformReference<string>(this, "sql_image_offer");
        set => SetArgument("sql_image_offer", value);
    }

    /// <summary>
    /// The sql_image_sku attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "SqlImageSku is required")]
    public required TerraformValue<string> SqlImageSku
    {
        get => new TerraformReference<string>(this, "sql_image_sku");
        set => SetArgument("sql_image_sku", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMap<string>? Tags
    {
        get => TerraformMap<string>.Lazy(ctx => new TerraformReference<TerraformMap<string>>(this, "tags").ResolveNodes(ctx));
        set => SetArgument("tags", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermMssqlVirtualMachineGroupTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermMssqlVirtualMachineGroupTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

    /// <summary>
    /// WsfcDomainProfile block (nesting mode: list).
    /// This block is required.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "WsfcDomainProfile is required")]
    [System.ComponentModel.DataAnnotations.MinLength(1, ErrorMessage = "At least 1 WsfcDomainProfile block(s) required")]
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 WsfcDomainProfile block(s) allowed")]
    public required AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock WsfcDomainProfile
    {
        get => GetRequiredArgument<AzurermMssqlVirtualMachineGroupWsfcDomainProfileBlock>("wsfc_domain_profile");
        set => SetArgument("wsfc_domain_profile", value);
    }

}
