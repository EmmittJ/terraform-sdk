using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_dev_center_project resource.
/// </summary>
public class AzurermDevCenterProject : TerraformResource
{
    public AzurermDevCenterProject(string name) : base("azurerm_dev_center_project", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("dev_center_uri");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The dev_center_id attribute.
    /// </summary>
    public TerraformProperty<string>? DevCenterId
    {
        get => GetProperty<TerraformProperty<string>>("dev_center_id");
        set => this.WithProperty("dev_center_id", value);
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
    /// The location attribute.
    /// </summary>
    public TerraformProperty<string>? Location
    {
        get => GetProperty<TerraformProperty<string>>("location");
        set => this.WithProperty("location", value);
    }

    /// <summary>
    /// The maximum_dev_boxes_per_user attribute.
    /// </summary>
    public TerraformProperty<double>? MaximumDevBoxesPerUser
    {
        get => GetProperty<TerraformProperty<double>>("maximum_dev_boxes_per_user");
        set => this.WithProperty("maximum_dev_boxes_per_user", value);
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
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformMapProperty<string>? Tags
    {
        get => GetProperty<TerraformMapProperty<string>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The dev_center_uri attribute.
    /// </summary>
    public TerraformExpression DevCenterUri => this["dev_center_uri"];

}
