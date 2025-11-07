using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.AzureRM;

/// <summary>
/// Manages a azurerm_eventgrid_domain resource.
/// </summary>
public class AzurermEventgridDomain : TerraformResource
{
    public AzurermEventgridDomain(string name) : base("azurerm_eventgrid_domain", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("endpoint");
        this.DeclareOutput("primary_access_key");
        this.DeclareOutput("secondary_access_key");
    }

    /// <summary>
    /// The auto_create_topic_with_first_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoCreateTopicWithFirstSubscription
    {
        get => GetProperty<TerraformProperty<bool>>("auto_create_topic_with_first_subscription");
        set => this.WithProperty("auto_create_topic_with_first_subscription", value);
    }

    /// <summary>
    /// The auto_delete_topic_with_last_subscription attribute.
    /// </summary>
    public TerraformProperty<bool>? AutoDeleteTopicWithLastSubscription
    {
        get => GetProperty<TerraformProperty<bool>>("auto_delete_topic_with_last_subscription");
        set => this.WithProperty("auto_delete_topic_with_last_subscription", value);
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
    /// The inbound_ip_rule attribute.
    /// </summary>
    public TerraformProperty<List<object>>? InboundIpRule
    {
        get => GetProperty<TerraformProperty<List<object>>>("inbound_ip_rule");
        set => this.WithProperty("inbound_ip_rule", value);
    }

    /// <summary>
    /// The input_schema attribute.
    /// </summary>
    public TerraformProperty<string>? InputSchema
    {
        get => GetProperty<TerraformProperty<string>>("input_schema");
        set => this.WithProperty("input_schema", value);
    }

    /// <summary>
    /// The local_auth_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? LocalAuthEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("local_auth_enabled");
        set => this.WithProperty("local_auth_enabled", value);
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
    /// The public_network_access_enabled attribute.
    /// </summary>
    public TerraformProperty<bool>? PublicNetworkAccessEnabled
    {
        get => GetProperty<TerraformProperty<bool>>("public_network_access_enabled");
        set => this.WithProperty("public_network_access_enabled", value);
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
    public TerraformProperty<Dictionary<string, string>>? Tags
    {
        get => GetProperty<TerraformProperty<Dictionary<string, string>>>("tags");
        set => this.WithProperty("tags", value);
    }

    /// <summary>
    /// The endpoint attribute.
    /// </summary>
    public TerraformExpression Endpoint => this["endpoint"];

    /// <summary>
    /// The primary_access_key attribute.
    /// </summary>
    public TerraformExpression PrimaryAccessKey => this["primary_access_key"];

    /// <summary>
    /// The secondary_access_key attribute.
    /// </summary>
    public TerraformExpression SecondaryAccessKey => this["secondary_access_key"];

}
