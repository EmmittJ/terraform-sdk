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
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredProperty<TerraformProperty<string>>("instance_id");
        set => this.WithProperty("instance_id", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformProperty<string>? RoutingProfileId
    {
        get => GetProperty<TerraformProperty<string>>("routing_profile_id");
        set => this.WithProperty("routing_profile_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? Tags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags");
        set => this.WithProperty("tags", value);
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
