using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Azurerm;

/// <summary>
/// Block type for logs in .
/// Nesting mode: list
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceLogsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "logs";

    /// <summary>
    /// The filtering_tag attribute.
    /// </summary>
    public TerraformList<TerraformMap<object>> FilteringTag
    {
        get => TerraformList<TerraformMap<object>>.Lazy(ctx => new TerraformReference<TerraformList<TerraformMap<object>>>(this, "filtering_tag").ResolveNodes(ctx));
    }

    /// <summary>
    /// The send_activity_logs attribute.
    /// </summary>
    public TerraformValue<bool> SendActivityLogs
    {
        get => new TerraformReference<bool>(this, "send_activity_logs");
    }

    /// <summary>
    /// The send_azuread_logs attribute.
    /// </summary>
    public TerraformValue<bool> SendAzureadLogs
    {
        get => new TerraformReference<bool>(this, "send_azuread_logs");
    }

    /// <summary>
    /// The send_subscription_logs attribute.
    /// </summary>
    public TerraformValue<bool> SendSubscriptionLogs
    {
        get => new TerraformReference<bool>(this, "send_subscription_logs");
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// Gets the block type.
    /// </summary>
    public override string BlockType => "timeouts";

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformValue<string>? Read
    {
        get => new TerraformReference<string>(this, "read");
        set => SetArgument("read", value);
    }

}

/// <summary>
/// Represents a azurerm_elastic_cloud_elasticsearch Terraform data source.
/// Retrieves information about a azurerm_elastic_cloud_elasticsearch.
/// </summary>
public partial class AzurermElasticCloudElasticsearchDataSource(string name) : TerraformDataSource("azurerm_elastic_cloud_elasticsearch", name)
{
    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformValue<string> Id
    {
        get => new TerraformReference<string>(this, "id");
        set => SetArgument("id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformValue<string> Name
    {
        get => new TerraformReference<string>(this, "name");
        set => SetArgument("name", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ResourceGroupName is required")]
    public required TerraformValue<string> ResourceGroupName
    {
        get => new TerraformReference<string>(this, "resource_group_name");
        set => SetArgument("resource_group_name", value);
    }

    /// <summary>
    /// Logs block (nesting mode: list).
    /// </summary>
    public TerraformList<AzurermElasticCloudElasticsearchDataSourceLogsBlock>? Logs
    {
        get => GetArgument<TerraformList<AzurermElasticCloudElasticsearchDataSourceLogsBlock>>("logs");
        set => SetArgument("logs", value);
    }

    /// <summary>
    /// Timeouts block (nesting mode: single).
    /// </summary>
    public AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock? Timeouts
    {
        get => GetArgument<AzurermElasticCloudElasticsearchDataSourceTimeoutsBlock>("timeouts");
        set => SetArgument("timeouts", value);
    }

}
