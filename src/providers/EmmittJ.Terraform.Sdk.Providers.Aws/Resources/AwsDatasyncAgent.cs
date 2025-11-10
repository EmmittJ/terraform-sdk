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
        get => GetProperty<TerraformProperty<string>>("create");
        set => WithProperty("create", value);
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
        this.WithOutput("arn");
    }

    /// <summary>
    /// The activation_key attribute.
    /// </summary>
    public TerraformProperty<string>? ActivationKey
    {
        get => GetProperty<TerraformProperty<string>>("activation_key");
        set => this.WithProperty("activation_key", value);
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
    /// The ip_address attribute.
    /// </summary>
    public TerraformProperty<string>? IpAddress
    {
        get => GetProperty<TerraformProperty<string>>("ip_address");
        set => this.WithProperty("ip_address", value);
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
    /// The private_link_endpoint attribute.
    /// </summary>
    public TerraformProperty<string>? PrivateLinkEndpoint
    {
        get => GetProperty<TerraformProperty<string>>("private_link_endpoint");
        set => this.WithProperty("private_link_endpoint", value);
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
    /// The security_group_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_arns");
        set => this.WithProperty("security_group_arns", value);
    }

    /// <summary>
    /// The subnet_arns attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SubnetArns
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("subnet_arns");
        set => this.WithProperty("subnet_arns", value);
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
    /// The vpc_endpoint_id attribute.
    /// </summary>
    public TerraformProperty<string>? VpcEndpointId
    {
        get => GetProperty<TerraformProperty<string>>("vpc_endpoint_id");
        set => this.WithProperty("vpc_endpoint_id", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsDatasyncAgentTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsDatasyncAgentTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

}
