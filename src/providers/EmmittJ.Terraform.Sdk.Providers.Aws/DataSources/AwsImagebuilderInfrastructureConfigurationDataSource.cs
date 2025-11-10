using EmmittJ.Terraform.Sdk;

namespace EmmittJ.Terraform.Sdk.Providers.Aws;

/// <summary>
/// Retrieves information about a aws_imagebuilder_infrastructure_configuration.
/// </summary>
public class AwsImagebuilderInfrastructureConfigurationDataSource : TerraformDataSource
{
    public AwsImagebuilderInfrastructureConfigurationDataSource(string name) : base("aws_imagebuilder_infrastructure_configuration", name)
    {
        InitializeOutputs();
    }

    private void InitializeOutputs()
    {
        SetOutput("date_created");
        SetOutput("date_updated");
        SetOutput("description");
        SetOutput("instance_metadata_options");
        SetOutput("instance_profile_name");
        SetOutput("instance_types");
        SetOutput("key_pair");
        SetOutput("logging");
        SetOutput("name");
        SetOutput("placement");
        SetOutput("security_group_ids");
        SetOutput("sns_topic_arn");
        SetOutput("subnet_id");
        SetOutput("terminate_instance_on_failure");
        SetOutput("arn");
        SetOutput("id");
        SetOutput("region");
        SetOutput("resource_tags");
        SetOutput("tags");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    [System.ComponentModel.DataAnnotations.Required(ErrorMessage = "Arn is required")]
    public required TerraformProperty<string> Arn
    {
        get => GetRequiredOutput<TerraformProperty<string>>("arn");
        set => SetProperty("arn", value);
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
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, TerraformProperty<string>> Tags
    {
        get => GetRequiredOutput<Dictionary<string, TerraformProperty<string>>>("tags");
        set => SetProperty("tags", value);
    }

    /// <summary>
    /// The date_created attribute.
    /// </summary>
    public TerraformExpression DateCreated => this["date_created"];

    /// <summary>
    /// The date_updated attribute.
    /// </summary>
    public TerraformExpression DateUpdated => this["date_updated"];

    /// <summary>
    /// The description attribute.
    /// </summary>
    public TerraformExpression Description => this["description"];

    /// <summary>
    /// The instance_metadata_options attribute.
    /// </summary>
    public TerraformExpression InstanceMetadataOptions => this["instance_metadata_options"];

    /// <summary>
    /// The instance_profile_name attribute.
    /// </summary>
    public TerraformExpression InstanceProfileName => this["instance_profile_name"];

    /// <summary>
    /// The instance_types attribute.
    /// </summary>
    public TerraformExpression InstanceTypes => this["instance_types"];

    /// <summary>
    /// The key_pair attribute.
    /// </summary>
    public TerraformExpression KeyPair => this["key_pair"];

    /// <summary>
    /// The logging attribute.
    /// </summary>
    public TerraformExpression Logging => this["logging"];

    /// <summary>
    /// The name attribute.
    /// </summary>
    public TerraformExpression Name => this["name"];

    /// <summary>
    /// The placement attribute.
    /// </summary>
    public TerraformExpression Placement => this["placement"];

    /// <summary>
    /// The security_group_ids attribute.
    /// </summary>
    public TerraformExpression SecurityGroupIds => this["security_group_ids"];

    /// <summary>
    /// The sns_topic_arn attribute.
    /// </summary>
    public TerraformExpression SnsTopicArn => this["sns_topic_arn"];

    /// <summary>
    /// The subnet_id attribute.
    /// </summary>
    public TerraformExpression SubnetId => this["subnet_id"];

    /// <summary>
    /// The terminate_instance_on_failure attribute.
    /// </summary>
    public TerraformExpression TerminateInstanceOnFailure => this["terminate_instance_on_failure"];

}
