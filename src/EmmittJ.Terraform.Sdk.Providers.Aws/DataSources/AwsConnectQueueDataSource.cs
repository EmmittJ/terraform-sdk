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
        this.DeclareOutput("arn");
        this.DeclareOutput("description");
        this.DeclareOutput("hours_of_operation_id");
        this.DeclareOutput("max_contacts");
        this.DeclareOutput("outbound_caller_config");
        this.DeclareOutput("status");
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
        get => GetProperty<TerraformProperty<string>>("instance_id");
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
    /// The queue_id attribute.
    /// </summary>
    public TerraformProperty<string>? QueueId
    {
        get => GetProperty<TerraformProperty<string>>("queue_id");
        set => this.WithProperty("queue_id", value);
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
