using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Retrieves information about a azurerm_eventhub_consumer_group.
/// </summary>
public class AzurermEventhubConsumerGroupDataSource : TerraformDataSource
{
    public AzurermEventhubConsumerGroupDataSource(string name) : base("azurerm_eventhub_consumer_group", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("user_metadata");
    }

    /// <summary>
    /// The eventhub_name attribute.
    /// </summary>
    public string? EventhubName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("eventhub_name")?.Value;
        set => this.WithProperty("eventhub_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The namespace_name attribute.
    /// </summary>
    public string? NamespaceName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("namespace_name")?.Value;
        set => this.WithProperty("namespace_name", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The user_metadata attribute.
    /// </summary>
    public TerraformExpression UserMetadata => this["user_metadata"];

}
