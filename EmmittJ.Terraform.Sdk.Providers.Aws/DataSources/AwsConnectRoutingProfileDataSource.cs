using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_routing_profile.
/// </summary>
public class AwsConnectRoutingProfileDataSource : TerraformDataSource
{
    public AwsConnectRoutingProfileDataSource(string name) : base("aws_connect_routing_profile", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("default_outbound_queue_id");
        this.DeclareOutput("description");
        this.DeclareOutput("media_concurrencies");
        this.DeclareOutput("queue_configs");
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
    /// The instance_id attribute.
    /// </summary>
    public string? InstanceId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("instance_id")?.Value;
        set => this.WithProperty("instance_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The routing_profile_id attribute.
    /// </summary>
    public string? RoutingProfileId
    {
        get => GetProperty<TerraformLiteralProperty<string>>("routing_profile_id")?.Value;
        set => this.WithProperty("routing_profile_id", value == null ? null : new TerraformLiteralProperty<string>(value));
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
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The default_outbound_queue_id attribute.
    /// </summary>
    public TerraformExpression DefaultOutboundQueueId => this["default_outbound_queue_id"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The media_concurrencies attribute.
    /// </summary>
    public TerraformExpression MediaConcurrencies => this["media_concurrencies"];

    /// <summary>
    /// The queue_configs attribute.
    /// </summary>
    public TerraformExpression QueueConfigs => this["queue_configs"];

}
