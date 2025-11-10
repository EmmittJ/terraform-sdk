using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermNetworkManagerStaticMemberTimeoutsBlock : TerraformBlock
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
/// Manages a azurerm_network_manager_static_member resource.
/// </summary>
public class AzurermNetworkManagerStaticMember : TerraformResource
{
    public AzurermNetworkManagerStaticMember(string name) : base("azurerm_network_manager_static_member", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("region");
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
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The network_group_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "NetworkGroupId is required")]
    public required TerraformProperty<string> NetworkGroupId
    {
        get => GetProperty<TerraformProperty<string>>("network_group_id");
        set => this.WithProperty("network_group_id", value);
    }

    /// <summary>
    /// The target_virtual_network_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "TargetVirtualNetworkId is required")]
    public required TerraformProperty<string> TargetVirtualNetworkId
    {
        get => GetProperty<TerraformProperty<string>>("target_virtual_network_id");
        set => this.WithProperty("target_virtual_network_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermNetworkManagerStaticMemberTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermNetworkManagerStaticMemberTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The region attribute.
    /// </summary>
    public TerraformExpression Region => this["region"];

}
