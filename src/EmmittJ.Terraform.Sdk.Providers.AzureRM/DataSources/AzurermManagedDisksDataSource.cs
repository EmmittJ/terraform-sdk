using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermManagedDisksDataSourceTimeoutsBlock : TerraformBlock
{
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
/// Retrieves information about a azurerm_managed_disks.
/// </summary>
public class AzurermManagedDisksDataSource : TerraformDataSource
{
    public AzurermManagedDisksDataSource(string name) : base("azurerm_managed_disks", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("disk");
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
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermManagedDisksDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermManagedDisksDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The disk attribute.
    /// </summary>
    public TerraformExpression Disk => this["disk"];

}
