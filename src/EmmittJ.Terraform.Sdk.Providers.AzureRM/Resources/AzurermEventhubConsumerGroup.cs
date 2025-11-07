using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventhub_consumer_group resource.
/// </summary>
public class AzurermEventhubConsumerGroup : TerraformResource
{
    public AzurermEventhubConsumerGroup(string name) : base("azurerm_eventhub_consumer_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public TerraformProperty<string>? EventhubName
    {
        get => GetProperty<TerraformProperty<string>>("eventhub_name");
        set => this.WithProperty("eventhub_name", value);
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
    /// The namespace_name attribute.
    /// </summary>
    public TerraformProperty<string>? NamespaceName
    {
        get => GetProperty<TerraformProperty<string>>("namespace_name");
        set => this.WithProperty("namespace_name", value);
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
    /// The user_metadata attribute.
    /// </summary>
    public TerraformProperty<string>? UserMetadata
    {
        get => GetProperty<TerraformProperty<string>>("user_metadata");
        set => this.WithProperty("user_metadata", value);
    }

}
