using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermEventgridSystemTopicDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a azurerm_eventgrid_system_topic.
/// </summary>
public class AzurermEventgridSystemTopicDataSource : TerraformDataSource
{
    public AzurermEventgridSystemTopicDataSource(string name) : base("azurerm_eventgrid_system_topic", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("identity");
        SetOutput("location");
        SetOutput("metric_arm_resource_id");
        SetOutput("metric_resource_id");
        SetOutput("source_arm_resource_id");
        SetOutput("source_resource_id");
        SetOutput("tags");
        SetOutput("topic_type");
        SetOutput("id");
        SetOutput("name");
        SetOutput("resource_group_name");
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformProperty<string> ResourceGroupName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("resource_group_name");
        set => SetProperty("resource_group_name", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermEventgridSystemTopicDataSourceTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The identity attribute.
    /// </summary>
    public TerraformExpression Identity => this["identity"];

    /// <summary>
    /// The location attribute.
    /// </summary>
    public TerraformExpression Location => this["location"];

    /// <summary>
    /// The metric_arm_resource_id attribute.
    /// </summary>
    public TerraformExpression MetricArmResourceId => this["metric_arm_resource_id"];

    /// <summary>
    /// The metric_resource_id attribute.
    /// </summary>
    public TerraformExpression MetricResourceId => this["metric_resource_id"];

    /// <summary>
    /// The source_arm_resource_id attribute.
    /// </summary>
    public TerraformExpression SourceArmResourceId => this["source_arm_resource_id"];

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public TerraformExpression SourceResourceId => this["source_resource_id"];

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public TerraformExpression Tags => this["tags"];

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    public TerraformExpression TopicType => this["topic_type"];

}
