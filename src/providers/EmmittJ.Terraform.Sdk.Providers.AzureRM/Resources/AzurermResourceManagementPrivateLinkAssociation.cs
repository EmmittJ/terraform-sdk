using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermResourceManagementPrivateLinkAssociationTimeoutsBlock : TerraformBlock
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

}

/// <summary>
/// Manages a azurerm_resource_management_private_link_association resource.
/// </summary>
public class AzurermResourceManagementPrivateLinkAssociation : TerraformResource
{
    public AzurermResourceManagementPrivateLinkAssociation(string name) : base("azurerm_resource_management_private_link_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutputenant_id");
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
    /// The management_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ManagementGroupId is required")]
    public required TerraformProperty<string> ManagementGroupId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("management_group_id");
        set => this.WithProperty("management_group_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The public_network_access_enabled attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "PublicNetworkAccessEnabled is required")]
    public required TerraformProperty<bool> PublicNetworkAccessEnabled
    {
        get => GetRequiredProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
    }

    /// <summary>
    /// The resource_management_private_link_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceManagementPrivateLinkId is required")]
    public required TerraformProperty<string> ResourceManagementPrivateLinkId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("resource_management_private_link_id");
        set => this.WithProperty("resource_management_private_link_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermResourceManagementPrivateLinkAssociationTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermResourceManagementPrivateLinkAssociationTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The tenant_id attribute.
    /// </summary>
    public TerraformExpression TenantId => this["tenant_id"];

}
