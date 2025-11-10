using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AzurermIothubEndpointCosmosdbAccountTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

    /// <summary>
    /// The delete attribute.
    /// </summary>
    public TerraformProperty<string>? Delete
    {
        set => SetProperty("delete", value);
    }

    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        set => SetProperty("read", value);
    }

    /// <summary>
    /// The update attribute.
    /// </summary>
    public TerraformProperty<string>? Update
    {
        set => SetProperty("update", value);
    }

}

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
        SetOutput("authentication_type");
        SetOutput("container_name");
        SetOutput("database_name");
        SetOutput("endpoint_uri");
        SetOutput("id");
        SetOutput("identity_id");
        SetOutput("iothub_id");
        SetOutput("name");
        SetOutput("partition_key_name");
        SetOutput("partition_key_template");
        SetOutput("primary_key");
        SetOutput("resource_group_name");
        SetOutput("secondary_key");
        SetOutput("subscription_id");
    }

    /// <summary>
    /// The authentication_type attribute.
    /// </summary>
    public TerraformProperty<string> AuthenticationType
    {
        get => GetRequiredOutput<TerraformProperty<string>>("authentication_type");
        set => SetProperty("authentication_type", value);
    }

    /// <summary>
    /// The container_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "ContainerName is required")]
    public required TerraformProperty<string> ContainerName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("container_name");
        set => SetProperty("container_name", value);
    }

    /// <summary>
    /// The database_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "DatabaseName is required")]
    public required TerraformProperty<string> DatabaseName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("database_name");
        set => SetProperty("database_name", value);
    }

    /// <summary>
    /// The endpoint_uri attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "EndpointUri is required")]
    public required TerraformProperty<string> EndpointUri
    {
        get => GetRequiredOutput<TerraformProperty<string>>("endpoint_uri");
        set => SetProperty("endpoint_uri", value);
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
    /// The identity_id attribute.
    /// </summary>
    public TerraformProperty<string> IdentityId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("identity_id");
        set => SetProperty("identity_id", value);
    }

    /// <summary>
    /// The iothub_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "IothubId is required")]
    public required TerraformProperty<string> IothubId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("iothub_id");
        set => SetProperty("iothub_id", value);
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
    /// The partition_key_name attribute.
    /// </summary>
    public TerraformProperty<string> PartitionKeyName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partition_key_name");
        set => SetProperty("partition_key_name", value);
    }

    /// <summary>
    /// The partition_key_template attribute.
    /// </summary>
    public TerraformProperty<string> PartitionKeyTemplate
    {
        get => GetRequiredOutput<TerraformProperty<string>>("partition_key_template");
        set => SetProperty("partition_key_template", value);
    }

    /// <summary>
    /// The primary_key attribute.
    /// </summary>
    public TerraformProperty<string> PrimaryKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("primary_key");
        set => SetProperty("primary_key", value);
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
    /// The secondary_key attribute.
    /// </summary>
    public TerraformProperty<string> SecondaryKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("secondary_key");
        set => SetProperty("secondary_key", value);
    }

    /// <summary>
    /// The subscription_id attribute.
    /// </summary>
    public TerraformProperty<string> SubscriptionId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subscription_id");
        set => SetProperty("subscription_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AzurermIothubEndpointCosmosdbAccountTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

}
