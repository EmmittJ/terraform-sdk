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
        get => GetProperty<TerraformProperty<string>>("outbound_caller_id_name");
        set => WithProperty("outbound_caller_id_name", value);
    }

    /// <summary>
    /// The outbound_caller_id_number_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundCallerIdNumberId
    {
        get => GetProperty<TerraformProperty<string>>("outbound_caller_id_number_id");
        set => WithProperty("outbound_caller_id_number_id", value);
    }

    /// <summary>
    /// The outbound_flow_id attribute.
    /// </summary>
    public TerraformProperty<string>? OutboundFlowId
    {
        get => GetProperty<TerraformProperty<string>>("outbound_flow_id");
        set => WithProperty("outbound_flow_id", value);
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
        this.DeclareOutput("arn");
        this.DeclareOutput("queue_id");
    }

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformProperty<string>? Description
    {
        get => GetProperty<TerraformProperty<string>>("description");
        set => this.WithProperty("description", value);
    }

    /// <summary>
    /// The hours_of_operation_id attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "HoursOfOperationId is required")]
    public required TerraformProperty<string> HoursOfOperationId
    {
        get => GetProperty<TerraformProperty<string>>("hours_of_operation_id");
        set => this.WithProperty("hours_of_operation_id", value);
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
    /// The max_contacts attribute.
    /// </summary>
    public TerraformProperty<double>? MaxContacts
    {
        get => GetProperty<TerraformProperty<double>>("max_contacts");
        set => this.WithProperty("max_contacts", value);
    }

    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetProperty<TerraformProperty<string>>("name");
        set => this.WithProperty("name", value);
    }

    /// <summary>
    /// The quick_connect_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? QuickConnectIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("quick_connect_ids");
        set => this.WithProperty("quick_connect_ids", value);
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
    /// The status attribute.
    /// </summary>
    public TerraformProperty<string>? Status
    {
        get => GetProperty<TerraformProperty<string>>("status");
        set => this.WithProperty("status", value);
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
    /// The tags_all attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? TagsAll
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("tags_all");
        set => this.WithProperty("tags_all", value);
    }

    /// <summary>
    /// Block for outbound_caller_config.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 OutboundCallerConfig block(s) allowed")]
    public List<AwsConnectQueueOutboundCallerConfigBlock>? OutboundCallerConfig
    {
        get => GetProperty<List<AwsConnectQueueOutboundCallerConfigBlock>>("outbound_caller_config");
        set => this.WithProperty("outbound_caller_config", value);
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
