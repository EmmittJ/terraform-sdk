using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_dev_center_project_pool.
/// </summary>
public class AzurermDevCenterProjectPoolDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectPoolDataSource(string name) : base("azurerm_dev_center_project_pool", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dev_box_definition_name");
        this.DeclareOutput("dev_center_attached_network_name");
        this.DeclareOutput("local_administrator_enabled");
        this.DeclareOutput("location");
        this.DeclareOutput("single_sign_on_enabled");
        this.DeclareOutput("stop_on_disconnect_grace_period_minutes");
        this.DeclareOutput("tags");
    }

    /// <summary>
    /// The dev_center_project_id attribute.
    /// </summary>
    public TerraformProperty<string>? DevCenterProjectId
    {
        get => GetProperty<TerraformProperty<string>>("dev_center_project_id");
        set => this.WithProperty("dev_center_project_id", value);
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
    public TerraformProperty<string>? Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The dev_box_definition_name attribute.
    /// </summary>
    public TerraformExpression DevBoxDefinitionName => this["dev_box_definition_name"];

    /// <summary>
    /// The dev_center_attached_network_name attribute.
    /// </summary>
    public TerraformExpression DevCenterAttachedNetworkName => this["dev_center_attached_network_name"];

    /// <summary>
    /// The local_administrator_enabled attribute.
    /// </summary>
    public TerraformExpression LocalAdministratorEnabled => this["local_administrator_enabled"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The single_sign_on_enabled attribute.
    /// </summary>
    public TerraformExpression SingleSignOnEnabled => this["single_sign_on_enabled"];

    /// <summary>
    /// The stop_on_disconnect_grace_period_minutes attribute.
    /// </summary>
    public TerraformExpression StopOnDisconnectGracePeriodMinutes => this["stop_on_disconnect_grace_period_minutes"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
