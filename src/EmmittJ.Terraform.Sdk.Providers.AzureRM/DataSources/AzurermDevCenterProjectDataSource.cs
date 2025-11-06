using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_dev_center_project.
/// </summary>
public class AzurermDevCenterProjectDataSource : TerraformDataSource
{
    public AzurermDevCenterProjectDataSource(string name) : base("azurerm_dev_center_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("description");
        this.DeclareOutput("dev_center_id");
        this.DeclareOutput("dev_center_uri");
        this.DeclareOutput("identity");
        this.DeclareOutput("location");
        this.DeclareOutput("maximum_dev_boxes_per_user");
        this.DeclareOutput("tags");
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
    /// The resource_group_name attribute.
    /// </summary>
    public string? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name")?.Value;
        set => this.WithProperty("resource_group_name", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    public TerraformExpression DevCenterId => this["dev_center_id"];

    /// <summary>
    /// The dev_center_uri attribute.
    /// </summary>
    public TerraformExpression DevCenterUri => this["dev_center_uri"];

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The maximum_dev_boxes_per_user attribute.
    /// </summary>
    public TerraformExpression MaximumDevBoxesPerUser => this["maximum_dev_boxes_per_user"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

}
