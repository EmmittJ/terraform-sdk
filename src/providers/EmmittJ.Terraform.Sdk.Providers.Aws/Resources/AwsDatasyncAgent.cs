using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsDatasyncAgentTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The create attribute.
    /// </summary>
    public TerraformProperty<string>? Create
    {
        set => SetProperty("create", value);
    }

}

/// <summary>
/// Manages a aws_datasync_agent resource.
/// </summary>
public class AwsDatasyncAgent : TerraformResource
{
    public AwsDatasyncAgent(string name) : base("aws_datasync_agent", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("activation_key");
        SetOutput("id");
        SetOutput("ip_address");
        SetOutput("name");
        SetOutput("private_link_endpoint");
        SetOutput("region");
        SetOutput("security_group_arns");
        SetOutput("subnet_arns");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("vpc_endpoint_id");
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    public TerraformProperty<string> ActivationKey
    {
        get => GetRequiredOutput<TerraformProperty<string>>("activation_key");
        set => SetProperty("activation_key", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string> IpAddress
    {
        get => GetRequiredOutput<TerraformProperty<string>>("ip_address");
        set => SetProperty("ip_address", value);
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
    /// The private_link_endpoint attribute.
    /// </summary>
    public TerraformProperty<string> PrivateLinkEndpoint
    {
        get => GetRequiredOutput<TerraformProperty<string>>("private_link_endpoint");
        set => SetProperty("private_link_endpoint", value);
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
    /// The security_group_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_arns");
        set => SetProperty("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SubnetArns
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("subnet_arns");
        set => SetProperty("subnet_arns", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string> VpcEndpointId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("vpc_endpoint_id");
        set => SetProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatasyncAgentTimeoutsBlock? Timeouts
    {
        set => SetProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
