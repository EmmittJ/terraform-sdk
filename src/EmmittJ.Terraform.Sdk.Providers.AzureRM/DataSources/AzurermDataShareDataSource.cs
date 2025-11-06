using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

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
    public string? AccountId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_id")?.Value;
        set => this.WithProperty("account_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public string? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name")?.Value;
        set => this.WithProperty("name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
