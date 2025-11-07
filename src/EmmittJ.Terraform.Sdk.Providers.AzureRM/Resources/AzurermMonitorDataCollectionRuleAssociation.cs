using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_monitor_data_collection_rule_association resource.
/// </summary>
public class AzurermMonitorDataCollectionRuleAssociation : TerraformResource
{
    public AzurermMonitorDataCollectionRuleAssociation(string name) : base("azurerm_monitor_data_collection_rule_association", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The data_collection_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataCollectionEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("data_collection_endpoint_id");
        set => this.WithProperty("data_collection_endpoint_id", value);
    }

    /// <summary>
    /// The data_collection_rule_id attribute.
    /// </summary>
    public TerraformProperty<string>? DataCollectionRuleId
    {
        get => GetProperty<TerraformProperty<string>>("data_collection_rule_id");
        set => this.WithProperty("data_collection_rule_id", value);
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
    /// The target_resource_id attribute.
    /// </summary>
    public TerraformProperty<string>? TargetResourceId
    {
        get => GetProperty<TerraformProperty<string>>("target_resource_id");
        set => this.WithProperty("target_resource_id", value);
    }

}
