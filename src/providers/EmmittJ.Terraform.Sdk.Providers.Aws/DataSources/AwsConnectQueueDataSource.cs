using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_connect_queue.
/// </summary>
public class AwsConnectQueueDataSource : TerraformDataSource
{
    public AwsConnectQueueDataSource(string name) : base("aws_connect_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("description");
        SetOutput("hours_of_operation_id");
        SetOutput("max_contacts");
        SetOutput("outbound_caller_config");
        SetOutput("status");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("name");
        SetOutput("queue_id");
        SetOutput("region");
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
    /// The queue_id attribute.
    /// </summary>
    public TerraformProperty<string> QueueId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("queue_id");
        set => SetProperty("queue_id", value);
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
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    public TerraformExpression HoursOfOperationId => this["hours_of_operation_id"];

    /// <summary>
    /// The max_contacts attribute.
    /// </summary>
    public TerraformExpression MaxContacts => this["max_contacts"];

    /// <summary>
    /// The outbound_caller_config attribute.
    /// </summary>
    public TerraformExpression OutboundCallerConfig => this["outbound_caller_config"];

    /// <summary>
    /// The status attribute.
    /// </summary>
    public TerraformExpression Status => this["status"];

}
