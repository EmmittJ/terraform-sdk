using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventgrid_system_topic resource.
/// </summary>
public class AzurermEventgridSystemTopic : TerraformResource
{
    public AzurermEventgridSystemTopic(string name) : base("azurerm_eventgrid_system_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("metric_arm_resource_id");
        this.DeclareOutput("metric_resource_id");
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
    /// The source_arm_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public TerraformProperty<string>? SourceArmResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_arm_resource_id");
        set => this.WithProperty("source_arm_resource_id", value);
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? SourceResourceId
    {
        get => GetProperty<TerraformProperty<string>>("source_resource_id");
        set => this.WithProperty("source_resource_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    public TerraformProperty<string>? TopicType
    {
        get => GetProperty<TerraformProperty<string>>("topic_type");
        set => this.WithProperty("topic_type", value);
    }

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    public TerraformExpression MetricArmResourceId => this["metric_arm_resource_id"];

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    public TerraformExpression MetricResourceId => this["metric_resource_id"];

}
