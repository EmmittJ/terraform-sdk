using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_netapp_volume_group_oracle.
/// </summary>
public class AzurermNetappVolumeGroupOracleDataSource : TerraformDataSource
{
    public AzurermNetappVolumeGroupOracleDataSource(string name) : base("azurerm_netapp_volume_group_oracle", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("application_identifier");
        this.DeclareOutput("group_description");
        this.DeclareOutput("location");
        this.DeclareOutput("volume");
    }

    /// <summary>
    /// The account_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AccountName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("account_name");
        set => this.WithProperty("account_name", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The application_identifier attribute.
    /// </summary>
    public TerraformExpression ApplicationIdentifier => this["application_identifier"];

    /// <summary>
    /// The group_description attribute.
    /// </summary>
    public TerraformExpression GroupDescription => this["group_description"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The volume attribute.
    /// </summary>
    public TerraformExpression Volume => this["volume"];

}
