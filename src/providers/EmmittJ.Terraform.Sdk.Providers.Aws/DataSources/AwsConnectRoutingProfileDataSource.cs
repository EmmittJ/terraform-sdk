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
        SetOutput("arn");
        SetOutput("default_outbound_queue_id");
        SetOutput("description");
        SetOutput("media_concurrencies");
        SetOutput("queue_configs");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("name");
        SetOutput("region");
        SetOutput("routing_profile_id");
        SetOutput("tags");
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
    /// The instance_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceId is required")]
    public required TerraformProperty<string> InstanceId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_id");
        set => SetProperty("instance_id", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformProperty<string> Name
    {
        get => GetRequiredOutput<TerraformProperty<string>>("name");
        set => SetProperty("name", value);
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The routing_profile_id attribute.
    /// </summary>
    public TerraformProperty<string> RoutingProfileId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("routing_profile_id");
        set => SetProperty("routing_profile_id", value);
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
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
