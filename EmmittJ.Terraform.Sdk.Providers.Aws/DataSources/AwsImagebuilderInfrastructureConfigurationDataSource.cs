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
        this.DeclareOutput("date_created");
        this.DeclareOutput("date_updated");
        this.DeclareOutput("description");
        this.DeclareOutput("instance_metadata_options");
        this.DeclareOutput("instance_profile_name");
        this.DeclareOutput("instance_types");
        this.DeclareOutput("key_pair");
        this.DeclareOutput("logging");
        this.DeclareOutput("name");
        this.DeclareOutput("placement");
        this.DeclareOutput("security_group_ids");
        this.DeclareOutput("sns_topic_arn");
        this.DeclareOutput("subnet_id");
        this.DeclareOutput("terminate_instance_on_failure");
    }

    /// <summary>
    /// The arn attribute.
    /// </summary>
    public string? Arn
    {
        get => GetProperty<TerraformLiteralProperty<string>>("arn")?.Value;
        set => this.WithProperty("arn", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The id attribute.
    /// </summary>
    public string? Id
    {
        get => GetProperty<TerraformLiteralProperty<string>>("id")?.Value;
        set => this.WithProperty("id", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// Region where this resource will be [managed](https://docs.aws.amazon.com/general/latest/gr/rande.html#regional-endpoints). Defaults to the Region set in the [provider configuration](https://registry.terraform.io/providers/hashicorp/aws/latest/docs#aws-configuration-reference).
    /// </summary>
    public string? Region
    {
        get => GetProperty<TerraformLiteralProperty<string>>("region")?.Value;
        set => this.WithProperty("region", value == null ? null : new TerraformLiteralProperty<string>(value));
    }

    /// <summary>
    /// The resource_tags attribute.
    /// </summary>
    public Dictionary<string, string>? ResourceTags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("resource_tags")?.Value;
        set => this.WithProperty("resource_tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
    }

    /// <summary>
    /// The tags attribute.
    /// </summary>
    public Dictionary<string, string>? Tags
    {
        get => GetProperty<TerraformLiteralProperty<Dictionary<string, string>>>("tags")?.Value;
        set => this.WithProperty("tags", value == null ? null : new TerraformLiteralProperty<Dictionary<string, string>>(value));
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
