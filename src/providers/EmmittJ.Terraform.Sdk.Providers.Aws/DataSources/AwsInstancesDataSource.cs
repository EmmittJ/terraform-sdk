using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for filter in .
/// Nesting mode: set
/// </summary>
public class AwsInstancesDataSourceFilterBlock : TerraformBlock
{
    /// <summary>
    /// The name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Name is required")]
    public required TerraformProperty<string> Name
    {
        get => GetRequiredProperty<TerraformProperty<string>>("name");
        set => WithProperty("name", value);
    }

    /// <summary>
    /// The values attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Values is required")]
    public HashSet<TerraformProperty<string>>? Values
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("values");
        set => WithProperty("values", value);
    }

}

/// <summary>
/// Block type for timeouts in .
/// Nesting mode: single
/// </summary>
public class AwsInstancesDataSourceTimeoutsBlock : TerraformBlock
{
    /// <summary>
    /// The read attribute.
    /// </summary>
    public TerraformProperty<string>? Read
    {
        get => GetProperty<TerraformProperty<string>>("read");
        set => WithProperty("read", value);
    }

}

/// <summary>
/// Retrieves information about a aws_instances.
/// </summary>
public class AwsInstancesDataSource : TerraformDataSource
{
    public AwsInstancesDataSource(string name) : base("aws_instances", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.WithOutput("ids");
        this.WithOutput("ipv6_addresses");
        this.WithOutput("private_ips");
        this.WithOutput("public_ips");
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
    /// The instance_state_names attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InstanceStateNames
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("instance_state_names");
        set => this.WithProperty("instance_state_names", value);
    }

    /// <summary>
    /// The instance_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? InstanceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("instance_tags");
        set => this.WithProperty("instance_tags", value);
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
    /// Block for filter.
    /// Nesting mode: set
    /// </summary>
    public HashSet<AwsInstancesDataSourceFilterBlock>? Filter
    {
        get => GetProperty<HashSet<AwsInstancesDataSourceFilterBlock>>("filter");
        set => this.WithProperty("filter", value);
    }

    /// <summary>
    /// Block for timeouts.
    /// Nesting mode: single
    /// </summary>
    public AwsInstancesDataSourceTimeoutsBlock? Timeouts
    {
        get => GetProperty<AwsInstancesDataSourceTimeoutsBlock>("timeouts");
        set => this.WithProperty("timeouts", value);
    }

    /// <summary>
    /// The ids attribute.
    /// </summary>
    public TerraformExpression Ids => this["ids"];

    /// <summary>
    /// The ipv6_addresses attribute.
    /// </summary>
    public TerraformExpression Ipv6Addresses => this["ipv6_addresses"];

    /// <summary>
    /// The private_ips attribute.
    /// </summary>
    public TerraformExpression PrivateIps => this["private_ips"];

    /// <summary>
    /// The public_ips attribute.
    /// </summary>
    public TerraformExpression PublicIps => this["public_ips"];

}
