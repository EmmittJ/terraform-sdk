using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for outbound_caller_config in .
/// Nesting mode: list
/// </summary>
public class AwsConnectQueueOutboundCallerConfigBlock : TerraformBlock
{
    /// <summary>
    /// The outbound_caller_id_name attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundCallerIdName
    {
        set => SetProperty("outbound_caller_id_name", value);
    }

    /// <summary>
    /// The outbound_caller_id_number_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundCallerIdNumberId
    {
        set => SetProperty("outbound_caller_id_number_id", value);
    }

    /// <summary>
    /// The outbound_flow_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundFlowId
    {
        set => SetProperty("outbound_flow_id", value);
    }

}

/// <summary>
/// Manages a aws_connect_queue resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsConnectQueue : TerraformResource
{
    public AwsConnectQueue(string name) : base("aws_connect_queue", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("queue_id");
        SetOutput("description");
        SetOutput("hours_of_operation_id");
        SetOutput("id");
        SetOutput("instance_id");
        SetOutput("max_contacts");
        SetOutput("name");
        SetOutput("quick_connect_ids");
        SetOutput("region");
        SetOutput("status");
        SetOutput("tags");
        SetOutput("tags_all");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string> Description
    {
        get => GetRequiredOutput<TerraformProperty<string>>("description");
        set => SetProperty("description", value);
    }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursOfOperationId is required")]
    public required TerraformProperty<string> HoursOfOperationId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("hours_of_operation_id");
        set => SetProperty("hours_of_operation_id", value);
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
    /// The max_contacts attribute.
    /// </summary>
    public TerraformProperty<double> MaxContacts
    {
        get => GetRequiredOutput<TerraformProperty<double>>("max_contacts");
        set => SetProperty("max_contacts", value);
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
    /// The quick_connect_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> QuickConnectIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("quick_connect_ids");
        set => SetProperty("quick_connect_ids", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string> Status
    {
        get => GetRequiredOutput<TerraformProperty<string>>("status");
        set => SetProperty("status", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> TagsAll
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => SetProperty("tags_all", value);
    }

    /// <summary>
    /// Block for outbound_caller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutboundCallerConfig block(s) allowed")]
    public List<AwsConnectQueueOutboundCallerConfigBlock>? OutboundCallerConfig
    {
        set => SetProperty("outbound_caller_config", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The queue_id attribute.
    /// </summary>
    public TerraformExpression QueueId => this["queue_id"];

}
