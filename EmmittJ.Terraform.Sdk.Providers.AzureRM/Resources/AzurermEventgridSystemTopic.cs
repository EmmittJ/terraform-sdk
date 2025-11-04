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
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The location attribute.
    /// </summary>
    public string? Location
    {
        get => GetProperty<TerraformLiteralProperty<string>>("location")?.Value;
        set => this.WithProperty("location", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The source_arm_resource_id attribute.
    /// </summary>
    [Obsolete("This property is deprecated.")]
    public string? SourceArmResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_arm_resource_id")?.Value;
        set => this.WithProperty("source_arm_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The source_resource_id attribute.
    /// </summary>
    public string? SourceResourceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("source_resource_id")?.Value;
        set => this.WithProperty("source_resource_id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The topic_type attribute.
    /// </summary>
    public string? TopicType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("topic_type")?.Value;
        set => this.WithProperty("topic_type", value == null ? null : new TerraformLiteralProperty<string>(value));
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
