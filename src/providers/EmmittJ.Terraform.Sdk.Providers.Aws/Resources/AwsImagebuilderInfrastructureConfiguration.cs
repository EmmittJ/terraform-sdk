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
        set => SetProperty("http_put_response_hop_limit", value);
    }

    /// <summary>
    /// The http_tokens attribute.
    /// </summary>
    public TerraformProperty<string>? HttpTokens
    {
        set => SetProperty("http_tokens", value);
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
        set => SetProperty("availability_zone", value);
    }

    /// <summary>
    /// The host_id attribute.
    /// </summary>
    public TerraformProperty<string>? HostId
    {
        set => SetProperty("host_id", value);
    }

    /// <summary>
    /// The host_resource_group_arn attribute.
    /// </summary>
    public TerraformProperty<string>? HostResourceGroupArn
    {
        set => SetProperty("host_resource_group_arn", value);
    }

    /// <summary>
    /// The tenancy attribute.
    /// </summary>
    public TerraformProperty<string>? Tenancy
    {
        set => SetProperty("tenancy", value);
    }

}

/// <summary>
/// Manages a aws_imagebuilder_infrastructure_configuration resource.
/// </summary>
[System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("This class uses MinLength/MaxLength validation attributes which use reflection.")]
public class AwsImagebuilderInfrastructureConfiguration : TerraformResource
{
    public AwsImagebuilderInfrastructureConfiguration(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("arn");
        SetOutput("date_created");
        SetOutput("date_updated");
        SetOutput("description");
        SetOutput("id");
        SetOutput("instance_profile_name");
        SetOutput("instance_types");
        SetOutput("key_pair");
        SetOutput("name");
        SetOutput("region");
        SetOutput("resource_tags");
        SetOutput("security_group_ids");
        SetOutput("sns_topic_arn");
        SetOutput("subnet_id");
        SetOutput("tags");
        SetOutput("tags_all");
        SetOutput("terminate_instance_on_failure");
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
    /// The id attribute.
    /// </summary>
    public TerraformProperty<string> Id
    {
        get => GetRequiredOutput<TerraformProperty<string>>("id");
        set => SetProperty("id", value);
    }

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "InstanceProfileName is required")]
    public required TerraformProperty<string> InstanceProfileName
    {
        get => GetRequiredOutput<TerraformProperty<string>>("instance_profile_name");
        set => SetProperty("instance_profile_name", value);
    }

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> InstanceTypes
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("instance_types");
        set => SetProperty("instance_types", value);
    }

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformProperty<string> KeyPair
    {
        get => GetRequiredOutput<TerraformProperty<string>>("key_pair");
        set => SetProperty("key_pair", value);
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
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public TerraformProperty<string> Region
    {
        get => GetRequiredOutput<TerraformProperty<string>>("region");
        set => SetProperty("region", value);
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> ResourceTags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("resource_tags");
        set => SetProperty("resource_tags", value);
    }

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public HashSet<TerraformProperty<string>> SecurityGroupIds
    {
        get => GetRequiredOutput<HashSet<TerraformProperty<string>>>("security_group_ids");
        set => SetProperty("security_group_ids", value);
    }

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformProperty<string> SnsTopicArn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("sns_topic_arn");
        set => SetProperty("sns_topic_arn", value);
    }

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformProperty<string> SubnetId
    {
        get => GetRequiredOutput<TerraformProperty<string>>("subnet_id");
        set => SetProperty("subnet_id", value);
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
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformProperty<bool> TerminateInstanceOnFailure
    {
        get => GetRequiredOutput<TerraformProperty<bool>>("terminate_instance_on_failure");
        set => SetProperty("terminate_instance_on_failure", value);
    }

    /// <summary>
    /// Block for instance_metadata_options.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 InstanceMetadataOptions block(s) allowed")]
    public List<AwsImagebuilderInfrastructureConfigurationInstanceMetadataOptionsBlock>? InstanceMetadataOptions
    {
        set => SetProperty("instance_metadata_options", value);
    }

    /// <summary>
    /// Block for logging.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Logging block(s) allowed")]
    public List<AwsImagebuilderInfrastructureConfigurationLoggingBlock>? Logging
    {
        set => SetProperty("logging", value);
    }

    /// <summary>
    /// Block for placement.
    /// Nesting mode: list
    /// </summary>
    [System.ComponentModel.DataAnnotations.MaxLength(1, ErrorMessage = "Maximum 1 Placement block(s) allowed")]
    public List<AwsImagebuilderInfrastructureConfigurationPlacementBlock>? Placement
    {
        set => SetProperty("placement", value);
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
