using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_iothub_endpoint_cosmosdb_account resource.
/// </summary>
public class AzurermIothubEndpointCosmosdbAccount : TerraformResource
{
    public AzurermIothubEndpointCosmosdbAccount(string name) : base("azurerm_iothub_endpoint_cosmosdb_account", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? AuthenticationType
    {
        get => GetProperty<TerraformLiteralProperty<string>>("authentication_type");
        set => this.WithProperty("authentication_type", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ContainerName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("container_name");
        set => this.WithProperty("container_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? DatabaseName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("database_name");
        set => this.WithProperty("database_name", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? EndpointUri
    {
        get => GetProperty<TerraformLiteralProperty<string>>("endpoint_uri");
        set => this.WithProperty("endpoint_uri", value);
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The identity_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IdentityId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("identity_id");
        set => this.WithProperty("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? IothubId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("iothub_id");
        set => this.WithProperty("iothub_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? Name
    {
        get => GetProperty<TerraformLiteralProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The partition_key_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PartitionKeyName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key_name");
        set => this.WithProperty("partition_key_name", value);
    }

    /// <summary>
    /// The partition_key_template attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PartitionKeyTemplate
    {
        get => GetProperty<TerraformLiteralProperty<string>>("partition_key_template");
        set => this.WithProperty("partition_key_template", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? PrimaryKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("primary_key");
        set => this.WithProperty("primary_key", value);
    }

    /// <summary>
    /// The resource_group_name attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? ResourceGroupName
    {
        get => GetProperty<TerraformLiteralProperty<string>>("resource_group_name");
        set => this.WithProperty("resource_group_name", value);
    }

    /// <summary>
    /// The secondary_key attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SecondaryKey
    {
        get => GetProperty<TerraformLiteralProperty<string>>("secondary_key");
        set => this.WithProperty("secondary_key", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformLiteralProperty<string>? SubscriptionId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("subscription_id");
        set => this.WithProperty("subscription_id", value);
    }

}
