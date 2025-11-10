using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermDataShareDataSourceTimeoutsBlock : TerraformBlock
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
/// Retrieves information about a azurerm_data_share.
/// </summary>
public class AzurermDataShareDataSource : TerraformDataSource
{
    public AzurermDataShareDataSource(string name) : base("azurerm_data_share", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("kind");
        this.DeclareOutput("snapshot_schedule");
        this.DeclareOutput("terms");
    }

    /// <summary>
    /// The account_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "AccountId is required")]
    public required TerraformProperty<string> AccountId
    {
        get => GetProperty<TerraformProperty<string>>("account_id");
        set => this.WithProperty("account_id", value);
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
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermDataShareDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AzurermDataShareDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The kind attribute.
    /// </summary>
    public TerraformExpression Kind => this["kind"];

    /// <summary>
    /// The snapshot_schedule attribute.
    /// </summary>
    public TerraformExpression SnapshotSchedule => this["snapshot_schedule"];

    /// <summary>
    /// The terms attribute.
    /// </summary>
    public TerraformExpression Terms => this["terms"];

}
