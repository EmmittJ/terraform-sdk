using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Block type for instance_metadata_options in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock : TerraformBlock
{
    /// <summary>
    /// The http_put_response_hop_limit attribute.
    /// </summary>
    public TerraformProperty<double>? HttpPutResponseHopLimit
    {
        get => GetProperty<TerraformProperty<double>>("http_put_response_hop_limit");
        set => WithProperty("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformProperty<string>? HttpTokens
    {
        get => GetProperty<TerraformProperty<string>>("http_tokens");
        set => WithProperty("http_tokens", value);
    }

}

/// <summary>
/// Block type for logging in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationLoggingBlock : TerraformBlock
{
}

/// <summary>
/// Block type for placement in .
/// Nesting mode: list
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationPlacementBlock : TerraformBlock
{
    /// <summary>
    /// The availability_zone attribute.
    /// </summary>
    public TerraformProperty<string>? AvailabilityZone
    {
        get => GetProperty<TerraformProperty<string>>("availability_zone");
        set => WithProperty("availability_zone", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostId
    {
        get => GetProperty<TerraformProperty<string>>("host_id");
        set => WithProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HostResourceGroupArn
    {
        get => GetProperty<TerraformProperty<string>>("host_resource_group_arn");
        set => WithProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? Tenancy
    {
        get => GetProperty<TerraformProperty<string>>("tenancy");
        set => WithProperty("tenancy", value);
    }

}

/// <summary>
/// Manages a aws_imagebuilder_infrastructure_configuration resource.
/// </summary>
public class AwsImagebuilderInfrastructureConfiguration : TerraformResource
{
    public AwsImagebuilderInfrastructureConfiguration(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        this.DeclareOutput("arn");
        this.DeclareOutput("date_created");
        this.DeclareOutput("date_updated");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string>? Id
    {
        get => GetProperty<TerraformProperty<string>>("id");
        set => this.WithProperty("id", value);
    }

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfileName is required")]
    public required TerraformProperty<string> InstanceProfileName
    {
        get => GetProperty<TerraformProperty<string>>("instance_profile_name");
        set => this.WithProperty("instance_profile_name", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? InstanceTypes
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("instance_types");
        set => this.WithProperty("instance_types", value);
    }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformProperty<string>? KeyPair
    {
        get => GetProperty<TerraformProperty<string>>("key_pair");
        set => this.WithProperty("key_pair", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string>? Region
    {
        get => GetProperty<TerraformProperty<string>>("region");
        set => this.WithProperty("region", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>>? ResourceTags
    {
        get => GetProperty<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => this.WithProperty("resource_tags", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>>? SecurityGroupIds
    {
        get => GetProperty<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => this.WithProperty("security_group_ids", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string>? SnsTopicArn
    {
        get => GetProperty<TerraformProperty<string>>("sns_topic_arn");
        set => this.WithProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string>? SubnetId
    {
        get => GetProperty<TerraformProperty<string>>("subnet_id");
        set => this.WithProperty("subnet_id", value);
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
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformProperty<bool>? TerminateInstanceOnFailure
    {
        get => GetProperty<TerraformProperty<bool>>("terminate_instance_on_failure");
        set => this.WithProperty("terminate_instance_on_failure", value);
    }

    /// <summary>
    /// Block for instance_metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataOptions block(s) allowed")]
    public List<AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock>? InstanceMetadataOptions
    {
        get => GetProperty<List<AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock>>("instance_metadata_options");
        set => this.WithProperty("instance_metadata_options", value);
    }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public List<AwsImagebuilderInfrastructureConfigurationLoggingBlock>? Logging
    {
        get => GetProperty<List<AwsImagebuilderInfrastructureConfigurationLoggingBlock>>("logging");
        set => this.WithProperty("logging", value);
    }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public List<AwsImagebuilderInfrastructureConfigurationPlacementBlock>? Placement
    {
        get => GetProperty<List<AwsImagebuilderInfrastructureConfigurationPlacementBlock>>("placement");
        set => this.WithProperty("placement", value);
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public TerraformExpression Arn => this["arn"];

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformExpression DateUpdated => this["date_updated"];

}
